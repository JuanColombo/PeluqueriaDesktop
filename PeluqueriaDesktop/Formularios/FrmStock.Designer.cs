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
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTituloPrincipal = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.NumUpDownStockActual = new System.Windows.Forms.NumericUpDown();
            this.lblNuevoStock = new System.Windows.Forms.Label();
            this.NumUpDownIngresoEgreso = new System.Windows.Forms.NumericUpDown();
            this.LblTotal = new System.Windows.Forms.Label();
            this.NumUpDownTotal = new System.Windows.Forms.NumericUpDown();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMarcaBBDD = new System.Windows.Forms.Label();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcionBBDD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownStockActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownIngresoEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).BeginInit();
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
            this.NumUpDownStockActual.TabIndex = 7;
            // 
            // lblNuevoStock
            // 
            this.lblNuevoStock.AutoSize = true;
            this.lblNuevoStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNuevoStock.Location = new System.Drawing.Point(443, 280);
            this.lblNuevoStock.Name = "lblNuevoStock";
            this.lblNuevoStock.Size = new System.Drawing.Size(164, 30);
            this.lblNuevoStock.TabIndex = 15;
            this.lblNuevoStock.Text = "Ingreso - Egreso";
            // 
            // NumUpDownIngresoEgreso
            // 
            this.NumUpDownIngresoEgreso.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownIngresoEgreso.Location = new System.Drawing.Point(626, 276);
            this.NumUpDownIngresoEgreso.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownIngresoEgreso.Minimum = new decimal(new int[] {
            1215752191,
            23,
            0,
            -2147483648});
            this.NumUpDownIngresoEgreso.Name = "NumUpDownIngresoEgreso";
            this.NumUpDownIngresoEgreso.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownIngresoEgreso.TabIndex = 16;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.Location = new System.Drawing.Point(25, 359);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(62, 30);
            this.LblTotal.TabIndex = 17;
            this.LblTotal.Text = "Total:";
            // 
            // NumUpDownTotal
            // 
            this.NumUpDownTotal.Enabled = false;
            this.NumUpDownTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumUpDownTotal.Location = new System.Drawing.Point(106, 350);
            this.NumUpDownTotal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumUpDownTotal.Name = "NumUpDownTotal";
            this.NumUpDownTotal.Size = new System.Drawing.Size(97, 39);
            this.NumUpDownTotal.TabIndex = 18;
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
            this.lblMarcaBBDD.Location = new System.Drawing.Point(106, 55);
            this.lblMarcaBBDD.Name = "lblMarcaBBDD";
            this.lblMarcaBBDD.Size = new System.Drawing.Size(18, 30);
            this.lblMarcaBBDD.TabIndex = 20;
            this.lblMarcaBBDD.Text = ".";
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
            this.TxtDescripcionBBDD.Location = new System.Drawing.Point(12, 129);
            this.TxtDescripcionBBDD.Multiline = true;
            this.TxtDescripcionBBDD.Name = "TxtDescripcionBBDD";
            this.TxtDescripcionBBDD.ReadOnly = true;
            this.TxtDescripcionBBDD.Size = new System.Drawing.Size(312, 95);
            this.TxtDescripcionBBDD.TabIndex = 22;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(743, 405);
            this.Controls.Add(this.TxtDescripcionBBDD);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.lblMarcaBBDD);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.NumUpDownTotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.NumUpDownIngresoEgreso);
            this.Controls.Add(this.lblNuevoStock);
            this.Controls.Add(this.NumUpDownStockActual);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblTituloPrincipal);
            this.Controls.Add(this.LblCantidad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownStockActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownIngresoEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTituloPrincipal;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.NumericUpDown NumUpDownStockActual;
        private System.Windows.Forms.Label lblNuevoStock;
        private System.Windows.Forms.NumericUpDown NumUpDownIngresoEgreso;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.NumericUpDown NumUpDownTotal;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMarcaBBDD;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcionBBDD;
    }
}