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

namespace CiclismoDesktopPorCodigo.Views.StoredProcedure
{
    public partial class EmpleadosStoredProcedure : Form
    {
        SqlCommand comand = new SqlCommand();
        public EmpleadosStoredProcedure()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos comando a EJECUTAR y lo ejecutamos, el RESULTADO queda en el SqldataReader
            comand.CommandType = CommandType.StoredProcedure;
            comand.CommandText = "GetAllEmployee";
            comand.Parameters.Clear();
            SqlDataReader empleadoReader = comand.ExecuteReader();

            // Cargamos los datos en un datatable para poder mostrarlo en la grilla
            DataTable empleadoTable = new DataTable();
            empleadoTable.Load(empleadoReader);

            dataGridEmpleados.DataSource = empleadoTable;

            empleadoReader.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarEmpleadoSPView nuevoEditarEmpleadoSPView = new NuevoEditarEmpleadoSPView();
            nuevoEditarEmpleadoSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEmpleadoEdit = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            NuevoEditarEmpleadoSPView nuevoEditarEmpleadoSPView = new NuevoEditarEmpleadoSPView(idEmpleadoEdit);
            nuevoEditarEmpleadoSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmpleadoEdit = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            string ApellidoEmpleado = (string)dataGridEmpleados.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar al empleado {ApellidoEmpleado}?",
                "Eliminar Empleado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el cliente utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = "DeleteEmployee";
                comand.Parameters.AddWithValue("id", idEmpleadoEdit);
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

