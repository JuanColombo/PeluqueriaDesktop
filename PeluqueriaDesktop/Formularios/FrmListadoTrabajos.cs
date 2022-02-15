using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Interfaces;
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
    public partial class FrmListadoTrabajos : Form
    {
        IDbAdmin dbAdmin;
        public FrmListadoTrabajos(IDbAdmin objetoDbAdmin)
        {
            InitializeComponent();
            dbAdmin = objetoDbAdmin;
            ActualizarGrilla();
            Grid.OcultarColumnas();
        }

        private void ActualizarGrilla()
        {
            using (var db = new PeluqueriaContext())
            {
                var trabajosAListar = from detalleTrabajo in db.DetalleTrabajos
                                      select new
                                      {
                                          Id = detalleTrabajo.Id,
                                          Fecha = detalleTrabajo.Fecha,
                                          Detalle = detalleTrabajo.DetalleTrabajo,
                                          Cliente = detalleTrabajo.cliente.Nombre,
                                          FormaPago = detalleTrabajo.FormaDePago
                                      };
                Grid.DataSource = trabajosAListar.ToList();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }
    }
}
