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

namespace EburyPartners
{
    public partial class ModClientesMain : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public ModClientesMain()
        {
            InitializeComponent();
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            try
            {
                string consulta = "SELECT * FROM Cliente;";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta);
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void actualizarSociosAutorizados(string nifEmpresa)
        {
            try
            {
                string consulta = "SELECT * FROM Cliente WHERE DNI_NIF IN " +
                    "(SELECT relacionado FROM Relacionado WHERE principal = '" + nifEmpresa + "');";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta);
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            lStatus.Text = "";
            actualizarDatagrid();
        }

        private void bSociosAutorizados_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (((string) dataGridView1.SelectedRows[0].Cells[12].Value).Equals("Autónomo")) 
                    {
                        lStatus.ForeColor = Color.Red;
                        lStatus.Text = "El cliente seleccionado no es una empresa.";
                    }
                    else
                    {
                        lStatus.Text = "";
                        actualizarSociosAutorizados((string)dataGridView1.SelectedRows[0].Cells[0].Value);
                    }
                }
                else
                {
                    lStatus.ForeColor = Color.Red;
                    lStatus.Text = "No se ha seleccionado ningún cliente.";
                }
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    lStatus.Text = "";
                    ModDatosClientes ventana = new ModDatosClientes((string) dataGridView1.SelectedRows[0].Cells[0].Value);
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    lStatus.ForeColor = Color.Red;
                    lStatus.Text = "No se ha seleccionado ningún cliente.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
