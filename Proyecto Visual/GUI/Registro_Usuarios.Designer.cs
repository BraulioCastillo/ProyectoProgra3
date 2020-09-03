namespace ProyectoFinal
{
    partial class Registro_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Usuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_registrarusuario = new System.Windows.Forms.Button();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_contraseña = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellidos = new System.Windows.Forms.TextBox();
            this.txb_telefono = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_rol = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salir.BackgroundImage")));
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(411, 357);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 40);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btn_registrarusuario
            // 
            this.btn_registrarusuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrarusuario.BackgroundImage")));
            this.btn_registrarusuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarusuario.ForeColor = System.Drawing.Color.White;
            this.btn_registrarusuario.Location = new System.Drawing.Point(170, 325);
            this.btn_registrarusuario.Name = "btn_registrarusuario";
            this.btn_registrarusuario.Size = new System.Drawing.Size(174, 40);
            this.btn_registrarusuario.TabIndex = 8;
            this.btn_registrarusuario.Text = "Registrar Usuario";
            this.btn_registrarusuario.UseVisualStyleBackColor = true;
            this.btn_registrarusuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(100, 19);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(142, 20);
            this.txb_id.TabIndex = 9;
            // 
            // txb_contraseña
            // 
            this.txb_contraseña.Location = new System.Drawing.Point(100, 45);
            this.txb_contraseña.Name = "txb_contraseña";
            this.txb_contraseña.Size = new System.Drawing.Size(142, 20);
            this.txb_contraseña.TabIndex = 10;
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(100, 72);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(142, 20);
            this.txb_nombre.TabIndex = 11;
            // 
            // txb_apellidos
            // 
            this.txb_apellidos.Location = new System.Drawing.Point(100, 98);
            this.txb_apellidos.Name = "txb_apellidos";
            this.txb_apellidos.Size = new System.Drawing.Size(142, 20);
            this.txb_apellidos.TabIndex = 12;
            // 
            // txb_telefono
            // 
            this.txb_telefono.Location = new System.Drawing.Point(100, 124);
            this.txb_telefono.Name = "txb_telefono";
            this.txb_telefono.Size = new System.Drawing.Size(142, 20);
            this.txb_telefono.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txb_rol);
            this.groupBox1.Controls.Add(this.txb_direccion);
            this.groupBox1.Controls.Add(this.txb_email);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txb_telefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txb_apellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_nombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txb_contraseña);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_id);
            this.groupBox1.Location = new System.Drawing.Point(124, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 246);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rol:";
            // 
            // txb_rol
            // 
            this.txb_rol.Location = new System.Drawing.Point(100, 203);
            this.txb_rol.Name = "txb_rol";
            this.txb_rol.Size = new System.Drawing.Size(142, 20);
            this.txb_rol.TabIndex = 18;
            // 
            // txb_direccion
            // 
            this.txb_direccion.Location = new System.Drawing.Point(100, 177);
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(142, 20);
            this.txb_direccion.TabIndex = 17;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(100, 150);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(142, 20);
            this.txb_email.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Wide Latin", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(386, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Registrar Usuarios";
            // 
            // Registro_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 399);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_registrarusuario);
            this.Controls.Add(this.btn_salir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro_Usuarios";
            this.Text = "Registro Usuarios";
            this.Load += new System.EventHandler(this.Registro_Usuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_registrarusuario;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.TextBox txb_contraseña;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellidos;
        private System.Windows.Forms.TextBox txb_telefono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_rol;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}