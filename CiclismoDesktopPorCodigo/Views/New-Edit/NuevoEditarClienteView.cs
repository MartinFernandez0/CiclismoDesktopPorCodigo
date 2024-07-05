using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views.New_Edit
{
    public partial class NuevoEditarClienteView : Form
    {
        private int idClienteAModificar;

        public NuevoEditarClienteView()
        {
            InitializeComponent();
        }

        public NuevoEditarClienteView(int idClienteAModificar)
        {
            this.idClienteAModificar = idClienteAModificar;
        }
    }
}
