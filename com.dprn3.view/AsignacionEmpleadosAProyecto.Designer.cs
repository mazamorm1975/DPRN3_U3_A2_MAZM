
namespace DPRNIII_U2_A1_MAZM
{
    partial class AsignacionEmpleadosAProyecto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevaAsignacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosEmpleadoToolStripMenuItem,
            this.datosProyectoToolStripMenuItem,
            this.ingresoProyectoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosEmpleadoToolStripMenuItem
            // 
            this.datosEmpleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEmpleadoToolStripMenuItem});
            this.datosEmpleadoToolStripMenuItem.Name = "datosEmpleadoToolStripMenuItem";
            this.datosEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.datosEmpleadoToolStripMenuItem.Text = "Datos_Empleado";
            // 
            // nuevoEmpleadoToolStripMenuItem
            // 
            this.nuevoEmpleadoToolStripMenuItem.Name = "nuevoEmpleadoToolStripMenuItem";
            this.nuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoEmpleadoToolStripMenuItem.Text = "Nuevo_Empleado";
            this.nuevoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEmpleadoToolStripMenuItem_Click);
            // 
            // datosProyectoToolStripMenuItem
            // 
            this.datosProyectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.datosProyectoToolStripMenuItem.Name = "datosProyectoToolStripMenuItem";
            this.datosProyectoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.datosProyectoToolStripMenuItem.Text = "Datos_Proyecto";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // ingresoProyectoToolStripMenuItem
            // 
            this.ingresoProyectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaNuevaAsignacionToolStripMenuItem});
            this.ingresoProyectoToolStripMenuItem.Name = "ingresoProyectoToolStripMenuItem";
            this.ingresoProyectoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.ingresoProyectoToolStripMenuItem.Text = "Ingreso_Proyecto";
            // 
            // altaNuevaAsignacionToolStripMenuItem
            // 
            this.altaNuevaAsignacionToolStripMenuItem.Name = "altaNuevaAsignacionToolStripMenuItem";
            this.altaNuevaAsignacionToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.altaNuevaAsignacionToolStripMenuItem.Text = "Asignacion_Nuevo_Proyecto";
            this.altaNuevaAsignacionToolStripMenuItem.Click += new System.EventHandler(this.altaNuevaAsignacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // AsignacionEmpleadosAProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AsignacionEmpleadosAProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODULO_GESTION_PROYECTOS_Version_1.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsignacionEmpleadosAProyecto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNuevaAsignacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}