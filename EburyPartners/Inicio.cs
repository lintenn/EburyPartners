using System;
using System.Windows.Forms;

namespace EburyPartners
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void bOtras_Click(object sender, EventArgs e)
        {
            EburyPartners ventana = new EburyPartners();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }

        private void bReRegistro_Click(object sender, EventArgs e)
        {
            Reregistro ventana = new Reregistro();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}
