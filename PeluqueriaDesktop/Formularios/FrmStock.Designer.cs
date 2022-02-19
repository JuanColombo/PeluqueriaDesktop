namespace PeluqueriaDesktop.Formularios
{
    partial class FrmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStock));
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumUpDownStockActual = new System.Windows.Forms.NumericUpDown();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.NumUpDownIngreso = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaBBDD = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcionBBDD = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.NumUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownEgreso = new System.Windows.Forms.NumericUpDown();
            this.lblEgreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownIngreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownEgreso)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblCantidad.Location = new System.Drawing.Point(475, 207);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(132, 30);
            this.LblCantidad.TabIndex = 0;
            this.LblCantidad.Text = "Stock Actual:";
            // 
            // LblTituloPrincipal
            // 
            this.LblTituloPrincipal.AutoSize = true;
            this.LblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTituloPrincipal.Location = new System.Drawing.Point(12, 9);
            this.LblTituloPrincipal.Name = "LblTituloPrincipal";
            this.LblTituloPrincipal.Size = new System.Drawing.Size(370, 46);
            this.LblTituloPrincipal.TabIndex = 12;
            this.LblTituloPrincipal.Text = "Stock de Productos";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(486, 351);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(121, 40);
            this.BtnGuardar.TabIndex = 3;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(613, 351);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 40);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // NumUpDownStockActual
            // 
            this.NumUpDownStockActual.Enabled = false;
            this.NumUpDownStockActual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownStockActual.Location = new System.Drawing.Point(626, 203);
            this.NumUpDownStockActual.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownStockActual.Name = "NumUpDownStockActual";
            this.NumUpDownStockActual.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownStockActual.TabIndex = 0;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIngreso.Location = new System.Drawing.Point(520, 252);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(87, 30);
            this.lblIngreso.TabIndex = 15;
            this.lblIngreso.Text = "Ingreso:";
            // 
            // NumUpDownIngreso
            // 
            this.NumUpDownIngreso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownIngreso.Location = new System.Drawing.Point(626, 248);
            this.NumUpDownIngreso.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownIngreso.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NumUpDownIngreso.Name = "NumUpDownIngreso";
            this.NumUpDownIngreso.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownIngreso.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(12, 55);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(76, 30);
            this.lblMarca.TabIndex = 19;
            this.lblMarca.Text = "Marca:";
            // 
            // lblMarcaBBDD
            // 
            this.lblMarcaBBDD.AutoSize = true;
            this.lblMarcaBBDD.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaBBDD.Location = new System.Drawing.Point(94, 55);
            this.lblMarcaBBDD.Name = "lblMarcaBBDD";
            this.lblMarcaBBDD.Size = new System.Drawing.Size(103, 30);
            this.lblMarcaBBDD.TabIndex = 20;
            this.lblMarcaBBDD.Text = "**********";
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblDescripcion.Location = new System.Drawing.Point(12, 96);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(126, 30);
            this.LblDescripcion.TabIndex = 21;
            this.LblDescripcion.Text = "Descripcion:";
            // 
            // TxtDescripcionBBDD
            // 
            this.TxtDescripcionBBDD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TxtDescripcionBBDD.Location = new System.Drawing.Point(160, 88);
            this.TxtDescripcionBBDD.Multiline = true;
            this.TxtDescripcionBBDD.Name = "TxtDescripcionBBDD";
            this.TxtDescripcionBBDD.ReadOnly = true;
            this.TxtDescripcionBBDD.Size = new System.Drawing.Size(427, 53);
            this.TxtDescripcionBBDD.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(26, 361);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(62, 30);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.Text = "Total:";
            // 
            // NumUpDownTotal
            // 
            this.NumUpDownTotal.Enabled = false;
            this.NumUpDownTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownTotal.Location = new System.Drawing.Point(108, 357);
            this.NumUpDownTotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownTotal.Name = "NumUpDownTotal";
            this.NumUpDownTotal.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownTotal.TabIndex = 25;
            // 
            // NumUpDownEgreso
            // 
            this.NumUpDownEgreso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownEgreso.Location = new System.Drawing.Point(626, 295);
            this.NumUpDownEgreso.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownEgreso.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NumUpDownEgreso.Name = "NumUpDownEgreso";
            this.NumUpDownEgreso.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownEgreso.TabIndex = 26;
            // 
            // lblEgreso
            // 
            this.lblEgreso.AutoSize = true;
            this.lblEgreso.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEgreso.Location = new System.Drawing.Point(520, 299);
            this.lblEgreso.Name = "lblEgreso";
            this.lblEgreso.Size = new System.Drawing.Size(86, 30);
            this.lblEgreso.TabIndex = 27;
            this.lblEgreso.Text = " Egreso:";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 405);
            this.Controls.Add(this.NumUpDownEgreso);
            this.Controls.Add(this.lblEgreso);
            this.Controls.Add(this.NumUpDownTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtDescripcionBBDD);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.lblMarcaBBDD);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.NumUpDownIngreso);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.NumUpDownStockActual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.LblCantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownIngreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownEgreso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTituloPrincipal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumUpDownStockActual;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.NumericUpDown NumUpDownIngreso;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaBBDD;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcionBBDD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.NumericUpDown NumUpDownTotal;
        private System.Windows.Forms.NumericUpDown NumUpDownEgreso;
        private System.Windows.Forms.Label lblEgreso;
    }
}