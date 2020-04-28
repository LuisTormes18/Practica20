using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Capa_Datos
{

    public class Sql_Connet
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
        /*metodo para mostrar cualquier tabla*/
        public DataTable Mostrar(string Sp_Consulta)
        {
            abrir_conexion();
            SqlCommand cmd = new SqlCommand(Sp_Consulta, conexion);
            cmd.CommandType = CommandType.StoredProcedure;          
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            ad.Fill(dt, "tabla");
            cerrar_conexion();
            return dt.Tables["tabla"];

        }
        /*metodo para insertar empleados*/
        public string insertar_E(string doc_I,string nombre,string apellido,int edad,char sexo,string puesto)
        {
            abrir_conexion();
            SqlCommand cmd = new SqlCommand("insertar_E",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@di",doc_I);
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@apellido",apellido);
            cmd.Parameters.AddWithValue("@edad",edad);         
            cmd.Parameters.AddWithValue("@sexo",sexo);
            cmd.Parameters.AddWithValue("@puesto",puesto);
            int verdad = cmd.ExecuteNonQuery();
            cerrar_conexion();
            if (verdad > 0)
                return "se ha isertaddo correctamente";
            else
                return "ha ocurrido un error";
            
        }
    }
}
