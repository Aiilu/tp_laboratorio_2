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
using Entidades;
using Excepciones;

namespace FormYenny
{
    public partial class FormCarrito : Form
    {
        private List<Producto> lis;
        private List<Producto> stock;

        public List<Producto> Lis
        {
            get
            {
                return this.lis;
            }
            set
            {
                this.lis = value;
            }
        }
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
        public FormCarrito()
        {
            InitializeComponent();
            this.Lis = new List<Producto>();
            this.Stock = new List<Producto>();
        }

        private void btnAceptarCarrito_OnClick(object sender, EventArgs e)
        {
            foreach (Producto p in this.clbCarrito.CheckedItems)
            {
                this.Lis.Add(p);
                this.Stock.Remove(p);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            this.cmbCarrito.DataSource = Enum.GetValues(typeof(Producto.VarProductos));
        }

        private void AgregarTipoProd_OnSelectValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.clbCarrito.Items.Clear();
                if (this.cmbCarrito.Text == "Libros")
                {
                    foreach (Producto p in this.Stock)
                    {
                        if (p.Productos == Producto.VarProductos.Libros)
                        {
                            this.clbCarrito.Items.Add(p);
                        }
                    }
                }
                else
                {
                    foreach (Producto p in this.Stock)
                    {
                        if (p.Productos == Producto.VarProductos.Juegos)
                        {
                            this.clbCarrito.Items.Add(p);
                        }
                    }
                }

                if (this.clbCarrito.Items.Count == 0)
                {
                    throw new FaltaStockException($"No hay stock de {this.cmbCarrito.Text}, vuelva a iniciar el formulario.");
                }
            }
            catch (FaltaStockException ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_OnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
