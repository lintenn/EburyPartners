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
    public partial class ModificarEstadoCliente : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public ModificarEstadoCliente()
        {
            InitializeComponent();
            labelMensaje.Text = "";
            actualizarDatagrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDatagrid()
        {
            try
            {
                string consulta = "SELECT * FROM Cliente;";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta);
            }
            catch (Exception ex)
            {
                labelMensaje.Text = ex.Message;
            }
        }

        private void bPasarInactivo_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string DNISeleccionado = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                string estadoSeleccionado = (string)dataGridView1.SelectedRows[0].Cells[11].Value;

                if (estadoSeleccionado.Equals("activo"))
                {
                    try
                    {

                        MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                        miBD.Update("UPDATE Cliente SET estado = 'inactivo' WHERE DNI_NIF = '" + DNISeleccionado + "';");

                        labelMensaje.Text = "Se ha pasado a inactivo con éxito.";
                    }
                    catch (Exception ex)
                    {
                        labelMensaje.Text = "ERROR: " + ex.Message;
                    }

                }
                else
                {
                    labelMensaje.Text = "ERROR: El cliente seleccionado ya se encuentra en estado inactivo.";
                }

            }
            else
            {
                labelMensaje.Text = "ERROR: Seleccione primero un cliente para pasar a inactivo.";
            }
                       
            actualizarDatagrid();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
