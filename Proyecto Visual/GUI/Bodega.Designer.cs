﻿namespace ProyectoFinal
{
    partial class Bodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bodega));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregararticulos = new System.Windows.Forms.Button();
            this.btn_consultarproductos = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btn_ingresararticulos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Menú Bodega";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_agregararticulos
            // 
            this.btn_agregararticulos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_agregararticulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregararticulos.BackgroundImage")));
            this.btn_agregararticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregararticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregararticulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregararticulos.Location = new System.Drawing.Point(194, 19);
            this.btn_agregararticulos.Name = "btn_agregararticulos";
            this.btn_agregararticulos.Size = new System.Drawing.Size(141, 54);
            this.btn_agregararticulos.TabIndex = 15;
            this.btn_agregararticulos.Text = "Actualizar Articulos";
            this.btn_agregararticulos.UseVisualStyleBackColor = false;
            this.btn_agregararticulos.Click += new System.EventHandler(this.btn_agregarnuevasede_Click);
            // 
            // btn_consultarproductos
            // 
            this.btn_consultarproductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consultarproductos.BackgroundImage")));
            this.btn_consultarproductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultarproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarproductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarproductos.Location = new System.Drawing.Point(17, 19);
            this.btn_consultarproductos.Name = "btn_consultarproductos";
            this.btn_consultarproductos.Size = new System.Drawing.Size(171, 54);
            this.btn_consultarproductos.TabIndex = 14;
            this.btn_consultarproductos.Text = "Consultar / Eliminar Productos";
            this.btn_consultarproductos.UseVisualStyleBackColor = true;
            this.btn_consultarproductos.Click += new System.EventHandler(this.btn_agregarsupermercado_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(504, 212);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 40);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btn_ingresararticulos
            // 
            this.btn_ingresararticulos.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ingresararticulos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingresararticulos.BackgroundImage")));
            this.btn_ingresararticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ingresararticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresararticulos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresararticulos.Location = new System.Drawing.Point(341, 19);
            this.btn_ingresararticulos.Name = "btn_ingresararticulos";
            this.btn_ingresararticulos.Size = new System.Drawing.Size(141, 54);
            this.btn_ingresararticulos.TabIndex = 20;
            this.btn_ingresararticulos.Text = "Ingresar Articulos";
            this.btn_ingresararticulos.UseVisualStyleBackColor = false;
            this.btn_ingresararticulos.Click += new System.EventHandler(this.btn_ingresararticulos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btn_consultarproductos);
            this.groupBox1.Controls.Add(this.btn_ingresararticulos);
            this.groupBox1.Controls.Add(this.btn_agregararticulos);
            this.groupBox1.Location = new System.Drawing.Point(49, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 94);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(610, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bodega";
            this.Text = "Bodega";
            this.Load += new System.EventHandler(this.Bodega_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregararticulos;
        private System.Windows.Forms.Button btn_consultarproductos;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btn_ingresararticulos;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}