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
public partial class NuevoEditarClienteView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int idClienteAModificar;

        public NuevoEditarClienteView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarClienteView(int idClienteAModificar)
        {
            InitializeComponent();

            comand.Connection = Helper.CrearConexion();

            this.idClienteAModificar = idClienteAModificar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            comand.CommandText = $"SELECT * FROM clientes WHERE id={this.idClienteAModificar}";
            var clienteReader = comand.ExecuteReader();
            if (clienteReader != null)
            {
                if (clienteReader.Read())
                {
                    txtNombre.Text = (string)clienteReader["Nombre"];
                    txtNombreContacto.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContacto.Text = (string)clienteReader["ApellidoContacto"];
                    txtTituloContacto.Text = (string)clienteReader["TituloContacto"];
                    txtCargoContacto.Text = (string)clienteReader["CargoContacto"];
                    txtGerenteDeCuenta.Text = (string)clienteReader["GerenteDeCuenta"];

                    // Convertir VentasAnioAnterior a string solo si no es DBNull y formatear a dos decimales
                    if (clienteReader["VentasAnioAnterior"] != DBNull.Value)
                        txtVentasAnioAnterior.Text = ((decimal)clienteReader["VentasAnioAnterior"]).ToString("F2");

                    txtDireccion1.Text = (string)clienteReader["Direccion1"];
                    txtDireccion2.Text = (string)clienteReader["Direccion2"];
                    txtCiudad.Text = (string)clienteReader["Ciudad"];
                    txtRegion.Text = (string)clienteReader["Region"];
                    txtPais.Text = (string)clienteReader["Pais"];
                    txtCodigoPostal.Text = (string)clienteReader["CodigoPostal"];
                    txtTelefono.Text = (string)clienteReader["Telefono"];
                    txtFax.Text = (string)clienteReader["Fax"];
                }
            }
            clienteReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombre.Text;
            string nombreContacto = txtNombreContacto.Text;
            string apellidoContacto = txtApellidoContacto.Text;
            string tituloContacto = txtTituloContacto.Text;
            string cargoContacto = txtCargoContacto.Text;
            string gerenteDeCuenta = txtGerenteDeCuenta.Text;

            // Obtener el valor numérico de VentasAnioAnterior
            decimal ventasAnioAnterior = 0;
            if (!decimal.TryParse(txtVentasAnioAnterior.Text, out ventasAnioAnterior))
            {
                MessageBox.Show("Ingrese un valor numérico válido para Ventas del Año Anterior.");
                return;
            }

            string direccion1 = txtDireccion1.Text;
            string direccion2 = txtDireccion2.Text;
            string ciudad = txtCiudad.Text;
            string region = txtRegion.Text;
            string pais = txtPais.Text;
            string codigoPostal = txtCodigoPostal.Text;
            string telefono = txtTelefono.Text;
            string fax = txtFax.Text;

            if (idClienteAModificar == 0) // Verifica si el idClienteAModificar no está definido
            {
                comand.CommandText = $"INSERT INTO clientes (Nombre, NombreContacto, ApellidoContacto, TituloContacto, CargoContacto, GerenteDeCuenta, VentasAnioAnterior, Direccion1, Direccion2, Ciudad, Region, Pais, CodigoPostal, Telefono, Fax) VALUES ('{nombreCliente}','{nombreContacto}','{apellidoContacto}','{tituloContacto}','{cargoContacto}','{gerenteDeCuenta}','{ventasAnioAnterior}','{direccion1}','{direccion2}','{ciudad}','{region}','{pais}','{codigoPostal}','{telefono}','{fax}')";
            }
            else
            {
                comand.CommandText = $"UPDATE clientes SET Nombre='{nombreCliente}', NombreContacto='{nombreContacto}', ApellidoContacto='{apellidoContacto}', TituloContacto='{tituloContacto}', CargoContacto='{cargoContacto}', GerenteDeCuenta='{gerenteDeCuenta}', VentasAnioAnterior='{ventasAnioAnterior}', Direccion1='{direccion1}', Direccion2='{direccion2}', Ciudad='{ciudad}', Region='{region}', Pais='{pais}', CodigoPostal='{codigoPostal}', Telefono='{telefono}', Fax='{fax}' WHERE id={this.idClienteAModificar}";
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
