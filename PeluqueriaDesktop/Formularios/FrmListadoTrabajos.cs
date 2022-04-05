using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Interfaces;
using PeluqueriaDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmListadoTrabajos : Form
    {
        IDbAdmin dbAdmin;
        IFormBase FrmNuevoEditar;
        private int idSeleccionado;

        public FrmListadoTrabajos(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            btnRegistrarPago.Visible = false;
            dbAdmin = objetoDbAdmin;
            DtpFechaDetalle.Value = DateTime.Now;
            ActualizarGrilla();
            Grid.OcultarColumnas();
            AjustarAnchoColumaDetalle();
        }

        private void AjustarAnchoColumaDetalle()
        {
            this.Grid.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void ActualizarGrilla()
        { if (chkCuentaCorriente.Checked == false)
            {
                btnRegistrarPago.Visible = false;
                using (var db = new PeluqueriaContext())
                {
                    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                          select new
                                          {
                                              Id = detalleTrabajo.Id,
                                              Fecha = detalleTrabajo.Fecha,
                                              Detalle = detalleTrabajo.DetalleTrabajo,
                                              Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                              FormaPago = detalleTrabajo.FormaDePago,
                                              Precio = detalleTrabajo.Valor
                                          };
                    Grid.DataSource = trabajosAListar.ToList();
                }
            }
        else
            {
                btnRegistrarPago.Visible = true;
                using (var db = new PeluqueriaContext())
                {
                    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos 
                                          where detalleTrabajo.FormaDePago==TipoDePagoEnum.CuentaCorriente
                                          select new
                                          {
                                              Id = detalleTrabajo.Id,
                                              Fecha = detalleTrabajo.Fecha,
                                              Detalle = detalleTrabajo.DetalleTrabajo,
                                              Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                              FormaPago = detalleTrabajo.FormaDePago,
                                              Precio = detalleTrabajo.Valor
                                          };
                    Grid.DataSource = trabajosAListar.ToList();
                }
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
           // Grid.DataSource = dbAdmin.ObtenerTodos(TxtBusqueda.Text);
           ActualizarGrilla(TxtBusqueda.Text);
            
        }

        private void ActualizarGrilla(string textoABuscar)
        {
            if (chkCuentaCorriente.Checked == false && ChkTarjetas.Checked==false)
            {
                btnRegistrarPago.Visible = false;
                using (var db = new PeluqueriaContext())
                {
                    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                          select new
                                          {
                                              Id = detalleTrabajo.Id,
                                              Fecha = detalleTrabajo.Fecha,
                                              Detalle = detalleTrabajo.DetalleTrabajo,
                                              Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                              FormaPago = detalleTrabajo.FormaDePago,
                                              Precio = detalleTrabajo.Valor
                                          };

                    Grid.DataSource = trabajosAListar.IgnoreQueryFilters().Where(c => c.Cliente.Contains(textoABuscar)).ToList();
                }
            }
            else if (chkCuentaCorriente.Checked == true && ChkTarjetas.Checked == false)
            {
                btnRegistrarPago.Visible = true;
                    using (var db = new PeluqueriaContext())
                    {
                        var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                              where detalleTrabajo.FormaDePago == TipoDePagoEnum.CuentaCorriente
                                              select new
                                              {
                                                  Id = detalleTrabajo.Id,
                                                  Fecha = detalleTrabajo.Fecha,
                                                  Detalle = detalleTrabajo.DetalleTrabajo,
                                                  Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                                  FormaPago = detalleTrabajo.FormaDePago,
                                                  Precio = detalleTrabajo.Valor
                                              };
                    Grid.DataSource = trabajosAListar.IgnoreQueryFilters().Where(c => c.Cliente.Contains(textoABuscar)).ToList();
                }
            }
            else if (chkCuentaCorriente.Checked == false && ChkTarjetas.Checked == true)
            {
                btnRegistrarPago.Visible = false;
                using (var db = new PeluqueriaContext())
                {
                    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                          where detalleTrabajo.FormaDePago == TipoDePagoEnum.TarjetaCredito
                                          select new
                                          {
                                              Id = detalleTrabajo.Id,
                                              Fecha = detalleTrabajo.Fecha,
                                              Detalle = detalleTrabajo.DetalleTrabajo,
                                              Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                              FormaPago = detalleTrabajo.FormaDePago,
                                              Precio = detalleTrabajo.Valor
                                          };
                    Grid.DataSource = trabajosAListar.IgnoreQueryFilters().Where(c => c.Cliente.Contains(textoABuscar)).ToList();
                }
            }

        }

        private void chkCuentaCorriente_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {            
            //creamos la variable para saber que id de Calendario tenemos seleccionado
            var idTrabajoSeleccionado = Grid.ObtenerIdSeleccionado();
            var filaAEditar = Grid.CurrentRow.Index;

            var frmNuevoTrabajo = new FrmNuevoTrabajos(idSeleccionado, idTrabajoSeleccionado);
            frmNuevoTrabajo.ShowDialog();

            //actualizamos la grilla
            ActualizarGrilla();


        }

        private void ChkTarjetas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarGrillaTarjetas();
        }

        private void ActualizarGrillaTarjetas()
        {
            if (ChkTarjetas.Checked==true)
            using (var db = new PeluqueriaContext())
            {
                var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                      where detalleTrabajo.FormaDePago == TipoDePagoEnum.TarjetaCredito
                                      select new
                                      {
                                          Id = detalleTrabajo.Id,
                                          Fecha = detalleTrabajo.Fecha,
                                          Detalle = detalleTrabajo.DetalleTrabajo,
                                          Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                          FormaPago = detalleTrabajo.FormaDePago,
                                          Precio = detalleTrabajo.Valor
                                      };
                Grid.DataSource = trabajosAListar.ToList();
            }
            else
                using (var db = new PeluqueriaContext())
                {
                    var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                          select new
                                          {
                                              Id = detalleTrabajo.Id,
                                              Fecha = detalleTrabajo.Fecha,
                                              Detalle = detalleTrabajo.DetalleTrabajo,
                                              Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                              FormaPago = detalleTrabajo.FormaDePago,
                                              Precio = detalleTrabajo.Valor
                                          };
                    Grid.DataSource = trabajosAListar.ToList();
                }
        }

        private void BtnModificarTrabajo_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de Calendario tenemos seleccionado
            var idTrabajoSeleccionado = Grid.ObtenerIdSeleccionado();
            var filaAEditar = Grid.CurrentRow.Index;

            var frmNuevoTrabajo = new FrmNuevoTrabajos(idSeleccionado, idTrabajoSeleccionado);
            frmNuevoTrabajo.ShowDialog();


            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void DtpFechaDetalle_ValueChanged(object sender, EventArgs e)
        {
            ActualizarGrillaFecha();
        }

        private void ActualizarGrillaFecha()
        {
            using (var db = new PeluqueriaContext())
            {
                var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                      where detalleTrabajo.Fecha.Date == DtpFechaDetalle.Value.Date
                                      select new
                                      {
                                          Id = detalleTrabajo.Id,
                                          Fecha = detalleTrabajo.Fecha,
                                          Detalle = detalleTrabajo.DetalleTrabajo,
                                          Cliente = detalleTrabajo.cliente.Nombre + " " + detalleTrabajo.cliente.Apellido,
                                          FormaPago = detalleTrabajo.FormaDePago,
                                          Precio = detalleTrabajo.Valor
                                      };
                Grid.DataSource = trabajosAListar.ToList();
            }
        }
    }
}
