using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Reportes
{
    public class ConexSQL
    {
        //variables para la conexion a la base de datos
        public static String servidorSQL = "DESKTOP-FTKL4RR";
        public static String baseDatos = "PUNTO_VENTAS";
        public static String usuario = "sa";
        public static String password = "1234";

        public static SqlConnection miConexion;


        public static void clsConexion()
        {
            miConexion = new SqlConnection();
        }

        //metodo para el string de conexion
        public static void ConnectionString(String _servidor, String _baseDatos, String _usuario, String _password)
        {

            if (miConexion.State == ConnectionState.Closed)
            {
                miConexion.ConnectionString = "Server= " + _servidor + "; Initial Catalog = " + _baseDatos + "; Integrated Security =false;user ID= " + _usuario
             + "; password= " + _password + "; MultipleActiveResultSets=true;"; //user id = sa password = j;
            }
        }
        //crea la base de datos
        public static void CrearBase()
        {

            string s = "IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'" + baseDatos + "') CREATE DATABASE " + baseDatos;
            SqlCommand cmd = new SqlCommand(s, miConexion);

            try
            {
                if (miConexion.State == System.Data.ConnectionState.Closed)
                {
                    miConexion.Open();
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                if (miConexion.State == System.Data.ConnectionState.Open)
                {
                    miConexion.Close();
                }
                ConnectionString(servidorSQL, baseDatos, usuario, password);
            }
        }
        //ejecuta consulta strign con parametros
        public clsMensaje ejecutarSentencia(String sql, SqlParameter[] misParametros)
        {
            clsMensaje miRespuesta = new clsMensaje();
            try
            {
                conectar();
                using (SqlCommand miCommand0 = new SqlCommand(sql, miConexion))
                {
                    miCommand0.CommandText = sql;
                    miCommand0.Connection = miConexion;
                    miCommand0.CommandType = System.Data.CommandType.Text;
                    miCommand0.Parameters.AddRange(misParametros);

                    try
                    {
                        miCommand0.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error:" + e.Message);
                    }
                    miRespuesta.codigoError = 0;
                }
            }
            catch (SqlException exSql)
            {
                MessageBox.Show("Erro SQL: " + exSql.Message, "PUNTO_VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                miRespuesta.codigoError = 1;
                miRespuesta.mensajeError = ex.Message;
            }
            return miRespuesta;
        }
        //conecta con la base de datos
        public static bool conectar()
        {
            bool resul;
            try
            {
                if (miConexion == null)
                {
                    clsConexion();
                }
                if (miConexion.State == ConnectionState.Closed)
                {
                    if (miConexion.State == ConnectionState.Open)
                    {
                        miConexion.Close();
                    }
                    miConexion.ConnectionString = "Server = " + servidorSQL + "; Initial Catalog = " + "master" + ";Integrated Security=false; User ID=" + usuario + ";Password=" + password + ";MultipleActiveResultSets=true;";
                    if (miConexion.State == ConnectionState.Closed)
                    {
                        miConexion.Open();
                    }
                    if (miConexion.State == System.Data.ConnectionState.Open)
                    {
                        CrearBase();
                        if (miConexion.State == ConnectionState.Open)
                        {
                            miConexion.Close();
                        }
                        ConnectionString(servidorSQL, baseDatos, usuario, password);
                        if (miConexion.State == ConnectionState.Closed)
                        {
                            miConexion.Open();
                        }
                    }
                }
                resul = true;
            }
            catch (Exception ex)
            {
                if (miConexion.State == ConnectionState.Open)
                {
                    miConexion.Close();
                }
                ConnectionString(servidorSQL, baseDatos, usuario, password);
                if (miConexion.State == ConnectionState.Closed)
                {
                    miConexion.Open();
                }
                resul = false;
                if (ex.Message != "No está autorizado a cambiar la propiedad 'ConnectionString'. El estado actual de la conexión es conectando.")
                {
                    MessageBox.Show("Error SQL: Problemas al conectar con el servidor, Error: " + ex.Message, "PUNTO_VENTAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return resul;
        }
        //lector consulta sql mediante un string
        public static SqlDataReader consultarInformacionSinParm(String sql)
        {
            conectar();
            SqlDataReader miDr = null;
            using (SqlCommand miCommand3 = new SqlCommand(sql, miConexion))
            {
                miCommand3.CommandText = sql;
                miCommand3.Connection = miConexion;
                miCommand3.CommandType = System.Data.CommandType.Text;
                try
                {
                    miDr = miCommand3.ExecuteReader();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message);
                }
            }

            return miDr;
        }
        //ejecuta la sentencia sql
        public void ejecutarSentenciaSql(String sqlCommandTex)
        {
            conectar();
            using (SqlCommand miCommand1 = new SqlCommand(sqlCommandTex, miConexion))
            {
                miCommand1.CommandText = sqlCommandTex;
                miCommand1.Connection = miConexion;
                miCommand1.CommandType = System.Data.CommandType.Text;

                try
                {
                    miCommand1.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message);
                }
            }
        }
        //consulta informacion mediante string y parametros
        public SqlDataReader consultarInformacion(String sql, SqlParameter[] misParametros)
        {
            conectar();
            SqlDataReader miDr = null;
            using (SqlCommand miCommand2 = new SqlCommand(sql, miConexion))
            {
                miCommand2.CommandText = sql;
                miCommand2.Connection = miConexion;
                miCommand2.Parameters.AddRange(misParametros);
                miCommand2.CommandType = System.Data.CommandType.Text;
                try
                {
                    miDr = miCommand2.ExecuteReader();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error:" + e.Message);
                }
            }
            return miDr;

        }
    }
}



