
namespace PeluqueriaDesktop
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuNuevoCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegistrarTrabajo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.MnuConfiguracion,
            this.MnuUsuario});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(952, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuNuevoCliente});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // subMnuNuevoCliente
            // 
            this.subMnuNuevoCliente.Name = "subMnuNuevoCliente";
            this.subMnuNuevoCliente.Size = new System.Drawing.Size(180, 22);
            this.subMnuNuevoCliente.Text = "Gestion de Clientes";
            this.subMnuNuevoCliente.Click += new System.EventHandler(this.subMnuNuevoCliente_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuNuevoProducto});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // subMnuNuevoProducto
            // 
            this.subMnuNuevoProducto.Name = "subMnuNuevoProducto";
            this.subMnuNuevoProducto.Size = new System.Drawing.Size(178, 22);
            this.subMnuNuevoProducto.Text = "Carga de productos";
            this.subMnuNuevoProducto.Click += new System.EventHandler(this.subMnuNuevoProducto_Click);
            // 
            // MnuConfiguracion
            // 
            this.MnuConfiguracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuParametros});
            this.MnuConfiguracion.Name = "MnuConfiguracion";
            this.MnuConfiguracion.Size = new System.Drawing.Size(95, 20);
            this.MnuConfiguracion.Text = "Configuracion";
            // 
            // subMnuParametros
            // 
            this.subMnuParametros.Name = "subMnuParametros";
            this.subMnuParametros.Size = new System.Drawing.Size(134, 22);
            this.subMnuParametros.Text = "Parametros";
            this.subMnuParametros.Click += new System.EventHandler(this.subMnuParametros_Click);
            // 
            // MnuUsuario
            // 
            this.MnuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuGestionUsuarios,
            this.cambioDeContraseñaToolStripMenuItem});
            this.MnuUsuario.Name = "MnuUsuario";
            this.MnuUsuario.Size = new System.Drawing.Size(64, 20);
            this.MnuUsuario.Text = "Usuarios";
            // 
            // subMnuGestionUsuarios
            // 
            this.subMnuGestionUsuarios.Name = "subMnuGestionUsuarios";
            this.subMnuGestionUsuarios.Size = new System.Drawing.Size(193, 22);
            this.subMnuGestionUsuarios.Text = "Gestion de Usuarios";
            this.subMnuGestionUsuarios.Click += new System.EventHandler(this.subMnuGestionUsuarios_Click);
            // 
            // cambioDeContraseñaToolStripMenuItem
            // 
            this.cambioDeContraseñaToolStripMenuItem.Name = "cambioDeContraseñaToolStripMenuItem";
            this.cambioDeContraseñaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cambioDeContraseñaToolStripMenuItem.Text = "Cambio de contraseña";
            this.cambioDeContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambioDeContraseñaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(351, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salon A Peluqueria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegistrarTrabajo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 57);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnRegistrarTrabajo
            // 
            this.BtnRegistrarTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarTrabajo.Image")));
            this.BtnRegistrarTrabajo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRegistrarTrabajo.Name = "BtnRegistrarTrabajo";
            this.BtnRegistrarTrabajo.Size = new System.Drawing.Size(54, 54);
            this.BtnRegistrarTrabajo.Text = "Trabajos";
            this.BtnRegistrarTrabajo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 442);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon A Peluqueria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMnuNuevoCliente;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMnuNuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem MnuConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem subMnuParametros;
        private System.Windows.Forms.ToolStripMenuItem MnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem subMnuGestionUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cambioDeContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnRegistrarTrabajo;
    }
}

