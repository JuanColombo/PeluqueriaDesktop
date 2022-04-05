﻿using Microsoft.EntityFrameworkCore;
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
            using (var db = new PeluqueriaContext())
            {
                detalleTrabajo = db.DetalleTrabajos.Find(IdEditar);
                lblClienteBBDD.Text = detalleTrabajo.ClienteId.ToString();
                DtpFechaTrabajo.Value = detalleTrabajo.Fecha;
                TxtDescripcionBBDD.Text = detalleTrabajo.DetalleTrabajo;
                NumUpDownValor.Value = (int)detalleTrabajo.Valor;
                CboTipoPago.SelectedItem = detalleTrabajo.FormaDePago;
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
                detalleTrabajo.FormaDePago = (TipoDePagoEnum)CboTipoPago.SelectedValue;
                detalleTrabajo.Fecha = DtpFechaTrabajo.Value.Date;
                detalleTrabajo.DetalleTrabajo = TxtDescripcionBBDD.Text;
                detalleTrabajo.Valor = (int)NumUpDownValor.Value;

                if (IdEditar == null) { 
                    detalleTrabajo.ClienteId = cliente.Id;
                    detalleTrabajo.Fecha = DtpFechaTrabajo.Value.Date;
                    detalleTrabajo.DetalleTrabajo = TxtDescripcionBBDD.Text;
                    detalleTrabajo.Valor = (int)NumUpDownValor.Value;
                    //agregamos el objeto Tutor al objeto DbContext
                    db.DetalleTrabajos.Add(detalleTrabajo);
                }
                else //configuramos el almacenamiento de la modificación
                {
                    db.Entry(detalleTrabajo).State = EntityState.Modified;
                }

                db.SaveChanges();

                MessageBox.Show("La operación fue realizada con exito");
            }
            this.Close();
        }
        }
    }

