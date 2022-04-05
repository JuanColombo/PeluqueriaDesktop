
namespace PeluqueriaDesktop.Formularios
{
    partial class FrmListadoTrabajos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.chkCuentaCorriente = new System.Windows.Forms.CheckBox();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.ChkTarjetas = new System.Windows.Forms.CheckBox();
            this.BtnModificarTrabajo = new System.Windows.Forms.Button();
            this.DtpFechaDetalle = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(64, 394);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(402, 23);
            this.TxtBusqueda.TabIndex = 19;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(13, 398);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 22;
            this.LblBuscar.Text = "Buscar ";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(665, 409);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(121, 40);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(10, 33);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowTemplate.Height = 25;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(776, 284);
            this.Grid.TabIndex = 14;
            // 
            // chkCuentaCorriente
            // 
            this.chkCuentaCorriente.AutoSize = true;
            this.chkCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCuentaCorriente.Location = new System.Drawing.Point(503, 368);
            this.chkCuentaCorriente.Name = "chkCuentaCorriente";
            this.chkCuentaCorriente.Size = new System.Drawing.Size(147, 25);
            this.chkCuentaCorriente.TabIndex = 23;
            this.chkCuentaCorriente.Text = "Cuenta Corriente";
            this.chkCuentaCorriente.UseVisualStyleBackColor = true;
            this.chkCuentaCorriente.CheckedChanged += new System.EventHandler(this.chkCuentaCorriente_CheckedChanged);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRegistrarPago.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarPago.Location = new System.Drawing.Point(665, 323);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(121, 40);
            this.btnRegistrarPago.TabIndex = 24;
            this.btnRegistrarPago.Text = "Pagar";
            this.btnRegistrarPago.UseVisualStyleBackColor = false;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // ChkTarjetas
            // 
            this.ChkTarjetas.AutoSize = true;
            this.ChkTarjetas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChkTarjetas.Location = new System.Drawing.Point(503, 394);
            this.ChkTarjetas.Name = "ChkTarjetas";
            this.ChkTarjetas.Size = new System.Drawing.Size(147, 25);
            this.ChkTarjetas.TabIndex = 25;
            this.ChkTarjetas.Text = "T. Credito/Debito";
            this.ChkTarjetas.UseVisualStyleBackColor = true;
            this.ChkTarjetas.CheckedChanged += new System.EventHandler(this.ChkTarjetas_CheckedChanged);
            // 
            // BtnModificarTrabajo
            // 
            this.BtnModificarTrabajo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnModificarTrabajo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnModificarTrabajo.ForeColor = System.Drawing.Color.White;
            this.BtnModificarTrabajo.Location = new System.Drawing.Point(665, 366);
            this.BtnModificarTrabajo.Name = "BtnModificarTrabajo";
            this.BtnModificarTrabajo.Size = new System.Drawing.Size(121, 40);
            this.BtnModificarTrabajo.TabIndex = 26;
            this.BtnModificarTrabajo.Text = "Editar Trabajo";
            this.BtnModificarTrabajo.UseVisualStyleBackColor = false;
            this.BtnModificarTrabajo.Click += new System.EventHandler(this.BtnModificarTrabajo_Click);
            // 
            // DtpFechaDetalle
            // 
            this.DtpFechaDetalle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaDetalle.Location = new System.Drawing.Point(64, 357);
            this.DtpFechaDetalle.Name = "DtpFechaDetalle";
            this.DtpFechaDetalle.Size = new System.Drawing.Size(101, 27);
            this.DtpFechaDetalle.TabIndex = 27;
            this.DtpFechaDetalle.ValueChanged += new System.EventHandler(this.DtpFechaDetalle_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha:";
            // 
            // FrmListadoTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaDetalle);
            this.Controls.Add(this.BtnModificarTrabajo);
            this.Controls.Add(this.ChkTarjetas);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.chkCuentaCorriente);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Grid);
            this.MaximizeBox = false;
            this.Name = "FrmListadoTrabajos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado De Trabajos Realizados";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.CheckBox chkCuentaCorriente;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.CheckBox ChkTarjetas;
        private System.Windows.Forms.Button BtnModificarTrabajo;
        private System.Windows.Forms.DateTimePicker DtpFechaDetalle;
        private System.Windows.Forms.Label label1;
    }
}