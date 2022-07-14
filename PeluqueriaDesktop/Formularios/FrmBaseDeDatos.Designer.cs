
namespace PeluqueriaDesktop.Formularios
{
    partial class FrmBaseDeDatos
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
            this.BtnDetalleEntregas = new System.Windows.Forms.Button();
            this.BtnClientesMayusculas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDetalleEntregas
            // 
            this.BtnDetalleEntregas.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnDetalleEntregas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnDetalleEntregas.ForeColor = System.Drawing.Color.White;
            this.BtnDetalleEntregas.Location = new System.Drawing.Point(41, 170);
            this.BtnDetalleEntregas.Name = "BtnDetalleEntregas";
            this.BtnDetalleEntregas.Size = new System.Drawing.Size(128, 53);
            this.BtnDetalleEntregas.TabIndex = 0;
            this.BtnDetalleEntregas.Text = "Detalle Entregas";
            this.BtnDetalleEntregas.UseVisualStyleBackColor = false;
            this.BtnDetalleEntregas.Click += new System.EventHandler(this.BtnDetalleEntregas_Click);
            // 
            // BtnClientesMayusculas
            // 
            this.BtnClientesMayusculas.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnClientesMayusculas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClientesMayusculas.ForeColor = System.Drawing.Color.White;
            this.BtnClientesMayusculas.Location = new System.Drawing.Point(343, 170);
            this.BtnClientesMayusculas.Name = "BtnClientesMayusculas";
            this.BtnClientesMayusculas.Size = new System.Drawing.Size(128, 53);
            this.BtnClientesMayusculas.TabIndex = 1;
            this.BtnClientesMayusculas.Text = "Clientes Mayusculas";
            this.BtnClientesMayusculas.UseVisualStyleBackColor = false;
            this.BtnClientesMayusculas.Click += new System.EventHandler(this.BtnClientesMayusculas_Click);
            // 
            // FrmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::PeluqueriaDesktop.Properties.Resources.Desarrollo22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(498, 235);
            this.Controls.Add(this.BtnClientesMayusculas);
            this.Controls.Add(this.BtnDetalleEntregas);
            this.DoubleBuffered = true;
            this.Name = "FrmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaseDeDatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDetalleEntregas;
        private System.Windows.Forms.Button BtnClientesMayusculas;
    }
}