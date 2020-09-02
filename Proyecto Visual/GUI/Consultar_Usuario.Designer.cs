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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_consultarusuario = new System.Windows.Forms.ComboBox();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_consultararusuario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_consultarusuario);
            this.groupBox1.Location = new System.Drawing.Point(106, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID:";
            // 
            // cmb_consultarusuario
            // 
            this.cmb_consultarusuario.FormattingEnabled = true;
            this.cmb_consultarusuario.Location = new System.Drawing.Point(74, 35);
            this.cmb_consultarusuario.Name = "cmb_consultarusuario";
            this.cmb_consultarusuario.Size = new System.Drawing.Size(121, 21);
            this.cmb_consultarusuario.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(391, 252);
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
            this.btn_consultararusuario.Location = new System.Drawing.Point(153, 205);
            this.btn_consultararusuario.Name = "btn_consultararusuario";
            this.btn_consultararusuario.Size = new System.Drawing.Size(174, 40);
            this.btn_consultararusuario.TabIndex = 28;
            this.btn_consultararusuario.Text = "Consultar Usuario";
            this.btn_consultararusuario.UseVisualStyleBackColor = true;
            // 
            // Consultar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(490, 291);
            this.Controls.Add(this.btn_consultararusuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.groupBox1);
            this.Name = "Consultar_Usuario";
            this.Text = "Consultar_Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_consultarusuario;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_consultararusuario;
    }
}