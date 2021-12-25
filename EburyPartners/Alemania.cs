using BDLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace EburyPartners
{
    public partial class Alemania : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public Alemania()
        {
            InitializeComponent();
        }

        private void guardarRealizacion(MYSQLDB miBD, bool esInicial)
        {
            try
            {
                miBD.Insert("Insert into Registro_Informe values (NOW(), " + (esInicial ? 1 : 0) + ");");
            }
            catch (Exception)
            {
                tMessage.Text = "ERROR: Se ha perdido la conexión para el guardado de la realización del primer informe. Intentando reestablecer la conexión...";

                guardarRealizacion(miBD, esInicial);
            }
        }

        private void sendMail(string name)
        {
            string path = Directory.GetCurrentDirectory() + @"\csvfiles\" + name + ".csv";
            string to = "angelrodriguezmercado95@gmail.com";
            string asunto = "Informe/reporte alemán " + name;
            string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Envío del informe alemán " + name + @"</h1></br>
                            <h2>Saludos regulador alemán, aquí se le envía su informe/reporte requerido.</h2>";
            string from = "eburypartnersgrupo01@outlook.es";
            string password = "cumplire_la_5amld";
            string displayName = "EburyPartner";

            try
            {
                MailMessage mail = new MailMessage();

                mail.Attachments.Add(new Attachment(path));

                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.Credentials = new NetworkCredential(from, password);
                client.EnableSsl = true;

                client.Send(mail);

                client.Dispose();

                mail.Dispose();

            }
            catch (Exception ex)
            {
                tMessage.Text = "ERROR: " + ex.Message;
            }
        }

        private void generarCSV(string sql, string name)
        {
            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

            if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\csvfiles")) // si no existe el directorio
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\csvfiles"); // lo creo

            //string path = @"C:\Users\Linten\Documents\GitHub\EburyPartners\EburyPartners\bin\Debug\csvfiles\inicial.csv";
            string path = Directory.GetCurrentDirectory();
            path = path + @"\csvfiles\" + name + ".csv";

            File.WriteAllText(path, "IBAN,primer nombre,segundo nombre,calle,numero edificio,ciudad,codigo postal,pais,DNI/NIF,fecha de nacimiento\n"); // creo el fichero csv vacío

            foreach (object[] tupla in miBD.Select(sql))
            {
                string IBAN = (string)tupla[0];
                string primer_nombre = (tupla[1] is DBNull) ? "no existente" : (string)tupla[1];
                string segundo_nombre = (tupla[2] is DBNull) ? "no existente" : (string)tupla[2];
                string calle = (tupla[3] is DBNull) ? "no existente" : (string)tupla[3];
                string num_edificio = (tupla[4] is DBNull) ? "no existente" : (string)tupla[4];
                string ciudad = (tupla[5] is DBNull) ? "no existente" : (string)tupla[5];
                string codigo_postal = (tupla[6] is DBNull) ? "no existente" : (string)tupla[6];
                string pais = (tupla[7] is DBNull) ? "no existente" : (string)tupla[7];
                string DNI_NIF = (tupla[8] is DBNull) ? "no existente" : (string)tupla[8];
                string fecha_nacimiento = (tupla[9] is DBNull) ? "no existente" : ((DateTime)tupla[9]).ToString("yyyy-MM-dd");

                File.AppendAllText(path, IBAN + "," + primer_nombre + "," + segundo_nombre + "," + calle + ","
                    + num_edificio + "," + ciudad + "," + codigo_postal + "," + pais + "," + DNI_NIF + "," + fecha_nacimiento + "\n");
            }
        }

        private void bGenerarInformeInicial_Click(object sender, EventArgs e)
        {
            try
            {

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                if (miBD.Select("Select * From Registro_Informe Where es_inicial = 1;").Count() == 0)
                {
                    string hora = DateTime.Now.ToString("u");

                    hora = hora.Replace(':', '.');

                    hora = hora.Remove(hora.Length - 1);

                    String nombre = "inicial " + hora;

                    generarCSV("SELECT P.IBAN, C.primer_nombre, C.segundo_nombre, C.calle, C.num_edificio, C.ciudad, C.codigo_postal, C.pais_cliente, C.DNI_NIF, C.fecha_nacimiento FROM Producto P JOIN Propietarios PROP ON P.IBAN = PROP.IBAN JOIN Cliente C ON PROP.DNI_NIF = C.DNI_NIF WHERE P.pais = 'Alemania' AND DATE_SUB(NOW(), INTERVAL 5 YEAR) <= P.fecha_cierre; ", nombre);

                    sendMail(nombre);

                    File.Delete(Directory.GetCurrentDirectory() + @"\csvfiles\" + nombre + ".csv");
                    Directory.Delete(Directory.GetCurrentDirectory() + @"\csvfiles");

                    guardarRealizacion(miBD, true);

                    tMessage.Text = "Se ha generado y enviado el informe csv inicial con éxito";
                } else
                {
                    tMessage.Text = "ERROR: Ya hay un informe inicial generado";
                }

            }
            catch (Exception ex)
            {
                tMessage.Text = "ERROR: " + ex.Message;
            }

        }

        private void bGenerarInformeSemanal_Click(object sender, EventArgs e)
        {
            string hora = DateTime.Now.ToString("u");

            hora = hora.Replace(':', '.');

            hora = hora.Remove(hora.Length - 1);

            String nombre = "semanal " + hora;
            try
            {

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                if (miBD.Select("Select * From Registro_Informe;").Count() == 0)
                {
                    tMessage.Text = "ERROR: No hay un informe inicial generado";
                }
                else
                {
                    generarCSV("SELECT P.IBAN, C.primer_nombre, C.segundo_nombre, C.calle, C.num_edificio, C.ciudad, C.codigo_postal, C.pais_cliente, C.DNI_NIF, C.fecha_nacimiento FROM Producto P JOIN Propietarios PROP ON P.IBAN = PROP.IBAN JOIN Cliente C ON PROP.DNI_NIF = C.DNI_NIF WHERE P.pais = 'Alemania' AND P.estado = 'activa';", nombre);

                    sendMail(nombre);

                    File.Delete(Directory.GetCurrentDirectory() + @"\csvfiles\" + nombre + ".csv");
                    Directory.Delete(Directory.GetCurrentDirectory() + @"\csvfiles");

                    guardarRealizacion(miBD, false);

                    tMessage.Text = "Se ha generado y enviado el informe csv semanal con éxito";
                }

                

            }
            catch (Exception ex)
            {
                tMessage.Text = "ERROR: " + ex.Message;
            }

            
            
        }

        private void bBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
