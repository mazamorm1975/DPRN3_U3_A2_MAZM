
namespace DPRNIII_U2_A1_MAZM
{
    partial class IngresoProyecto
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
            this.contenedorProyecto = new System.Windows.Forms.GroupBox();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.txtDescripcionProyecto = new System.Windows.Forms.TextBox();
            this.lblDescripcionProyecto = new System.Windows.Forms.Label();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.btnIngresar = new FontAwesome.Sharp.IconButton();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblDepto = new System.Windows.Forms.Label();
            this.cboDepto = new System.Windows.Forms.ComboBox();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboProyecto = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblEstatus = new System.Windows.Forms.Label();
            this.lblFecha_Final = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblNombreProyecto = new System.Windows.Forms.Label();
            this.contenedorProyecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // contenedorProyecto
            // 
            this.contenedorProyecto.Controls.Add(this.btnSalir);
            this.contenedorProyecto.Controls.Add(this.txtDescripcionProyecto);
            this.contenedorProyecto.Controls.Add(this.lblDescripcionProyecto);
            this.contenedorProyecto.Controls.Add(this.dgvProyecto);
            this.contenedorProyecto.Controls.Add(this.btnIngresar);
            this.contenedorProyecto.Controls.Add(this.txtStatus);
            this.contenedorProyecto.Controls.Add(this.lblDepto);
            this.contenedorProyecto.Controls.Add(this.cboDepto);
            this.contenedorProyecto.Controls.Add(this.dtFechaFinal);
            this.contenedorProyecto.Controls.Add(this.dtFechaInicio);
            this.contenedorProyecto.Controls.Add(this.cboProyecto);
            this.contenedorProyecto.Controls.Add(this.lblDepartamento);
            this.contenedorProyecto.Controls.Add(this.lblEstatus);
            this.contenedorProyecto.Controls.Add(this.lblFecha_Final);
            this.contenedorProyecto.Controls.Add(this.lblFechaInicio);
            this.contenedorProyecto.Controls.Add(this.lblNombreProyecto);
            this.contenedorProyecto.Location = new System.Drawing.Point(12, 12);
            this.contenedorProyecto.Name = "contenedorProyecto";
            this.contenedorProyecto.Size = new System.Drawing.Size(624, 240);
            this.contenedorProyecto.TabIndex = 0;
            this.contenedorProyecto.TabStop = false;
            this.contenedorProyecto.Text = "Proyecto_Information";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnSalir.IconColor = System.Drawing.Color.Red;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 28;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(441, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(164, 40);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescripcionProyecto
            // 
            this.txtDescripcionProyecto.Location = new System.Drawing.Point(173, 186);
            this.txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            this.txtDescripcionProyecto.Size = new System.Drawing.Size(252, 20);
            this.txtDescripcionProyecto.TabIndex = 22;
            // 
            // lblDescripcionProyecto
            // 
            this.lblDescripcionProyecto.AutoSize = true;
            this.lblDescripcionProyecto.Location = new System.Drawing.Point(24, 189);
            this.lblDescripcionProyecto.Name = "lblDescripcionProyecto";
            this.lblDescripcionProyecto.Size = new System.Drawing.Size(92, 13);
            this.lblDescripcionProyecto.TabIndex = 21;
            this.lblDescripcionProyecto.Text = "Nombre_Proyecto";
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.AllowUserToAddRows = false;
            this.dgvProyecto.AllowUserToDeleteRows = false;
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(173, 109);
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.Size = new System.Drawing.Size(252, 59);
            this.dgvProyecto.TabIndex = 20;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnIngresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIngresar.IconSize = 28;
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(441, 136);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(164, 40);
            this.btnIngresar.TabIndex = 15;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(441, 110);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 14;
            // 
            // lblDepto
            // 
            this.lblDepto.AutoSize = true;
            this.lblDepto.Location = new System.Drawing.Point(255, 93);
            this.lblDepto.Name = "lblDepto";
            this.lblDepto.Size = new System.Drawing.Size(74, 13);
            this.lblDepto.TabIndex = 12;
            this.lblDepto.Text = "Departamento";
            // 
            // cboDepto
            // 
            this.cboDepto.FormattingEnabled = true;
            this.cboDepto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cboDepto.Location = new System.Drawing.Point(22, 109);
            this.cboDepto.Name = "cboDepto";
            this.cboDepto.Size = new System.Drawing.Size(121, 21);
            this.cboDepto.TabIndex = 11;
            this.cboDepto.SelectedIndexChanged += new System.EventHandler(this.cboDepto_SelectedIndexChanged);
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Location = new System.Drawing.Point(405, 58);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtFechaFinal.TabIndex = 8;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(173, 58);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtFechaInicio.TabIndex = 7;
            // 
            // cboProyecto
            // 
            this.cboProyecto.FormattingEnabled = true;
            this.cboProyecto.Items.AddRange(new object[] {
            "P1",
            "P2",
            "P3",
            "P4",
            "P5",
            "P6",
            "P7",
            "P8",
            "P9",
            "P10",
            "P11",
            "P12",
            "P13",
            "P14",
            "P15",
            "P16",
            "P17",
            "P18",
            "P19",
            "P20",
            "P21",
            "P22",
            "P23",
            "P24",
            "P25",
            "P26",
            "P27",
            "P28",
            "P29",
            "P30",
            "P31",
            "P32",
            "P33",
            "P34",
            "P35",
            "P36",
            "P37",
            "P38",
            "P39",
            "P40",
            "P41",
            "P42",
            "P43",
            "P44",
            "P45",
            "P46",
            "P47",
            "P48",
            "P49",
            "P50",
            "P51",
            "P52",
            "P53",
            "P54",
            "P55",
            "P56",
            "P57",
            "P58",
            "P59",
            "P60",
            "P61",
            "P62",
            "P63",
            "P64",
            "P65",
            "P66",
            "P67",
            "P68",
            "P69",
            "P70",
            "P71",
            "P72",
            "P73",
            "P74",
            "P75",
            "P76",
            "P77",
            "P78",
            "P79",
            "P80",
            "P81",
            "P82",
            "P83",
            "P84",
            "P85",
            "P86",
            "P87",
            "P88",
            "P89",
            "P90",
            "P91",
            "P92",
            "P93",
            "P94",
            "P95",
            "P96",
            "P97",
            "P98",
            "P99",
            "P100"});
            this.cboProyecto.Location = new System.Drawing.Point(22, 58);
            this.cboProyecto.Name = "cboProyecto";
            this.cboProyecto.Size = new System.Drawing.Size(121, 21);
            this.cboProyecto.TabIndex = 6;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(24, 93);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(103, 13);
            this.lblDepartamento.TabIndex = 5;
            this.lblDepartamento.Text = "ID_Depto_Asignado";
            // 
            // lblEstatus
            // 
            this.lblEstatus.AutoSize = true;
            this.lblEstatus.Location = new System.Drawing.Point(450, 93);
            this.lblEstatus.Name = "lblEstatus";
            this.lblEstatus.Size = new System.Drawing.Size(78, 13);
            this.lblEstatus.TabIndex = 4;
            this.lblEstatus.Text = "Estatus_Actual";
            // 
            // lblFecha_Final
            // 
            this.lblFecha_Final.AutoSize = true;
            this.lblFecha_Final.Location = new System.Drawing.Point(463, 32);
            this.lblFecha_Final.Name = "lblFecha_Final";
            this.lblFecha_Final.Size = new System.Drawing.Size(65, 13);
            this.lblFecha_Final.TabIndex = 3;
            this.lblFecha_Final.Text = "Fecha_Final";
            this.lblFecha_Final.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(242, 32);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(68, 13);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha_Inicio";
            // 
            // lblNombreProyecto
            // 
            this.lblNombreProyecto.AutoSize = true;
            this.lblNombreProyecto.Location = new System.Drawing.Point(57, 32);
            this.lblNombreProyecto.Name = "lblNombreProyecto";
            this.lblNombreProyecto.Size = new System.Drawing.Size(49, 13);
            this.lblNombreProyecto.TabIndex = 0;
            this.lblNombreProyecto.Text = "Proyecto";
            // 
            // IngresoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 259);
            this.Controls.Add(this.contenedorProyecto);
            this.Name = "IngresoProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresoProyecto";
            this.contenedorProyecto.ResumeLayout(false);
            this.contenedorProyecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox contenedorProyecto;
        private System.Windows.Forms.Label lblFecha_Final;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblNombreProyecto;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.ComboBox cboProyecto;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblEstatus;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblDepto;
        private System.Windows.Forms.ComboBox cboDepto;
        private System.Windows.Forms.DataGridView dgvProyecto;
        private System.Windows.Forms.TextBox txtDescripcionProyecto;
        private System.Windows.Forms.Label lblDescripcionProyecto;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}