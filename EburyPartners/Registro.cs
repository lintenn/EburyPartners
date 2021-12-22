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
    public partial class Registro : Form
    {

        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";

        public Registro()
        {
            InitializeComponent();
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Text = "Autónomo";
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipo.SelectedIndex == 0)
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
            }
            vaciarCampos();
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
            tCP.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void bRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbTipo.SelectedItem.ToString().Equals("Autónomo"))
                {
                    lStatus.ForeColor = Color.Red;
                    if (tDNI.Text.Equals(""))
                    {
                        lStatus.Text = "El campo DNI_NIF no puede estar vacío.";
                    }else if(tNombre1.Text.Equals(""))
                    {
                        lStatus.Text = "El campo Nombre no puede estar vacío.";
                    }else if (tApellido1.Text.Equals(""))
                    {
                        lStatus.Text = "El campo Apellido no puede estar vacío.";
                    }else if (dateTimePicker1.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                    {
                        lStatus.Text = "El campo Fecha no puede estar vacío.";
                    }
                    else
                    {

                        string n2 = "'" + tNombre2.Text + "'";
                        string a2 = "'" + tApellido2.Text + "'";
                        string calle = "'" + tCalle.Text + "'";
                        string pais = "'" + tPais.Text + "'";
                        string n = "'" + tNumero.Text + "'";
                        string ciudad = "'" + tCiudad.Text + "'";
                        string cp = "'" + tCP.Text + "'";

                        if (tNombre2.Text.Equals(""))
                        {
                            n2 = "NULL";
                        }
                        if (tApellido2.Text.Equals(""))
                        {
                            a2 = "NULL";
                        }
                        if (tCalle.Text.Equals(""))
                        {
                            calle = "NULL";
                        }
                        if (tPais.Text.Equals(""))
                        {
                            pais = "NULL";   
                        }
                        if (tNumero.Text.Equals(""))
                        {
                            n = "NULL"; 
                        }
                        if (tCiudad.Text.Equals(""))
                        {
                            ciudad = "NULL";
                        }
                        if (tCP.Text.Equals(""))
                        {
                            cp = "NULL";
                        }

                        MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                        miBD.Insert("INSERT INTO Cliente VALUES('" + tDNI.Text + "','" + tNombre1.Text + "'," + n2  + ",'" +  tApellido1.Text + "'," + a2 + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," + calle + "," + n + "," + ciudad + "," + cp + "," + pais + ",'Activo','" + cbTipo.Text + "');");
                        
                        lStatus.ForeColor = Color.Black;
                        lStatus.Text = "Cliente registrado correctamente en el sistema.";
                    }

                }
                else
                {
                    lStatus.ForeColor = Color.Red;
                    if (tDNI.Text.Equals(""))
                    {
                        lStatus.Text = "El campo DNI_NIF no puede estar vacío.";
                    }
                    else if (tNombre1.Text.Equals(""))
                    {
                        lStatus.Text = "El campo Nombre no puede estar vacío.";
                    }
                    else if (dateTimePicker1.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                    {
                        lStatus.Text = "El campo Fecha no puede estar vacío.";
                    }
                    else
                    {

                        string calle = "'" + tCalle.Text + "'";
                        string pais = "'" + tPais.Text + "'";
                        string n = "'" + tNumero.Text + "'";
                        string ciudad = "'" + tCiudad.Text + "'";
                        string cp = "'" + tCP.Text + "'";

                      
                        if (tCalle.Text.Equals(""))
                        {
                            calle = "NULL";
                        }
                        if (tPais.Text.Equals(""))
                        {
                            pais = "NULL";
                        }
                        if (tNumero.Text.Equals(""))
                        {
                            n = "NULL";
                        }
                        if (tCiudad.Text.Equals(""))
                        {
                            ciudad = "NULL";
                        }
                        if (tCP.Text.Equals(""))
                        {
                            cp = "NULL";
                        }

                        MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);
                        miBD.Insert("INSERT INTO Cliente VALUES('" + tDNI.Text + "','" + tNombre1.Text + "',NULL,NULL,NULL,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," + calle + "," + n + "," + ciudad + "," + cp + "," + pais + ",'Activo','" + cbTipo.Text + "');");

                        lStatus.ForeColor = Color.Black;
                        lStatus.Text = "Cliente registrado correctamente en el sistema.";
                    }
                }   

            }catch (Exception ex)
            {
                lStatus.ForeColor = Color.Red;
                lStatus.Text = "           Error al registrar el cliente";
            }
        }
    }
}
