using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;
using Newtonsoft.Json;

namespace EburyPartners
{
    public partial class FiltroCuenta : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public FiltroCuenta()
        {
            InitializeComponent();
            cbActivas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbActivas.Text = "Todas";
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string consulta;

            if (tCuenta.Text.Equals("Cuenta bancaria"))
                tCuenta.Text = "";

            if ((tCuenta.Text.Equals("") | tCuenta.Text.StartsWith("NL")))
            {

                label1.Text = "";
                if (cbActivas.SelectedItem.Equals("Todas"))
                {
                    consulta = "SELECT P.IBAN,P.caja_deposito,P.fecha_apertura, P.fecha_cierre, P.cantidad, P.moneda, P.pais, P.estado estado_cuenta, P.tipo tipo_cuenta, Pr.DNI_NIF, Pr.estado estado_usuario, Pr.tipo tipo_usuario, Pr.primer_nombre, Pr.segundo_nombre, Pr.ciudad, Pr.calle, Pr.num_edificio, Pr.codigo_postal, Pr.pais_cliente FROM Producto P JOIN Propietarios Prop ON P.IBAN = Prop.IBAN JOIN Cliente Pr ON Pr.DNI_NIF = Prop.DNI_NIF WHERE P.IBAN LIKE '%" + tCuenta.Text + "%' AND pais = 'NL'; ";
                }
                else
                {
                    consulta = "SELECT P.IBAN,P.caja_deposito,P.fecha_apertura, P.fecha_cierre, P.cantidad, P.moneda, P.pais, P.estado estado_cuenta, P.tipo tipo_cuenta, Pr.DNI_NIF, Pr.estado estado_usuario, Pr.tipo tipo_usuario, Pr.primer_nombre, Pr.segundo_nombre, Pr.ciudad, Pr.calle, Pr.num_edificio, Pr.codigo_postal, Pr.pais_cliente FROM Producto P JOIN Propietarios Prop ON P.IBAN = Prop.IBAN JOIN Cliente Pr ON Pr.DNI_NIF = Prop.DNI_NIF WHERE P.IBAN LIKE '%" + tCuenta.Text + "%' AND pais = 'NL' AND P.estado = '" + cbActivas.Text + "';";
                }

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta, label1);

                if (dataGridView1.Rows.Count == 1)
                {
                    label1.Text = "Cuenta no encontrada";
                }
                else
                {

                    string jsonObject = null;

                    string hora = DateTime.Now.ToString("u");
                    hora = hora.Replace(':', '.');
                    hora = hora.Remove(hora.Length - 1);

                    string path = Directory.GetCurrentDirectory() + @"\jsonfiles\jsonfileCuentas " + hora + ".json";


                    for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                    {
                        for(int j=1; j<dataGridView1.Rows[i].Cells.Count; ++j)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value is DBNull)
                            {
                                if(j == 2 || j == 3)
                                {
                                  
                                    DateTime tn = DateTime.Now;
                                    tn = tn.AddDays(-(tn.Day-1));
                                    tn = tn.AddMonths(-(tn.Month-1));
                                    tn = tn.AddYears(-(tn.Year-1));
                                    tn = tn.AddHours(-(tn.Hour));
                                    tn = tn.AddMinutes(-(tn.Minute));
                                    tn = tn.AddSeconds(-(tn.Second));

                                    dataGridView1.Rows[i].Cells[j].Value = tn;
                                }
                                else if(j != 9 && j != 4)
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = "No existente";
                                }
                            }
                        }
                    }

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; ++i)
                    {
                        ConsultaFiltroCuenta c = new ConsultaFiltroCuenta((string)dataGridView1.Rows[i].Cells[0].Value, dataGridView1.Rows[i].Cells[1].Value is DBNull ? "No existente":(string)dataGridView1.Rows[i].Cells[1].Value, dataGridView1.Rows[i].Cells[2].Value is DBNull ? DateTime.Now : (DateTime)dataGridView1.Rows[i].Cells[2].Value, dataGridView1.Rows[i].Cells[3].Value is DBNull ? DateTime.Now : (DateTime)dataGridView1.Rows[i].Cells[3].Value, dataGridView1.Rows[i].Cells[4].Value is DBNull ? 0 : (double)dataGridView1.Rows[i].Cells[4].Value, dataGridView1.Rows[i].Cells[5].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[5].Value, dataGridView1.Rows[i].Cells[6].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[6].Value, dataGridView1.Rows[i].Cells[7].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[7].Value, dataGridView1.Rows[i].Cells[8].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[8].Value, dataGridView1.Rows[i].Cells[9].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[9].Value, dataGridView1.Rows[i].Cells[10].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[10].Value, dataGridView1.Rows[i].Cells[11].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[11].Value, dataGridView1.Rows[i].Cells[12].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[12].Value, dataGridView1.Rows[i].Cells[13].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[13].Value, dataGridView1.Rows[i].Cells[14].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[14].Value, dataGridView1.Rows[i].Cells[15].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[15].Value, dataGridView1.Rows[i].Cells[16].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[16].Value, dataGridView1.Rows[i].Cells[17].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[17].Value, dataGridView1.Rows[i].Cells[18].Value is DBNull ? "No existente" : (string)dataGridView1.Rows[i].Cells[18].Value);
                        jsonObject = JsonConvert.SerializeObject(c);
                        using (var tw = new StreamWriter(path, true))
                        {
                            tw.WriteLine(jsonObject);
                            tw.Close();
                        }
                    }

                }
            }
            else
            {
                label1.Text = "Formato de la cuenta bancaria erróneo";
            }
        }

        private void tCuenta_MouseClick(object sender, MouseEventArgs e)
        {
            tCuenta.Text = "";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
