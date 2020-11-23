using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesAbstractas;
using ClasesInstanciables;

namespace FormYenny
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        private void btnAceptarCarrito_OnClick(object sender, EventArgs e)
        {
            FormPrincipal menu = new FormPrincipal();

            menu.Carrito.Items.Add(this.clbCarrito.CheckedItems.ToString());

            menu.ShowDialog(); //No puedo usar el Show porque no se guardan las cosas en el menu

            //this.Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            this.cmbCarrito.DataSource = Enum.GetValues(typeof(Producto.VarProductos));
        }

        private void AgregarTipoProd_OnSelectValueChanged(object sender, EventArgs e)
        {
            if (this.cmbCarrito.Text == "Libros")
            {
                this.clbCarrito.Items.Clear();

                /*int[] array;

                array = (int[])Enum.GetValues(typeof(Libros.LibTerror));

                this.clbCarrito.Items.Add(array);*/

                this.clbCarrito.Items.Add("Anochecer");
                this.clbCarrito.Items.Add("IT");

            }
            else
            {
                this.clbCarrito.Items.Clear();
                this.clbCarrito.Items.Add("Horizon");
                this.clbCarrito.Items.Add("Ghost");
            }
        }

        private void btnCancelar_OnClick(object sender, EventArgs e)
        {
            FormPrincipal menu = new FormPrincipal();

            menu.Show();

            this.Close();
        }
    }
}
