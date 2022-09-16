
namespace PeluqueriaDesktop.Formularios
{
    partial class FrmResumenMensual
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.DtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownTotalIngresos = new System.Windows.Forms.NumericUpDown();
            this.numUpDownTotalEgresos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numUpSaldo = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NumEfectivo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NumTarjetas = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(684, 402);
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
            this.Grid.Size = new System.Drawing.Size(791, 262);
            this.Grid.TabIndex = 14;
            // 
            // DtpFechaCaja
            // 
            this.DtpFechaCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaCaja.Location = new System.Drawing.Point(626, 346);
            this.DtpFechaCaja.Name = "DtpFechaCaja";
            this.DtpFechaCaja.Size = new System.Drawing.Size(175, 29);
            this.DtpFechaCaja.TabIndex = 22;
            this.DtpFechaCaja.ValueChanged += new System.EventHandler(this.DtpFechaCaja_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(667, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Resumen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(251, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Ingresos";
            // 
            // numUpDownTotalIngresos
            // 
            this.numUpDownTotalIngresos.BackColor = System.Drawing.Color.SpringGreen;
            this.numUpDownTotalIngresos.Enabled = false;
            this.numUpDownTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotalIngresos.ForeColor = System.Drawing.SystemColors.Window;
            this.numUpDownTotalIngresos.Location = new System.Drawing.Point(254, 342);
            this.numUpDownTotalIngresos.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpDownTotalIngresos.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numUpDownTotalIngresos.Name = "numUpDownTotalIngresos";
            this.numUpDownTotalIngresos.Size = new System.Drawing.Size(120, 33);
            this.numUpDownTotalIngresos.TabIndex = 25;
            this.numUpDownTotalIngresos.ThousandsSeparator = true;
            // 
            // numUpDownTotalEgresos
            // 
            this.numUpDownTotalEgresos.BackColor = System.Drawing.Color.LightCoral;
            this.numUpDownTotalEgresos.Enabled = false;
            this.numUpDownTotalEgresos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotalEgresos.ForeColor = System.Drawing.Color.Black;
            this.numUpDownTotalEgresos.Location = new System.Drawing.Point(407, 342);
            this.numUpDownTotalEgresos.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpDownTotalEgresos.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numUpDownTotalEgresos.Name = "numUpDownTotalEgresos";
            this.numUpDownTotalEgresos.Size = new System.Drawing.Size(120, 33);
            this.numUpDownTotalEgresos.TabIndex = 29;
            this.numUpDownTotalEgresos.ThousandsSeparator = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(408, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total Egresos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Listado de Ingresos Mensuales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(227, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(380, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "$:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(384, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "$:";
            // 
            // numUpSaldo
            // 
            this.numUpSaldo.Enabled = false;
            this.numUpSaldo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpSaldo.Location = new System.Drawing.Point(411, 406);
            this.numUpSaldo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpSaldo.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numUpSaldo.Name = "numUpSaldo";
            this.numUpSaldo.Size = new System.Drawing.Size(120, 33);
            this.numUpSaldo.TabIndex = 34;
            this.numUpSaldo.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(412, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Saldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(254, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "(Incluido Pago Tarjetas)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Ingresos Efectivo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(0, 346);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "$:";
            // 
            // NumEfectivo
            // 
            this.NumEfectivo.Enabled = false;
            this.NumEfectivo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NumEfectivo.Location = new System.Drawing.Point(27, 342);
            this.NumEfectivo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumEfectivo.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.NumEfectivo.Name = "NumEfectivo";
            this.NumEfectivo.Size = new System.Drawing.Size(120, 33);
            this.NumEfectivo.TabIndex = 38;
            this.NumEfectivo.ThousandsSeparator = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "$:";
            // 
            // NumTarjetas
            // 
            this.NumTarjetas.Enabled = false;
            this.NumTarjetas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NumTarjetas.Location = new System.Drawing.Point(27, 406);
            this.NumTarjetas.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.NumTarjetas.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.NumTarjetas.Name = "NumTarjetas";
            this.NumTarjetas.Size = new System.Drawing.Size(120, 33);
            this.NumTarjetas.TabIndex = 41;
            this.NumTarjetas.ThousandsSeparator = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(0, 378);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Ingresos Tarjetas";
            // 
            // FrmResumenMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 443);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NumTarjetas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NumEfectivo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numUpSaldo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numUpDownTotalEgresos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDownTotalIngresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaCaja);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Grid);
            this.MaximizeBox = false;
            this.Name = "FrmResumenMensual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen Mensual";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker DtpFechaCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUpDownTotalIngresos;
        private System.Windows.Forms.NumericUpDown numUpDownTotalEgresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numUpSaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown NumEfectivo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NumTarjetas;
        private System.Windows.Forms.Label label12;
    }
}