using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Datos;
namespace Capa_Logica.Empleados
{
    public class Empleado
    {
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
