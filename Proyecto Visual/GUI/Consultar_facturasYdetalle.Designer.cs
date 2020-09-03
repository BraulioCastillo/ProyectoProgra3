namespace ProyectoFinal
{
    partial class Consultar_facturasYdetalle
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
            this.btnConsultaFactura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaFactura
            // 
            this.btnConsultaFactura.Location = new System.Drawing.Point(252, 207);
            this.btnConsultaFactura.Name = "btnConsultaFactura";
            this.btnConsultaFactura.Size = new System.Drawing.Size(75, 87);
            this.btnConsultaFactura.TabIndex = 0;
            this.btnConsultaFactura.Text = "Consultar facturas";
            this.btnConsultaFactura.UseVisualStyleBackColor = true;
            this.btnConsultaFactura.Click += new System.EventHandler(this.btnConsultaFactura_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "Consultar detalles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Consultar_facturasYdetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConsultaFactura);
            this.Name = "Consultar_facturasYdetalle";
            this.Text = "Consultar_facturasYdetalle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaFactura;
        private System.Windows.Forms.Button button2;
    }
}