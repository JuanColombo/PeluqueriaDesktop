using PeluqueriaDesktop.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PeluqueriaDesktop.Formularios
{
    public partial class FrmListadoTurnos : Form
    {
        IDbAdmin dbAdmin;
        private object modificarTurno;

        public FrmListadoTurnos(IDbAdmin objetoDbAdmin)
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
                var turnosAListar = from turnos in db.Turnos
                                    where turnos.Eliminado==false
                                    select new
                                    {
                                        Id = turnos.Id,
                                        Fecha = turnos.Fecha,
                                        Hora = turnos.Hora.ToShortTimeString(),
                                        Trabajo = turnos.TrabajoARealizar,
                                        Cliente = turnos.Cliente.Nombre + " " + turnos.Cliente.Apellido
                                      };
                Grid.DataSource = turnosAListar.ToList();

            }
          
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.MensajeDeAdvertenciaDeSalida();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            ActualizarGrilla(TxtBusqueda.Text);
        }

        private void ActualizarGrilla(string textoABuscar)
        {
            using (var db = new PeluqueriaContext())
            {
                var turnosAListar = from turnos in db.Turnos
                                    where turnos.Eliminado == false
                                    select new
                                    {
                                        Id = turnos.Id,
                                        Fecha = turnos.Fecha,
                                        Hora = turnos.Hora.ToShortTimeString(),
                                        Trabajo = turnos.TrabajoARealizar,
                                        Cliente = turnos.Cliente.Nombre + " " + turnos.Cliente.Apellido
                                    };
                Grid.DataSource = turnosAListar.IgnoreQueryFilters().Where(c => c.Cliente.Contains(textoABuscar) || c.Fecha.Day.ToString().Contains(textoABuscar)).ToList();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //creamos la variable para saber que id de Producto que tenemos seleccionado
            var idSeleccionado = Grid.ObtenerIdSeleccionado();
            var filaAEditar = Grid.CurrentRow.Index;

            var frmNuevoTurno = new FrmCargarTurno(idSeleccionado, modificarTurno);
            frmNuevoTurno.ShowDialog();


            //actualizamos la grilla
            ActualizarGrilla();

            //seleccionamos el registro editado
            Grid.CurrentCell = Grid.Rows[filaAEditar].Cells[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            //obtenemos el id y el nombre del Turno seleccionado en la grilla
            var idSeleccionado = Grid.ObtenerIdSeleccionado();
            // preguntar si realmente desea eliminar al Calendario [nombre_Calendario_seleccionado]
            //colocamos el signo $ para crear la interpolacion de cadenas
            DialogResult respuesta = MessageBox.Show($"¿Estas seguro que desea {BtnEliminar.Text} el turno seleccionado?", BtnEliminar.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //si responde que si, instanciamos al objeto dbContext y eliminamos el Calendario a traves del id que obtuvimos.
            if (respuesta == DialogResult.Yes && BtnEliminar.Text == "Eliminar")
            {
                dbAdmin.Eliminar(idSeleccionado);
                ActualizarGrilla();
            }
            else
                this.Close();
        }
    }
}
