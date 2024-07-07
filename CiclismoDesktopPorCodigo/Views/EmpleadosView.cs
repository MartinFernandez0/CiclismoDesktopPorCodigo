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

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class EmpleadosView : Form
    {
        SqlCommand comand = new SqlCommand();

        public EmpleadosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // Escribimos comando a EJECUTAR y lo ejecutamos, el RESULTADO queda en el SqldataReader
            comand.CommandText = "Select * from Empleados";
            SqlDataReader empleadosReader = comand.ExecuteReader();

            // Cargamos los datos en un datatable para poder mostrarlo en la grilla
            DataTable empleadoTable = new DataTable();
            empleadoTable.Load(empleadosReader);

            dataGridEmpleados.DataSource = empleadoTable;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            int idEmpleadoAModificar = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            NuevoEditarEmpleadoView nuevoEditarEmpleadoView = new NuevoEditarEmpleadoView(idEmpleadoAModificar);
            nuevoEditarEmpleadoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            int idEmpleadoAEliminar = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            string nombreEmpleado = (string)dataGridEmpleados.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar al empleado {nombreEmpleado}?",
                "Eliminar empleado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el empleado utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from empleados where id={idEmpleadoAEliminar}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarEmpleadoView nuevoEditarEmpleadoView = new NuevoEditarEmpleadoView();
            nuevoEditarEmpleadoView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
