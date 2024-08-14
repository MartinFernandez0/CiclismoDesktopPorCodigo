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
    public partial class NuevoEditarEmpleadoView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idEmpleadoAModificar;

        public NuevoEditarEmpleadoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarEmpleadoView(int? idEmpleadoAModificar)
        {
            InitializeComponent();

            comand.Connection = Helper.CrearConexion();

            this.idEmpleadoAModificar = idEmpleadoAModificar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            comand.CommandText = $"SELECT * FROM empleados WHERE id={this.idEmpleadoAModificar}";
            var empleadoReader = comand.ExecuteReader();
            if (empleadoReader != null)
            {
                if (empleadoReader.Read())
                {
                    txtApellidoEmpleado.Text = (string)empleadoReader["Apellido"];
                    txtNombreEmpleado.Text = (string)empleadoReader["Nombre"];
                    txtCargoEmpleado.Text = (string)empleadoReader["Cargo"];

                    // Ingresar Valores Date
                    dateTimeFechaNacimiento.Value = (DateTime)empleadoReader["FechaDeNacimiento"];
                    dateTimeFechaIngreso.Value = (DateTime)empleadoReader["FechaDeIngreso"];

                    txtTelEmpleado.Text = (string)empleadoReader["TelefonoDomicilio"];
                    txtAnexoEmpleado.Text = (string)empleadoReader["Anexo"];
                };
            }
            empleadoReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellidoEmpleado.Text;
            string nombre = txtNombreEmpleado.Text;
            string cargo = txtCargoEmpleado.Text;

            DateTime fechaNacimiento = dateTimeFechaNacimiento.Value;
            DateTime fechaIngreso = dateTimeFechaIngreso.Value;

            string telEmpleado = txtTelEmpleado.Text;
            string Anexo = txtAnexoEmpleado.Text;


            if (idEmpleadoAModificar == null)
            {
                comand.CommandText = $"INSERT INTO empleados (Apellido, Nombre, Cargo, FechaDeNacimiento, FechaDeIngreso,TelefonoDomicilio, Anexo) VALUES ('{apellido}','{nombre}','{cargo}','{fechaNacimiento}','{fechaIngreso}','{telEmpleado}','{Anexo}')";
            }
            else
            {
                comand.CommandText = $"UPDATE empleados SET Apellido='{apellido}',Nombre='{nombre}', Cargo='{cargo}', FechaDeNacimiento='{fechaNacimiento}', FechaDeIngreso='{fechaIngreso}',TelefonoDomicilio='{telEmpleado}',Anexo='{Anexo}' WHERE id={this.idEmpleadoAModificar}";
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
