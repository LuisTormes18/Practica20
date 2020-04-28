using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica.Empleados;
using Capa_Logica.Clientes;
using Capa__UI.Formularios.Empleados;
namespace Capa__UI
{
    public partial class Inicio : Form {

        public Inicio()
        {
            InitializeComponent();
        }

        private void button_Empleados_Click(object sender, EventArgs e)
        {
            Form abrir = new Empleados_UI();
            abrir.BringToFront();
            abrir.Show();
        }
    }
}
