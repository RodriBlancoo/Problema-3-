namespace Vistas.Formularios
{
    partial class frmProductos
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
            this.tcRegistarProducto = new System.Windows.Forms.TabControl();
            this.tcAgregarProducto = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbInfoProducto = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblZapato = new System.Windows.Forms.Label();
            this.tbActualizarroducto = new System.Windows.Forms.TabPage();
            this.dgvProductosActualizar = new System.Windows.Forms.DataGridView();
            this.btnActualizarActualizar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gbInfoActualizar = new System.Windows.Forms.GroupBox();
            this.cbCategoriaActualizar = new System.Windows.Forms.ComboBox();
            this.dtpFechaActualizar = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreProductoActualizar = new System.Windows.Forms.TextBox();
            this.lblPrecioActualizar = new System.Windows.Forms.Label();
            this.lblFechaActualizar = new System.Windows.Forms.Label();
            this.lblCategoriaActualizar = new System.Windows.Forms.Label();
            this.lblZapatoActualizar = new System.Windows.Forms.Label();
            this.tcRegistarProducto.SuspendLayout();
            this.tcAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.gbInfoProducto.SuspendLayout();
            this.tbActualizarroducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosActualizar)).BeginInit();
            this.gbInfoActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcRegistarProducto
            // 
            this.tcRegistarProducto.Controls.Add(this.tcAgregarProducto);
            this.tcRegistarProducto.Controls.Add(this.tbActualizarroducto);
            this.tcRegistarProducto.Location = new System.Drawing.Point(12, 12);
            this.tcRegistarProducto.Name = "tcRegistarProducto";
            this.tcRegistarProducto.SelectedIndex = 0;
            this.tcRegistarProducto.Size = new System.Drawing.Size(762, 426);
            this.tcRegistarProducto.TabIndex = 0;
            // 
            // tcAgregarProducto
            // 
            this.tcAgregarProducto.Controls.Add(this.dgvProductos);
            this.tcAgregarProducto.Controls.Add(this.btnInsertar);
            this.tcAgregarProducto.Controls.Add(this.btnEliminar);
            this.tcAgregarProducto.Controls.Add(this.btnActualizar);
            this.tcAgregarProducto.Controls.Add(this.gbInfoProducto);
            this.tcAgregarProducto.Location = new System.Drawing.Point(4, 22);
            this.tcAgregarProducto.Name = "tcAgregarProducto";
            this.tcAgregarProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tcAgregarProducto.Size = new System.Drawing.Size(754, 400);
            this.tcAgregarProducto.TabIndex = 0;
            this.tcAgregarProducto.Text = "Agregar Producto";
            this.tcAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(19, 261);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(703, 133);
            this.dgvProductos.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(489, 69);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(233, 40);
            this.btnInsertar.TabIndex = 11;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(489, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 36);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(489, 157);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(233, 47);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // gbInfoProducto
            // 
            this.gbInfoProducto.Controls.Add(this.cbCategoria);
            this.gbInfoProducto.Controls.Add(this.dtpFecha);
            this.gbInfoProducto.Controls.Add(this.txtPrecio);
            this.gbInfoProducto.Controls.Add(this.txtNombreProducto);
            this.gbInfoProducto.Controls.Add(this.lblPrecio);
            this.gbInfoProducto.Controls.Add(this.lblFecha);
            this.gbInfoProducto.Controls.Add(this.lblCategoria);
            this.gbInfoProducto.Controls.Add(this.lblZapato);
            this.gbInfoProducto.Location = new System.Drawing.Point(19, 17);
            this.gbInfoProducto.Name = "gbInfoProducto";
            this.gbInfoProducto.Size = new System.Drawing.Size(464, 231);
            this.gbInfoProducto.TabIndex = 1;
            this.gbInfoProducto.TabStop = false;
            this.gbInfoProducto.Text = "Info. Producto";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(154, 181);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(297, 21);
            this.cbCategoria.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(154, 122);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(297, 20);
            this.dtpFecha.TabIndex = 11;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(154, 72);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(297, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(154, 26);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(297, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 79);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 128);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(99, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha del Registro:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(6, 172);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 6;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblZapato
            // 
            this.lblZapato.AutoSize = true;
            this.lblZapato.Location = new System.Drawing.Point(6, 33);
            this.lblZapato.Name = "lblZapato";
            this.lblZapato.Size = new System.Drawing.Size(110, 13);
            this.lblZapato.TabIndex = 5;
            this.lblZapato.Text = "Nombre del Producto:";
            // 
            // tbActualizarroducto
            // 
            this.tbActualizarroducto.Controls.Add(this.dgvProductosActualizar);
            this.tbActualizarroducto.Controls.Add(this.btnActualizarActualizar);
            this.tbActualizarroducto.Controls.Add(this.lblBuscar);
            this.tbActualizarroducto.Controls.Add(this.btnBuscar);
            this.tbActualizarroducto.Controls.Add(this.txtBuscar);
            this.tbActualizarroducto.Controls.Add(this.gbInfoActualizar);
            this.tbActualizarroducto.Location = new System.Drawing.Point(4, 22);
            this.tbActualizarroducto.Name = "tbActualizarroducto";
            this.tbActualizarroducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbActualizarroducto.Size = new System.Drawing.Size(754, 400);
            this.tbActualizarroducto.TabIndex = 1;
            this.tbActualizarroducto.Text = "Actualizar Producto";
            this.tbActualizarroducto.UseVisualStyleBackColor = true;
            // 
            // dgvProductosActualizar
            // 
            this.dgvProductosActualizar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosActualizar.Location = new System.Drawing.Point(18, 257);
            this.dgvProductosActualizar.Name = "dgvProductosActualizar";
            this.dgvProductosActualizar.Size = new System.Drawing.Size(697, 137);
            this.dgvProductosActualizar.TabIndex = 14;
            // 
            // btnActualizarActualizar
            // 
            this.btnActualizarActualizar.Location = new System.Drawing.Point(595, 208);
            this.btnActualizarActualizar.Name = "btnActualizarActualizar";
            this.btnActualizarActualizar.Size = new System.Drawing.Size(82, 31);
            this.btnActualizarActualizar.TabIndex = 13;
            this.btnActualizarActualizar.Text = "Actualizar";
            this.btnActualizarActualizar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(554, 89);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 12;
            this.lblBuscar.Text = "Buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(642, 143);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 19);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(557, 105);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(158, 24);
            this.txtBuscar.TabIndex = 10;
            // 
            // gbInfoActualizar
            // 
            this.gbInfoActualizar.Controls.Add(this.cbCategoriaActualizar);
            this.gbInfoActualizar.Controls.Add(this.dtpFechaActualizar);
            this.gbInfoActualizar.Controls.Add(this.txtPrecioActualizar);
            this.gbInfoActualizar.Controls.Add(this.txtNombreProductoActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblPrecioActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblFechaActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblCategoriaActualizar);
            this.gbInfoActualizar.Controls.Add(this.lblZapatoActualizar);
            this.gbInfoActualizar.Location = new System.Drawing.Point(18, 20);
            this.gbInfoActualizar.Name = "gbInfoActualizar";
            this.gbInfoActualizar.Size = new System.Drawing.Size(512, 219);
            this.gbInfoActualizar.TabIndex = 8;
            this.gbInfoActualizar.TabStop = false;
            this.gbInfoActualizar.Text = "Info. Productos";
            // 
            // cbCategoriaActualizar
            // 
            this.cbCategoriaActualizar.FormattingEnabled = true;
            this.cbCategoriaActualizar.Location = new System.Drawing.Point(191, 181);
            this.cbCategoriaActualizar.Name = "cbCategoriaActualizar";
            this.cbCategoriaActualizar.Size = new System.Drawing.Size(297, 21);
            this.cbCategoriaActualizar.TabIndex = 12;
            // 
            // dtpFechaActualizar
            // 
            this.dtpFechaActualizar.Location = new System.Drawing.Point(191, 141);
            this.dtpFechaActualizar.Name = "dtpFechaActualizar";
            this.dtpFechaActualizar.Size = new System.Drawing.Size(297, 20);
            this.dtpFechaActualizar.TabIndex = 11;
            // 
            // txtPrecioActualizar
            // 
            this.txtPrecioActualizar.Location = new System.Drawing.Point(191, 85);
            this.txtPrecioActualizar.Name = "txtPrecioActualizar";
            this.txtPrecioActualizar.Size = new System.Drawing.Size(297, 20);
            this.txtPrecioActualizar.TabIndex = 10;
            // 
            // txtNombreProductoActualizar
            // 
            this.txtNombreProductoActualizar.Location = new System.Drawing.Point(191, 27);
            this.txtNombreProductoActualizar.Name = "txtNombreProductoActualizar";
            this.txtNombreProductoActualizar.Size = new System.Drawing.Size(297, 20);
            this.txtNombreProductoActualizar.TabIndex = 9;
            // 
            // lblPrecioActualizar
            // 
            this.lblPrecioActualizar.AutoSize = true;
            this.lblPrecioActualizar.Location = new System.Drawing.Point(17, 85);
            this.lblPrecioActualizar.Name = "lblPrecioActualizar";
            this.lblPrecioActualizar.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioActualizar.TabIndex = 8;
            this.lblPrecioActualizar.Text = "Precio:";
            // 
            // lblFechaActualizar
            // 
            this.lblFechaActualizar.AutoSize = true;
            this.lblFechaActualizar.Location = new System.Drawing.Point(17, 129);
            this.lblFechaActualizar.Name = "lblFechaActualizar";
            this.lblFechaActualizar.Size = new System.Drawing.Size(99, 13);
            this.lblFechaActualizar.TabIndex = 7;
            this.lblFechaActualizar.Text = "Fecha del Registro:";
            // 
            // lblCategoriaActualizar
            // 
            this.lblCategoriaActualizar.AutoSize = true;
            this.lblCategoriaActualizar.Location = new System.Drawing.Point(17, 184);
            this.lblCategoriaActualizar.Name = "lblCategoriaActualizar";
            this.lblCategoriaActualizar.Size = new System.Drawing.Size(55, 13);
            this.lblCategoriaActualizar.TabIndex = 6;
            this.lblCategoriaActualizar.Text = "Categoria:";
            // 
            // lblZapatoActualizar
            // 
            this.lblZapatoActualizar.AutoSize = true;
            this.lblZapatoActualizar.Location = new System.Drawing.Point(17, 34);
            this.lblZapatoActualizar.Name = "lblZapatoActualizar";
            this.lblZapatoActualizar.Size = new System.Drawing.Size(115, 13);
            this.lblZapatoActualizar.TabIndex = 5;
            this.lblZapatoActualizar.Text = "Nombre del Productos:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcRegistarProducto);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.tcRegistarProducto.ResumeLayout(false);
            this.tcAgregarProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.gbInfoProducto.ResumeLayout(false);
            this.gbInfoProducto.PerformLayout();
            this.tbActualizarroducto.ResumeLayout(false);
            this.tbActualizarroducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosActualizar)).EndInit();
            this.gbInfoActualizar.ResumeLayout(false);
            this.gbInfoActualizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcRegistarProducto;
        private System.Windows.Forms.TabPage tcAgregarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox gbInfoProducto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblZapato;
        private System.Windows.Forms.TabPage tbActualizarroducto;
        private System.Windows.Forms.GroupBox gbInfoActualizar;
        private System.Windows.Forms.ComboBox cbCategoriaActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaActualizar;
        private System.Windows.Forms.TextBox txtPrecioActualizar;
        private System.Windows.Forms.TextBox txtNombreProductoActualizar;
        private System.Windows.Forms.Label lblPrecioActualizar;
        private System.Windows.Forms.Label lblFechaActualizar;
        private System.Windows.Forms.Label lblCategoriaActualizar;
        private System.Windows.Forms.Label lblZapatoActualizar;
        private System.Windows.Forms.DataGridView dgvProductosActualizar;
        private System.Windows.Forms.Button btnActualizarActualizar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}