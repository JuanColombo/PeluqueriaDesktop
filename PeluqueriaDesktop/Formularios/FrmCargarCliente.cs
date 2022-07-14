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

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmCargarCliente : Form, IFormBase
    {
        DbAdminClientes dbAdmin = new DbAdminClientes();
        public int? IdEditar { get; set; }
        Cliente cliente = new Cliente();
        
        public FrmCargarCliente(int? idSeleccionado = null)

        {
            InitializeComponent();

            if (idSeleccionado != null)
            {
                
                IdEditar = idSeleccionado;
                //llamamos al metodo de carga datos
                CargarDatosDelCliente();
            }

        }
        //public FrmCargarCliente(int idSeleccionado)
        //{
        //    InitializeComponent();
        //    if (idSeleccionado != 0)
        //    {
        //        IdEditar = idSeleccionado;
        //        //llamamos al metodo de carga datos
        //        CargarDatosDelCliente();
        //    }

        //}

        private void CargarDatosDelCliente()
        {
            using (var db = new PeluqueriaContext())
            {
                cliente = db.Cliente.Find(IdEditar);
                TxtNombre.Text = cliente.Nombre;
                TxtApellido.Text = cliente.Apellido;
                NumUpDownTelefono.Value = (decimal)cliente.Telefono;

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
                cliente.Nombre = TxtNombre.Text.ToUpper();
                cliente.Apellido = TxtApellido.Text.ToUpper();
                cliente.Telefono = (double)NumUpDownTelefono.Value;

                //si el id del Cliente a editar es nulo agregamos un Cliente Nuevo a la tabla
                if (IdEditar == null)
                    // agregamos el objeto Clientes a la Base De datos
                    db.Cliente.Add(cliente);
                else //configuramos el almacenamiento de la modificacion si el id del Cliente es distinto de nulo
                {
                    db.Entry(cliente).State = EntityState.Modified;
                }
                db.SaveChanges();

                if (IdEditar == null)
                      MessageBox.Show("Cliente " + cliente.Apellido + " " + cliente.Nombre + " cargado con exito");
                else
                      MessageBox.Show("Cliente " + cliente.Apellido + " " + cliente.Nombre + "  modificado con exito");
                this.Close();

            }
        }

        public void CargarDatosEnPantalla()
        {
            LblTituloPrincipal.Text = "Editar Cliente";
            cliente = (Cliente)dbAdmin.Obtener(IdEditar);
            TxtNombre.Text = cliente.Nombre;
            TxtApellido.Text = cliente.Apellido;
            NumUpDownTelefono.Value = (decimal)cliente.Telefono;
        }

        public void LimpiarDatosDeLaPantalla()
        {
            LblTituloPrincipal.Text = "Nuevo Cliente";
            cliente = new Cliente();
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            NumUpDownTelefono.Value = 0;
        }
    }
}
