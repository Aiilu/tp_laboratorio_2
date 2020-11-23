using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Interfaz;

namespace Entidades
{
    /// <summary>
    /// ACA SE IMPLEMENTA EL TEMA INTERFACES.
    /// </summary>
    public class Compra : IDAO
    {
        private List<Producto> listaProductos;

        private SqlConnection sqlConnection;
        private string connectionString;

        /// <summary>
        /// Instancia la lista de Productos y se encarga de realizar la conexion a la base de datos
        /// </summary>
        public Compra()
        {
            this.listaProductos = new List<Producto>();

            this.connectionString = "Server=.;Database=Compras;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Propiedad de lectura y escritura de la lista de Productos.
        /// </summary>
        public List<Producto> ListaProductos
        {
            get
            {
                return this.listaProductos;
            }
            set
            {
                this.listaProductos = value;
            }
        }

        /// <summary>
        /// Metodo de la interfaz IDAO, EL CUAL IMPLEMENTA EL TEMA BASE DE DATOS. Se encarga de insertar un registro en la tabla.
        /// </summary>
        /// <param name="nombre">Nombre a insertar</param>
        /// <param name="dni">DNI a insertar</param>
        /// <param name="datos">Datos a insertar</param>
        public void InsertarEnTabla(string nombre, int dni, string datos)
        {
            try
            {
                string command = "INSERT INTO TablaCompras (Nombre, DNI, Datos) VALUES (@NombreIdent, @DNIIdent, @DatosIdent)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                sqlCommand.Parameters.AddWithValue("NombreIdent", nombre); 
                sqlCommand.Parameters.AddWithValue("DNIIdent", dni);
                sqlCommand.Parameters.AddWithValue("DatosIdent", datos);

                this.sqlConnection.Open();

                sqlCommand.ExecuteNonQuery(); 
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

        /// <summary>
        /// Metodo de la interfaz IDAO, EL CUAL IMPLEMENTA EL TEMA BASE DE DATOS. Se encarga de leer un registro de la tabla.
        /// </summary>
        /// <param name="nombre">Nombre por el cual filtra en la base</param>
        /// <param name="dni">DNI por el cual filtra en la base</param>
        /// <returns></returns>
        public string LeerTabla(string nombre, int dni)
        {
            try
            {
                string command = "SELECT Datos FROM TablaCompras WHERE Nombre=@NombreIdent and DNI=@DNIIdent";
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);

                this.sqlConnection.Open();

                sqlCommand.Parameters.AddWithValue("NombreIdent", nombre);
                sqlCommand.Parameters.AddWithValue("DNIIdent", dni);

                SqlDataReader read = sqlCommand.ExecuteReader(); 

                if (read.Read())
                {
                    return read.GetString(0);
                }
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }

            return null;
        }

        /// <summary>
        /// Sobrescritura del metodo virtual ToString.
        /// </summary>
        /// <returns>Retorna un string con los datos contenidos en la lista de Productos</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();

            foreach(Producto p in this.ListaProductos)
            {
                datos.AppendLine(p.ToString());
            }

            return datos.ToString();
        }

    }
}
