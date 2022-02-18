using PeluqueriaDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmCaja : Form
    {
        public static DetalleTrabajos DetalleTrabajos;
        double totalPagos;
        public FrmCaja()
        {
            InitializeComponent();
            DtpFechaCaja.Value = DateTime.Now;
            CargarDtpTotal();
        }

        private void CargarDtpTotal()
        {
            if (DetalleTrabajos.FormaDePago == TipoDePagoEnum.Contado)
            {
                using (var db = new PeluqueriaContext())
                {

                }
            }
        }
    }
}
