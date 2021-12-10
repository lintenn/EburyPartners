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
    public partial class Holanda : Form
    {
        public Holanda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HealthCheck ventana = new HealthCheck();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bFiltroCuenta_Click(object sender, EventArgs e)
        {
            FiltroCuenta ventana = new FiltroCuenta();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void Holanda_Load(object sender, EventArgs e)
        {

        }
    }
}
