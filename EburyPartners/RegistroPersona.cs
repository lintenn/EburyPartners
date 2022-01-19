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
    public partial class RegistroPersona : Form
    {

        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";
       

        public RegistroPersona()
        {
            InitializeComponent();
            
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }     

        private void vaciarCampos()
        {
            tNombre1.Text = "";
            tNombre2.Text = "";
            tApellido1.Text = "";
            tApellido2.Text = "";
            tDNI.Text = "";
            tCiudad.Text = "";
            tPais.Text = "";
            tCalle.Text = "";
            tNumero.Text = "";
            tRegion.Text = "";
            tPlanta.Text = "";
            tContraseña.Text = "";
            tContraseña2.Text = "";
            checkBox1.Checked = false;
            tCP.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                    lStatus.ForeColor = Color.Red;
                    if (tDNI.Text.Equals(""))
                    {
                        MessageBox.Show("El campo DNI_NIF no puede estar vacío.");
                    }
                    else if(tNombre1.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Nombre no puede estar vacío.");
                    }
                    else if (tApellido1.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Apellido no puede estar vacío.");
                    }
                    else if (dateTimePicker1.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                    {
                        MessageBox.Show("El campo Fecha no puede estar vacío.");
                    }
                    else if (tCalle.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Calle no puede estar vacío.");
                    }
                    else if (tNumero.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Número no puede estar vacío.");
                    }
                    else if (tPlanta.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Planta/Puerta/Oficina no puede estar vacío.");
                    }
                    else if (tCiudad.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Ciudad no puede estar vacío.");
                    }
                    else if (tCP.Text.Equals(""))
                    {
                        MessageBox.Show("El campo Código Postal no puede estar vacío.");
                    }
                    else if (tPais.Text.Equals(""))
                    {
                        MessageBox.Show("El campo País no puede estar vacío.");
                    }
                    else if (DateTime.Compare(dateTimePicker1.Value.AddYears(18),DateTime.Now) > 0)
                    {
                        MessageBox.Show("Debe tener al menos 18 años.");
                    }
                    else if (!tContraseña.Text.Equals(tContraseña2.Text))
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                    }
                    else if (tContraseña.Text.Equals(""))
                    {
                        MessageBox.Show("El campo contraseña no puede estar vacío.");
                    }
                    else
                    {

                        string n2 = "'" + tNombre2.Text + "'";
                        string a2 = "'" + tApellido2.Text + "'";
                        string r  = "'" + tRegion.Text + "'";
                        

                        if (tNombre2.Text.Equals(""))
                        {
                            n2 = "NULL";
                        }
                        if (tApellido2.Text.Equals(""))
                        {
                            a2 = "NULL";
                        }
                        if (tRegion.Text.Equals(""))
                        {
                            r = "NULL";
                        }

                    MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                        bool esta = false;
                     
                        foreach(Object[] t in miBD.Select("SELECT * FROM Cliente WHERE DNI_NIF='" + tDNI.Text + "';")){
                                esta = true;
                        }

                        if (esta)
                        {
                            MessageBox.Show("Cliente ya existente en el sistema.");
                        }
                        else
                        {

                            miBD.Insert("INSERT INTO Cliente VALUES('" + tDNI.Text + "','" + tNombre1.Text + "'," + n2 + ",'" + tApellido1.Text + "'," + a2 + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + tCalle.Text + "','" + tNumero.Text + "','" + tPlanta.Text + "','" + tCiudad.Text + "'," + r + ",'" + tCP.Text + "','" + tPais.Text + "'," + (checkBox1.Checked ? 1:0) + ",'activo','Autónomo','" + tContraseña.Text + "',NULL);");

                            MessageBox.Show("Cliente registrado correctamente en el sistema.");
                            this.Close();
                        }
                    }
            }catch (Exception)
            {
                MessageBox.Show("No se ha podido crear la cuenta por problemas de acceso a la base de datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaciarCampos();
        }
    }
}
