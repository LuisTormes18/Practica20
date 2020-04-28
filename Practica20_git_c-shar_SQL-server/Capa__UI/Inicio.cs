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
using Capa__UI.Formularios.Clientes;
namespace Capa__UI
{
    public partial class Inicio : Form {

        public Inicio()
        {
            InitializeComponent();
        }

        private void button_Empleados_Click(object sender, EventArgs e)
        {
            formulario_hijo(new Empleados_UI());

        }

        Form formularioactivo = null;
        private void formulario_hijo(Form hijo)
        {
            if (formularioactivo != null)
            {
                formularioactivo.Close();
            }
            formularioactivo = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(hijo);
            panel_contenedor.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
        }

        private void panel_contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            formulario_hijo(new Clientes_UI());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_Menu_Click(object sender, EventArgs e)
        {
            
        }
    }
}
