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
namespace Capa__UI.Formularios.Empleados
{
    public partial class Empleados_UI : Form
    {
        public Empleados_UI()
        {
            InitializeComponent();
        }
        Empleado nuevo = new Empleado();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenar_Data_grid()
        {
            dataGridView1.DataSource = nuevo.mostrar("@Cosultar_E3");
        }
    }
}
