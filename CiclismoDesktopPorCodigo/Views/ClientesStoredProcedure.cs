using CiclismoDesktopPorCodigo.Utils;
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
    public partial class ClientesStoredProcedureView : Form
    {
        // Establecemos Conexion
        SqlCommand comand = new SqlCommand();
        public ClientesStoredProcedureView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos comando a EJECUTAR y lo ejecutamos, el RESULTADO queda en el SqldataReader
            comand.CommandType = CommandType.StoredProcedure;
            comand.CommandText = "GetAllClient";
            comand.Parameters.Clear();
            SqlDataReader clientesReader = comand.ExecuteReader();

            // Cargamos los datos en un datatable para poder mostrarlo en la grilla
            DataTable clienteTable = new DataTable();
            clienteTable.Load(clientesReader);

            dataGridClientes.DataSource = clienteTable;

            clientesReader.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteAEliminar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string nombreCliente = (string)dataGridClientes.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar al cliente {nombreCliente}?",
                "Eliminar cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el cliente utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = "DeleteClient";
                comand.Parameters.AddWithValue("id", idClienteAEliminar);
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteView nuevoEditarClienteView = new NuevoEditarClienteView();
            nuevoEditarClienteView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idClienteAModificar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarClienteView nuevoEditarClienteView = new NuevoEditarClienteView(idClienteAModificar);
            nuevoEditarClienteView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
