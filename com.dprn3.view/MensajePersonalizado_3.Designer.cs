
namespace DPRNIII_U2_A1_MAZM
{
    partial class MensajePersonalizado_3
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMensajePersonalizado_3 = new System.Windows.Forms.Label();
            this.btnOk = new FontAwesome.Sharp.IconButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(150, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 16);
            this.lblMessage.TabIndex = 1;
            // 
            // lblMensajePersonalizado_2
            // 
            this.lblMensajePersonalizado_3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblMensajePersonalizado_3.AutoSize = true;
            this.lblMensajePersonalizado_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajePersonalizado_3.Location = new System.Drawing.Point(188, 32);
            this.lblMensajePersonalizado_3.Name = "lblMensajePersonalizado_2";
            this.lblMensajePersonalizado_3.Size = new System.Drawing.Size(394, 16);
            this.lblMensajePersonalizado_3.TabIndex = 3;
            this.lblMensajePersonalizado_3.Text = "No puede existir mas de 3 programadores en un mismo proyecto";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnOk.IconColor = System.Drawing.Color.ForestGreen;
            this.btnOk.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOk.IconSize = 24;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(235, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "&Close";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::DPRNIII_U2_A1_MAZM.Properties.Resources.candado_color;
            this.pictureBox.Location = new System.Drawing.Point(12, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(115, 112);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // MensajePersonalizado_3
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 136);
            this.Controls.Add(this.lblMensajePersonalizado_3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MensajePersonalizado_3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MensajePersonalizado_3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnOk;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblMensajePersonalizado_3;
    }
}