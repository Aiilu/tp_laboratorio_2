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

namespace FormYenny
{
    public partial class FormPrincipal : Form
    {
        private List<Producto> stock;
        private Random num;

        /// <summary>
        /// Constructor principal. Instancia la lista y el Random. Con el Random traemos un numero aleatorio entre el rango especificado, de esta manera nos trae los productos que tenemos la cantidad de veces que de el Random.
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
            this.num = new Random();
            this.stock = new List<Producto>();

            for(int i=0; i < num.Next(0,3); i++)
            {
                stock.Add(new Juegos(5000.99f, Juegos.JuegosPS4.Ghost));
            }
            for (int i = 0; i < num.Next(0, 3); i++)
            {
                stock.Add(new Juegos(3550f, Juegos.JuegosPS4.Horizon));
            }
            for (int i = 0; i < num.Next(0, 3); i++)
            {
                stock.Add(new Libros(1000f, Libros.LibTerror.Anochecer));
            }
            for (int i = 0; i < num.Next(0, 3); i++)
            {
                stock.Add(new Libros(1500f, Libros.LibTerror.IT));
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo listCarrito.
        /// </summary>
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

        /// <summary>
        /// Propiedad de lectura y escritura del atributo stock.
        /// </summary>
        public List<Producto> Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        /// <summary>
        /// Se encarga de Agregar cosas al carrito, te lleva al formulario FormCarrito donde se seleccionaran los productos que queremos. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_OnClick(object sender, EventArgs e)
        {
            FormCarrito carrito = new FormCarrito();

            carrito.Stock = this.Stock;

            carrito.ShowDialog();

            if (carrito.DialogResult == DialogResult.OK)
            {
                foreach (Producto p in carrito.Lis)
                {
                    this.Carrito.Items.Add(p);
                }

                this.Stock = carrito.Stock;
            }

            carrito.Dispose();
        }

        /// <summary>
        /// Se encarga de limpiar la informacion que se encuentra en la ListBox del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_OnClick(object sender, EventArgs e)
        {
            this.Carrito.Items.Clear();
        }

        /// <summary>
        /// Se encarga de eliminar un dato de la ListBox en base a su indice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitar_OnClick(object sender, EventArgs e)
        {
            if (this.Carrito.SelectedIndex != -1)
            {
                this.Carrito.Items.RemoveAt(this.Carrito.SelectedIndex);
            }
        }

        /// <summary>
        /// Se encarga de llamar al FormComprar, el cual solo puede ser llamado si antes se paso por el FormCarrito y este se lleno.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_OnClick(object sender, EventArgs e)
        {
            if(this.Carrito.Items.Count != 0)
            {
                FormCompra compra = new FormCompra();

                foreach (Producto p in this.Carrito.Items)
                {
                    compra.Compra.ListaProductos.Add(p);
                }

                compra.ShowDialog();
                compra.Dispose();
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito!");
            }
        }
    }
}
