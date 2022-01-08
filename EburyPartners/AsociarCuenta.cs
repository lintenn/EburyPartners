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
                String pais= (string)dataGridViewClientes.SelectedRows[0].Cells[10].Value;
                String tipo = lTipo.Text;
                String IBAN = AsociarCuentaBancaria(DNI, pais, tipo);
                
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

        public string AsociarCuentaBancaria(string DNI, string pais, string tipo)
        {
            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
            miBD.mostrarDataGrid(dataGridViewClientes, "SELECT * FROM Cliente;");

            Object[] tupla = miBD.Select("SELECT * FROM Producto LEFT JOIN Propietarios USING(IBAN) WHERE Propietarios.IBAN IS NULL AND estado = 'activa' and cantidad = 0; ")[0];

            String IBAN=(string)tupla[0];
            return IBAN;
        }
    }
}
