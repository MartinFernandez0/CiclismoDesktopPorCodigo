using CiclismoDesktopPorCodigo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views.New___Edit
{
    public partial class NuevoEditarProductoView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idProductoAModificar;

        public NuevoEditarProductoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarProductoView(int? idProductoAModificar)
        {
            InitializeComponent();

            comand.Connection = Helper.CrearConexion();

            this.idProductoAModificar = idProductoAModificar;
            CargarDatosEnPantalla();
        }
        private void CargarDatosEnPantalla()
        {
            comand.CommandText = $"SELECT * FROM productos WHERE id={this.idProductoAModificar}";

            using (var productoReader = comand.ExecuteReader())
            {
                if (productoReader.Read())
                {
                    txtNombreProducto.Text = GetStringOrNull(productoReader, "NombreProducto");
                    txtColorProducto.Text = GetStringOrNull(productoReader, "Color");
                    txtTallaProducto.Text = GetStringOrNull(productoReader, "Talla");
                    txtMFProducto.Text = GetStringOrNull(productoReader, "M_F");

                    // Valor Numerico
                    if (productoReader["Precio"] != DBNull.Value)
                        numericUpDownPrecioProducto.Value = Convert.ToDecimal(productoReader["Precio"]);

                    txtClaseProducto.Text = GetStringOrNull(productoReader, "ClaseProducto");
                }
            }
        }

        private string GetStringOrNull(SqlDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        }

        //private void CargarDatosEnPantalla()
        //{
        //    comand.CommandText = $"SELECT * FROM productos WHERE id={this.idProductoAModificar}";
        //    var productoReader = comand.ExecuteReader();
        //    if (productoReader != null)
        //    {
        //        if (productoReader.Read())
        //        {
        //            txtNombreProducto.Text = (string)productoReader["NombreProducto"];
        //            txtColorProducto.Text = (string)productoReader["Color"];
        //            txtTallaProducto.Text = (string)productoReader["Talla"];
        //            txtMFProducto.Text = (string)productoReader["M_F"];

        //            // Valor Numerico
        //            numericUpDownPrecioProducto.Value = Convert.ToDecimal(productoReader["Precio"]);

        //            txtClaseProducto.Text = (string)productoReader["ClaseProducto"];
        //        };

        //    }
        //    productoReader?.Close();
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string colorProducto = txtColorProducto.Text;
            string tallaProducto = txtTallaProducto.Text;
            string M_FProducto = txtMFProducto.Text;


            // Obtener el valor numérico del NumericUpDown
            decimal precioProducto = numericUpDownPrecioProducto.Value;

            string claseProducto = txtClaseProducto.Text;

            if (idProductoAModificar == null)
            {
                comand.CommandText = $"INSERT INTO productos (NombreProducto, Color, Talla, M_F, Precio,ClaseProducto) VALUES ('{nombreProducto}','{colorProducto}','{tallaProducto}','{M_FProducto}','{precioProducto}','{claseProducto}')";
            }
            else
            {
                comand.CommandText = $"UPDATE productos SET NombreProducto='{nombreProducto}',Color='{colorProducto}', Talla='{tallaProducto}', M_F='{M_FProducto}', Precio='{precioProducto}',ClaseProducto='{claseProducto}' WHERE id={this.idProductoAModificar}";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
