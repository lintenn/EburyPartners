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
        }

        private void showClientes()
        {
            try
            {     
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dataGridViewClientes, "SELECT * FROM Cliente;");
            }
            catch (Exception)
            {
               
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
