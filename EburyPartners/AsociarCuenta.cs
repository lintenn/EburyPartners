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
    public partial class AsociarCuenta : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public AsociarCuenta()
        {
            InitializeComponent();
            showClientes();
            lEstado.ForeColor = Color.Black;
            lEstado.Text = "";
        }

        private void showClientes()
        {
            try
            {     
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridViewClientes, "SELECT * FROM Cliente;");
            }
            catch
            {
                lEstado.ForeColor = Color.Red;
                lEstado.Text = "No se puede obtener la lista de clientes debido a que no existe conexión con la base de datos";
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bAsociar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count > 0 && lTipo.Text!="")
            {
                String DNI = (string)dataGridViewClientes.SelectedRows[0].Cells[0].Value;
                String IBAN = "1";
                String pais= (string)dataGridViewClientes.SelectedRows[0].Cells[10].Value;
                String tipo = lTipo.Text;
                AsociarCuentaBancaria(DNI, IBAN, pais, tipo);
                lEstado.ForeColor = Color.Black;
                lEstado.Text = "Cuenta con IBAN "+IBAN+"del tipo "+tipo+" asociada al cliente "+DNI;
            }
            else
            {
                lEstado.ForeColor = Color.Red;
                lEstado.Text = "Seleccione un cliente y tipo de cuenta antes de asociar cuenta bancaria";
            }

            dataGridViewClientes.ClearSelection();
            lTipo.SelectedIndex = -1;
        }

        public void AsociarCuentaBancaria(string DNI, string IBAN, string pais, string tipo)
        {
            Console.WriteLine(DNI + " " + IBAN + " " + pais + " " + tipo);
        }
    }
}
