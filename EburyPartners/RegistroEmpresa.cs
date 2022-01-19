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
    public partial class RegistroEmpresa : Form
    {
        public RegistroEmpresa()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            GestionPersonasEmpresa ventana = new GestionPersonasEmpresa();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}
