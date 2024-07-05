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

                };
            }
            clienteReader?.Close();
        }
    }
}
