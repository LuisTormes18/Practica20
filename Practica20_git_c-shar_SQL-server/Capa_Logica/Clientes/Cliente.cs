using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_Logica.Clientes
{
    public class Cliente
    {
        /*Atributos de los clientes*/
        Sql_Connet Connecion = new Sql_Connet();
        public string Dmi;
        public string Nombre;
        public string Apellido;
        public string Cedula;
        public int Edad;
        public char sexo;
        public string puesto;
        public DataTable mostrar(string Sp)
        {
            return Connecion.Mostrar(Sp);
        }
    }
}
