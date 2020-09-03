namespace ProyectoFinal
{
    partial class Consultar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Usuario));
            this.btn_salir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_consultararusuario = new System.Windows.Forms.Button();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(192, 214);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 40);
            this.btn_salir.TabIndex = 26;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 28);
            this.label9.TabIndex = 27;
            this.label9.Text = "Consultar Usuario";
            // 
            // btn_consultararusuario
            // 
            this.btn_consultararusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_consultararusuario.BackgroundImage")));
            this.btn_consultararusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_consultararusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultararusuario.ForeColor = System.Drawing.Color.White;
            this.btn_consultararusuario.Location = new System.Drawing.Point(160, 168);
            this.btn_consultararusuario.Name = "btn_consultararusuario";
            this.btn_consultararusuario.Size = new System.Drawing.Size(174, 40);
            this.btn_consultararusuario.TabIndex = 28;
            this.btn_consultararusuario.Text = "Consultar Usuario";
            this.btn_consultararusuario.UseVisualStyleBackColor = true;
            this.btn_consultararusuario.Click += new System.EventHandler(this.btn_consultararusuario_Click);
            // 
            // dgv_productos
            // 
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(13, 56);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(493, 105);
            this.dgv_productos.TabIndex = 29;
            // 
            // Consultar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 266);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.btn_consultararusuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_salir);
            this.Name = "Consultar_Usuario";
            this.Text = "Consultar_Usuario";
            this.Load += new System.EventHandler(this.Consultar_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_consultararusuario;
        private System.Windows.Forms.DataGridView dgv_productos;
    }
}