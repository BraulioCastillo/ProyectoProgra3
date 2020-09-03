namespace ProyectoFinal
{
    partial class Actualizar_Supermercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actualizar_Supermercado));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_idDueño = new System.Windows.Forms.TextBox();
            this.txb_localidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_nombresupermercado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_idSupermercado = new System.Windows.Forms.ComboBox();
            this.btn_actualizarsupermercado = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Actualizar Supermercado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txb_idDueño);
            this.groupBox1.Controls.Add(this.txb_localidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_nombresupermercado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_idSupermercado);
            this.groupBox1.Location = new System.Drawing.Point(124, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 265);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // txb_idDueño
            // 
            this.txb_idDueño.Enabled = false;
            this.txb_idDueño.Location = new System.Drawing.Point(204, 185);
            this.txb_idDueño.Name = "txb_idDueño";
            this.txb_idDueño.Size = new System.Drawing.Size(121, 20);
            this.txb_idDueño.TabIndex = 20;
            // 
            // txb_localidad
            // 
            this.txb_localidad.Location = new System.Drawing.Point(204, 143);
            this.txb_localidad.Name = "txb_localidad";
            this.txb_localidad.Size = new System.Drawing.Size(121, 20);
            this.txb_localidad.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID_Dueño:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txb_nombresupermercado
            // 
            this.txb_nombresupermercado.Location = new System.Drawing.Point(204, 102);
            this.txb_nombresupermercado.Name = "txb_nombresupermercado";
            this.txb_nombresupermercado.Size = new System.Drawing.Size(121, 20);
            this.txb_nombresupermercado.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Localidad:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID:";
            // 
            // cmb_idSupermercado
            // 
            this.cmb_idSupermercado.FormattingEnabled = true;
            this.cmb_idSupermercado.Location = new System.Drawing.Point(204, 64);
            this.cmb_idSupermercado.Name = "cmb_idSupermercado";
            this.cmb_idSupermercado.Size = new System.Drawing.Size(121, 21);
            this.cmb_idSupermercado.TabIndex = 12;
            this.cmb_idSupermercado.SelectedIndexChanged += new System.EventHandler(this.cmb_iddueñosupermercado_SelectedIndexChanged);
            // 
            // btn_actualizarsupermercado
            // 
            this.btn_actualizarsupermercado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizarsupermercado.BackgroundImage")));
            this.btn_actualizarsupermercado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizarsupermercado.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_actualizarsupermercado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizarsupermercado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_actualizarsupermercado.Location = new System.Drawing.Point(301, 349);
            this.btn_actualizarsupermercado.Name = "btn_actualizarsupermercado";
            this.btn_actualizarsupermercado.Size = new System.Drawing.Size(123, 36);
            this.btn_actualizarsupermercado.TabIndex = 8;
            this.btn_actualizarsupermercado.Text = "Actualizar";
            this.btn_actualizarsupermercado.UseVisualStyleBackColor = true;
            this.btn_actualizarsupermercado.Click += new System.EventHandler(this.btn_actualizarsupermercado_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(630, 383);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 40);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.Text = "Salir";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Actualizar_Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 428);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_actualizarsupermercado);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Actualizar_Supermercado";
            this.Text = "Actualizar Supermercado";
            this.Load += new System.EventHandler(this.Actualizar_Supermercado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_localidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_nombresupermercado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_idSupermercado;
        private System.Windows.Forms.Button btn_actualizarsupermercado;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txb_idDueño;
    }
}