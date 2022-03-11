namespace PeluqueriaDesktop.Formularios
{
    partial class FrmCargarTurno
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
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtTrabajo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.DtpHoraTurno = new System.Windows.Forms.DateTimePicker();
            this.lblClienteBBDD = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(39, 123);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(41, 15);
            this.LblFecha.TabIndex = 0;
            this.LblFecha.Text = "Fecha:";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Location = new System.Drawing.Point(39, 154);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(36, 15);
            this.LblHora.TabIndex = 1;
            this.LblHora.Text = "Hora:";
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTituloPrincipal.Location = new System.Drawing.Point(154, 9);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(250, 46);
            this.LblTituloPrincipal.TabIndex = 12;
            this.LblTituloPrincipal.Text = "Nuevo Turno";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(190, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 40);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click_1);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(317, 266);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 40);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // txtTrabajo
            // 
            this.txtTrabajo.Location = new System.Drawing.Point(172, 193);
            this.txtTrabajo.Multiline = true;
            this.txtTrabajo.Name = "txtTrabajo";
            this.txtTrabajo.PlaceholderText = "Escriba aqui una descripcion del producto";
            this.txtTrabajo.Size = new System.Drawing.Size(276, 53);
            this.txtTrabajo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Trabajo:";
            // 
            // DtpFechaTurno
            // 
            this.DtpFechaTurno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaTurno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaTurno.Location = new System.Drawing.Point(172, 123);
            this.DtpFechaTurno.Name = "DtpFechaTurno";
            this.DtpFechaTurno.Size = new System.Drawing.Size(200, 29);
            this.DtpFechaTurno.TabIndex = 17;
            // 
            // DtpHoraTurno
            // 
            this.DtpHoraTurno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpHoraTurno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtpHoraTurno.Location = new System.Drawing.Point(172, 158);
            this.DtpHoraTurno.Name = "DtpHoraTurno";
            this.DtpHoraTurno.Size = new System.Drawing.Size(200, 29);
            this.DtpHoraTurno.TabIndex = 18;
            // 
            // lblClienteBBDD
            // 
            this.lblClienteBBDD.AutoSize = true;
            this.lblClienteBBDD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteBBDD.Location = new System.Drawing.Point(127, 73);
            this.lblClienteBBDD.Name = "lblClienteBBDD";
            this.lblClienteBBDD.Size = new System.Drawing.Size(103, 30);
            this.lblClienteBBDD.TabIndex = 22;
            this.lblClienteBBDD.Text = "**********";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(39, 73);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(82, 30);
            this.lblMarca.TabIndex = 21;
            this.lblMarca.Text = "Cliente:";
            // 
            // CboClientes
            // 
            this.CboClientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(127, 70);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(368, 33);
            this.CboClientes.Sorted = true;
            this.CboClientes.TabIndex = 23;
            this.CboClientes.Visible = false;
            // 
            // FrmCargarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 320);
            this.Controls.Add(this.CboClientes);
            this.Controls.Add(this.lblClienteBBDD);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.DtpHoraTurno);
            this.Controls.Add(this.DtpFechaTurno);
            this.Controls.Add(this.txtTrabajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.LblFecha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargarTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Turno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label LblTituloPrincipal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtTrabajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaTurno;
        private System.Windows.Forms.DateTimePicker DtpHoraTurno;
        private System.Windows.Forms.Label lblClienteBBDD;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox CboClientes;
    }
}