
namespace PeluqueriaDesktop
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.chkVerEliminados = new System.Windows.Forms.CheckBox();
            this.BtnStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Location = new System.Drawing.Point(75, 324);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(402, 23);
            this.TxtBusqueda.TabIndex = 6;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged_1);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Location = new System.Drawing.Point(24, 328);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(45, 15);
            this.LblBuscar.TabIndex = 13;
            this.LblBuscar.Text = "Buscar ";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(672, 390);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(121, 40);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(288, 390);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(121, 40);
            this.BtnEliminar.TabIndex = 3;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.Location = new System.Drawing.Point(158, 390);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(121, 40);
            this.BtnEditar.TabIndex = 2;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNuevo.Location = new System.Drawing.Point(31, 390);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(121, 40);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click_1);
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(12, 46);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowTemplate.Height = 25;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(776, 252);
            this.Grid.TabIndex = 0;
            // 
            // chkVerEliminados
            // 
            this.chkVerEliminados.AutoSize = true;
            this.chkVerEliminados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chkVerEliminados.Location = new System.Drawing.Point(655, 304);
            this.chkVerEliminados.Name = "chkVerEliminados";
            this.chkVerEliminados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkVerEliminados.Size = new System.Drawing.Size(133, 25);
            this.chkVerEliminados.TabIndex = 7;
            this.chkVerEliminados.Text = "Ver Eliminados";
            this.chkVerEliminados.UseVisualStyleBackColor = true;
            this.chkVerEliminados.CheckedChanged += new System.EventHandler(this.chkVerEliminados_CheckedChanged_1);
            // 
            // BtnStock
            // 
            this.BtnStock.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnStock.Location = new System.Drawing.Point(423, 390);
            this.BtnStock.Name = "BtnStock";
            this.BtnStock.Size = new System.Drawing.Size(121, 40);
            this.BtnStock.TabIndex = 4;
            this.BtnStock.Text = "Stock";
            this.BtnStock.UseVisualStyleBackColor = false;
            this.BtnStock.Click += new System.EventHandler(this.BtnStock_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnStock);
            this.Controls.Add(this.chkVerEliminados);
            this.Controls.Add(this.TxtBusqueda);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.CheckBox chkVerEliminados;
        private System.Windows.Forms.Button BtnStock;
    }
}