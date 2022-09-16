using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Modelos;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmResumenMensual : Form
    {
        DbAdminTrabajosRealizados dbAdmin = new DbAdminTrabajosRealizados();
        Caja caja = new Caja();
        public FrmResumenMensual()
        {
            InitializeComponent();
            //personalizamos el datetime para mostrar
            DtpFechaCaja.Format = DateTimePickerFormat.Custom;
            // Le damos el formato de mes colocando una M por caracter y las y por año
            DtpFechaCaja.CustomFormat = "MMMMMMMMMMMMMMMM yyyy";
            ActualizarGrilla();
            CargarTotalIngresos();
        }

        private void CargarTotalIngresos()
        {
            var retiroTotal = 0;
            var sumaCaja = 0;
            var fecha = DtpFechaCaja.Value;
            var efectivoCaja = 0;
            var tarjetasCaja = 0;

            var detalle = dbAdmin.ObtenerIngresos(fecha);
            foreach (DetalleTrabajos i in detalle)
            {
                sumaCaja += (int)i.Entrega;
            }

            var retiro = dbAdmin.ObtenerTodosLosRetiros(fecha);
            foreach (Caja i in retiro)
            {
                retiroTotal += (int)i.RetiroCaja;

            }

            var efectivo = dbAdmin.ObtenerEfectivo(fecha);
            foreach (DetalleTrabajos i in efectivo)
            {
                efectivoCaja += (int)i.Entrega;

            }

            var tarjetas = dbAdmin.ObtenerTarjetas(fecha);
            foreach (DetalleTrabajos i in tarjetas)
            {
                tarjetasCaja += (int)i.Entrega;

            }

            numUpDownTotalEgresos.Value = retiroTotal;
            numUpDownTotalIngresos.Value = sumaCaja;
            numUpSaldo.Value = sumaCaja - retiroTotal;
            NumEfectivo.Value = efectivoCaja;
            NumTarjetas.Value = tarjetasCaja;
            if (numUpSaldo.Value < 0)
            {
                numUpSaldo.BackColor = Color.LightCoral;
            }
            else if (numUpSaldo.Value > 0)
            {
                numUpSaldo.BackColor = Color.SpringGreen;
            }
        }

        private void ActualizarGrilla()
        {
            using (var db = new PeluqueriaContext())
            {
                var resumenMensual = from detalle in db.DetalleTrabajos
                                   where DtpFechaCaja.Value.Month == detalle.Fecha.Month
                                   where DtpFechaCaja.Value.Year == detalle.Fecha.Year
                                   orderby detalle.Fecha descending
                                   select new
                                   {
                                       Fecha = detalle.Fecha.Date,
                                       FormaPago = detalle.FormaDePago,
                                       Cliente = (detalle.cliente.Nombre + " " + detalle.cliente.Apellido).ToUpper(),
                                       Valor = "$" + ((int)detalle.Entrega)
                                    };
                    
                Grid.DataSource = resumenMensual.ToList();

            }
        }

        private void DtpFechaCaja_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
            CargarTotalIngresos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
