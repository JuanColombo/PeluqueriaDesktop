using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using PeluqueriaDesktop.Modelos;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmClienteTrabajos : Form
    {
        Cliente cliente = new Cliente();
        public int? IdDatos { get; set; }
        public FrmClienteTrabajos(int idSeleccionado)
        {
            InitializeComponent();
            DtpFechaFicha.Format = DateTimePickerFormat.Custom;
            
            // Le damos el formato de mes colocando una M por caracter y las y por año
            DtpFechaFicha.CustomFormat = "yyyy";
            IdDatos = idSeleccionado;
            CargarFichaCliente();
            ActualizarGrilla();
            AjustarColumnaDetalle();
           


        }

        private void CargarFichaCliente()
        {
            using (var db = new PeluqueriaContext())
            {
                cliente = db.Cliente.Find(IdDatos);
                LblFichaCliente.Text = cliente.Apellido + " " + cliente.Nombre;
            }
        }

        private void ActualizarGrilla()
        {
            using (var db = new PeluqueriaContext())
            {
                
                var fichaAListar = from detalleTrabajos in db.DetalleTrabajos
                                   where detalleTrabajos.ClienteId == cliente.Id
                                   where DtpFechaFicha.Value.Year == detalleTrabajos.Fecha.Year
                                   orderby detalleTrabajos.Fecha.Date descending
                                   select new
                                   {
                                       Fecha = detalleTrabajos.Fecha.Date,
                                       Valor = "$" + detalleTrabajos.Valor,
                                       Entregas = "$" + detalleTrabajos.Entrega,
                                       Saldo = "$" + (detalleTrabajos.Valor - detalleTrabajos.Entrega),
                                       Forma_De_Pago =detalleTrabajos.FormaDePago,
                                       Detalle = detalleTrabajos.DetalleTrabajo
                                   };
                Grid.DataSource = fichaAListar.ToList();
                

            }         
        }

        private void DtpFechaFicha_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
            AjustarColumnaDetalle();

        }

        private void AjustarColumnaDetalle()
        {
            this.Grid.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
