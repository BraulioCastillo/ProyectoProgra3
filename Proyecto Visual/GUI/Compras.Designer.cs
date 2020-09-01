namespace ProyectoFinal
{
    partial class Compras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_carrito = new System.Windows.Forms.DataGridView();
            this.gbx_consultar = new System.Windows.Forms.GroupBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.nup_cantidad = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_consulta_id = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrito)).BeginInit();
            this.gbx_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_carrito);
            this.groupBox1.Location = new System.Drawing.Point(30, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carrito";
            // 
            // dgv_carrito
            // 
            this.dgv_carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_carrito.Location = new System.Drawing.Point(8, 20);
            this.dgv_carrito.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_carrito.Name = "dgv_carrito";
            this.dgv_carrito.Size = new System.Drawing.Size(725, 195);
            this.dgv_carrito.TabIndex = 12;
            // 
            // gbx_consultar
            // 
            this.gbx_consultar.Controls.Add(this.Cantidad);
            this.gbx_consultar.Controls.Add(this.nup_cantidad);
            this.gbx_consultar.Controls.Add(this.button1);
            this.gbx_consultar.Controls.Add(this.txb_consulta_id);
            this.gbx_consultar.Controls.Add(this.dgv_productos);
            this.gbx_consultar.Controls.Add(this.pictureBox1);
            this.gbx_consultar.Controls.Add(this.btn_consultar);
            this.gbx_consultar.Location = new System.Drawing.Point(30, 15);
            this.gbx_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Name = "gbx_consultar";
            this.gbx_consultar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Size = new System.Drawing.Size(740, 192);
            this.gbx_consultar.TabIndex = 4;
            this.gbx_consultar.TabStop = false;
            this.gbx_consultar.Text = "Consultar Productos";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(7, 115);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(49, 13);
            this.Cantidad.TabIndex = 14;
            this.Cantidad.Text = "Cantidad";
            // 
            // nup_cantidad
            // 
            this.nup_cantidad.Location = new System.Drawing.Point(68, 113);
            this.nup_cantidad.Name = "nup_cantidad";
            this.nup_cantidad.Size = new System.Drawing.Size(64, 20);
            this.nup_cantidad.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar al Carrito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_consulta_id
            // 
            this.txb_consulta_id.Location = new System.Drawing.Point(8, 84);
            this.txb_consulta_id.Margin = new System.Windows.Forms.Padding(4);
            this.txb_consulta_id.Name = "txb_consulta_id";
            this.txb_consulta_id.Size = new System.Drawing.Size(124, 20);
            this.txb_consulta_id.TabIndex = 9;
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(140, 23);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(397, 105);
            this.dgv_productos.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 106);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(8, 23);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 43);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar Por Código";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_consultar);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_carrito)).EndInit();
            this.gbx_consultar.ResumeLayout(false);
            this.gbx_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_carrito;
        private System.Windows.Forms.GroupBox gbx_consultar;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.NumericUpDown nup_cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_consulta_id;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_consultar;
    }
}