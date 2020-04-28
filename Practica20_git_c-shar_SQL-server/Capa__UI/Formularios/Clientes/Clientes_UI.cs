using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica.Clientes;
namespace Capa__UI.Formularios.Clientes
{
    public partial class Clientes_UI : Form
    {
        Cliente nuevo = new Cliente();
        public Clientes_UI()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void llenar_Data_grid()
        {
            dataGridView1.DataSource = nuevo.mostrar("Cosultar_C3");
        }

        private void Clientes_UI_Load(object sender, EventArgs e)
        {
            llenar_Data_grid();
        }
    }
}
