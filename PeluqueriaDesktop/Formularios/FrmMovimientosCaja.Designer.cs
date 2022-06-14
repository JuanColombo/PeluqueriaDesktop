
namespace PeluqueriaDesktop.Formularios
{
    partial class FrmMovimientosCaja
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
            this.numUpDownTotalEgresos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numUpDownSubTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalEgresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSubTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(681, 378);
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
            this.DtpFechaCaja.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.DtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpFechaCaja.Location = new System.Drawing.Point(111, 335);
            this.DtpFechaCaja.Name = "DtpFechaCaja";
            this.DtpFechaCaja.Size = new System.Drawing.Size(171, 33);
            this.DtpFechaCaja.TabIndex = 22;
            this.DtpFechaCaja.ValueChanged += new System.EventHandler(this.DtpFechaCaja_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Resumen:";
            // 
            // numUpDownTotalEgresos
            // 
            this.numUpDownTotalEgresos.Enabled = false;
            this.numUpDownTotalEgresos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotalEgresos.Location = new System.Drawing.Point(681, 339);
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
            this.numUpDownTotalEgresos.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(681, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total Egresos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(654, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "$:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(462, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "$:";
            // 
            // numUpDownSubTotal
            // 
            this.numUpDownSubTotal.Enabled = false;
            this.numUpDownSubTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownSubTotal.Location = new System.Drawing.Point(488, 339);
            this.numUpDownSubTotal.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpDownSubTotal.Minimum = new decimal(new int[] {
            -727379969,
            232,
            0,
            -2147483648});
            this.numUpDownSubTotal.Name = "numUpDownSubTotal";
            this.numUpDownSubTotal.Size = new System.Drawing.Size(120, 33);
            this.numUpDownSubTotal.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(503, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Sub-Total";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltro.Location = new System.Drawing.Point(88, 374);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(262, 29);
            this.txtFiltro.TabIndex = 36;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(17, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Filtrar:";
            // 
            // FrmMovimientosCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 425);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUpDownSubTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUpDownTotalEgresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpFechaCaja);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.Grid);
            this.MaximizeBox = false;
            this.Name = "FrmMovimientosCaja";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos de Caja";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalEgresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownSubTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DateTimePicker DtpFechaCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpDownTotalEgresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numUpDownSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label6;
    }
}