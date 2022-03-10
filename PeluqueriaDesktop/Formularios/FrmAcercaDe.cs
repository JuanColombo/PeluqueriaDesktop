using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
            TituloLabel();
        }



        private void TituloLabel()
        {
            LblAcercaDe.Text = "Desarrollo por Colombo Juan Pablo y Valle Ivan C.";
            LblContacto.Text = "Contacto: 3498463367  --  3498459297";
        }
    }
}
