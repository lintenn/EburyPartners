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
    public partial class ModificarAutorizados : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        private string iban;
        public ModificarAutorizados()
        {
            InitializeComponent();
            actualizarDGVCuentas();
        }

        private void actualizarDGVCuentas()
        {
            try
            {
                string consulta = "SELECT * FROM Producto WHERE IBAN IN (SELECT IBAN FROM Propietarios WHERE DNI_NIF IN (" +
                    "SELECT principal FROM Relacionado)) AND tipo = 'pooled';";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dgvCuentas, consulta);
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void mostrarSocios()
        {
            try
            {
                string consulta1 = "SELECT * FROM Cliente WHERE DNI_NIF IN " +
                    "(SELECT relacionado FROM Relacionado WHERE principal IN " +
                    "(SELECT DNI_NIF FROM Propietarios WHERE IBAN = '" + iban + "')) AND DNI_NIF NOT IN " +
                    "(SELECT DNI_NIF FROM Autorizado WHERE IBAN = '" + iban + "');";

                string consulta2 = "SELECT * FROM Cliente WHERE DNI_NIF IN " +
                    "(SELECT relacionado FROM Relacionado WHERE principal IN " +
                    "(SELECT DNI_NIF FROM Propietarios WHERE IBAN = '" + iban + "')) AND DNI_NIF IN " +
                    "(SELECT DNI_NIF FROM Autorizado WHERE IBAN = '" + iban + "');";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.mostrarDataGrid(dgvNoAutorizados, consulta1);
                miBD.mostrarDataGrid(dgvAutorizados, consulta2);
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void autorizarSocio(string nif)
        {
            try
            {
                string consulta = "INSERT INTO Autorizado VALUES('" + nif + "', '" + iban + "');";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.Insert(consulta);
                mostrarSocios();
                lStatus.ForeColor = Color.Black;
                lStatus.Text = "Cliente autorizado con éxito.";
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void desautorizarSocio(string nif)
        {
            try
            {
                string consulta = "DELETE FROM Autorizado WHERE DNI_NIF = '" + nif + "';";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                miBD.Delete(consulta);
                mostrarSocios();
                lStatus.ForeColor = Color.Black;
                lStatus.Text = "Cliente desautorizado con éxito.";
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCuentas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCuentas.SelectedRows.Count > 0)
                {
                    iban = (string)dgvCuentas.SelectedRows[0].Cells[0].Value;
                    mostrarSocios();
                    lStatus.Text = "";
                }
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void bAutorizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvNoAutorizados.SelectedRows.Count > 0)
                {
                    autorizarSocio((string)dgvNoAutorizados.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    lStatus.ForeColor = Color.Red;
                    lStatus.Text = "No se ha seleccionado ningún cliente de la lista de 'No autorizados'.";
                }
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }

        private void bDesautorizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAutorizados.SelectedRows.Count > 0)
                {
                    desautorizarSocio((string)dgvAutorizados.SelectedRows[0].Cells[0].Value);
                }
                else
                {
                    lStatus.ForeColor = Color.Red;
                    lStatus.Text = "No se ha seleccionado ningún cliente de la lista de 'Autorizados'.";
                }
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "Error al conectar con la base de datos.";
            }
        }
    }
}
