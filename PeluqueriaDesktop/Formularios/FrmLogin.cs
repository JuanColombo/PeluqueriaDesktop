
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace PeluqueriaDesktop
{

    public partial class FrmLogin : Form
    {
        int intentosFallidos = 0;
        int intentosMaximos = 3;
        int intentosRestantes;
        public FrmMenuPrincipal FrmMenuPrincipal;
        public FrmLogin(FrmMenuPrincipal frmPrincipal)
        {
            InitializeComponent();
            FrmMenuPrincipal = frmPrincipal;
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            Acceder();
        }

        private void Acceder()
        {
            if (ValidarAcceso())
                this.Close();
            else
            {
                intentosFallidos++;
                intentosRestantes = intentosMaximos - intentosFallidos;
                if (intentosFallidos == 3)
                    this.Close();
                else
                {
                    MessageBox.Show($"Error en ingresar, usuario o contraseña incorrectos, te quedan {intentosRestantes} intentos");

                    TxtUsuario.Text = "";
                    TxtContraseña.Text = "";
                }
            }
        }

        private bool ValidarAcceso()
        {
            using var db = new PeluqueriaContext();
            string pass = HelperPeluqueria.ObtenerSha256Hash(TxtContraseña.Text);
            var listaUsuarios = db.Usuarios.Where(u => u.User.Equals(TxtUsuario.Text)).Where(u => u.Password.Equals(pass)).ToList();
            if (listaUsuarios.Count > 0)
            {
                FrmMenuPrincipal.Usuario = listaUsuarios.ElementAt(0);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void TxtContraseña_KeyDown(object sender, KeyEventArgs argumento)
        {
            if (argumento.KeyCode == Keys.Enter)
                BtnAcceder.PerformClick();
        }



        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
