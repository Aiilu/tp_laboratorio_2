using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MetodExtension;
using Archivos;
using System.Threading;

namespace FormYenny
{
    public delegate void CompraRealizada(string nombre, int dni, string datos);

    public partial class FormCompra : Form
    {
        private Compra compra;

        public event CompraRealizada EventCompra;

        public FormCompra()
        {
            InitializeComponent();
            this.Compra = new Compra();
            this.EventCompra += this.Compra.InsertarEnTabla;
    }

        public Compra Compra
        {
            get
            {
                return this.compra;
            }
            set
            {
                this.compra = value;
            }
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            float precio = 0;
            StringBuilder datos = new StringBuilder();
            foreach (Producto p in this.Compra.ListaProductos)
            {
                datos.AppendLine(p.ToString());
                precio += p.Precio;
            }
            this.txtDatosCompra.Text = datos.ToString();
            this.lblPrecioTotal.Text = precio.Mostrar();
        }

        private void btnConfirmar_OnClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.txtNombre.Text) && !string.IsNullOrWhiteSpace(this.txtDNI.Text))
            {
                Thread hilo = new Thread(Archivos<Compra>.GuardarArchivo);
                hilo.Start(this.Compra);

                this.EventCompra.Invoke(this.txtNombre.Text, int.Parse(this.txtDNI.Text), this.txtDatosCompra.Text);
                MessageBox.Show("Se ha realizado la compra correctamente!!");
            }
            else
            {
                MessageBox.Show("Debe cargar los datos correctamente.");
            }
        }

        private void txtDni_OnLeave(object sender, EventArgs e)
        {
            int num;

            if (!int.TryParse(this.txtDNI.Text, out num))
            {
                this.txtDNI.Focus();
            }
        }
    }
}
