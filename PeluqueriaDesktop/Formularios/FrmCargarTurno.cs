using PeluqueriaDesktop.AdminData;
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
    public partial class FrmCargarTurno : Form
    {
        public int? IdDatos { get; set; }
        Cliente cliente = new Cliente();
        Turno turno = new Turno();
        public FrmCargarTurno(int idSeleccionado)
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
                lblClienteBBDD.Text = cliente.Apellido + " " + cliente.Nombre;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            using (var db = new PeluqueriaContext())
            {

                turno.ClienteId = cliente.Id;
                turno.Fecha = DtpFechaTurno.Value.Date;
                turno.Hora = DtpHoraTurno.Value;
                turno.TrabajoARealizar = txtTrabajo.Text;
                db.Turnos.Add(turno);

                db.SaveChanges();

                MessageBox.Show("La operación fue realizada con exito");
            }
            this.Close();
        }
    }
}

