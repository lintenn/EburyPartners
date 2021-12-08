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
    public partial class Alemania : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public Alemania()
        {
            InitializeComponent();
        }

        private void bGenerarInformeInicial_Click(object sender, EventArgs e)
        {
            try
            {
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                string sql = (string)miBD.SelectScalar("SELECT DNI_NIF FROM Cliente WHERE DNI_NIF = 111111;");

                tMessage.Text = sql;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
            
        }

        private void bGenerarInformeSemanal_Click(object sender, EventArgs e)
        {
            tMessage.Text = "";
        }

        private void Alemania_Load(object sender, EventArgs e)
        {

        }
    }
}
