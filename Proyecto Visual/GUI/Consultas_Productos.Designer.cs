﻿namespace ProyectoFinal
{
    partial class Consultas_Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_Productos));
            this.btn_regresar_productos = new System.Windows.Forms.Button();
            this.gbx_consultar = new System.Windows.Forms.GroupBox();
            this.cmb_consultaId = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbx_eliminar = new System.Windows.Forms.GroupBox();
            this.cmb_consultaId2 = new System.Windows.Forms.ComboBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbx_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.gbx_eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar_productos
            // 
            this.btn_regresar_productos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_regresar_productos.BackgroundImage")));
            this.btn_regresar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar_productos.Location = new System.Drawing.Point(666, 251);
            this.btn_regresar_productos.Name = "btn_regresar_productos";
            this.btn_regresar_productos.Size = new System.Drawing.Size(122, 50);
            this.btn_regresar_productos.TabIndex = 12;
            this.btn_regresar_productos.Text = "Regresar";
            this.btn_regresar_productos.UseVisualStyleBackColor = true;
            // 
            // gbx_consultar
            // 
            this.gbx_consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_consultar.BackgroundImage")));
            this.gbx_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_consultar.Controls.Add(this.cmb_consultaId);
            this.gbx_consultar.Controls.Add(this.pictureBox1);
            this.gbx_consultar.Controls.Add(this.dgv_productos);
            this.gbx_consultar.Controls.Add(this.btn_consultar);
            this.gbx_consultar.Location = new System.Drawing.Point(49, 68);
            this.gbx_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Name = "gbx_consultar";
            this.gbx_consultar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Size = new System.Drawing.Size(740, 141);
            this.gbx_consultar.TabIndex = 8;
            this.gbx_consultar.TabStop = false;
            this.gbx_consultar.Text = "Consultar Productos";
            // 
            // cmb_consultaId
            // 
            this.cmb_consultaId.FormattingEnabled = true;
            this.cmb_consultaId.Location = new System.Drawing.Point(12, 85);
            this.cmb_consultaId.Name = "cmb_consultaId";
            this.cmb_consultaId.Size = new System.Drawing.Size(121, 21);
            this.cmb_consultaId.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 106);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(140, 23);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(374, 105);
            this.dgv_productos.TabIndex = 10;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consultar.BackgroundImage")));
            this.btn_consultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(8, 23);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 55);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar Por Código";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultas Productos";
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(666, 307);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(122, 50);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gbx_eliminar
            // 
            this.gbx_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_eliminar.BackgroundImage")));
            this.gbx_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_eliminar.Controls.Add(this.cmb_consultaId2);
            this.gbx_eliminar.Controls.Add(this.btn_eliminar);
            this.gbx_eliminar.Controls.Add(this.label6);
            this.gbx_eliminar.Location = new System.Drawing.Point(49, 217);
            this.gbx_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_eliminar.Name = "gbx_eliminar";
            this.gbx_eliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_eliminar.Size = new System.Drawing.Size(574, 94);
            this.gbx_eliminar.TabIndex = 15;
            this.gbx_eliminar.TabStop = false;
            this.gbx_eliminar.Text = "Eliminar Producto";
            // 
            // cmb_consultaId2
            // 
            this.cmb_consultaId2.FormattingEnabled = true;
            this.cmb_consultaId2.Location = new System.Drawing.Point(57, 50);
            this.cmb_consultaId2.Name = "cmb_consultaId2";
            this.cmb_consultaId2.Size = new System.Drawing.Size(139, 21);
            this.cmb_consultaId2.TabIndex = 13;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Location = new System.Drawing.Point(345, 31);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(136, 41);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(33, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Digite el Código de Producto";
            // 
            // Consultas_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 369);
            this.Controls.Add(this.gbx_eliminar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar_productos);
            this.Controls.Add(this.gbx_consultar);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas_Productos";
            this.Text = "Consultas Productos";
            this.Load += new System.EventHandler(this.Consultas_Productos_Load);
            this.gbx_consultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.gbx_eliminar.ResumeLayout(false);
            this.gbx_eliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_productos;
        private System.Windows.Forms.GroupBox gbx_consultar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox gbx_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_consultaId;
        private System.Windows.Forms.ComboBox cmb_consultaId2;
    }
}