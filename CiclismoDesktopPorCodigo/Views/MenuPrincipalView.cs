using CiclismoDesktopPorCodigo.Views;

namespace CiclismoDesktopPorCodigo
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void gestionarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }
    }
}
