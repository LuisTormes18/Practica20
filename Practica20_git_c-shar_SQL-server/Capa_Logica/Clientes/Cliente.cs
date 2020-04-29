using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica.Clientes
{
    public class Cliente
    {
        /*Atributos de los clientes*/
        public string Nombre { get; set ; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Edad { get; set; }
        public char sexo { get; set; }
        public string direccion{ get; set; }
    }
}
