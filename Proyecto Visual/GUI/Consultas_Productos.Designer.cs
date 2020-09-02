namespace ProyectoFinal
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
            this.gbx_eliminar = new System.Windows.Forms.GroupBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txb_codigo_eliminar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbx_actualizar = new System.Windows.Forms.GroupBox();
            this.txb_actualizar = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.gbx_consultar = new System.Windows.Forms.GroupBox();
            this.txb_consulta_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.gbx_seleccionar = new System.Windows.Forms.GroupBox();
            this.rdb_eliminar = new System.Windows.Forms.RadioButton();
            this.rdb_actualizar = new System.Windows.Forms.RadioButton();
            this.rdb_insertar = new System.Windows.Forms.RadioButton();
            this.rdb_consultar = new System.Windows.Forms.RadioButton();
            this.gbx_insertarProducto = new System.Windows.Forms.GroupBox();
            this.txb_ingresar_info = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbx_eliminar.SuspendLayout();
            this.gbx_actualizar.SuspendLayout();
            this.gbx_consultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.gbx_seleccionar.SuspendLayout();
            this.gbx_insertarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresar_productos
            // 
            this.btn_regresar_productos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_regresar_productos.BackgroundImage")));
            this.btn_regresar_productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_regresar_productos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar_productos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_regresar_productos.Location = new System.Drawing.Point(661, 496);
            this.btn_regresar_productos.Name = "btn_regresar_productos";
            this.btn_regresar_productos.Size = new System.Drawing.Size(122, 67);
            this.btn_regresar_productos.TabIndex = 12;
            this.btn_regresar_productos.Text = "Regresar";
            this.btn_regresar_productos.UseVisualStyleBackColor = true;
            // 
            // gbx_eliminar
            // 
            this.gbx_eliminar.Controls.Add(this.btn_eliminar);
            this.gbx_eliminar.Controls.Add(this.txb_codigo_eliminar);
            this.gbx_eliminar.Controls.Add(this.label6);
            this.gbx_eliminar.Location = new System.Drawing.Point(44, 478);
            this.gbx_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_eliminar.Name = "gbx_eliminar";
            this.gbx_eliminar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_eliminar.Size = new System.Drawing.Size(574, 94);
            this.gbx_eliminar.TabIndex = 10;
            this.gbx_eliminar.TabStop = false;
            this.gbx_eliminar.Text = "Eliminar Producto";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_eliminar.Location = new System.Drawing.Point(352, 34);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(132, 51);
            this.btn_eliminar.TabIndex = 8;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // txb_codigo_eliminar
            // 
            this.txb_codigo_eliminar.Location = new System.Drawing.Point(38, 60);
            this.txb_codigo_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txb_codigo_eliminar.Name = "txb_codigo_eliminar";
            this.txb_codigo_eliminar.Size = new System.Drawing.Size(206, 20);
            this.txb_codigo_eliminar.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Digite el Código de Producto";
            // 
            // gbx_actualizar
            // 
            this.gbx_actualizar.Controls.Add(this.txb_actualizar);
            this.gbx_actualizar.Controls.Add(this.btn_actualizar);
            this.gbx_actualizar.Location = new System.Drawing.Point(431, 185);
            this.gbx_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_actualizar.Name = "gbx_actualizar";
            this.gbx_actualizar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_actualizar.Size = new System.Drawing.Size(352, 114);
            this.gbx_actualizar.TabIndex = 9;
            this.gbx_actualizar.TabStop = false;
            this.gbx_actualizar.Text = "Actualizar Producto";
            // 
            // txb_actualizar
            // 
            this.txb_actualizar.Location = new System.Drawing.Point(170, 34);
            this.txb_actualizar.Multiline = true;
            this.txb_actualizar.Name = "txb_actualizar";
            this.txb_actualizar.Size = new System.Drawing.Size(175, 60);
            this.txb_actualizar.TabIndex = 10;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_actualizar.Location = new System.Drawing.Point(8, 34);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(143, 59);
            this.btn_actualizar.TabIndex = 5;
            this.btn_actualizar.Text = "Ir a la Ventana Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // gbx_consultar
            // 
            this.gbx_consultar.Controls.Add(this.txb_consulta_id);
            this.gbx_consultar.Controls.Add(this.pictureBox1);
            this.gbx_consultar.Controls.Add(this.dgv_productos);
            this.gbx_consultar.Controls.Add(this.btn_consultar);
            this.gbx_consultar.Location = new System.Drawing.Point(44, 316);
            this.gbx_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Name = "gbx_consultar";
            this.gbx_consultar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_consultar.Size = new System.Drawing.Size(740, 141);
            this.gbx_consultar.TabIndex = 8;
            this.gbx_consultar.TabStop = false;
            this.gbx_consultar.Text = "Consultar Productos";
            // 
            // txb_consulta_id
            // 
            this.txb_consulta_id.Location = new System.Drawing.Point(8, 84);
            this.txb_consulta_id.Margin = new System.Windows.Forms.Padding(4);
            this.txb_consulta_id.Name = "txb_consulta_id";
            this.txb_consulta_id.Size = new System.Drawing.Size(124, 20);
            this.txb_consulta_id.TabIndex = 9;
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
            this.btn_consultar.Location = new System.Drawing.Point(8, 23);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(124, 43);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar Por Código";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // gbx_seleccionar
            // 
            this.gbx_seleccionar.Controls.Add(this.rdb_eliminar);
            this.gbx_seleccionar.Controls.Add(this.rdb_actualizar);
            this.gbx_seleccionar.Controls.Add(this.rdb_insertar);
            this.gbx_seleccionar.Controls.Add(this.rdb_consultar);
            this.gbx_seleccionar.Location = new System.Drawing.Point(44, 69);
            this.gbx_seleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_seleccionar.Name = "gbx_seleccionar";
            this.gbx_seleccionar.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_seleccionar.Size = new System.Drawing.Size(739, 91);
            this.gbx_seleccionar.TabIndex = 11;
            this.gbx_seleccionar.TabStop = false;
            this.gbx_seleccionar.Text = "Seleccionar Opción";
            // 
            // rdb_eliminar
            // 
            this.rdb_eliminar.AutoSize = true;
            this.rdb_eliminar.Location = new System.Drawing.Point(562, 41);
            this.rdb_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_eliminar.Name = "rdb_eliminar";
            this.rdb_eliminar.Size = new System.Drawing.Size(107, 17);
            this.rdb_eliminar.TabIndex = 3;
            this.rdb_eliminar.TabStop = true;
            this.rdb_eliminar.Text = "Eliminar Producto";
            this.rdb_eliminar.UseVisualStyleBackColor = true;
            // 
            // rdb_actualizar
            // 
            this.rdb_actualizar.AutoSize = true;
            this.rdb_actualizar.Location = new System.Drawing.Point(389, 41);
            this.rdb_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_actualizar.Name = "rdb_actualizar";
            this.rdb_actualizar.Size = new System.Drawing.Size(120, 17);
            this.rdb_actualizar.TabIndex = 4;
            this.rdb_actualizar.TabStop = true;
            this.rdb_actualizar.Text = "Actualizar Productor";
            this.rdb_actualizar.UseVisualStyleBackColor = true;
            // 
            // rdb_insertar
            // 
            this.rdb_insertar.AutoSize = true;
            this.rdb_insertar.Location = new System.Drawing.Point(8, 41);
            this.rdb_insertar.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_insertar.Name = "rdb_insertar";
            this.rdb_insertar.Size = new System.Drawing.Size(141, 17);
            this.rdb_insertar.TabIndex = 1;
            this.rdb_insertar.TabStop = true;
            this.rdb_insertar.Text = "Insertar Producto Nuevo";
            this.rdb_insertar.UseVisualStyleBackColor = true;
            // 
            // rdb_consultar
            // 
            this.rdb_consultar.AutoSize = true;
            this.rdb_consultar.Location = new System.Drawing.Point(222, 41);
            this.rdb_consultar.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_consultar.Name = "rdb_consultar";
            this.rdb_consultar.Size = new System.Drawing.Size(115, 17);
            this.rdb_consultar.TabIndex = 2;
            this.rdb_consultar.TabStop = true;
            this.rdb_consultar.Text = "Consultar Producto";
            this.rdb_consultar.UseVisualStyleBackColor = true;
            // 
            // gbx_insertarProducto
            // 
            this.gbx_insertarProducto.Controls.Add(this.txb_ingresar_info);
            this.gbx_insertarProducto.Controls.Add(this.btn_ingresar);
            this.gbx_insertarProducto.Location = new System.Drawing.Point(44, 182);
            this.gbx_insertarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_insertarProducto.Name = "gbx_insertarProducto";
            this.gbx_insertarProducto.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_insertarProducto.Size = new System.Drawing.Size(379, 117);
            this.gbx_insertarProducto.TabIndex = 7;
            this.gbx_insertarProducto.TabStop = false;
            this.gbx_insertarProducto.Text = "Insertar Nuevo Producto";
            // 
            // txb_ingresar_info
            // 
            this.txb_ingresar_info.Location = new System.Drawing.Point(184, 37);
            this.txb_ingresar_info.Multiline = true;
            this.txb_ingresar_info.Name = "txb_ingresar_info";
            this.txb_ingresar_info.Size = new System.Drawing.Size(175, 60);
            this.txb_ingresar_info.TabIndex = 9;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.BackgroundImage")));
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ingresar.Location = new System.Drawing.Point(8, 37);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(167, 60);
            this.btn_ingresar.TabIndex = 8;
            this.btn_ingresar.Text = "Ir a Ventana para Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Consultas Productos";
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(728, 585);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 40);
            this.btncancelar.TabIndex = 14;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Consultas_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 628);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar_productos);
            this.Controls.Add(this.gbx_eliminar);
            this.Controls.Add(this.gbx_actualizar);
            this.Controls.Add(this.gbx_consultar);
            this.Controls.Add(this.gbx_seleccionar);
            this.Controls.Add(this.gbx_insertarProducto);
            this.Name = "Consultas_Productos";
            this.Text = "Consultas Productos";
            this.gbx_eliminar.ResumeLayout(false);
            this.gbx_eliminar.PerformLayout();
            this.gbx_actualizar.ResumeLayout(false);
            this.gbx_actualizar.PerformLayout();
            this.gbx_consultar.ResumeLayout(false);
            this.gbx_consultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.gbx_seleccionar.ResumeLayout(false);
            this.gbx_seleccionar.PerformLayout();
            this.gbx_insertarProducto.ResumeLayout(false);
            this.gbx_insertarProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar_productos;
        private System.Windows.Forms.GroupBox gbx_eliminar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txb_codigo_eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbx_actualizar;
        private System.Windows.Forms.TextBox txb_actualizar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.GroupBox gbx_consultar;
        private System.Windows.Forms.TextBox txb_consulta_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.GroupBox gbx_seleccionar;
        private System.Windows.Forms.RadioButton rdb_eliminar;
        private System.Windows.Forms.RadioButton rdb_actualizar;
        private System.Windows.Forms.RadioButton rdb_insertar;
        private System.Windows.Forms.RadioButton rdb_consultar;
        private System.Windows.Forms.GroupBox gbx_insertarProducto;
        private System.Windows.Forms.TextBox txb_ingresar_info;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancelar;
    }
}