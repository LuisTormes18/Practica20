using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{
    class Sql_Connet
    {
        private SqlConnection conexion = new SqlConnection("Data Source =PC-PC\\SQLEXPRESS ; Initial Catalog =Practica;Integrated Security=true");

        /*metodo para abrir la coneccion*/
        public void abrir_conexion()
        {
            if(conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        /*metodo para cerrar la coneccion*/
        public void cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
