using Microsoft.EntityFrameworkCore;
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
    public partial class FrmStock : Form
    {
        public int? IdEditar { get; set; }
        Producto producto = new Producto();
        public FrmStock(int idSeleccionado)
        {
            InitializeComponent();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosStock();
                NumUpDownTotal.Value = (decimal)producto.Cantidad;
            }
        }

        private void CargarDatosStock()
        {
            using (var db = new PeluqueriaContext())
            {
                producto = db.Producto.Find(IdEditar);
                lblMarcaBBDD.Text = producto.Marca;
                TxtDescripcionBBDD.Text = producto.Descripcion;
                NumUpDownStockActual.Value = (decimal)producto.Cantidad;
                


            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new PeluqueriaContext())
            {

                producto.Cantidad = producto.Cantidad + (double)NumUpDownIngreso.Value- (double)NumUpDownEgreso.Value;
                db.Entry(producto).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Stock de " + producto.Marca + "  modificado con exito");
                this.Close();


            }   

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }


        private void PrecioTotal()
        {
            NumUpDownTotal.Value = NumUpDownStockActual.Value + NumUpDownIngreso.Value - NumUpDownEgreso.Value;
        }

        private void NumUpDownIngreso_ValueChanged(object sender, EventArgs e)
        {
            PrecioTotal();
        }

        private void NumUpDownEgreso_ValueChanged(object sender, EventArgs e)
        {
            PrecioTotal();
        }
    }
}
