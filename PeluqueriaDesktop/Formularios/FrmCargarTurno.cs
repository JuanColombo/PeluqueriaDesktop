using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmCargarTurno : Form
    {
        public int? IdDatos { get; set; }
        Cliente cliente = new Cliente();
        Turno turno = new Turno();
        public FrmCargarTurno()
        {
            InitializeComponent();
            BtnGuardar.Text = "Guardar";
            CboClientes.Visible = true;
            lblClienteBBDD.Visible = false;
            CargarComboClientes();

        }
        public FrmCargarTurno(int idSeleccionado)
        {
            InitializeComponent();
            BtnGuardar.Text = "Guardar";
            CboClientes.Visible = false;
            lblClienteBBDD.Visible = true;
            if (idSeleccionado != 0)
            {
                IdDatos = idSeleccionado;
                CargarDatosPantalla();
            }

        }
        public FrmCargarTurno(int idSeleccionado, object modificarTurno)
        {
            InitializeComponent();
            CboClientes.Visible = true;
            lblClienteBBDD.Visible = false;
            BtnGuardar.Text = "Guardar Cambios";
            CargarComboClientes();
            CboClientes.Enabled = false;
            if (idSeleccionado != 0)
            {
                IdDatos = idSeleccionado;
                CargarDatosDelTurno();
            }

        }
        private void CargarComboClientes()
        {
            using (var db = new PeluqueriaContext())
            {
                var listaClientes = from clientes in db.Cliente
                                    select new { id = clientes.Id, nombre = clientes.Apellido + " " + clientes.Nombre };
                //cargamos el combo de clientes con los existentes en la base de datos
                CboClientes.DataSource = listaClientes.ToList();
                CboClientes.DisplayMember = "nombre";
                CboClientes.ValueMember = "id";
                CboClientes.SelectedValue = 0;
            }
        }
        private void CargarDatosDelTurno()
        {
            using (var db = new PeluqueriaContext())
            {
                turno = db.Turnos.Find(IdDatos);
                //lblClienteBBDD.Text = turno.ClienteId.ToString();
                CboClientes.SelectedValue = turno.ClienteId;
                DtpFechaTurno.Value = turno.Fecha.Date;
                DtpHoraTurno.Value = turno.Hora;
                txtTrabajo.Text = turno.TrabajoARealizar;
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
            if (lblClienteBBDD.Visible == true && BtnGuardar.Text=="Guardar") { 
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
            else if (CboClientes.Visible==true && BtnGuardar.Text=="Guardar")
            {
                using (var db = new PeluqueriaContext())
                {

                    turno.ClienteId =(int)CboClientes.SelectedValue;
                    turno.Fecha = DtpFechaTurno.Value.Date;
                    turno.Hora = DtpHoraTurno.Value;
                    turno.TrabajoARealizar = txtTrabajo.Text;
                    db.Turnos.Add(turno);

                    db.SaveChanges();

                    MessageBox.Show("La operación fue realizada con exito");
                }
                this.Close();
            }
            else if (BtnGuardar.Text=="Guardar Cambios")
            {
                using (var db = new PeluqueriaContext())
                {
                    turno.Fecha = DtpFechaTurno.Value.Date;
                    turno.Hora = DtpHoraTurno.Value;
                    turno.TrabajoARealizar = txtTrabajo.Text;
                    db.Entry(turno).State = EntityState.Modified;
                    db.SaveChanges();
                    MessageBox.Show("La operación fue realizada con exito");
                }
                this.Close();

            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

