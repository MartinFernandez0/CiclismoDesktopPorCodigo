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
    public partial class NuevoEditarEmpleadoSPView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idEmpleadoEdit;

        public NuevoEditarEmpleadoSPView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarEmpleadoSPView(int idEmpleadoEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idEmpleadoEdit = idEmpleadoEdit;
            CargarDatosAPantalla();
        }

        private void CargarDatosAPantalla()
        {
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();
            comand.CommandText = "GetEmployeeById";
            comand.Parameters.AddWithValue("id", idEmpleadoEdit);
            var empleadoReader = comand.ExecuteReader();
            if (empleadoReader != null)
            {
                if (empleadoReader.Read())
                {
                    //txtNombre.Text = (string)clienteReader["Nombre"];
                    txtApellidoEmpleado.Text = (string)empleadoReader["Apellido"];
                    txtNombreEmpleado.Text = (string)empleadoReader["Nombre"];

                    txtCargoEmpleado.Text = (string)empleadoReader["Cargo"];

                    dateTimeFechaNacimiento.Value = (DateTime)empleadoReader["FechaDeNacimiento"];
                    dateTimeFechaIngreso.Value = (DateTime)empleadoReader["FechaDeIngreso"];

                    txtTelEmpleado.Text = (string)empleadoReader["TelefonoDomicilio"];
                    txtAnexoEmpleado.Text = (string)empleadoReader["Anexo"];
                }
            }
            empleadoReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //string nombre = txtNombre.Text;

            string apellidoEmpleado = txtApellidoEmpleado.Text;
            string nombreEmpleado = txtNombreEmpleado.Text;
            dateTimeFechaNacimiento.Value = (DateTime)dateTimeFechaNacimiento.Value;
            dateTimeFechaIngreso.Value = (DateTime)dateTimeFechaIngreso.Value;
            string cargoEmpleado = txtCargoEmpleado.Text;
            string telEmpleado = txtTelEmpleado.Text;
            string anexoEmpleado = txtAnexoEmpleado.Text;

            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();

            if (idEmpleadoEdit == null)
            {
                comand.CommandText = "AddEmployee";
            }
            else
            {
                comand.CommandText = "UpdateEmployee";
                comand.Parameters.AddWithValue("id", idEmpleadoEdit);
            }

            //comand.Parameters.AddWithValue("nombre", nombre);
            comand.Parameters.AddWithValue("Apellido", apellidoEmpleado);
            comand.Parameters.AddWithValue("Nombre", nombreEmpleado);
            comand.Parameters.AddWithValue("FechaDeNacimiento", dateTimeFechaNacimiento.Value);
            comand.Parameters.AddWithValue("FechaDeIngreso", dateTimeFechaIngreso.Value);
            comand.Parameters.AddWithValue("Cargo", cargoEmpleado);
            comand.Parameters.AddWithValue("TelefonoDomicilio", telEmpleado);
            comand.Parameters.AddWithValue("Anexo", anexoEmpleado);

            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
