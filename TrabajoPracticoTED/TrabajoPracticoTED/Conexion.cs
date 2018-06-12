using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TrabajoPracticoTED
{
    public static class Conexion
    {
        private static string cadena_conexion = "Data Source=GASTONGARCIA\\SQLEXPRESS2014;Initial Catalog=Usuarios;Integrated Security=True";
        private static SqlConnection sql = null;
        public static SqlDataReader consultar_usuario_contraseña(string nombre, string contraseña)
        {
            SqlDataReader sdr = null;
            string consulta = "SELECT * FROM usuarios WHERE nombre = '" + nombre + "' AND contraseña = '" + contraseña + "';";
            sql = new SqlConnection();
            sql.ConnectionString = cadena_conexion;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql;

            sql.Open();
            cmd.CommandText = consulta;

            sdr = cmd.ExecuteReader();

            return sdr;
        }

        public static SqlDataReader consultar_usuario(string nombre)
        {
            SqlDataReader sdr = null;
            string consulta = "SELECT * FROM usuarios WHERE nombre = '" + nombre + "';";
            sql = new SqlConnection();
            sql.ConnectionString = cadena_conexion;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql;

            sql.Open();
            cmd.CommandText = consulta;

            sdr = cmd.ExecuteReader();

            return sdr;
        }

        public static void insertar_usuario(string nombre, string contraseña)
        {
            string consulta = "INSERT INTO usuarios(nombre, contraseña) VALUES('" + nombre + "', '" + contraseña + "');";
            sql = new SqlConnection();
            sql.ConnectionString = cadena_conexion;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = sql;

            sql.Open();
            cmd.CommandText = consulta;

            cmd.ExecuteNonQuery();
        }

        public static void CerrarConexion()
        {
            sql.Close();
        }
    }
}
