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
    public partial class FrmEgresos : Form
    {
        DbAdminTrabajosRealizados dbAdmin = new DbAdminTrabajosRealizados();
        Caja caja = new Caja();


        public FrmEgresos()
        {
            InitializeComponent();
            CargarTotalEgresos();
        }

        private void CargarTotalEgresos()
        {
            var retiroTotal = 0;
            var empleado = "GRACIELA";
            var retiro = dbAdmin.ObtenerTodosLosRetiros(empleado);
            foreach (Caja i in retiro)
            {
                retiroTotal += (int)i.RetiroCaja;

            }

            numUpDownTotalEgresos.Value = retiroTotal;
        }
    }
}
