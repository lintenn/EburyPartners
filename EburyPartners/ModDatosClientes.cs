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
    public partial class ModDatosClientes : Form
    {
        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        private string nifCliente;

        public ModDatosClientes(string nifCliente)
        {
            InitializeComponent();
            this.nifCliente = nifCliente;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tDNI.Enabled = false;
            cbTipo.Enabled = false;

            try
            {
                string consulta = "SELECT * FROM Cliente WHERE DNI_NIF = '" + nifCliente + "';";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                Object[] tupla = miBD.Select(consulta)[0];
                tDNI.Text = nifCliente;
                tNombre1.Text = (string)tupla[1];
                tNombre2.Text = tupla[2] is DBNull ? "" : (string)tupla[2];
                tApellido1.Text = tupla[3] is DBNull ? "" : (string)tupla[3];
                tApellido2.Text = tupla[4] is DBNull ? "" : (string)tupla[4];
                dateTimePicker1.Value = (DateTime)tupla[5];
                tCalle.Text = tupla[6] is DBNull ? "" : (string)tupla[6];
                tNumero.Text = tupla[7] is DBNull ? "" : (string)tupla[7];
                tCiudad.Text = tupla[8] is DBNull ? "" : (string)tupla[8];
                tCP.Text = tupla[9] is DBNull ? "" : (string)tupla[9];
                tPais.Text = tupla[10] is DBNull ? "" : (string)tupla[10];
                cbTipo.Text = (string)tupla[12];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipo.SelectedIndex == 0)
            {
                lr3.Text = "*";
                lFecha.Text = "Fecha de nacimiento:";
                tNombre2.Enabled = true;
                tApellido1.Enabled = true;
                tApellido2.Enabled = true;
            }
            else
            {
                lr3.Text = "";
                lFecha.Text = "   Fecha de creación:";
                tNombre2.Enabled = false;
                tApellido1.Enabled = false;
                tApellido2.Enabled = false;
                tNombre2.Text = "";
                tApellido1.Text = "";
                tApellido2.Text = "";
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                string consulta = "SELECT * FROM Cliente WHERE DNI_NIF = '" + nifCliente + "';";
                Object[] tupla = miBD.Select(consulta)[0];

                lStatus.ForeColor = Color.Red;
                if (tDNI.Text.Equals("")) lStatus.Text = "El campo DNI_NIF no puede estar vacío.";
                else if (tNombre1.Text.Equals("")) lStatus.Text = "El campo Nombre no puede estar vacío.";
                else if (cbTipo.SelectedItem.ToString().Equals("Autónomo") && tApellido1.Text.Equals("")) lStatus.Text = "El campo Primer apellido no puede estar vacío.";
                else
                {
                    if (cbTipo.SelectedItem.ToString().Equals("Autónomo"))
                    {
                        if (!(tupla[2] is DBNull) && !tNombre2.Text.Equals((string)tupla[2]))
                        {
                            if (tNombre2.Text.Equals("")) miBD.Update("UPDATE Cliente SET segundo_nombre = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                            else miBD.Update("UPDATE Cliente SET segundo_nombre = '" + tNombre2.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                        }
                        else if ((tupla[2] is DBNull) && !tNombre2.Text.Equals(""))
                        {
                            miBD.Update("UPDATE Cliente SET segundo_nombre = '" + tNombre2.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                        }

                        if (!tApellido1.Text.Equals((string)tupla[3]))
                        {
                            miBD.Update("UPDATE Cliente SET primer_apellido = '" + tApellido1.Text + "' WHERE DNI_NIF ='" + nifCliente + "';");
                        }

                        if (!(tupla[4] is DBNull) && !tApellido2.Text.Equals((string)tupla[4]))
                        {
                            if (tApellido2.Text.Equals("")) miBD.Update("UPDATE Cliente SET segundo_apellido = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                            else miBD.Update("UPDATE Cliente SET segundo_apellido = '" + tApellido2.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                        }
                        else if ((tupla[4] is DBNull) && !tNombre2.Text.Equals(""))
                        {
                            miBD.Update("UPDATE Cliente SET segundo_apellido = '" + tNombre2.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                        }
                    }

                    if (!tDNI.Text.Equals((string)tupla[0]))
                    {
                        // miBD.Update("UPDATE Cliente SET DNI_NIF = '" + tDNI.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                        // nifCliente = tDNI.Text;
                    }

                    if (!tNombre1.Text.Equals((string)tupla[1]))
                    {
                        miBD.Update("UPDATE Cliente SET primer_nombre = '" + tNombre1.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    if (!dateTimePicker1.Value.Equals((DateTime)tupla[5]))
                    {
                        miBD.Update("UPDATE Cliente SET fecha_nacimiento = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' WHERE DNI_NIF ='" + nifCliente + "';");
                    }

                    if (!(tupla[6] is DBNull) && !tCalle.Text.Equals((string)tupla[6]))
                    {
                        if (tCalle.Text.Equals("")) miBD.Update("UPDATE Cliente SET calle = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                        else miBD.Update("UPDATE Cliente SET calle = '" + tCalle.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }
                    else if ((tupla[6] is DBNull) && !tCalle.Text.Equals(""))
                    {
                        miBD.Update("UPDATE Cliente SET calle = '" + tCalle.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    if (!(tupla[7] is DBNull) && !tNumero.Text.Equals((string)tupla[7]))
                    {
                        if (tNumero.Text.Equals("")) miBD.Update("UPDATE Cliente SET num_edificio = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                        else miBD.Update("UPDATE Cliente SET num_edificio = '" + tNumero.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }
                    else if ((tupla[7] is DBNull) && !tNumero.Text.Equals(""))
                    {
                        miBD.Update("UPDATE Cliente SET num_edificio = '" + tNumero.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    if (!(tupla[8] is DBNull) && !tCiudad.Text.Equals((string)tupla[8]))
                    {
                        if (tCiudad.Text.Equals("")) miBD.Update("UPDATE Cliente SET ciudad = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                        else miBD.Update("UPDATE Cliente SET ciudad = '" + tCiudad.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }
                    else if ((tupla[8] is DBNull) && !tCiudad.Text.Equals(""))
                    {
                        miBD.Update("UPDATE Cliente SET ciudad = '" + tCiudad.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    if (!(tupla[9] is DBNull) && !tCP.Text.Equals((string)tupla[9]))
                    {
                        if (tCP.Text.Equals("")) miBD.Update("UPDATE Cliente SET codigo_postal = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                        else miBD.Update("UPDATE Cliente SET codigo_postal = '" + tCP.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }
                    else if ((tupla[9] is DBNull) && !tCP.Text.Equals(""))
                    {
                        miBD.Update("UPDATE Cliente SET codigo_postal = '" + tCP.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    if (!(tupla[10] is DBNull) && !tPais.Text.Equals((string)tupla[10]))
                    {
                        if (tPais.Text.Equals("")) miBD.Update("UPDATE Cliente SET pais_cliente = NULL WHERE DNI_NIF = '" + nifCliente + "';");
                        else miBD.Update("UPDATE Cliente SET pais_cliente = '" + tPais.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }
                    else if ((tupla[10] is DBNull) && !tPais.Text.Equals(""))
                    {
                        miBD.Update("UPDATE Cliente SET pais_cliente = '" + tPais.Text + "' WHERE DNI_NIF = '" + nifCliente + "';");
                    }

                    lStatus.ForeColor = Color.Black;
                    lStatus.Text = "Datos actualizados correctamente.";
                }
            }
            catch (Exception)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "  Error al actualizar datos del cliente";
            }
        }
    }
}
