namespace PeluqueriaDesktop.Formularios
{
    partial class FrmNuevoTrabajos
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
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumUpDownValor = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblClienteBBDD = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcionBBDD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpFechaTrabajo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.CboTipoPago = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValor)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.Location = new System.Drawing.Point(15, 285);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(140, 30);
            this.LblCantidad.TabIndex = 0;
            this.LblCantidad.Text = "Tipo de pago:";
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTituloPrincipal.Location = new System.Drawing.Point(12, 9);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(391, 46);
            this.LblTituloPrincipal.TabIndex = 12;
            this.LblTituloPrincipal.Text = "Registro de Trabajos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.Location = new System.Drawing.Point(501, 351);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(105, 42);
            this.BtnGuardar.TabIndex = 13;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.Location = new System.Drawing.Point(626, 351);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 42);
            this.BtnCancelar.TabIndex = 14;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NumUpDownValor
            // 
            this.NumUpDownValor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownValor.Location = new System.Drawing.Point(210, 222);
            this.NumUpDownValor.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownValor.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NumUpDownValor.Name = "NumUpDownValor";
            this.NumUpDownValor.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownValor.TabIndex = 16;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(12, 55);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(82, 30);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Cliente:";
            // 
            // lblClienteBBDD
            // 
            this.lblClienteBBDD.AutoSize = true;
            this.lblClienteBBDD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClienteBBDD.Location = new System.Drawing.Point(94, 55);
            this.lblClienteBBDD.Name = "lblClienteBBDD";
            this.lblClienteBBDD.Size = new System.Drawing.Size(103, 30);
            this.lblClienteBBDD.TabIndex = 20;
            this.lblClienteBBDD.Text = "**********";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripcion.Location = new System.Drawing.Point(12, 174);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(188, 30);
            this.LblDescripcion.TabIndex = 21;
            this.LblDescripcion.Text = "Detalle del trabajo:";
            // 
            // TxtDescripcionBBDD
            // 
            this.TxtDescripcionBBDD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcionBBDD.Location = new System.Drawing.Point(210, 156);
            this.TxtDescripcionBBDD.Multiline = true;
            this.TxtDescripcionBBDD.Name = "TxtDescripcionBBDD";
            this.TxtDescripcionBBDD.Size = new System.Drawing.Size(396, 48);
            this.TxtDescripcionBBDD.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha:";
            // 
            // DtpFechaTrabajo
            // 
            this.DtpFechaTrabajo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaTrabajo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaTrabajo.Location = new System.Drawing.Point(210, 104);
            this.DtpFechaTrabajo.Name = "DtpFechaTrabajo";
            this.DtpFechaTrabajo.Size = new System.Drawing.Size(143, 29);
            this.DtpFechaTrabajo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 25;
            this.label2.Text = "Precio:";
            // 
            // CboTipoPago
            // 
            this.CboTipoPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CboTipoPago.FormattingEnabled = true;
            this.CboTipoPago.Location = new System.Drawing.Point(210, 291);
            this.CboTipoPago.Name = "CboTipoPago";
            this.CboTipoPago.Size = new System.Drawing.Size(160, 29);
            this.CboTipoPago.TabIndex = 26;
            // 
            // FrmNuevoTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(743, 405);
            this.Controls.Add(this.CboTipoPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DtpFechaTrabajo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDescripcionBBDD);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.lblClienteBBDD);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.NumUpDownValor);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.LblCantidad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoTrabajos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajos Realizados";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTituloPrincipal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumUpDownValor;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblClienteBBDD;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcionBBDD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DtpFechaTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboTipoPago;
    }
}