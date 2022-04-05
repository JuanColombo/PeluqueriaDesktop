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
    public partial class FrmMovimientosCaja : Form
    {
        
        public FrmMovimientosCaja()
        {
            InitializeComponent();
            //personalizamos el datetime para mostrar
            DtpFechaCaja.Format = DateTimePickerFormat.Custom;
            // Le damos el formato de mes colocando una M por caracter y las y por año
            DtpFechaCaja.CustomFormat = "MMMMMMMMMMMMMMMM yyyy";
            ActualizarGrilla();
            AjustarColumna();
        }

        private void AjustarColumna()
        {
            //this.Grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.Grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.Grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //this.Grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Grid.Columns[4].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ActualizarGrilla()
        {
            using (var db = new PeluqueriaContext())
            {
                var cajasAListar = from cajas in db.Caja
                                   where DtpFechaCaja.Value.Month == cajas.Fecha.Month
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

        private void DtpFechaCaja_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
            AjustarColumna();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
