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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bPersona_Click(object sender, EventArgs e)
        {
            RegistroPersona ventana = new RegistroPersona();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void bEmpresa_Click(object sender, EventArgs e)
        {
            RegistroEmpresa ventana = new RegistroEmpresa();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
            this.Close();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
