using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmCaja : Form
    {
        DbAdminTrabajosRealizados dbAdmin = new DbAdminTrabajosRealizados();
        Caja caja = new Caja();
        public FrmCaja()
        {
           
            InitializeComponent();
            DtpFechaCaja.Value = DateTime.Now;
            CargarDtpTotal();

        }



        private void CargarDtpTotal()
        {
            var sumaCaja = 0;
            var retiroTotal = 0;
            var sumaEntrega = 0;

            var detalle = dbAdmin.ObtenerTodosLosContados();
            foreach (DetalleTrabajos i in detalle)
            {
                sumaCaja += ((int)i.Valor + (int)i.Entrega);

            }
            var detalleEntrega = dbAdmin.ObtenerEntregas();
            foreach (DetalleTrabajos i in detalleEntrega)
            {
                sumaEntrega += (int)i.Entrega;

            }
            var retiro = dbAdmin.ObtenerTodosLosRetiros();
            foreach (Caja i in retiro)
            {
                retiroTotal += (int)i.RetiroCaja;

            }

            numUpDownTotal.Value = (sumaCaja + sumaEntrega) - retiroTotal;
            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            using (var db = new PeluqueriaContext())
            {
                caja.TotalCaja = (int)numUpDownTotal.Value;
                caja.RetiroCaja = (int)numUpDownRetiro.Value;
                caja.DescripcionRetiro = txtDescripcionRetiro.Text;
                caja.Fecha = DtpFechaCaja.Value;
                db.Caja.Add(caja);
                db.SaveChanges();
                Close();
            }
        }
    }
}
