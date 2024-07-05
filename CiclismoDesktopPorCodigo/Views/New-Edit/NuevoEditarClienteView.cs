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
    public partial class NuevoEditarClienteView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idClienteAModificar;

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
                    txtNombreCliente.Text = (string)clienteReader["Nombre"];
                    txtNombreContactoCliente.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContactoCliente.Text = (string)clienteReader["ApellidoContacto"];
                    txtTituloContactoCliente.Text = (string)clienteReader["TituloContacto"];
                    txtCargoContactoCliente.Text = (string)clienteReader["CargoContacto"];
                    txtGerenteCuentaCliente.Text = (string)clienteReader["GerenteDeCuenta"];
                    txtVentasAñoAnteriorCliente.Text = clienteReader["VentasAnioAnterior"].ToString();
                    txtDireccion1Cliente.Text = (string)clienteReader["Direccion1"];
                    txtDireccion2Cliente.Text = (string)clienteReader["Direccion2"];
                    txtCiudadCliente.Text = (string)clienteReader["Ciudad"];
                    txtRegionCliente.Text = (string)clienteReader["Region"];
                    txtPaisCliente.Text = (string)clienteReader["Pais"];
                    txtCodigoPostalCliente.Text = (string)clienteReader["CodigoPostal"];
                    txtTelefonoCliente.Text = (string)clienteReader["Telefono"];
                    txtFaxCliente.Text = (string)clienteReader["Fax"];
                };
            }
            clienteReader?.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreCliente.Text;
            string nombreContacto = txtNombreContactoCliente.Text;
            string apellidoContacto = txtApellidoContactoCliente.Text;
            string TituloContacto = txtTituloContactoCliente.Text;
            string CargoContacto = txtCargoContactoCliente.Text;
            string GerenteCuenta = txtGerenteCuentaCliente.Text;
            string VentasAñoAnterior = txtVentasAñoAnteriorCliente.Text;
            string Direccion1 = txtDireccion1Cliente.Text;
            string Direccion2 = txtDireccion2Cliente.Text;
            string Ciudad = txtCiudadCliente.Text;
            string Region = txtRegionCliente.Text;
            string Pais = txtPaisCliente.Text;
            string CodigoPostal = txtCodigoPostalCliente.Text;
            string Telefono = txtTelefonoCliente.Text;
            string Fax = txtFaxCliente.Text;


            if (idClienteAModificar == null)
            {
                comand.CommandText = $"INSERT INTO clientes (nombre, NombreContacto, ApellidoContacto, TituloContacto, CargoContacto, GerenteDeCuenta, VentasAnioAnterior, Direccion1, Direccion2, Ciudad, Region, Pais, CodigoPostal, Telefono, Fax) VALUES ('{nombre}','{nombreContacto}','{apellidoContacto}','{TituloContacto}','{CargoContacto}','{GerenteCuenta}','{VentasAñoAnterior}','{Direccion1}','{Direccion2}','{Ciudad}','{Region}','{Pais}','{CodigoPostal}','{Telefono}','{Fax}')";
            }
            else
            {
                comand.CommandText = $"UPDATE clientes SET nombre='{nombre}', NombreContacto='{nombreContacto}', ApellidoContacto='{apellidoContacto}', TituloContacto'{TituloContacto}', CargoContacto'{CargoContacto}', GerenteDeCuenta'{GerenteCuenta}', VentasAnioAnterior'{VentasAñoAnterior}',Direccion1'{Direccion1}', Direccion2'{Direccion2}', Ciudad'{Ciudad}', Region'{Region}', Pais'{Pais}', CodigoPostal'{CodigoPostal}', Telefono'{Telefono}', Fax'{Fax}' WHERE id={this.idClienteAModificar}";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNombreCliente = new TextBox();
            txtNombreContactoCliente = new TextBox();
            label2 = new Label();
            txtApellidoContactoCliente = new TextBox();
            txtTituloContactoCliente = new TextBox();
            txtDireccion1Cliente = new TextBox();
            txtVentasAñoAnteriorCliente = new TextBox();
            txtGerenteCuentaCliente = new TextBox();
            txtCargoContactoCliente = new TextBox();
            txtFaxCliente = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtCodigoPostalCliente = new TextBox();
            txtPaisCliente = new TextBox();
            txtRegionCliente = new TextBox();
            txtCiudadCliente = new TextBox();
            txtDireccion2Cliente = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Cliente:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(146, 29);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(179, 23);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtNombreContactoCliente
            // 
            txtNombreContactoCliente.Location = new Point(146, 70);
            txtNombreContactoCliente.Name = "txtNombreContactoCliente";
            txtNombreContactoCliente.Size = new Size(179, 23);
            txtNombreContactoCliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 73);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Vamss:";
            // 
            // txtApellidoContactoCliente
            // 
            txtApellidoContactoCliente.Location = new Point(146, 115);
            txtApellidoContactoCliente.Name = "txtApellidoContactoCliente";
            txtApellidoContactoCliente.Size = new Size(179, 23);
            txtApellidoContactoCliente.TabIndex = 4;
            // 
            // txtTituloContactoCliente
            // 
            txtTituloContactoCliente.Location = new Point(146, 157);
            txtTituloContactoCliente.Name = "txtTituloContactoCliente";
            txtTituloContactoCliente.Size = new Size(179, 23);
            txtTituloContactoCliente.TabIndex = 5;
            // 
            // txtDireccion1Cliente
            // 
            txtDireccion1Cliente.Location = new Point(146, 326);
            txtDireccion1Cliente.Name = "txtDireccion1Cliente";
            txtDireccion1Cliente.Size = new Size(179, 23);
            txtDireccion1Cliente.TabIndex = 9;
            // 
            // txtVentasAñoAnteriorCliente
            // 
            txtVentasAñoAnteriorCliente.Location = new Point(146, 284);
            txtVentasAñoAnteriorCliente.Name = "txtVentasAñoAnteriorCliente";
            txtVentasAñoAnteriorCliente.Size = new Size(179, 23);
            txtVentasAñoAnteriorCliente.TabIndex = 8;
            // 
            // txtGerenteCuentaCliente
            // 
            txtGerenteCuentaCliente.Location = new Point(146, 239);
            txtGerenteCuentaCliente.Name = "txtGerenteCuentaCliente";
            txtGerenteCuentaCliente.Size = new Size(179, 23);
            txtGerenteCuentaCliente.TabIndex = 7;
            // 
            // txtCargoContactoCliente
            // 
            txtCargoContactoCliente.Location = new Point(146, 198);
            txtCargoContactoCliente.Name = "txtCargoContactoCliente";
            txtCargoContactoCliente.Size = new Size(179, 23);
            txtCargoContactoCliente.TabIndex = 6;
            // 
            // txtFaxCliente
            // 
            txtFaxCliente.Location = new Point(557, 287);
            txtFaxCliente.Name = "txtFaxCliente";
            txtFaxCliente.Size = new Size(179, 23);
            txtFaxCliente.TabIndex = 16;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(557, 242);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(179, 23);
            txtTelefonoCliente.TabIndex = 15;
            // 
            // txtCodigoPostalCliente
            // 
            txtCodigoPostalCliente.Location = new Point(557, 201);
            txtCodigoPostalCliente.Name = "txtCodigoPostalCliente";
            txtCodigoPostalCliente.Size = new Size(179, 23);
            txtCodigoPostalCliente.TabIndex = 14;
            // 
            // txtPaisCliente
            // 
            txtPaisCliente.Location = new Point(557, 160);
            txtPaisCliente.Name = "txtPaisCliente";
            txtPaisCliente.Size = new Size(179, 23);
            txtPaisCliente.TabIndex = 13;
            // 
            // txtRegionCliente
            // 
            txtRegionCliente.Location = new Point(557, 118);
            txtRegionCliente.Name = "txtRegionCliente";
            txtRegionCliente.Size = new Size(179, 23);
            txtRegionCliente.TabIndex = 12;
            // 
            // txtCiudadCliente
            // 
            txtCiudadCliente.Location = new Point(557, 73);
            txtCiudadCliente.Name = "txtCiudadCliente";
            txtCiudadCliente.Size = new Size(179, 23);
            txtCiudadCliente.TabIndex = 11;
            // 
            // txtDireccion2Cliente
            // 
            txtDireccion2Cliente.Location = new Point(557, 32);
            txtDireccion2Cliente.Name = "txtDireccion2Cliente";
            txtDireccion2Cliente.Size = new Size(179, 23);
            txtDireccion2Cliente.TabIndex = 10;
            // 
            // NuevoEditarClienteView
            // 
            ClientSize = new Size(895, 459);
            Controls.Add(txtFaxCliente);
            Controls.Add(txtTelefonoCliente);
            Controls.Add(txtCodigoPostalCliente);
            Controls.Add(txtPaisCliente);
            Controls.Add(txtRegionCliente);
            Controls.Add(txtCiudadCliente);
            Controls.Add(txtDireccion2Cliente);
            Controls.Add(txtDireccion1Cliente);
            Controls.Add(txtVentasAñoAnteriorCliente);
            Controls.Add(txtGerenteCuentaCliente);
            Controls.Add(txtCargoContactoCliente);
            Controls.Add(txtTituloContactoCliente);
            Controls.Add(txtApellidoContactoCliente);
            Controls.Add(txtNombreContactoCliente);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Name = "NuevoEditarClienteView";
            Text = "Nuevo Editar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox txtNombreCliente;
        private TextBox txtNombreContactoCliente;
        private Label label2;
        private TextBox txtApellidoContactoCliente;
        private TextBox txtTituloContactoCliente;
        private TextBox txtDireccion1Cliente;
        private TextBox txtVentasAñoAnteriorCliente;
        private TextBox txtGerenteCuentaCliente;
        private TextBox txtCargoContactoCliente;
        private TextBox txtFaxCliente;
        private TextBox txtTelefonoCliente;
        private TextBox txtCodigoPostalCliente;
        private TextBox txtPaisCliente;
        private TextBox txtRegionCliente;
        private TextBox txtCiudadCliente;
        private TextBox txtDireccion2Cliente;
    }
}
