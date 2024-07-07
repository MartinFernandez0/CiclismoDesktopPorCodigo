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

            numericUpDownPrecioProducto.DecimalPlaces = 2;
            numericUpDownPrecioProducto.Minimum = 0;
            numericUpDownPrecioProducto.Maximum = 9999999999.99M;
            numericUpDownPrecioProducto.Increment = 0.01M;


            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            if (idProductoAModificar.HasValue)
            {
                comand.CommandText = $"SELECT * FROM productos WHERE id=@IdProducto";
                comand.Parameters.AddWithValue("@IdProducto", idProductoAModificar);

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
        }

        private string GetStringOrNull(SqlDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string colorProducto = txtColorProducto.Text;
            string tallaProducto = txtTallaProducto.Text;
            string M_FProducto = txtMFProducto.Text;

            decimal precioProducto = numericUpDownPrecioProducto.Value;


            string claseProducto = txtClaseProducto.Text;

            try
            {
                comand.Parameters.Clear();

                if (!idProductoAModificar.HasValue)
                {
                    comand.CommandText = "INSERT INTO productos (NombreProducto, Color, Talla, M_F, Precio, ClaseProducto) " +
                                         "VALUES (@NombreProducto, @Color, @Talla, @M_F, @Precio, @ClaseProducto)";
                    comand.Parameters.AddWithValue("@IdProducto", DBNull.Value); // Agregar el parámetro IdProducto con valor DBNull para la inserción
                }
                else
                {
                    comand.CommandText = "UPDATE productos " +
                                         "SET NombreProducto = @NombreProducto, Color = @Color, Talla = @Talla, " +
                                         "M_F = @M_F, Precio = @Precio, ClaseProducto = @ClaseProducto " +
                                         "WHERE id = @IdProducto";
                    comand.Parameters.AddWithValue("@IdProducto", idProductoAModificar); // Agregar el parámetro IdProducto con su valor para la actualización
                }


                comand.Parameters.AddWithValue("@NombreProducto", nombreProducto);
                comand.Parameters.AddWithValue("@Color", colorProducto);
                comand.Parameters.AddWithValue("@Talla", tallaProducto);
                comand.Parameters.AddWithValue("@M_F", M_FProducto);
                comand.Parameters.AddWithValue("@Precio", precioProducto);
                comand.Parameters.AddWithValue("@ClaseProducto", claseProducto);

                comand.ExecuteNonQuery();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
