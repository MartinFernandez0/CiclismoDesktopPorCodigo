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
    public partial class NuevoEditarClienteStoredProcedureView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idCLienteEdit;

        public NuevoEditarClienteStoredProcedureView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }
        public NuevoEditarClienteStoredProcedureView(int idCLienteEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idCLienteEdit = idCLienteEdit;
            CargarDatosAPantalla();
        }

        private void CargarDatosAPantalla()
        {
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();
            comand.CommandText = "GetClientById";
            comand.Parameters.AddWithValue("idClient", idCLienteEdit);
            var clienteReader = comand.ExecuteReader();
            if (clienteReader != null)
            {
                if (clienteReader.Read())
                {
                    txtNombre.Text = (string)clienteReader["Nombre"];
                    txtNombreContacto.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContacto.Text = (string)clienteReader["ApellidoContacto"];
                }
            }
            clienteReader?.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string nombreContacto = txtNombreContacto.Text;
            string apellidoContacto = txtApellidoContacto.Text;

            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();

            if (idCLienteEdit == null)
            {
                comand.CommandText = "AddClient";
            }
            else
            {
                comand.CommandText = "UpdateClient";
                comand.Parameters.AddWithValue("idClient", idCLienteEdit);
            }

            comand.Parameters.AddWithValue("nombre", nombre);
            comand.Parameters.AddWithValue("nombreContacto", nombreContacto);
            comand.Parameters.AddWithValue("apellidoContacto", apellidoContacto);

            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
