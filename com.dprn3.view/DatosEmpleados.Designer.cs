
namespace DPRNIII_U2_A1_MAZM
{
    partial class frmDatosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtApellido_Materno_Empleado = new System.Windows.Forms.TextBox();
            this.txtApellido__Paterno_Empleado = new System.Windows.Forms.TextBox();
            this.txtNombre_Empleado = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblIDEmpleado = new System.Windows.Forms.Label();
            this.dgvRolEmpleado = new System.Windows.Forms.DataGridView();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolEmpleado)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtApellido_Materno_Empleado);
            this.panel1.Controls.Add(this.txtApellido__Paterno_Empleado);
            this.panel1.Controls.Add(this.txtNombre_Empleado);
            this.panel1.Controls.Add(this.lblApellidoMaterno);
            this.panel1.Controls.Add(this.lblApellidoPaterno);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.txtIDEmpleado);
            this.panel1.Controls.Add(this.lblIDEmpleado);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 175);
            this.panel1.TabIndex = 0;
            // 
            // txtApellido_Materno_Empleado
            // 
            this.txtApellido_Materno_Empleado.Location = new System.Drawing.Point(134, 125);
            this.txtApellido_Materno_Empleado.Name = "txtApellido_Materno_Empleado";
            this.txtApellido_Materno_Empleado.Size = new System.Drawing.Size(266, 20);
            this.txtApellido_Materno_Empleado.TabIndex = 7;
            // 
            // txtApellido__Paterno_Empleado
            // 
            this.txtApellido__Paterno_Empleado.Location = new System.Drawing.Point(134, 89);
            this.txtApellido__Paterno_Empleado.Name = "txtApellido__Paterno_Empleado";
            this.txtApellido__Paterno_Empleado.Size = new System.Drawing.Size(266, 20);
            this.txtApellido__Paterno_Empleado.TabIndex = 6;
            // 
            // txtNombre_Empleado
            // 
            this.txtNombre_Empleado.Location = new System.Drawing.Point(134, 56);
            this.txtNombre_Empleado.Name = "txtNombre_Empleado";
            this.txtNombre_Empleado.Size = new System.Drawing.Size(266, 20);
            this.txtNombre_Empleado.TabIndex = 5;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(13, 128);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblApellidoMaterno.TabIndex = 4;
            this.lblApellidoMaterno.Text = "Apellido_Materno";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(13, 92);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Apellido_Paterno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre_Empleado";
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(134, 14);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(68, 20);
            this.txtIDEmpleado.TabIndex = 1;
            // 
            // lblIDEmpleado
            // 
            this.lblIDEmpleado.AutoSize = true;
            this.lblIDEmpleado.Location = new System.Drawing.Point(13, 17);
            this.lblIDEmpleado.Name = "lblIDEmpleado";
            this.lblIDEmpleado.Size = new System.Drawing.Size(84, 13);
            this.lblIDEmpleado.TabIndex = 0;
            this.lblIDEmpleado.Text = "Ldap_Empleado";
            // 
            // dgvRolEmpleado
            // 
            this.dgvRolEmpleado.AllowUserToAddRows = false;
            this.dgvRolEmpleado.AllowUserToDeleteRows = false;
            this.dgvRolEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolEmpleado.Location = new System.Drawing.Point(170, 16);
            this.dgvRolEmpleado.Name = "dgvRolEmpleado";
            this.dgvRolEmpleado.ReadOnly = true;
            this.dgvRolEmpleado.Size = new System.Drawing.Size(230, 60);
            this.dgvRolEmpleado.TabIndex = 10;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cboPerfil.Location = new System.Drawing.Point(16, 32);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(131, 21);
            this.cboPerfil.TabIndex = 9;
            this.cboPerfil.SelectedIndexChanged += new System.EventHandler(this.cboPerfil_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Perfill_De_Privilegios";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboPerfil);
            this.panel2.Controls.Add(this.dgvRolEmpleado);
            this.panel2.Location = new System.Drawing.Point(12, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 88);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 175);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iconSplitButton1
            // 
            this.iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconSplitButton1.IconColor = System.Drawing.Color.Black;
            this.iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSplitButton1.IconSize = 48;
            this.iconSplitButton1.Name = "iconSplitButton1";
            this.iconSplitButton1.Rotation = 0D;
            this.iconSplitButton1.Size = new System.Drawing.Size(23, 23);
            this.iconSplitButton1.Text = "iconSplitButton1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(431, 194);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(183, 44);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.btnSalir.IconColor = System.Drawing.Color.Black;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(431, 244);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(179, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // frmDatosEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 292);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDatosEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatosEmpleados";
            this.Load += new System.EventHandler(this.DatosEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolEmpleado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtApellido_Materno_Empleado;
        private System.Windows.Forms.TextBox txtApellido__Paterno_Empleado;
        private System.Windows.Forms.TextBox txtNombre_Empleado;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label lblIDEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRolEmpleado;
        public System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}