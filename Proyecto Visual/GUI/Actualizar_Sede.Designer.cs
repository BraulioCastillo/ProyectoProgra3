namespace ProyectoFinal
{
    partial class Actualizar_Sede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Sede));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_acutualizarsede = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_idSede = new System.Windows.Forms.TextBox();
            this.txb_idEncargado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_localidadsede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_idSede = new System.Windows.Forms.ComboBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(201, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Sede";
            // 
            // btn_acutualizarsede
            // 
            this.btn_acutualizarsede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_acutualizarsede.BackgroundImage")));
            this.btn_acutualizarsede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_acutualizarsede.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_acutualizarsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acutualizarsede.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_acutualizarsede.Location = new System.Drawing.Point(271, 321);
            this.btn_acutualizarsede.Name = "btn_acutualizarsede";
            this.btn_acutualizarsede.Size = new System.Drawing.Size(143, 33);
            this.btn_acutualizarsede.TabIndex = 7;
            this.btn_acutualizarsede.Text = "Actualizar";
            this.btn_acutualizarsede.UseVisualStyleBackColor = true;
            this.btn_acutualizarsede.Click += new System.EventHandler(this.btn_acutualizarsede_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txb_idSede);
            this.groupBox1.Controls.Add(this.txb_idEncargado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_localidadsede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_idSede);
            this.groupBox1.Location = new System.Drawing.Point(69, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // txb_idSede
            // 
            this.txb_idSede.Enabled = false;
            this.txb_idSede.Location = new System.Drawing.Point(248, 164);
            this.txb_idSede.Name = "txb_idSede";
            this.txb_idSede.Size = new System.Drawing.Size(140, 20);
            this.txb_idSede.TabIndex = 12;
            // 
            // txb_idEncargado
            // 
            this.txb_idEncargado.Enabled = false;
            this.txb_idEncargado.Location = new System.Drawing.Point(248, 124);
            this.txb_idEncargado.Name = "txb_idEncargado";
            this.txb_idEncargado.Size = new System.Drawing.Size(140, 20);
            this.txb_idEncargado.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID_Sede:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txb_localidadsede
            // 
            this.txb_localidadsede.Location = new System.Drawing.Point(248, 88);
            this.txb_localidadsede.Name = "txb_localidadsede";
            this.txb_localidadsede.Size = new System.Drawing.Size(140, 20);
            this.txb_localidadsede.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID_Encargado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Localidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // cmb_idSede
            // 
            this.cmb_idSede.FormattingEnabled = true;
            this.cmb_idSede.Location = new System.Drawing.Point(248, 49);
            this.cmb_idSede.Name = "cmb_idSede";
            this.cmb_idSede.Size = new System.Drawing.Size(140, 20);
            this.cmb_idSede.TabIndex = 2;
            this.cmb_idSede.SelectedIndexChanged += new System.EventHandler(this.cmb_idSede_SelectedIndexChanged);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(551, 378);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(117, 37);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Actualizar_Sede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(673, 420);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btn_acutualizarsede);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizar_Sede";
            this.Text = "Actualizar Sede";
            this.Load += new System.EventHandler(this.Actualizar_Sede_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_acutualizarsede;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_localidadsede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_idSede;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txb_idSede;
        private System.Windows.Forms.TextBox txb_idEncargado;
    }
}