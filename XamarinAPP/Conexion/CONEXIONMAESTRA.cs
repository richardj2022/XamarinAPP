using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace XamarinAPP.Conexion
{
    internal class CONEXIONMAESTRA
    {
        public static string conexion = ("Data Source=200.55.239.9,1404;Initial Catalog=BASEAPPXAMARIN;User ID=sa;Password=dbdesarrollo1234");
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void Abrir ()
        { 
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open ();
            }
        }
        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
