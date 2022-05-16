
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
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTotalEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(680, 301);
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
            this.DtpFechaCaja.Location = new System.Drawing.Point(626, 356);
            this.DtpFechaCaja.Name = "DtpFechaCaja";
            this.DtpFechaCaja.Size = new System.Drawing.Size(175, 29);
            this.DtpFechaCaja.TabIndex = 22;
            this.DtpFechaCaja.ValueChanged += new System.EventHandler(this.DtpFechaCaja_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(529, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Resumen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(28, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Total Ingresos";
            // 
            // numUpDownTotalIngresos
            // 
            this.numUpDownTotalIngresos.Enabled = false;
            this.numUpDownTotalIngresos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotalIngresos.Location = new System.Drawing.Point(31, 361);
            this.numUpDownTotalIngresos.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpDownTotalIngresos.Name = "numUpDownTotalIngresos";
            this.numUpDownTotalIngresos.Size = new System.Drawing.Size(120, 33);
            this.numUpDownTotalIngresos.TabIndex = 25;
            // 
            // numUpDownTotalEgresos
            // 
            this.numUpDownTotalEgresos.Enabled = false;
            this.numUpDownTotalEgresos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.numUpDownTotalEgresos.Location = new System.Drawing.Point(216, 361);
            this.numUpDownTotalEgresos.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUpDownTotalEgresos.Name = "numUpDownTotalEgresos";
            this.numUpDownTotalEgresos.Size = new System.Drawing.Size(120, 33);
            this.numUpDownTotalEgresos.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(217, 333);
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
            // FrmResumenMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(813, 401);
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
    }
}