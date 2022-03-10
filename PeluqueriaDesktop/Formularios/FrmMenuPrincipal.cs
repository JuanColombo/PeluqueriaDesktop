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
        private object BotonStock;
        private object BotonTurno;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            BackgroundImage = HelperPeluqueria.RecuperarImagenDeArchivoDeRecursos("fondoSistema"); ;
        }

        private void subMnuNuevoCliente_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente(), BotonStock);
            frmCargarClientes.ShowDialog();
        }

        private void subMnuNuevoProducto_Click(object sender, EventArgs e)
        {
            var frmCargarProductos = new FrmBase(new DbAdminProductos(), new FrmCargarProducto());
            frmCargarProductos.ShowDialog();

        }

        private void subMnuParametros_Click(object sender, EventArgs e)
        {
            var frmParametros = new FrmParametros(this);
            frmParametros.ShowDialog();

        }
        private void cambioDeContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmCambioContraseña = new FrmCambioContrasena(FrmMenuPrincipal.Usuario.Id);
            frmCambioContraseña.ShowDialog();
        }

        private void subMnuGestionUsuarios_Click(object sender, EventArgs e)
        {
            var frmGestionUsuarios = new FrmGestionUsuario();
            frmGestionUsuarios.ShowDialog();
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            if (Usuario == null)
            {
                //si no hay nadie logeado, entonces mostramos el formulario de Login
                var frmLogin = new FrmLogin(this);
                frmLogin.ShowDialog();
                if (Usuario != null)
                {
                    //dependiendo el tipo de usuario, habilitamos los distintos menues para que tengan acceso
                    MnuUsuario.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador || Usuario.TipoUsuario == TipoUsuarioEnum.Dueño ? true : false;
                    MnuConfiguracion.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador || Usuario.TipoUsuario == TipoUsuarioEnum.Dueño ? true : false;
                    BtnCaja.Enabled = Usuario.TipoUsuario == TipoUsuarioEnum.Administrador || Usuario.TipoUsuario == TipoUsuarioEnum.Dueño ? true : false;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void BtnRegistrarTrabajo_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente(), BotonStock);
            frmCargarClientes.ShowDialog();
        }

        private void BtnCargarTurno_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente(), BotonStock, BotonTurno);
            frmCargarClientes.ShowDialog();
        }

        private void subMnuListadoTrabajos_Click(object sender, EventArgs e)
        {
            var frmListadoTrabajos = new FrmListadoTrabajos(new DbAdminTrabajosRealizados());
            frmListadoTrabajos.ShowDialog();
        }

        private void subMnuListadoTurnos_Click(object sender, EventArgs e)
        {
            var frmListadoTurnos = new FrmListadoTurnos(new DbAdminTrabajosRealizados());
            frmListadoTurnos.ShowDialog();
        }

        private void BtnCaja_Click(object sender, EventArgs e)
        {
            var fmrCaja = new FrmCaja();
            fmrCaja.ShowDialog();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente(), BotonStock);
            frmCargarClientes.ShowDialog();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            var frmCargarProductos = new FrmBase(new DbAdminProductos(), new FrmCargarProducto());
            frmCargarProductos.ShowDialog();
        }

        private void BtnTrabajo_Click(object sender, EventArgs e)
        {
            var frmCargarClientes = new FrmBase(new DbAdminClientes(), new FrmCargarCliente(), BotonStock);
            frmCargarClientes.ShowDialog();

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void PbDesarrollo22_Click(object sender, EventArgs e)
        {
            var frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();

        }
    }
}
