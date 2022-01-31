using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeluqueriaDesktop
{
    public partial class FrmMenuPrincipal : Form
    {
        public static Usuario Usuario;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BackgroundImage = HelperPeluqueria.RecuperarImagenDeArchivoDeRecursos("fondoSistema"); ;
        }

        private void subMnuNuevoCliente_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente());
            frmCargarClientes.ShowDialog();
        }

        private void subMnuNuevoProducto_Click(object sender, EventArgs e)
        {
            var frmCargarProductos = new FrmBase(new DbAdminProductos(), new FrmCargarProducto());
            frmCargarProductos.ShowDialog();

        }

        private void subMnuParametros_Click(object sender, EventArgs e)
        {

        }

        private void subMnuNuevoUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
