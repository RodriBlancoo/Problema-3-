namespace Vistas.Formularios
{
    partial class frmPricipalRegistro
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
            this.btncrearCuenta = new System.Windows.Forms.Button();
            this.btnInicarsesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncrearCuenta
            // 
            this.btncrearCuenta.BackColor = System.Drawing.Color.SeaGreen;
            this.btncrearCuenta.Location = new System.Drawing.Point(12, 375);
            this.btncrearCuenta.Name = "btncrearCuenta";
            this.btncrearCuenta.Size = new System.Drawing.Size(81, 41);
            this.btncrearCuenta.TabIndex = 0;
            this.btncrearCuenta.Text = "Crear Cuenta";
            this.btncrearCuenta.UseVisualStyleBackColor = false;
            // 
            // btnInicarsesion
            // 
            this.btnInicarsesion.BackColor = System.Drawing.Color.SeaGreen;
            this.btnInicarsesion.Location = new System.Drawing.Point(99, 375);
            this.btnInicarsesion.Name = "btnInicarsesion";
            this.btnInicarsesion.Size = new System.Drawing.Size(81, 41);
            this.btnInicarsesion.TabIndex = 1;
            this.btnInicarsesion.Text = "Inicar Sesion";
            this.btnInicarsesion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnInicarsesion);
            this.panel1.Controls.Add(this.btncrearCuenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(600, 450);
            this.pnlPrincipal.TabIndex = 3;
            // 
            // frmPricipalRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "frmPricipalRegistro";
            this.Text = "frmPricipalRegistro";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncrearCuenta;
        private System.Windows.Forms.Button btnInicarsesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}