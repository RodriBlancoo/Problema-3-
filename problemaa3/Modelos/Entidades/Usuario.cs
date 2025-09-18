using Modelos.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Modelos.Entidades
{
    public class Usuario
    {
        private int id_Usuario;
        private string nombre_Usuario;
        private string clave;
        private int id_Rol;

        public int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        public string Nombre_Usuario { get => nombre_Usuario; set => nombre_Usuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }


        public bool RegistrarUsuario()
        {
            try
            {
                SqlConnection conn = Conexion.Conexion.conectar();
                string queryhas = "INSERT INTO usuarios (nombre_Usuario,clave,id_Rol) VALUES (@nombre_Usuario,@clave,@id_Rol)";
                SqlCommand insertar = new SqlCommand(queryhas, conn);
                insertar.Parameters.AddWithValue("@nombre_Usuario", nombre_Usuario);
                insertar.Parameters.AddWithValue("@clave", clave);
                insertar.Parameters.AddWithValue("@id_Rol", id_Rol);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Este Usuario ya existe, ulitiliza otro correo electronico" + ex);
                return false;
            }
        }

        public bool VerificarLogin(string correo, string clave)
        {
            string hashEnBaseDeDatos = "";
            SqlConnection conn = Conexion.Conexion.conectar();
            string query = "SELECT *FROM usuarios WHERE nombre_Usuario=@nombre_Usuario";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Email", correo);
            MessageBox.Show("executeescarlar" + cmd.ExecuteScalar());
            if (cmd.ExecuteScalar() == null)
            {
                return false;
            }
            else
            {
                hashEnBaseDeDatos = cmd.ExecuteScalar().ToString();
                return BCrypt.Net.BCrypt.Verify(clave, hashEnBaseDeDatos);
            }
        }

        public static DataTable cargarRol()
        {
            SqlConnection conn = Conexion.Conexion.conectar();
            string querycargar = "SELECT Id_Roles,Nombre from Roles;";
            SqlDataAdapter dt = new SqlDataAdapter(querycargar, conn);
            DataTable tabla = new DataTable();
            dt.Fill(tabla);
            return tabla;
        }

    }

}
