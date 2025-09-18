using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelos.Conexion
{
    internal class Conexion
    {
        private static string servidor = "LAB03-DS-EQ17\\SQLEXPRESS";
        private static string dbdata = "Ejercicio_3";

        public static SqlConnection conectar()
        {
            try
            {
                string cadena = $"Data Source={servidor};Initial Catalog={dbdata};Integrated Security=true";
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();
                return conexion;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo conectar al servidor{servidor}", "Error:" + ex, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        }
    }

