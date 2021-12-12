using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BDLibrary
{
    public class BDLibrary
    {
        public string origen_datos;
        public string cadenaConexion;
        public string cadenaConexionSQLNCLI;

        public BDLibrary()
        {

        }

        public List<string> getColumnas(string tabla)
        {
            List<string> res = new List<string>();
            string consultaSelect = "SELECT TOP 1 * FROM " + tabla + ";";
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            reader.Read();
            for (int i = 0; i < reader.FieldCount; ++i) res.Add(reader.GetName(i));

            conexion.Close();
            return res;
        }

        public void mostrarDataGrid(DataGridView dg, string consulta, Label l)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);

                conexion.Open();

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                MySqlDataAdapter con = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();
                con.Fill(ds);

                dg.DataSource = ds.Tables[0];


                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<object[]> Select(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;

            List<object[]> res = new List<object[]>();
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                int numColumnas = reader.FieldCount;
                object[] fila = new object[numColumnas];
                for (int i = 0; i < numColumnas; ++i) fila[i] = reader[i];
                res.Add(fila);
            }

            conexion.Close();


            return res;
        }

        public object SelectScalar(string consultaSelect)
        {

            if (consultaSelect.Length == 0) return null;
            if (consultaSelect.ToUpper().IndexOf("SELECT") == -1) return null;
            if (consultaSelect.ToUpper().IndexOf("DROP") > -1) return null;


            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(consultaSelect, conexion);

            conexion.Open();
            object res = comando.ExecuteScalar();

            conexion.Close();


            return res;
        }

        public void Update(string cadenaUpdate)
        {
            if (cadenaUpdate.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaUpdate, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Delete(string cadenaDelete)
        {
            if (cadenaDelete.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            MySqlCommand comando = new MySqlCommand(cadenaDelete, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Insert(string cadenaInsert)
        {
            if (cadenaInsert.Length == 0) return;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            MySqlCommand comando = new MySqlCommand(cadenaInsert, conexion);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void EjecutaProcedimiento(string name, SqlParameter[] param)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexionSQLNCLI);
            SqlCommand comando = new SqlCommand(name, conexion);
            foreach (SqlParameter p in param)
            {
                comando.Parameters.Add(p);
            }
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }

    public class AccessDB : BDLibrary
    {
        public AccessDB(string pathBD)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; "
                    + "Data Source=" + pathBD;
        }

        public AccessDB(string pathBD, string pwd)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0; "
                    + "Data Source=" + pathBD
                    + ";Jet OLEDB:Database Password=" + pwd;
        }
    }

    public class AccessDB2007 : BDLibrary
    {

        public AccessDB2007(string pathBD)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; "
                    + "Data Source=" + pathBD;
        }

        public AccessDB2007(string pathBD, string pwd)
        {
            origen_datos = pathBD;
            cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0; "
                    + "Data Source=" + pathBD
                    + ";Jet OLEDB:Database Password=" + pwd;
        }
    }

    public class SQLSERVERDB : BDLibrary
    {
        public SQLSERVERDB(string server, string instancia, string BD)
        {
            origen_datos = BD;

            cadenaConexion = "Provider=SQLOLEDB;Data Source=" + server + "\\" + instancia
                + ";Integrated Security=SSPI;Initial Catalog=" + BD;
            cadenaConexionSQLNCLI = "Data Source=" + server + "\\" + instancia
                + ";Integrated Security=SSPI;Initial Catalog=" + BD;
        }

        public SQLSERVERDB(string server, string BD)
        {
            origen_datos = BD;

            cadenaConexion = "Provider=SQLOLEDB;Data Source=" + server + ";"
                + "Integrated Security=SSPI;Initial Catalog=" + BD;
            cadenaConexionSQLNCLI = "Data Source=" + server + ";"
                + "Integrated Security=SSPI;Initial Catalog=" + BD;
        }


        public SQLSERVERDB(string server, string instancia, string BD, string user, string pwd)
        {
            origen_datos = BD;

            cadenaConexion = "Provider=SQLOLEDB;Data Source=" + server + "\\" + instancia
                + "Initial Catalog=" + BD + ";User ID=" + user + ";Password=" + pwd + ";";
            cadenaConexionSQLNCLI = "Data Source=" + server + "\\" + instancia
                + "Initial Catalog=" + BD + ";User ID=" + user + ";Password=" + pwd + ";";
        }

        public SQLSERVERDB(string server, string BD, string user, string pwd)
        {
            origen_datos = BD;

            cadenaConexion = "Provider=SQLOLEDB;Data Source=" + server + ";"
                + "Initial Catalog=" + BD + ";User ID=" + user + ";Password=" + pwd + ";";
            cadenaConexionSQLNCLI = "Data Source=" + server + ";"
                + "Initial Catalog=" + BD + ";User ID=" + user + ";Password=" + pwd + ";";
        }


    }

    public class MYSQLDB : BDLibrary
    {
        public MYSQLDB(string server, string BD, string user, string pwd)
        {
            origen_datos = BD;

            cadenaConexion = "Data Source=" + server + "; Database=" + BD + "; User ID=" + user + "; Password=" + pwd + ";";
            cadenaConexionSQLNCLI = "";
        }

    }


}