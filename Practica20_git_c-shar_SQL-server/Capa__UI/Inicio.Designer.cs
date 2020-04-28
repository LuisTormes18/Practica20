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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_linea = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.button_Menu = new System.Windows.Forms.Button();
            this.button_Clientes = new System.Windows.Forms.Button();
            this.button_Empleados = new System.Windows.Forms.Button();
            this.Barra_inicio = new System.Windows.Forms.Panel();
            this.button_menimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.Barra_inicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel_Menu.Controls.Add(this.panel_linea);
            this.panel_Menu.Controls.Add(this.panel_logo);
            this.panel_Menu.Controls.Add(this.button_Clientes);
            this.panel_Menu.Controls.Add(this.button_Empleados);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(200, 600);
            this.panel_Menu.TabIndex = 0;
            // 
            // panel_linea
            // 
            this.panel_linea.Location = new System.Drawing.Point(50, 52);
            this.panel_linea.Name = "panel_linea";
            this.panel_linea.Size = new System.Drawing.Size(8, 550);
            this.panel_linea.TabIndex = 5;
            this.panel_linea.Visible = false;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel_logo.Controls.Add(this.button_Menu);
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 52);
            this.panel_logo.TabIndex = 4;
            this.panel_logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_logo_MouseMove);
            // 
            // button_Menu
            // 
            this.button_Menu.FlatAppearance.BorderSize = 0;
            this.button_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Menu.Image = ((System.Drawing.Image)(resources.GetObject("button_Menu.Image")));
            this.button_Menu.Location = new System.Drawing.Point(12, 5);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(33, 37);
            this.button_Menu.TabIndex = 2;
            this.button_Menu.UseVisualStyleBackColor = true;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // button_Clientes
            // 
            this.button_Clientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.button_Clientes.FlatAppearance.BorderSize = 0;
            this.button_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clientes.Image = ((System.Drawing.Image)(resources.GetObject("button_Clientes.Image")));
            this.button_Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Clientes.Location = new System.Drawing.Point(12, 155);
            this.button_Clientes.Name = "button_Clientes";
            this.button_Clientes.Size = new System.Drawing.Size(169, 43);
            this.button_Clientes.TabIndex = 3;
            this.button_Clientes.Text = "Clientes";
            this.button_Clientes.UseVisualStyleBackColor = false;
            this.button_Clientes.Click += new System.EventHandler(this.button_Clientes_Click);
            // 
            // button_Empleados
            // 
            this.button_Empleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.button_Empleados.FlatAppearance.BorderSize = 0;
            this.button_Empleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Empleados.Image = ((System.Drawing.Image)(resources.GetObject("button_Empleados.Image")));
            this.button_Empleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Empleados.Location = new System.Drawing.Point(12, 87);
            this.button_Empleados.Name = "button_Empleados";
            this.button_Empleados.Size = new System.Drawing.Size(169, 43);
            this.button_Empleados.TabIndex = 2;
            this.button_Empleados.Text = "Empleados";
            this.button_Empleados.UseVisualStyleBackColor = false;
            this.button_Empleados.Click += new System.EventHandler(this.button_Empleados_Click);
            // 
            // Barra_inicio
            // 
            this.Barra_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.Barra_inicio.Controls.Add(this.button_menimizar);
            this.Barra_inicio.Controls.Add(this.button1);
            this.Barra_inicio.Controls.Add(this.flowLayoutPanel1);
            this.Barra_inicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_inicio.Location = new System.Drawing.Point(200, 0);
            this.Barra_inicio.Name = "Barra_inicio";
            this.Barra_inicio.Size = new System.Drawing.Size(800, 52);
            this.Barra_inicio.TabIndex = 1;
            this.Barra_inicio.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Barra_inicio_MouseMove);
            // 
            // button_menimizar
            // 
            this.button_menimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_menimizar.FlatAppearance.BorderSize = 0;
            this.button_menimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menimizar.Image = ((System.Drawing.Image)(resources.GetObject("button_menimizar.Image")));
            this.button_menimizar.Location = new System.Drawing.Point(640, 12);
            this.button_menimizar.Name = "button_menimizar";
            this.button_menimizar.Size = new System.Drawing.Size(49, 23);
            this.button_menimizar.TabIndex = 2;
            this.button_menimizar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(739, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(324, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 21);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(200, 52);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(800, 548);
            this.panel_contenedor.TabIndex = 2;
            this.panel_contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenedor_Paint);
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
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.Barra_inicio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Barra_inicio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_Empleados;
        private System.Windows.Forms.Button button_Clientes;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_menimizar;
        private System.Windows.Forms.Button button_Menu;
        public System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_linea;
    }
}

