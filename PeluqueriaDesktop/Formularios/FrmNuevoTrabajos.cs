using Microsoft.EntityFrameworkCore;
using PeluqueriaDesktop.Modelos;
using System;
using System.Linq;
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
        public int? IdEditar { get; set; }
        Cliente cliente = new Cliente();

        DetalleTrabajos detalleTrabajo = new DetalleTrabajos();
        public FrmNuevoTrabajos(int idSeleccionado)
        {
            //Creando un nuevo registro de trabajo a partir del Id del cliente seleccionado en la grilla
            InitializeComponent();
            if (idSeleccionado != 0)
            {
                IdDatos = idSeleccionado;
                CargarDatosPantalla();
            }

        }
        public FrmNuevoTrabajos(int idSeleccionado,int idTrabajoSeleccionado)
        {
            InitializeComponent();
            DtpFechaTrabajo.Enabled = true;
            TxtDescripcionBBDD.Enabled = true;
            NumUpDownValor.Enabled = true;
            CargarComboPago();
            if (idTrabajoSeleccionado != 0)
            {
                IdEditar = idTrabajoSeleccionado;
                CargarDatosPantallaTrabajo();
            }

        }

        private void CargarComboPago()
        {
            CboTipoPago.DataSource = Enum.GetValues(typeof(TipoDePagoEnum));
        }

        private void CargarDatosPantallaTrabajo()
        {
            lblMarca.Text = "Cliente ID: ";
            numSaldo.Enabled = false;
            CboTipoPago.Enabled = false;

            using (var db = new PeluqueriaContext())
            {
                detalleTrabajo = db.DetalleTrabajos.Find(IdEditar);
                //lblClienteBBDD.Text = detalleTrabajo.ClienteId.ToString();
                

                DtpFechaTrabajo.Value = detalleTrabajo.Fecha;
                TxtDescripcionBBDD.Text = detalleTrabajo.DetalleTrabajo;
                NumUpDownValor.Value = (int)detalleTrabajo.Valor;
                CboTipoPago.SelectedItem = detalleTrabajo.FormaDePago;
                numSaldo.Value = (int)detalleTrabajo.Valor - (int)detalleTrabajo.Entrega;



                var clienteBBDD = from cliente in db.Cliente
                              join detalle in db.DetalleTrabajos
                              on cliente.Id equals detalle.ClienteId
                              select new
                              {

                                  Nombre = cliente.Nombre
                                 
                              };
                lblClienteBBDD.Text = clienteBBDD.ToString();
            }

            
        }

        private void CargarDatosPantalla()
        {
            numSaldo.Enabled = false;
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
                //codigo por si estamos editando un detalle de trabajo
                detalleTrabajo.FormaDePago = (TipoDePagoEnum)CboTipoPago.SelectedValue;
                detalleTrabajo.Fecha = DtpFechaTrabajo.Value.Date;
                detalleTrabajo.DetalleTrabajo = TxtDescripcionBBDD.Text;
                detalleTrabajo.Valor = (int)NumUpDownValor.Value;
                detalleTrabajo.Entrega = detalleTrabajo.Entrega + (int)numEntrega.Value;

                //codigo si estamos creando un nuevo registro de trabajo
                if (IdEditar == null) { 
                    detalleTrabajo.ClienteId = cliente.Id;
                    detalleTrabajo.Fecha = DtpFechaTrabajo.Value.Date;
                    detalleTrabajo.DetalleTrabajo = TxtDescripcionBBDD.Text;
                    detalleTrabajo.Valor = (int)NumUpDownValor.Value;
                    detalleTrabajo.Entrega = (int)numEntrega.Value;

                    //SI EL MEDIO DE PAGO ES CONTADO O TARJETA DE CREDITO IGUALAMOS LA ENTREGA 
                    if (detalleTrabajo.FormaDePago == TipoDePagoEnum.Contado ||
                        detalleTrabajo.FormaDePago == TipoDePagoEnum.TarjetaCredito)
                    { 
                        detalleTrabajo.Entrega = detalleTrabajo.Valor;
                    }



                    //agregamos el objeto DetalleTrabajo al objeto DbContext
                    db.DetalleTrabajos.Add(detalleTrabajo);
                }
                else //configuramos el almacenamiento de la modificación
                {
                    db.Entry(detalleTrabajo).State = EntityState.Modified;
                }
                //guardamos los cambios en la base de datos
                db.SaveChanges();

                MessageBox.Show("La operación fue realizada con exito");
            }
            this.Close();
        }

        private void CboTipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((int)CboTipoPago.SelectedItem == (int)TipoDePagoEnum.Contado ||
                (int)CboTipoPago.SelectedItem == (int)TipoDePagoEnum.TarjetaCredito)
            {
                numEntrega.Value = 0;
                numEntrega.Enabled = false;
               
            }
            else
            {
                numEntrega.Enabled = true;
            }
        }
    }
    }

