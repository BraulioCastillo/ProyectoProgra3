﻿namespace ProyectoFinal
{
    partial class Carrito_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito_compras));
            this.gbx_consultar = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmb_consultaId = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProcesarFactura = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.principalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbx_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_consultar
            // 
            this.gbx_consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_consultar.BackgroundImage")));
            this.gbx_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_consultar.Controls.Add(this.label7);
            this.gbx_consultar.Controls.Add(this.pictureBox1);
            this.gbx_consultar.Controls.Add(this.txtDetalle);
            this.gbx_consultar.Controls.Add(this.txtExistencias);
            this.gbx_consultar.Controls.Add(this.txtPrecio);
            this.gbx_consultar.Controls.Add(this.label5);
            this.gbx_consultar.Controls.Add(this.label4);
            this.gbx_consultar.Controls.Add(this.label3);
            this.gbx_consultar.Controls.Add(this.label1);
            this.gbx_consultar.Controls.Add(this.nudCantidad);
            this.gbx_consultar.Controls.Add(this.btnAgregar);
            this.gbx_consultar.Controls.Add(this.cmb_consultaId);
            this.gbx_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_consultar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbx_consultar.Location = new System.Drawing.Point(13, 107);
            this.gbx_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Name = "gbx_consultar";
            this.gbx_consultar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Size = new System.Drawing.Size(915, 158);
            this.gbx_consultar.TabIndex = 9;
            this.gbx_consultar.TabStop = false;
            this.gbx_consultar.Text = "Consultar Productos";
            this.gbx_consultar.Enter += new System.EventHandler(this.gbx_consultar_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cantidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(562, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 108);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(313, 28);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(243, 106);
            this.txtDetalle.TabIndex = 26;
            // 
            // txtExistencias
            // 
            this.txtExistencias.Enabled = false;
            this.txtExistencias.Location = new System.Drawing.Point(112, 93);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(121, 26);
            this.txtExistencias.TabIndex = 25;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(112, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 26);
            this.txtPrecio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Existencias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Detalle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(781, 58);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(116, 26);
            this.nudCantidad.TabIndex = 14;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(781, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 55);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar al carrito";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmb_consultaId
            // 
            this.cmb_consultaId.FormattingEnabled = true;
            this.cmb_consultaId.Location = new System.Drawing.Point(112, 26);
            this.cmb_consultaId.Name = "cmb_consultaId";
            this.cmb_consultaId.Size = new System.Drawing.Size(121, 28);
            this.cmb_consultaId.TabIndex = 12;
            this.cmb_consultaId.SelectedIndexChanged += new System.EventHandler(this.cmb_consultaId_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 261);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(791, 283);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(52, 20);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total: ";
            // 
            // btnProcesarFactura
            // 
            this.btnProcesarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProcesarFactura.BackgroundImage")));
            this.btnProcesarFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcesarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarFactura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcesarFactura.Location = new System.Drawing.Point(795, 331);
            this.btnProcesarFactura.Name = "btnProcesarFactura";
            this.btnProcesarFactura.Size = new System.Drawing.Size(116, 62);
            this.btnProcesarFactura.TabIndex = 12;
            this.btnProcesarFactura.Text = "Procesar factura";
            this.btnProcesarFactura.UseVisualStyleBackColor = true;
            this.btnProcesarFactura.Click += new System.EventHandler(this.btnProcesarFactura_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(587, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(315, 24);
            this.dtpFecha.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "msMenu";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(156, 25);
            this.consultarProductoToolStripMenuItem.Text = "Consultar producto";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalir.Location = new System.Drawing.Point(801, 487);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 41);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // principalToolStripMenuItem1
            // 
            this.principalToolStripMenuItem1.Name = "principalToolStripMenuItem1";
            this.principalToolStripMenuItem1.Size = new System.Drawing.Size(82, 25);
            this.principalToolStripMenuItem1.Text = "Principal";
            // 
            // consultarProductoToolStripMenuItem1
            // 
            this.consultarProductoToolStripMenuItem1.Name = "consultarProductoToolStripMenuItem1";
            this.consultarProductoToolStripMenuItem1.Size = new System.Drawing.Size(156, 25);
            this.consultarProductoToolStripMenuItem1.Text = "Consultar producto";
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Location = new System.Drawing.Point(21, 34);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(84, 24);
            this.rbtnEfectivo.TabIndex = 16;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.rbtnTarjeta);
            this.groupBox1.Controls.Add(this.rbtnEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 77);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método de pago";
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Location = new System.Drawing.Point(146, 34);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(76, 24);
            this.rbtnTarjeta.TabIndex = 17;
            this.rbtnTarjeta.TabStop = true;
            this.rbtnTarjeta.Text = "Tarjeta";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID";
            // 
            // txb_ID
            // 
            this.txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ID.Location = new System.Drawing.Point(326, 34);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(100, 26);
            this.txb_ID.TabIndex = 19;
            this.txb_ID.TextChanged += new System.EventHandler(this.txb_ID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(592, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "lblFactura";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Carrito_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 540);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnProcesarFactura);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbx_consultar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Carrito_compras";
            this.Text = "Carrito_compras";
            this.Load += new System.EventHandler(this.Carrito_compras_Load);
            this.gbx_consultar.ResumeLayout(false);
            this.gbx_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_consultar;
        private System.Windows.Forms.ComboBox cmb_consultaId;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProcesarFactura;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem1;
        private System.Windows.Forms.RadioButton rbtnEfectivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}