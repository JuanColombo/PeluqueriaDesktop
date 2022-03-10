
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
            this.MnuTrabajos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuListadoTrabajos = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuListadoTurnos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConfiguracion = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuParametros = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.cambioDeContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnRegistrarTrabajo = new System.Windows.Forms.ToolStripButton();
            this.BtnCargarTurno = new System.Windows.Forms.ToolStripButton();
            this.BtnCaja = new System.Windows.Forms.ToolStripButton();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PbDesarrollo22 = new System.Windows.Forms.PictureBox();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnTrabajo = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDesarrollo22)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.MnuTrabajos,
            this.MnuConfiguracion,
            this.MnuUsuario,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
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
            this.subMnuNuevoCliente.Size = new System.Drawing.Size(175, 22);
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
            // MnuTrabajos
            // 
            this.MnuTrabajos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuListadoTrabajos,
            this.subMnuListadoTurnos});
            this.MnuTrabajos.Name = "MnuTrabajos";
            this.MnuTrabajos.Size = new System.Drawing.Size(57, 20);
            this.MnuTrabajos.Text = "Listado";
            // 
            // subMnuListadoTrabajos
            // 
            this.subMnuListadoTrabajos.Name = "subMnuListadoTrabajos";
            this.subMnuListadoTrabajos.Size = new System.Drawing.Size(176, 22);
            this.subMnuListadoTrabajos.Text = "Ver LIstado trabajos";
            this.subMnuListadoTrabajos.Click += new System.EventHandler(this.subMnuListadoTrabajos_Click);
            // 
            // subMnuListadoTurnos
            // 
            this.subMnuListadoTurnos.Name = "subMnuListadoTurnos";
            this.subMnuListadoTurnos.Size = new System.Drawing.Size(176, 22);
            this.subMnuListadoTurnos.Text = "Ver Listado Turnos";
            this.subMnuListadoTurnos.Click += new System.EventHandler(this.subMnuListadoTurnos_Click);
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
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Clarendon Blk BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salon A Peluqueria";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnRegistrarTrabajo,
            this.BtnCargarTurno,
            this.BtnCaja});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 57);
            this.toolStrip1.TabIndex = 1;
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
            this.BtnRegistrarTrabajo.Click += new System.EventHandler(this.BtnRegistrarTrabajo_Click);
            // 
            // BtnCargarTurno
            // 
            this.BtnCargarTurno.Image = ((System.Drawing.Image)(resources.GetObject("BtnCargarTurno.Image")));
            this.BtnCargarTurno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCargarTurno.Name = "BtnCargarTurno";
            this.BtnCargarTurno.Size = new System.Drawing.Size(47, 54);
            this.BtnCargarTurno.Text = "Turnos";
            this.BtnCargarTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCargarTurno.Click += new System.EventHandler(this.BtnCargarTurno_Click);
            // 
            // BtnCaja
            // 
            this.BtnCaja.Image = ((System.Drawing.Image)(resources.GetObject("BtnCaja.Image")));
            this.BtnCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCaja.Name = "BtnCaja";
            this.BtnCaja.Size = new System.Drawing.Size(39, 54);
            this.BtnCaja.Text = "Caja";
            this.BtnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnCaja.Click += new System.EventHandler(this.BtnCaja_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClientes.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClientes.Location = new System.Drawing.Point(693, 84);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(124, 48);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(186, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 125);
            this.panel1.TabIndex = 3;
            // 
            // PbDesarrollo22
            // 
            this.PbDesarrollo22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PbDesarrollo22.BackColor = System.Drawing.Color.Transparent;
            this.PbDesarrollo22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbDesarrollo22.BackgroundImage")));
            this.PbDesarrollo22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbDesarrollo22.Location = new System.Drawing.Point(708, 325);
            this.PbDesarrollo22.Name = "PbDesarrollo22";
            this.PbDesarrollo22.Size = new System.Drawing.Size(109, 111);
            this.PbDesarrollo22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbDesarrollo22.TabIndex = 4;
            this.PbDesarrollo22.TabStop = false;
            this.PbDesarrollo22.Click += new System.EventHandler(this.PbDesarrollo22_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProductos.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProductos.Location = new System.Drawing.Point(693, 138);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Size = new System.Drawing.Size(124, 48);
            this.BtnProductos.TabIndex = 5;
            this.BtnProductos.Text = "Productos";
            this.BtnProductos.UseVisualStyleBackColor = false;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnTrabajo
            // 
            this.BtnTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTrabajo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnTrabajo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTrabajo.Location = new System.Drawing.Point(693, 192);
            this.BtnTrabajo.Name = "BtnTrabajo";
            this.BtnTrabajo.Size = new System.Drawing.Size(124, 48);
            this.BtnTrabajo.TabIndex = 6;
            this.BtnTrabajo.Text = "Registrar Trabajo";
            this.BtnTrabajo.UseVisualStyleBackColor = false;
            this.BtnTrabajo.Click += new System.EventHandler(this.BtnTrabajo_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 438);
            this.Controls.Add(this.BtnTrabajo);
            this.Controls.Add(this.BtnProductos);
            this.Controls.Add(this.PbDesarrollo22);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon A Peluqueria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmMenuPrincipal_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbDesarrollo22)).EndInit();
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
        private System.Windows.Forms.ToolStripButton BtnCargarTurno;
        private System.Windows.Forms.ToolStripMenuItem MnuTrabajos;
        private System.Windows.Forms.ToolStripMenuItem subMnuListadoTrabajos;
        private System.Windows.Forms.ToolStripMenuItem subMnuListadoTurnos;
        private System.Windows.Forms.ToolStripButton BtnCaja;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PbDesarrollo22;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Button BtnTrabajo;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}

