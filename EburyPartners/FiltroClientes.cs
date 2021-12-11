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
    public partial class FiltroClientes : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public FiltroClientes()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            string consulta;
            string fecha;
            string ano; 

            ano = (Int32.Parse(DateTime.Now.ToString("yyyy")) - 3).ToString();
            fecha = DateTime.Now.ToString("MM-dd");
            fecha = ano + "-" + fecha;

            consulta = "SELECT * FROM Producto WHERE IBAN IN (SELECT IBAN FROM Propietarios WHERE DNI_NIF IN " +
                "(SELECT DNI_NIF FROM Cliente WHERE DNI_NIF IS NOT NULL"; 

            if (!t1Nombre.Text.Equals("Primer nombre")) consulta += " AND primer_nombre LIKE '%" + t1Nombre.Text + "%'";
            if (!t2Nombre.Text.Equals("Segundo nombre")) consulta += " AND segundo_nombre LIKE '%" + t2Nombre.Text + "%'";
            if (!tCiudad.Text.Equals("Ciudad")) consulta += " AND ciudad LIKE '%" + tCiudad.Text + "%'";
            if (!tCalle.Text.Equals("Calle")) consulta += " AND calle LIKE '%" + tCalle.Text + "%'";
            if (!tNumero.Text.Equals("Número")) consulta += " AND num_edificio LIKE '%" + tNumero.Text + "%'";
            if (!tCodPostal.Text.Equals("Código postal")) consulta += " AND codigo_postal LIKE '%" + tCodPostal.Text + "%'";

            consulta += ")) AND IBAN LIKE 'NL%' AND fecha_cierre > '" + fecha + "';";

            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
            miBD.mostrarDataGrid(dataGridClientes, consulta, label1);
        }

        private void t1Nombre_Enter(object sender, System.EventArgs e)
        {
            if (t1Nombre.Text.Equals("Primer nombre"))
            {
                t1Nombre.Text = "";
                t1Nombre.ForeColor = Color.Black;
            }
        }

        private void t1Nombre_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(t1Nombre.Text))
            {
                t1Nombre.Text = "Primer nombre";
                t1Nombre.ForeColor = Color.Silver;
            }
        }

        private void t2Nombre_Enter(object sender, System.EventArgs e)
        {
            if (t2Nombre.Text.Equals("Segundo nombre"))
            {
                t2Nombre.Text = "";
                t2Nombre.ForeColor = Color.Black;
            }
        }

        private void t2Nombre_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(t2Nombre.Text))
            {
                t2Nombre.Text = "Segundo nombre";
                t2Nombre.ForeColor = Color.Silver;
            }
        }

        private void tCiudad_Enter(object sender, System.EventArgs e)
        {
            if (tCiudad.Text.Equals("Ciudad"))
            {
                tCiudad.Text = "";
                tCiudad.ForeColor = Color.Black;
            }
        }

        private void tCiudad_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCiudad.Text))
            {
                tCiudad.Text = "Ciudad";
                tCiudad.ForeColor = Color.Silver;
            }
        }

        private void tCalle_Enter(object sender, System.EventArgs e)
        {
            if (tCalle.Text.Equals("Calle"))
            {
                tCalle.Text = "";
                tCalle.ForeColor = Color.Black;
            }
        }

        private void tCalle_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCalle.Text))
            {
                tCalle.Text = "Calle";
                tCalle.ForeColor = Color.Silver;
            }
        }

        private void tNumero_Enter(object sender, System.EventArgs e)
        {
            if (tNumero.Text.Equals("Número"))
            {
                tNumero.Text = "";
                tNumero.ForeColor = Color.Black;
            }
        }

        private void tNumero_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tNumero.Text))
            {
                tNumero.Text = "Número";
                tNumero.ForeColor = Color.Silver;
            }
        }

        private void tCodPostal_Enter(object sender, System.EventArgs e)
        {
            if (tCodPostal.Text.Equals("Código postal"))
            {
                tCodPostal.Text = "";
                tCodPostal.ForeColor = Color.Black;
            }
        }

        private void tCodPostal_Leave(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(tCodPostal.Text))
            {
                tCodPostal.Text = "Código postal";
                tCodPostal.ForeColor = Color.Silver;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Holanda ventana = new Holanda();
            this.Visible = false;
            ventana.ShowDialog();
            this.Visible = true;
        }
    }
}
