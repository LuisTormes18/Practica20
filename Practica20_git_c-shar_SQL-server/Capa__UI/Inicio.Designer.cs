namespace Capa__UI
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.button_Empleados = new System.Windows.Forms.Button();
            this.Barra_inicio = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Clientes = new System.Windows.Forms.Button();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.Barra_inicio.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.panel_logo);
            this.panel_Menu.Controls.Add(this.button_Clientes);
            this.panel_Menu.Controls.Add(this.button_Empleados);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 600);
            this.panel_Menu.TabIndex = 0;
            // 
            // button_Empleados
            // 
            this.button_Empleados.Location = new System.Drawing.Point(12, 88);
            this.button_Empleados.Name = "button_Empleados";
            this.button_Empleados.Size = new System.Drawing.Size(137, 43);
            this.button_Empleados.TabIndex = 2;
            this.button_Empleados.Text = "Empleados";
            this.button_Empleados.UseVisualStyleBackColor = true;
            this.button_Empleados.Click += new System.EventHandler(this.button_Empleados_Click);
            // 
            // Barra_inicio
            // 
            this.Barra_inicio.Controls.Add(this.flowLayoutPanel1);
            this.Barra_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_inicio.Location = new System.Drawing.Point(200, 0);
            this.Barra_inicio.Name = "Barra_inicio";
            this.Barra_inicio.Size = new System.Drawing.Size(800, 67);
            this.Barra_inicio.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 21);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_Clientes
            // 
            this.button_Clientes.Location = new System.Drawing.Point(12, 137);
            this.button_Clientes.Name = "button_Clientes";
            this.button_Clientes.Size = new System.Drawing.Size(137, 43);
            this.button_Clientes.TabIndex = 3;
            this.button_Clientes.Text = "Clientes";
            this.button_Clientes.UseVisualStyleBackColor = true;
            this.button_Clientes.Click += new System.EventHandler(this.button_Clientes_Click);
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.SystemColors.Window;
            this.panel_contenedor.Controls.Add(this.flowLayoutPanel2);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(200, 67);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(800, 533);
            this.panel_contenedor.TabIndex = 2;
            this.panel_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(324, 120);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 21);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 67);
            this.panel_logo.TabIndex = 4;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.Barra_inicio);
            this.Controls.Add(this.panel_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.panel_Menu.ResumeLayout(false);
            this.Barra_inicio.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel Barra_inicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Empleados;
        private System.Windows.Forms.Button button_Clientes;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel_logo;
    }
}

