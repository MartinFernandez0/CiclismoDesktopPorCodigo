using CiclismoDesktopPorCodigo.Utils;
using CiclismoDesktopPorCodigo.Views.New___Edit;
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

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ProductosView : Form
    {
        SqlCommand comand = new SqlCommand();

        public ProductosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos comando a EJECUTAR y lo ejecutamos, el RESULTADO queda en el SqldataReader
            comand.CommandText = "Select * from Productos";
            SqlDataReader productosReader = comand.ExecuteReader();

            // Cargamos los datos en un datatable para poder mostrarlo en la grilla
            DataTable productosTable = new DataTable();
            productosTable.Load(productosReader);

            dataGridProductos.DataSource = productosTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoEditarProductoView nuevoEditarProductoView = new NuevoEditarProductoView();
            nuevoEditarProductoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            int idProductoAModificar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            NuevoEditarProductoView nuevoEditarProductoView = new NuevoEditarProductoView(idProductoAModificar);
            nuevoEditarProductoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int idProductoAEliminar = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            string nombreProducto = (string)dataGridProductos.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar el producto {nombreProducto}?",
                "Eliminar producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el cliente utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from productos where id={idProductoAEliminar}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

