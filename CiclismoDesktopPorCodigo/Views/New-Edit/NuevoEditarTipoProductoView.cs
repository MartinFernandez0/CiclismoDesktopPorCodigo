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

namespace CiclismoDesktopPorCodigo.Views.New_Edit
{
    public partial class NuevoEditarTipoProductoView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idTipoProductoAModificar;

        public NuevoEditarTipoProductoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarTipoProductoView(int idTipoProductoAModificar)
        {
            InitializeComponent();

            comand.Connection = Helper.CrearConexion();

            this.idTipoProductoAModificar = idTipoProductoAModificar;

            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            if (idTipoProductoAModificar.HasValue)
            {
                comand.CommandText = $"SELECT * FROM Tipo_productos WHERE id=@IdProducto";
                comand.Parameters.AddWithValue("@IdProducto", idTipoProductoAModificar);

                using (var tipoproductoReader = comand.ExecuteReader())
                {
                    if (tipoproductoReader.Read())
                    {
                        //txtNombreProducto.Text = GetStringOrNull(productoReader, "NombreProducto");
                        txtNombreTipoProducto.Text = GetStringOrNull(tipoproductoReader, "NombreTipoProducto");
                        txtDescripcionTipoProducto.Text = GetStringOrNull(tipoproductoReader, "Descripcion");
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
            string NombreTipoProducto = txtNombreTipoProducto.Text;
            string DescripcionTipoProducto = txtDescripcionTipoProducto.Text;

            try
            {
                comand.Parameters.Clear();

                if (!idTipoProductoAModificar.HasValue)
                {
                    comand.CommandText = "INSERT INTO Tipo_productos (NombreTipoProducto, Descripcion) " +
                                         "VALUES (@NombreTipoProducto, @Descripcion)";
                    comand.Parameters.AddWithValue("@IdTipoProducto", DBNull.Value); // Agregar el parámetro IdProducto con valor DBNull para la inserción
                }
                else
                {
                    comand.CommandText = "UPDATE Tipo_productos " +
                                         "SET NombreTipoProducto = @NombreTipoProducto, Descripcion = @Descripcion WHERE id = @IdTipoProducto";
                    comand.Parameters.AddWithValue("@IdTipoProducto", idTipoProductoAModificar); // Agregar el parámetro IdProducto con su valor para la actualización
                }


                comand.Parameters.AddWithValue("@NombreTipoProducto", NombreTipoProducto);
                comand.Parameters.AddWithValue("@Descripcion", DescripcionTipoProducto);

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
