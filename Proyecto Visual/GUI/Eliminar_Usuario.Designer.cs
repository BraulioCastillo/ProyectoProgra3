namespace ProyectoFinal
{
    partial class Eliminar_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eliminar_Usuario));
            this.cmb_eliminiarusuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_actualizarusuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_eliminiarusuario
            // 
            this.cmb_eliminiarusuario.FormattingEnabled = true;
            this.cmb_eliminiarusuario.Location = new System.Drawing.Point(74, 35);
            this.cmb_eliminiarusuario.Name = "cmb_eliminiarusuario";
            this.cmb_eliminiarusuario.Size = new System.Drawing.Size(121, 21);
            this.cmb_eliminiarusuario.TabIndex = 0;
            this.cmb_eliminiarusuario.SelectedIndexChanged += new System.EventHandler(this.cmb_eliminiarusuario_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(53, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(359, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Eliminar Usuario";
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(376, 246);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 40);
            this.btn_salir.TabIndex = 21;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_actualizarusuario
            // 
            this.btn_actualizarusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizarusuario.BackgroundImage")));
            this.btn_actualizarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarusuario.ForeColor = System.Drawing.Color.White;
            this.btn_actualizarusuario.Location = new System.Drawing.Point(147, 193);
            this.btn_actualizarusuario.Name = "btn_actualizarusuario";
            this.btn_actualizarusuario.Size = new System.Drawing.Size(174, 40);
            this.btn_actualizarusuario.TabIndex = 22;
            this.btn_actualizarusuario.Text = "Eliminar Usuario";
            this.btn_actualizarusuario.UseVisualStyleBackColor = true;
            this.btn_actualizarusuario.Click += new System.EventHandler(this.btn_actualizarusuario_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_eliminiarusuario);
            this.groupBox1.Location = new System.Drawing.Point(100, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // Eliminar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 287);
            this.Controls.Add(this.btn_actualizarusuario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label9);
            this.Name = "Eliminar_Usuario";
            this.Text = "Eliminar_Usuario";
            this.Load += new System.EventHandler(this.Eliminar_Usuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_eliminiarusuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_actualizarusuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}