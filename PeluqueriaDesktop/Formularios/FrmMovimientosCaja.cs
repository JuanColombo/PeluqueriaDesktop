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
    public partial class FrmMovimientosCaja : Form
    {
        DbAdminTrabajosRealizados dbAdmin = new DbAdminTrabajosRealizados();
        Caja caja = new Caja();

        public FrmMovimientosCaja()
        {
            InitializeComponent();
            //personalizamos el datetime para mostrar
            DtpFechaCaja.Format = DateTimePickerFormat.Custom;
            // Le damos el formato de mes colocando una M por caracter y las y por año
            DtpFechaCaja.CustomFormat = "MMMMMMMMMMMMMMMM yyyy";
            ActualizarGrilla();
            AjustarColumna();
            CargarTotalRetiro();

        }



        private void CargarTotalRetiro()
        {

            var retiroTotal = 0;
            var fecha = DtpFechaCaja.Value;

            var retiro = dbAdmin.ObtenerTodosLosRetiros(fecha);
            foreach (Caja i in retiro)
            {
                retiroTotal += (int)i.RetiroCaja;

            }

            numUpDownTotalEgresos.Value = retiroTotal;
        }

        private void AjustarColumna()
        {
            this.Grid.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ActualizarGrilla()
        {
            if (txtFiltro.Text == "")
            {
                using (var db = new PeluqueriaContext())
                {
                    var cajasAListar = from cajas in db.Caja
                                       where DtpFechaCaja.Value.Month == cajas.Fecha.Month
                                       where DtpFechaCaja.Value.Year == cajas.Fecha.Year 
                                       select new
                                       {
                                           Fecha = cajas.Fecha.Date,
                                           Total = "$" + cajas.TotalCaja,
                                           Retiro = "$" + cajas.RetiroCaja,
                                           Saldo = "$" + (cajas.TotalCaja - cajas.RetiroCaja),
                                           Descripcion = cajas.DescripcionRetiro.ToUpper()
                                       };
                    Grid.DataSource = cajasAListar.ToList();

                }

            }
            else
            {
                using (var db = new PeluqueriaContext())
                {
                    var cajasAListar = from cajas in db.Caja
                                       where DtpFechaCaja.Value.Month == cajas.Fecha.Month
                                       where DtpFechaCaja.Value.Year == cajas.Fecha.Year
                                       where cajas.DescripcionRetiro.ToUpper().Contains(txtFiltro.Text.ToUpper())
                                       select new
                                       {
                                           Fecha = cajas.Fecha.Date,
                                           Total = "$" + cajas.TotalCaja,
                                           Retiro = "$" + cajas.RetiroCaja,
                                           Saldo = "$" + (cajas.TotalCaja - cajas.RetiroCaja),
                                           Descripcion = cajas.DescripcionRetiro.ToUpper()
                                        };
                    Grid.DataSource = cajasAListar.ToList();

                }
            }
        }

        private void DtpFechaCaja_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
            AjustarColumna();
            CargarTotalRetiro();
            CargarSubTotal(txtFiltro.Text);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarSubTotal(txtFiltro.Text);
            ActualizarGrilla();
        }

        private void CargarSubTotal(string txtFiltro)
        {

            var retiroTotal = 0;
            var fecha = DtpFechaCaja.Value;

            var subTotal = dbAdmin.ObtenerTodosLosSubTotal(fecha,txtFiltro);
            foreach (Caja i in subTotal)
            {
                retiroTotal += (int)i.RetiroCaja;

            }

            numUpDownSubTotal.Value = retiroTotal;
        }
    }
}
