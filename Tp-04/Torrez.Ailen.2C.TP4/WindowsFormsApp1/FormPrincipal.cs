using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormYenny
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public ListBox Carrito
        {
            get
            {
                return this.listCarrito;
            }
            set
            {
                this.listCarrito = value;
            }
        }

        private void btnAgregar_OnClick(object sender, EventArgs e)
        {
            FormCarrito carrito = new FormCarrito();

            carrito.ShowDialog();
        }

        private void btnLimpiar_OnClick(object sender, EventArgs e)
        {
            this.Carrito.Items.Clear();
        }

        private void btnQuitar_OnClick(object sender, EventArgs e)
        {
            int index = this.Carrito.SelectedIndex;
            this.Carrito.Items.RemoveAt(index);
        }

        private void btnComprar_OnClick(object sender, EventArgs e)
        {
            FormCompra compra = new FormCompra();

            compra.ShowDialog();
        }
    }
}
