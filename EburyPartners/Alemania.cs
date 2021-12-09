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

        private void bGenerarInformeInicial_Click(object sender, EventArgs e)
        {
            try
            {
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\csvfiles")) // si no existe el directorio
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\csvfiles"); // lo creo

                //string path = @"C:\Users\Linten\Documents\GitHub\EburyPartners\EburyPartners\bin\Debug\csvfiles\inicial.csv";
                string path = Directory.GetCurrentDirectory();
                //for (int i = 0; i < 9; i++)
                //    path = path.Remove(path.Length - 1);
                path = path + @"\csvfiles\inicial.csv";

                File.WriteAllText(path, ""); // creo el fichero csv vacío

                foreach (object[] tupla in miBD.Select("SELECT P.IBAN, C.primer_nombre, C.segundo_nombre, C.calle, C.num_edificio, C.ciudad, C.codigo_postal, C.pais_cliente, C.DNI_NIF, C.fecha_nacimiento FROM Producto P JOIN Propietarios PROP ON P.IBAN = PROP.IBAN JOIN Cliente C ON PROP.DNI_NIF = C.DNI_NIF WHERE P.pais = 'Alemania' AND DATE_SUB(NOW(), INTERVAL 5 YEAR) <= P.fecha_cierre; "))
                {
                    string IBAN = (string) tupla[0];
                    string primer_nombre = (tupla[1] is DBNull) ? "noexiste" : (string) tupla[1];
                    string segundo_nombre = ( tupla[2] is DBNull) ? "noexiste" : (string) tupla[2];
                    string calle = ( tupla[3] is DBNull) ? "noexiste" : ( string) tupla[3];
                    string num_edificio = ( tupla[4] is DBNull) ? "noexiste" : (string)tupla[4];
                    string ciudad = ( tupla[5] is DBNull) ? "noexiste" : (string)tupla[5];
                    string codigo_postal = ( tupla[6] is DBNull) ? "noexiste" : (string) tupla[6];
                    string pais = ( tupla[7] is DBNull) ? "noexiste" : (string)tupla[7];
                    string DNI_NIF = (tupla[8] is DBNull) ? "noexiste" : (string)tupla[8];
                    string fecha_nacimiento = ( tupla[9] is DBNull) ? "noexiste" : ((DateTime) tupla[9]).ToString("yyyy-MM-dd");

                    File.AppendAllText(path, IBAN + "," + primer_nombre + "," + segundo_nombre + "," + calle + ","
                        + num_edificio + "," + ciudad + "," + codigo_postal + "," + pais + "," + DNI_NIF + "," + fecha_nacimiento + "\n");

                }

                tMessage.Text = "Se ha generado el informe csv inicial con éxito";

            }
            catch (Exception ex)
            {
                tMessage.Text = "ERROR: " + ex.Message;
            }
            
        }

        private void bGenerarInformeSemanal_Click(object sender, EventArgs e)
        {
            tMessage.Text = "";
        }

        private void Alemania_Load(object sender, EventArgs e)
        {

        }
    }
}
