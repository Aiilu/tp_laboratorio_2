namespace FormYenny
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            this.txtDatosCompra = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDatosCompra
            // 
            this.txtDatosCompra.Enabled = false;
            this.txtDatosCompra.Location = new System.Drawing.Point(12, 25);
            this.txtDatosCompra.Multiline = true;
            this.txtDatosCompra.Name = "txtDatosCompra";
            this.txtDatosCompra.Size = new System.Drawing.Size(184, 167);
            this.txtDatosCompra.TabIndex = 0;
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(12, 9);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(58, 13);
            this.lblProductos.TabIndex = 1;
            this.lblProductos.Text = "Productos:";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(12, 259);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(119, 26);
            this.lblPrecioTotal.TabIndex = 2;
            this.lblPrecioTotal.Text = "Total: $100";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(202, 25);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(141, 20);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "DNI";
            this.txtDNI.Leave += new System.EventHandler(this.txtDni_OnLeave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(202, 65);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Text = "Nombre";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(251, 233);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 52);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_OnClick);
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(369, 294);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblProductos);
            this.Controls.Add(this.txtDatosCompra);
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDatosCompra;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnConfirmar;
    }
}