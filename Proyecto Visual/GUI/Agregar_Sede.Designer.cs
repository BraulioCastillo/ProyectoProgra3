namespace ProyectoFinal
{
    partial class Agregar_Sede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar_Sede));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_idencargadosede = new System.Windows.Forms.ComboBox();
            this.cmb_idsupermercadosede = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_localidadsede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_idsede = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregarsede = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Sede";
            // 
            // cmb_idencargadosede
            // 
            this.cmb_idencargadosede.FormattingEnabled = true;
            this.cmb_idencargadosede.Location = new System.Drawing.Point(213, 133);
            this.cmb_idencargadosede.Name = "cmb_idencargadosede";
            this.cmb_idencargadosede.Size = new System.Drawing.Size(121, 21);
            this.cmb_idencargadosede.TabIndex = 2;
            // 
            // cmb_idsupermercadosede
            // 
            this.cmb_idsupermercadosede.FormattingEnabled = true;
            this.cmb_idsupermercadosede.Location = new System.Drawing.Point(213, 173);
            this.cmb_idsupermercadosede.Name = "cmb_idsupermercadosede";
            this.cmb_idsupermercadosede.Size = new System.Drawing.Size(121, 21);
            this.cmb_idsupermercadosede.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_localidadsede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txb_idsede);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_idencargadosede);
            this.groupBox1.Controls.Add(this.cmb_idsupermercadosede);
            this.groupBox1.Location = new System.Drawing.Point(141, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 246);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID_Spermercado:";
            // 
            // txb_localidadsede
            // 
            this.txb_localidadsede.Location = new System.Drawing.Point(213, 95);
            this.txb_localidadsede.Name = "txb_localidadsede";
            this.txb_localidadsede.Size = new System.Drawing.Size(121, 20);
            this.txb_localidadsede.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID_Encargado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Localidad:";
            // 
            // txb_idsede
            // 
            this.txb_idsede.Location = new System.Drawing.Point(213, 54);
            this.txb_idsede.Name = "txb_idsede";
            this.txb_idsede.Size = new System.Drawing.Size(121, 20);
            this.txb_idsede.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // btn_agregarsede
            // 
            this.btn_agregarsede.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_agregarsede.BackgroundImage")));
            this.btn_agregarsede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarsede.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_agregarsede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarsede.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_agregarsede.Location = new System.Drawing.Point(289, 338);
            this.btn_agregarsede.Name = "btn_agregarsede";
            this.btn_agregarsede.Size = new System.Drawing.Size(123, 36);
            this.btn_agregarsede.TabIndex = 5;
            this.btn_agregarsede.Text = "Agregar ";
            this.btn_agregarsede.UseVisualStyleBackColor = true;
            this.btn_agregarsede.Click += new System.EventHandler(this.btn_agregarsede_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(575, 398);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 40);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Agregar_Sede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 444);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btn_agregarsede);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agregar_Sede";
            this.Text = "Agregar Sede";
            this.Load += new System.EventHandler(this.Agregar_Sede_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_idencargadosede;
        private System.Windows.Forms.ComboBox cmb_idsupermercadosede;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_idsede;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_localidadsede;
        private System.Windows.Forms.Button btn_agregarsede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncancelar;
    }
}