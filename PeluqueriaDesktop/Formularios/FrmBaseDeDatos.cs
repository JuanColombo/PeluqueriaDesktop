using Microsoft.EntityFrameworkCore;
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
    public partial class FrmBaseDeDatos : Form
    {
        DbAdminTrabajosRealizados dbAdmin = new DbAdminTrabajosRealizados();
        DbAdminClientes dbAdminClientes = new DbAdminClientes();

        DetalleTrabajos detalleTrabajos = new DetalleTrabajos();
        Cliente cliente = new Cliente();

        public FrmBaseDeDatos()
        {
            InitializeComponent();
        }

        private void BtnDetalleEntregas_Click(object sender, EventArgs e)
        {
         
            var detalle = dbAdmin.ObtenerContadosTarjetas();
            foreach (DetalleTrabajos i in detalle)
            {
                i.Entrega = (int)i.Valor;
                dbAdmin.Actualizar(i);
            }
            MessageBox.Show("Operacion realizada con exito" );


        }

        private void BtnClientesMayusculas_Click(object sender, EventArgs e)
        {
            var cliente = dbAdminClientes.ObtenerTodosyEliminados();
            foreach (Cliente i in cliente)
            {
                i.Nombre    = i.Nombre.ToUpper();
                i.Apellido = i.Apellido.ToUpper();
                dbAdminClientes.Actualizar(i);
            }
            MessageBox.Show("Operacion realizada con exito");
        }
    }
}
