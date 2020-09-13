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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia el TextBox, el Label y el ComboBox
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "0";
            cmbOperador.Text = "";
        }

        /// <summary>
        /// Llama a un metodo para limpiar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Llama a un metodo de la clase Calculadora, para realizar una operacion matematica.
        /// </summary>
        /// <param name="numero1">Primer operando</param>
        /// <param name="numero2">Segundo operando</param>
        /// <param name="operador">Tipo de operacion</param>
        /// <returns>Retorna el resultado de la operacion matematica</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        /// <summary>
        /// Llama a un metodo que devuelve el resultado de una operacion, y validamos que el resultado sea
        /// diferente de MinValue, en caso de ser asi le asignamos el resultado al Label del formulario.
        /// Caso contrario le asignamos al Label un mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);

            if(resultado != double.MinValue)
            {
                lblResultado.Text = resultado.ToString();
            }
            else
            {
                lblResultado.Text = "No se puede dividir por 0";
            }
        }

        /// <summary>
        /// Llama a un metodo de la clase Numero para convertir un decimal a binario,
        /// asignandole el resultado al Label del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCovertirABinario_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.DecimalBinario(lblResultado.Text);
        }

        /// <summary>
        /// Llama a un metodo de la clase Numero para convertir un binario a decimal,
        /// asignandole el resultado al Label del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            lblResultado.Text = Numero.BinarioDecimal(lblResultado.Text);
        }
    }
}
