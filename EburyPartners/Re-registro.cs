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
    public partial class Reregistro : Form
    {

        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public Reregistro()
        {
            InitializeComponent();
            actualizarDatagrid();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
        
                    Formulario ventana = new Formulario((string)dataGridView1.SelectedRows[0].Cells[0].Value);
                    this.Visible = false;
                    ventana.ShowDialog();
                    this.Visible = true;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }

        }

        private void bRegistro_MouseClick(object sender, MouseEventArgs e)
        {
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            try
            {
                string consulta = "SELECT * FROM Cliente WHERE estado='Inactivo';";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
