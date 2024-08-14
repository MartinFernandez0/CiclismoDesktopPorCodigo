using CiclismoDesktopPorCodigo.Utils;
using CiclismoDesktopPorCodigo.Views.New___Edit;
using CiclismoDesktopPorCodigo.Views.New_Edit;
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
    public partial class TipoProductoView : Form
    {
        SqlCommand comand = new SqlCommand();
        public TipoProductoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos comando a EJECUTAR y lo ejecutamos, el RESULTADO queda en el SqldataReader
            comand.CommandText = "Select * from Tipo_Productos";
            SqlDataReader tipoproductoReader = comand.ExecuteReader();

            // Cargamos los datos en un datatable para poder mostrarlo en la grilla
            DataTable tipoproductoTable = new DataTable();
            tipoproductoTable.Load(tipoproductoReader);

            dataGridTipoProducto.DataSource = tipoproductoTable;

            tipoproductoReader.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarTipoProductoView nuevoEditarTipoProductoView = new NuevoEditarTipoProductoView();
            nuevoEditarTipoProductoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idTipoProductoAModificar = (int)dataGridTipoProducto.CurrentRow.Cells[0].Value;
            NuevoEditarTipoProductoView nuevoEditarTipoProductoView = new NuevoEditarTipoProductoView(idTipoProductoAModificar);
            nuevoEditarTipoProductoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idTipoProductoAEliminar = (int)dataGridTipoProducto.CurrentRow.Cells[0].Value;
            string nombreTipoProducto = (string)dataGridTipoProducto.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar el tipo de producto {nombreTipoProducto}?",
                "Eliminar tipo de producto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el cliente utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from tipo_productos where id={idTipoProductoAEliminar}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
