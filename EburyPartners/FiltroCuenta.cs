using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BDLibrary;

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

        private void cbActivas_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    consulta = "SELECT * FROM Producto WHERE IBAN LIKE '%" + tCuenta.Text + "%' AND pais='NL';";
                }
                else
                {
                    consulta = "SELECT * FROM Producto WHERE IBAN LIKE '%" + tCuenta.Text + "%' AND estado='" + cbActivas.Text + "' AND pais='NL';";
                }

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridView1, consulta,label1);

                if (dataGridView1.Rows.Count == 1)
                {
                    label1.Text = "Cuenta no encontrada";
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
            Holanda ventana = new Holanda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}
