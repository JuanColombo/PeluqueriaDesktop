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
    public partial class FrmNuevoTrabajos : Form
    {
        public int? IdDatos { get; set; }
        Cliente cliente = new Cliente();
        DetalleTrabajos detalleTrabajo = new DetalleTrabajos();
        public FrmNuevoTrabajos(int idSeleccionado)
        {
            InitializeComponent();
            if (idSeleccionado != 0)
            {
                IdDatos = idSeleccionado;
                CargarDatosPantalla();
            }

        }

        private void CargarDatosPantalla()
        {
            using (var db = new PeluqueriaContext())
            {
                cliente = db.Cliente.Find(IdDatos);
                lblClienteBBDD.Text = cliente.Apellido + " " + cliente.Nombre ;
                CboTipoPago.DataSource = Enum.GetValues(typeof(TipoDePagoEnum));
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new PeluqueriaContext())
            {

                detalleTrabajo.ClienteId = cliente.Id; 
                detalleTrabajo.Fecha = DtpFechaTrabajo.Value.Date;
                detalleTrabajo.DetalleTrabajo = TxtDescripcionBBDD.Text;
                detalleTrabajo.FormaDePago = (TipoDePagoEnum)CboTipoPago.SelectedValue;
                detalleTrabajo.Valor = (int)NumUpDownValor.Value;

                db.DetalleTrabajos.Add(detalleTrabajo);

                db.SaveChanges();

                MessageBox.Show("La operación fue realizada con exito");
            }
            this.Close();
        }
        }
    }

