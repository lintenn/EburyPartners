using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EburyPartners
{
    public partial class EburyPartners : Form
    {
        public EburyPartners()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bAlemania_Click(object sender, EventArgs e)
        {
            Alemania ventana = new Alemania();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bHolanda_Click(object sender, EventArgs e)
        {
            Holanda ventana = new Holanda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;

        }
 
    }
}
