
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PeluqueriaDesktop
{
    public partial class FrmInicio : Form
    {
        private bool CargaBBDDCompleta = false;
        public FrmInicio()
        {
            InitializeComponent();
            PnlFondo.BackgroundImage = HelperPeluqueria.RecuperarImagenDeArchivoDeRecursos("fondoSistema"); ;

        }
        private void TmrCronometro_Tick(object sender, EventArgs e)
        {
            PbaBarraProgreso.Value = PbaBarraProgreso.Value + 1;
            LblPorcentaje.Text = PbaBarraProgreso.Value.ToString() + "%";

            if (PbaBarraProgreso.Value == 100 || CargaBBDDCompleta)
            {
                if (CargaBBDDCompleta)
                {
                    TmrCronometro.Enabled = false;
                    var frmMenuPrincipal = new FrmMenuPrincipal();
                    frmMenuPrincipal.ShowDialog();
                    Application.Exit();
                }
                else
                {
                    PbaBarraProgreso.Value = 0;
                }
            }
        }

        private async void FrmInicio_Activated(object sender, EventArgs e)
        {
            await ConsultaDatosSqlAsync();
        }
        private async Task ConsultaDatosSqlAsync()
        {
            await Task.Run(() =>
            {
                using (var db = new PeluqueriaContext())
                {
                    var listaProductos = db.Producto.ToList();
                }
                CargaBBDDCompleta = true;
            });
        }
    }
}
