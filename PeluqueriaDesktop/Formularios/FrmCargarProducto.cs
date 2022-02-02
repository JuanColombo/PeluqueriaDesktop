using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using PeluqueriaDesktop.Interfaces;
using PeluqueriaDesktop.AdminData;
using PeluqueriaDesktop.Modelos;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmCargarProducto : Form, IFormBase
    {
        DbAdminProductos dbAdmin = new DbAdminProductos();
        public int? IdEditar { get; set; }
        Producto producto = new Producto();

        public FrmCargarProducto()
        {
            InitializeComponent();

        }
        public FrmCargarProducto(int idSeleccionado)
        {
            InitializeComponent();
            if (idSeleccionado != 0)
            {
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelProducto();
            }

        }

        private void CargarDatosDelProducto()
        {
            using (var db = new PeluqueriaContext())
            {
                producto = db.Producto.Find(IdEditar);
                NumUpDownCantidad.Value= (decimal)producto.Cantidad;
                numUpDownCodigo.Value = (decimal)producto.Codigo;
                txtMarca.Text = producto.Marca;
                txtDescripcion.Text = producto.Descripcion;

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            using (var db = new PeluqueriaContext())
            {
                //le asignamos a sus propiedades el valor de cada uno de los cuadros de texto
                producto.Cantidad = (double)NumUpDownCantidad.Value;
                producto.Codigo = (double)numUpDownCodigo.Value;
                producto.Marca = txtMarca.Text;
                producto.Descripcion = txtDescripcion.Text;

                //si el id del Producto a editar es nulo agregamos un Producto Nuevo a la tabla
                if (IdEditar == null)
                    // agregamos el objeto Producto a la Base De datos
                    db.Producto.Add(producto);
                else //configuramos el almacenamiento de la modificacion si el id del Producto es distinto de nulo
                {
                    db.Entry(producto).State = EntityState.Modified;
                }
                db.SaveChanges();

                if (IdEditar == null)
                    MessageBox.Show("Producto " + producto.Marca  + " cargado con exito");
                else
                    MessageBox.Show("Producto " + producto.Marca + "  modificado con exito");
                this.Close();

            }
        }

        public void CargarDatosEnPantalla()
        {
            producto = (Producto)dbAdmin.Obtener(IdEditar);
            NumUpDownCantidad.Value = (decimal)producto.Cantidad;
            numUpDownCodigo.Value = (decimal)producto.Codigo;
            txtMarca.Text = producto.Marca;
            txtDescripcion.Text = producto.Descripcion;
        }

        public void LimpiarDatosDeLaPantalla()
        {
            producto = new Producto();
            txtMarca.Text = "";
            txtDescripcion.Text = "";
            numUpDownCodigo.Value = 0;
            NumUpDownCantidad.Value = 0;
        }
    }
}

