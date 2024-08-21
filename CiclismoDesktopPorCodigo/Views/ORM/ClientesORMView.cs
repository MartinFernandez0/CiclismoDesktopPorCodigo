using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiclismoDesktopPorCodigo.DatabaseModels.ModelosCiclismo;
using CiclismoDesktopPorCodigo.Views.New_Edit;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ClientesORMView : Form
    {
        CiclismoRenzo2Context context = new CiclismoRenzo2Context();
        BindingSource ListaClientes = new BindingSource();

        public ClientesORMView()
        {
            InitializeComponent();
            dataGridClientes.DataSource = ListaClientes;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ListaClientes.DataSource = context.Clientes.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            var cliente = (Cliente)ListaClientes.Current;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar al cliente {cliente.Nombre}?",
                "Eliminar cliente",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el cliente utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                CargarGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView();
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)ListaClientes.Current;
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView(cliente);
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
