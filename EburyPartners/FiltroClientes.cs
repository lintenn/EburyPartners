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
    public partial class FiltroClientes : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public FiltroClientes()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string consulta;

            consulta = "SELECT C.DNI_NIF, C.estado, C.tipo, C.fecha_nacimiento, C.primer_nombre, C.segundo_nombre, C.ciudad, C.calle, C.num_edificio, C.codigo_postal, C.pais_cliente, P.IBAN IBAN_propiedad, P.estado estado_propiedad, P.tipo tipo_propiedad, Au.IBAN IBAN_autorizado, Au.estado estado_autorizado, Au.tipo tipo_autorizado, Rel.primer_nombre primer_nombre_relacionado, Rel.segundo_nombre segundo_nombre_relacionado, Rel.fecha_nacimiento fecha_nacimiento_relacionado, Rel.ciudad ciudad_relacionado, Rel.calle calle_relacionado, Rel.num_edificio num_edificio_relacionado, Rel.codigo_postal codigo_postal_relacionado, Rel.pais_cliente pais_cliente_relacionado FROM Cliente C LEFT JOIN Propietarios Prop ON C.DNI_NIF = Prop.DNI_NIF LEFT JOIN Producto P ON Prop.IBAN = P.IBAN LEFT JOIN Autorizado A ON C.DNI_NIF = A.DNI_NIF LEFT JOIN Producto Au ON A.IBAN = Au.IBAN LEFT JOIN Relacionado R ON R.principal = C.DNI_NIF LEFT JOIN Cliente Rel ON Rel.DNI_NIF = R.relacionado WHERE ((P.fecha_cierre >= DATE_SUB(NOW(), INTERVAL 3 YEAR) AND P.pais = 'NL' AND P.IBAN LIKE 'NL%') OR (Au.fecha_cierre >= DATE_SUB(NOW(), INTERVAL 5 YEAR) AND Au.pais = 'NL' AND Au.IBAN LIKE 'NL%'))";

            if (!t1Nombre.Text.Equals("Primer nombre")) consulta += " AND C.primer_nombre LIKE '%" + t1Nombre.Text + "%'";
            if (!t2Nombre.Text.Equals("Segundo nombre")) consulta += " AND C.segundo_nombre LIKE '%" + t2Nombre.Text + "%'";
            if (!tCiudad.Text.Equals("Ciudad")) consulta += " AND C.ciudad LIKE '%" + tCiudad.Text + "%'";
            if (!tCalle.Text.Equals("Calle")) consulta += " AND C.calle LIKE '%" + tCalle.Text + "%'";
            if (!tNumero.Text.Equals("Número")) consulta += " AND C.num_edificio LIKE '%" + tNumero.Text + "%'";
            if (!tCodPostal.Text.Equals("Código postal")) consulta += " AND C.codigo_postal LIKE '%" + tCodPostal.Text + "%'";

            consulta += ";";

            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
            miBD.mostrarDataGrid(dataGridClientes, consulta, label1);

            if (dataGridClientes.Rows.Count == 1)
            {
                label1.Text = "Cliente no encontrado";
            }
            else
            {
                string jsonObject = null;

                string hora = DateTime.Now.ToString("u");
                hora = hora.Replace(':', '.');
                hora = hora.Remove(hora.Length - 1);

                string path = Directory.GetCurrentDirectory() + @"\jsonfiles\jsonfileClientes " + hora + ".json";

                for (int i = 0; i < dataGridClientes.Rows.Count - 1; ++i)
                {
                    for (int j = 1; j < dataGridClientes.Rows[i].Cells.Count; ++j)
                    {
                        if (dataGridClientes.Rows[i].Cells[j].Value is DBNull)
                        {
                            if (j == 19 || j == 3)
                            {
                                DateTime tn = DateTime.Now;
                                tn = tn.AddDays(-(tn.Day - 1));
                                tn = tn.AddMonths(-(tn.Month - 1));
                                tn = tn.AddYears(-(tn.Year - 1));
                                tn = tn.AddHours(-(tn.Hour));
                                tn = tn.AddMinutes(-(tn.Minute));
                                tn = tn.AddSeconds(-(tn.Second));

                                dataGridClientes.Rows[i].Cells[j].Value = tn;
                            }
                            else
                            {
                                dataGridClientes.Rows[i].Cells[j].Value = "No existente";
                            }
                        }
                    }
                }

                for (int i = 0; i < dataGridClientes.Rows.Count - 1; ++i)
                {
                    ConsultaFiltroCliente c = new ConsultaFiltroCliente((string)dataGridClientes.Rows[i].Cells[0].Value, dataGridClientes.Rows[i].Cells[1].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[1].Value, dataGridClientes.Rows[i].Cells[2].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[2].Value, dataGridClientes.Rows[i].Cells[3].Value is DBNull ? DateTime.Now : (DateTime)dataGridClientes.Rows[i].Cells[3].Value, dataGridClientes.Rows[i].Cells[4].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[4].Value, dataGridClientes.Rows[i].Cells[5].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[5].Value, dataGridClientes.Rows[i].Cells[6].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[6].Value, dataGridClientes.Rows[i].Cells[7].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[7].Value, dataGridClientes.Rows[i].Cells[8].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[8].Value, dataGridClientes.Rows[i].Cells[9].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[9].Value, dataGridClientes.Rows[i].Cells[10].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[10].Value, dataGridClientes.Rows[i].Cells[11].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[11].Value, dataGridClientes.Rows[i].Cells[12].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[12].Value, dataGridClientes.Rows[i].Cells[13].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[13].Value, dataGridClientes.Rows[i].Cells[14].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[14].Value, dataGridClientes.Rows[i].Cells[15].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[15].Value, dataGridClientes.Rows[i].Cells[16].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[16].Value, dataGridClientes.Rows[i].Cells[17].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[17].Value, dataGridClientes.Rows[i].Cells[18].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[18].Value, dataGridClientes.Rows[i].Cells[19].Value is DBNull ? DateTime.Now : (DateTime)dataGridClientes.Rows[i].Cells[19].Value, dataGridClientes.Rows[i].Cells[20].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[20].Value, dataGridClientes.Rows[i].Cells[21].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[21].Value, dataGridClientes.Rows[i].Cells[22].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[22].Value, dataGridClientes.Rows[i].Cells[23].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[23].Value, dataGridClientes.Rows[i].Cells[24].Value is DBNull ? "No existente" : (string)dataGridClientes.Rows[i].Cells[24].Value);
                    jsonObject = JsonConvert.SerializeObject(c);
                    using (var tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(jsonObject);
                        tw.Close();
                    }
                }
            }
        }

        private void t1Nombre_Enter(object sender, System.EventArgs e)
        {
            if (t1Nombre.Text.Equals("Primer nombre"))
            {
                t1Nombre.Text = "";
                t1Nombre.ForeColor = Color.Black;
            }
        }

        private void t1Nombre_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(t1Nombre.Text))
            {
                t1Nombre.Text = "Primer nombre";
                t1Nombre.ForeColor = Color.Silver;
            }
        }

        private void t2Nombre_Enter(object sender, System.EventArgs e)
        {
            if (t2Nombre.Text.Equals("Segundo nombre"))
            {
                t2Nombre.Text = "";
                t2Nombre.ForeColor = Color.Black;
            }
        }

        private void t2Nombre_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(t2Nombre.Text))
            {
                t2Nombre.Text = "Segundo nombre";
                t2Nombre.ForeColor = Color.Silver;
            }
        }

        private void tCiudad_Enter(object sender, System.EventArgs e)
        {
            if (tCiudad.Text.Equals("Ciudad"))
            {
                tCiudad.Text = "";
                tCiudad.ForeColor = Color.Black;
            }
        }

        private void tCiudad_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCiudad.Text))
            {
                tCiudad.Text = "Ciudad";
                tCiudad.ForeColor = Color.Silver;
            }
        }

        private void tCalle_Enter(object sender, System.EventArgs e)
        {
            if (tCalle.Text.Equals("Calle"))
            {
                tCalle.Text = "";
                tCalle.ForeColor = Color.Black;
            }
        }

        private void tCalle_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCalle.Text))
            {
                tCalle.Text = "Calle";
                tCalle.ForeColor = Color.Silver;
            }
        }

        private void tNumero_Enter(object sender, System.EventArgs e)
        {
            if (tNumero.Text.Equals("Número"))
            {
                tNumero.Text = "";
                tNumero.ForeColor = Color.Black;
            }
        }

        private void tNumero_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tNumero.Text))
            {
                tNumero.Text = "Número";
                tNumero.ForeColor = Color.Silver;
            }
        }

        private void tCodPostal_Enter(object sender, System.EventArgs e)
        {
            if (tCodPostal.Text.Equals("Código postal"))
            {
                tCodPostal.Text = "";
                tCodPostal.ForeColor = Color.Black;
            }
        }

        private void tCodPostal_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCodPostal.Text))
            {
                tCodPostal.Text = "Código postal";
                tCodPostal.ForeColor = Color.Silver;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
