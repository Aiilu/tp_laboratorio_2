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
    public class Compra : IDAO
    {
        private List<Producto> listaProductos;

        private SqlConnection sqlConnection;
        private string connectionString;


        public Compra()
        {
            this.listaProductos = new List<Producto>();

            //Serie de datos para conectarse a la base de datos
            this.connectionString = "Server=.;Database=Compras;Trusted_Connection=True";
            this.sqlConnection = new SqlConnection(connectionString); //Se encarga de realizar la conexion.
        }

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

        public void InsertarEnTabla(string nombre, int dni, string datos)
        {
            try
            {
                string command = "INSERT INTO TablaCompras (Nombre, DNI, Datos) VALUES (@NombreIdent, @DNIIdent, @DatosIdent)";
                //sqlCommand.CommandText

                //Para insertar secuencias INSERT en base de datos.
                //Ejecuta comandos en la base de datos.
                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);
                //Lo que esta aca lo va a interpretar como un valor si o si, y no como una secuencia SQL.
                //Lo que pasaria si pusieramos directamente la propiedad.
                sqlCommand.Parameters.AddWithValue("NombreIdent", nombre); //Como voy a identificar a este parametro.
                sqlCommand.Parameters.AddWithValue("DNIIdent", dni);
                sqlCommand.Parameters.AddWithValue("DatosIdent", datos);

                //Abrimos la conexion
                this.sqlConnection.Open();

                //Ejecutar sentencias que no son Querys, osea, no consultas, no select. Para insert, update y delete.
                sqlCommand.ExecuteNonQuery(); //Asi devuelve la cantidad de filas afectadas.
            }
            finally
            {
                if (this.sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }
            }
        }

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
