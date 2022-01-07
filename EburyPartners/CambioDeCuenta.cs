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
    public partial class CambioDeCuenta : Form
    {

        private const string SERVER = "eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com";
        private const string BD = "grupo01DB";
        private const string USER = "grupo01";
        private const string PWD = "nsB79maupU4rELd4";
        private string tipoCuenta;
        private string IBANCuenta;
        private string dni;
        private string paisCuenta;
        private string monedaCuenta;

        public CambioDeCuenta(string dniCliente, string IBAN)
        {
            InitializeComponent();

            dni = dniCliente;
            IBANCuenta = IBAN;

            actualizar(dni, IBANCuenta);

            comboBoxTipoCuenta.Items.Add("Pooled");
            comboBoxTipoCuenta.Items.Add("Segregada");
            comboBoxTipoCuenta.Items.Add("Dedicada");
        }

        private void bBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string aux = (String)comboBoxTipoCuenta.SelectedItem;
                aux = aux.ToLower();

                if (aux.Equals(tipoCuenta))
                {
                    lMessage.Text = "ERROR: El tipo de cuenta bancaria seleccionado es el mismo que el que usted posee";
                }
                else
                {
                    if (!tipoCuenta.Equals("pooled"))
                    {
                        if (!aux.Equals("pooled"))
                        {
                            string consulta = "UPDATE Producto Set tipo = '" + aux + "' where IBAN = '" + IBANCuenta + "';";

                            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                            miBD.Update(consulta);

                            lMessage.Text = "Se ha realizado con éxito";

                            actualizar(dni, IBANCuenta);
                        }
                        else
                        {

                            MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                            miBD.Delete("Delete FROM Propietarios where DNI_NIF='" + dni + "' and IBAN = '" + IBANCuenta + "'");

                            string nuevoIBAN = "";

                            string consulta1 = "Select IBAN from Producto where tipo = 'pooled' and fecha_cierre>NOW() and pais = '" + paisCuenta + "' and moneda = '" + monedaCuenta + "' and estado = 'activa';";

                            int i = 0;

                            foreach (Object[] tupla in miBD.Select(consulta1))
                            {
                                if (i == 0)
                                {
                                    nuevoIBAN = (String)tupla[0];
                                }
                                i++;
                            }

                            miBD.Insert("Insert into Propietarios values('" + dni + "','" + nuevoIBAN + "')");

                            lMessage.Text = "Se ha realizado con éxito";

                            actualizar(dni, nuevoIBAN);
                        }
                    }
                    else
                    {
                        MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                        miBD.Delete("Delete FROM Propietarios where DNI_NIF='" + dni + "' and IBAN = '" + IBANCuenta + "'");

                        string nuevoIBAN = "";

                        string consulta1 = "Select IBAN from Producto where tipo = '" + aux + "' and fecha_cierre>NOW() and pais = '" + paisCuenta + "' and moneda = '" + monedaCuenta + "' and estado = 'activa';";

                        int i = 0;

                        foreach (Object[] tupla in miBD.Select(consulta1))
                        {
                            if (i == 0)
                            {
                                nuevoIBAN = (String)tupla[0];
                            }
                            i++;
                        }

                        miBD.Insert("Insert into Propietarios values('" + dni + "','" + nuevoIBAN + "')");

                        lMessage.Text = "Se ha realizado con éxito";

                        actualizar(dni, nuevoIBAN);
                    }
                }
            }
            catch (Exception)
            {
                lMessage.ForeColor = Color.Red;
                lMessage.Text = "ERROR al conectar con la base de datos";
            }
        }

        private void actualizar(string dniCliente, string IBAN)
        {
            try
            {
                string consulta = "SELECT Producto.IBAN, tipo, Producto.moneda, Producto.pais FROM Producto left join Propietarios on Producto.IBAN = Propietarios.IBAN where Propietarios.DNI_NIF = '" + dniCliente + "' and Producto.IBAN = '" + IBAN + "';";

                MYSQLDB miBD = new MYSQLDB(SERVER, BD, USER, PWD);

                Object[] tupla = miBD.Select(consulta)[0];
                tipoCuenta = (String)tupla[1];
                IBANCuenta = (String)tupla[0];
                paisCuenta = (String)tupla[2];
                monedaCuenta = (String)tupla[3];

                lNombre.Text = "El cliente con DNI/NIF " + dniCliente + " tiene la cuenta " + tipoCuenta;
            }
            catch (Exception)
            {
                lMessage.ForeColor = Color.Red;
                lMessage.Text = "ERROR al conectar con la base de datos";
            }
        }

        private void CambioDeCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}
