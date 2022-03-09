
namespace PeluqueriaDesktop.Formularios
{
    partial class FrmCaja
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
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.numUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.numUpDownRetiro = new System.Windows.Forms.NumericUpDown();
            this.lblRetiro = new System.Windows.Forms.Label();
            this.BtnGuardarCambios = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.DtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRetiro)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(329, 284);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(121, 40);
            this.BtnSalir.TabIndex = 21;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(68, 80);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 50);
            this.lblTitulo.TabIndex = 22;
            this.lblTitulo.Text = "Total:";
            // 
            // numUpDownTotal
            // 
            this.numUpDownTotal.Enabled = false;
            this.numUpDownTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotal.Location = new System.Drawing.Point(209, 82);
            this.numUpDownTotal.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numUpDownTotal.Name = "numUpDownTotal";
            this.numUpDownTotal.Size = new System.Drawing.Size(330, 50);
            this.numUpDownTotal.TabIndex = 23;
            // 
            // numUpDownRetiro
            // 
            this.numUpDownRetiro.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numUpDownRetiro.Location = new System.Drawing.Point(209, 168);
            this.numUpDownRetiro.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numUpDownRetiro.Name = "numUpDownRetiro";
            this.numUpDownRetiro.Size = new System.Drawing.Size(330, 50);
            this.numUpDownRetiro.TabIndex = 24;
            // 
            // lblRetiro
            // 
            this.lblRetiro.AutoSize = true;
            this.lblRetiro.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRetiro.Location = new System.Drawing.Point(68, 168);
            this.lblRetiro.Name = "lblRetiro";
            this.lblRetiro.Size = new System.Drawing.Size(127, 50);
            this.lblRetiro.TabIndex = 25;
            this.lblRetiro.Text = "Retiro:";
            // 
            // BtnGuardarCambios
            // 
            this.BtnGuardarCambios.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCambios.Location = new System.Drawing.Point(168, 284);
            this.BtnGuardarCambios.Name = "BtnGuardarCambios";
            this.BtnGuardarCambios.Size = new System.Drawing.Size(134, 40);
            this.BtnGuardarCambios.TabIndex = 26;
            this.BtnGuardarCambios.Text = "Guardar Cambios";
            this.BtnGuardarCambios.UseVisualStyleBackColor = false;
            this.BtnGuardarCambios.Click += new System.EventHandler(this.BtnGuardarCambios_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.Location = new System.Drawing.Point(351, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 30);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "Fecha:";
            // 
            // DtpFechaCaja
            // 
            this.DtpFechaCaja.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.DtpFechaCaja.Enabled = false;
            this.DtpFechaCaja.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaCaja.Location = new System.Drawing.Point(429, 15);
            this.DtpFechaCaja.Name = "DtpFechaCaja";
            this.DtpFechaCaja.Size = new System.Drawing.Size(162, 35);
            this.DtpFechaCaja.TabIndex = 28;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 351);
            this.Controls.Add(this.DtpFechaCaja);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.BtnGuardarCambios);
            this.Controls.Add(this.lblRetiro);
            this.Controls.Add(this.numUpDownRetiro);
            this.Controls.Add(this.numUpDownTotal);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnSalir);
            this.MaximizeBox = false;
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ":: Caja ::";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownRetiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown numUpDownTotal;
        private System.Windows.Forms.NumericUpDown numUpDownRetiro;
        private System.Windows.Forms.Label lblRetiro;
        private System.Windows.Forms.Button BtnGuardarCambios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker DtpFechaCaja;
    }
}