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
    public partial class SeleccionClientesCambioCuenta : Form
    {

        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public SeleccionClientesCambioCuenta()
        {
            InitializeComponent();
            actualizarDatagrid();
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            actualizarDatagrid();
        }

        private void actualizarDatagrid()
        {
            try
            {
                string consulta = "SELECT  p.tipo as 'Tipo de cuenta bancaria', p.IBAN, c.DNI_NIF, c.primer_nombre, c.segundo_nombre, c.primer_apellido, c.segundo_apellido, c.fecha_nacimiento, c.calle, c.num_edificio, c.ciudad, c.codigo_postal, c.pais_cliente, c.estado, c.tipo as 'Tipo de cuenta del cliente' FROM Cliente c left join Propietarios pr on c.DNI_NIF = pr.DNI_NIF left join Producto p on pr.IBAN = p.IBAN;";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    CambioDeCuenta ventana = new CambioDeCuenta((string)dataGridView1.SelectedRows[0].Cells[2].Value, (string)dataGridView1.SelectedRows[0].Cells[1].Value);
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

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
