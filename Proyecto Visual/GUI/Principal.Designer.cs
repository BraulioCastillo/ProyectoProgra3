namespace WindowsFormsApp1
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label1 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsede = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.btnbodega = new System.Windows.Forms.Button();
            this.btnusuarios = new System.Windows.Forms.Button();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(145, 52);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(93, 25);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "Nombre";
            this.lblnombre.Click += new System.EventHandler(this.lblnombre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Roll:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(145, 125);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(33, 25);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "...";
            this.lblCargo.Click += new System.EventHandler(this.lblCargo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha:";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(145, 160);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(33, 25);
            this.lblhora.TabIndex = 7;
            this.lblhora.Text = "...";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(145, 195);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(33, 25);
            this.lblfecha.TabIndex = 8;
            this.lblfecha.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(645, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 208);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnsede
            // 
            this.btnsede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsede.BackgroundImage")));
            this.btnsede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsede.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsede.Location = new System.Drawing.Point(311, 19);
            this.btnsede.Name = "btnsede";
            this.btnsede.Size = new System.Drawing.Size(213, 62);
            this.btnsede.TabIndex = 14;
            this.btnsede.Text = "Supermercado";
            this.btnsede.UseVisualStyleBackColor = false;
            this.btnsede.Click += new System.EventHandler(this.btnsede_Click);
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.Transparent;
            this.btnventas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnventas.BackgroundImage")));
            this.btnventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnventas.Location = new System.Drawing.Point(32, 19);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(127, 62);
            this.btnventas.TabIndex = 15;
            this.btnventas.Text = "Ventas";
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click_1);
            // 
            // btncompras
            // 
            this.btncompras.BackColor = System.Drawing.Color.Yellow;
            this.btncompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncompras.BackgroundImage")));
            this.btncompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncompras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncompras.Location = new System.Drawing.Point(165, 19);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(140, 62);
            this.btncompras.TabIndex = 16;
            this.btncompras.Text = "Compras";
            this.btncompras.UseVisualStyleBackColor = false;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // btnbodega
            // 
            this.btnbodega.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnbodega.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnbodega.BackgroundImage")));
            this.btnbodega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnbodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbodega.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbodega.Location = new System.Drawing.Point(530, 19);
            this.btnbodega.Name = "btnbodega";
            this.btnbodega.Size = new System.Drawing.Size(131, 62);
            this.btnbodega.TabIndex = 17;
            this.btnbodega.Text = "Bodega";
            this.btnbodega.UseVisualStyleBackColor = false;
            this.btnbodega.Click += new System.EventHandler(this.btnbodega_Click);
            // 
            // btnusuarios
            // 
            this.btnusuarios.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnusuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnusuarios.BackgroundImage")));
            this.btnusuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnusuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnusuarios.Location = new System.Drawing.Point(667, 19);
            this.btnusuarios.Name = "btnusuarios";
            this.btnusuarios.Size = new System.Drawing.Size(145, 62);
            this.btnusuarios.TabIndex = 18;
            this.btnusuarios.Text = "Usuarios";
            this.btnusuarios.UseVisualStyleBackColor = false;
            this.btnusuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellidos.Location = new System.Drawing.Point(145, 89);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(109, 25);
            this.lbl_apellidos.TabIndex = 20;
            this.lbl_apellidos.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Apellidos:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnventas);
            this.groupBox1.Controls.Add(this.btncompras);
            this.groupBox1.Controls.Add(this.btnsede);
            this.groupBox1.Controls.Add(this.btnusuarios);
            this.groupBox1.Controls.Add(this.btnbodega);
            this.groupBox1.Location = new System.Drawing.Point(12, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(867, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_apellidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsede;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnbodega;
        private System.Windows.Forms.Button btnusuarios;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}