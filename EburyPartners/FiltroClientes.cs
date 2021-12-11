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
    public partial class FiltroClientes : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public FiltroClientes()
        {
            InitializeComponent();
            //cbActivas.DropDownStyle = ComboBoxStyle.DropDownList;
            //cbActivas.Text = "Todas";
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {

        }

        private void tCuenta_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
