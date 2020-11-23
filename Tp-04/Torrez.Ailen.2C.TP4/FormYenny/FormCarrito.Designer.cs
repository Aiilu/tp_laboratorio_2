namespace FormYenny
{
    partial class FormCarrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarrito));
            this.clbCarrito = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbCarrito = new System.Windows.Forms.ComboBox();
            this.lblCarrito = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clbCarrito
            // 
            this.clbCarrito.FormattingEnabled = true;
            this.clbCarrito.Location = new System.Drawing.Point(227, 97);
            this.clbCarrito.Name = "clbCarrito";
            this.clbCarrito.Size = new System.Drawing.Size(192, 109);
            this.clbCarrito.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(344, 260);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 40);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptarCarrito_OnClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(227, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_OnClick);
            // 
            // cmbCarrito
            // 
            this.cmbCarrito.FormattingEnabled = true;
            this.cmbCarrito.Location = new System.Drawing.Point(227, 30);
            this.cmbCarrito.Name = "cmbCarrito";
            this.cmbCarrito.Size = new System.Drawing.Size(192, 21);
            this.cmbCarrito.TabIndex = 1;
            this.cmbCarrito.SelectedValueChanged += new System.EventHandler(this.AgregarTipoProd_OnSelectValueChanged);
            // 
            // lblCarrito
            // 
            this.lblCarrito.AutoSize = true;
            this.lblCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrito.Location = new System.Drawing.Point(280, 9);
            this.lblCarrito.Name = "lblCarrito";
            this.lblCarrito.Size = new System.Drawing.Size(77, 18);
            this.lblCarrito.TabIndex = 8;
            this.lblCarrito.Text = "Productos";
            // 
            // FormCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(636, 331);
            this.Controls.Add(this.lblCarrito);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbCarrito);
            this.Controls.Add(this.clbCarrito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.FormCarrito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCarrito;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbCarrito;
        private System.Windows.Forms.Label lblCarrito;
    }
}