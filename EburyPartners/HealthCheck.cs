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
    public partial class HealthCheck : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public HealthCheck()
        {
            InitializeComponent();
        }

        private void HealthCheck_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String health="La conexión con la API está online";

            try
            {
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                List<object[]> tupla = miBD.Select("SELECT * FROM Producto");

                if (tupla == null)
                {
                    health = "No hay conexión disponible con la API";
                }
            }
            catch
            {
                health = "No hay conexión disponible con la API";
            }

            tMessage.Text = health;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
