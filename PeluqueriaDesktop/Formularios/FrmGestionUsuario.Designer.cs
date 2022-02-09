
namespace PeluqueriaDesktop
{
    partial class FrmGestionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionUsuario));
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.BtnEditarUsuario = new System.Windows.Forms.Button();
            this.BtnAñadirUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(12, 42);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.ReadOnly = true;
            this.dataGridUsuarios.RowTemplate.Height = 25;
            this.dataGridUsuarios.Size = new System.Drawing.Size(712, 259);
            this.dataGridUsuarios.TabIndex = 0;
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEliminarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEliminarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(288, 307);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(121, 40);
            this.BtnEliminarUsuario.TabIndex = 3;
            this.BtnEliminarUsuario.Text = "Eliminar";
            this.BtnEliminarUsuario.UseVisualStyleBackColor = false;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // BtnEditarUsuario
            // 
            this.BtnEditarUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEditarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnEditarUsuario.Location = new System.Drawing.Point(153, 307);
            this.BtnEditarUsuario.Name = "BtnEditarUsuario";
            this.BtnEditarUsuario.Size = new System.Drawing.Size(121, 40);
            this.BtnEditarUsuario.TabIndex = 2;
            this.BtnEditarUsuario.Text = "Editar";
            this.BtnEditarUsuario.UseVisualStyleBackColor = false;
            this.BtnEditarUsuario.Click += new System.EventHandler(this.BtnEditarUsuario_Click);
            // 
            // BtnAñadirUsuario
            // 
            this.BtnAñadirUsuario.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAñadirUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAñadirUsuario.ForeColor = System.Drawing.Color.White;
            this.BtnAñadirUsuario.Location = new System.Drawing.Point(26, 307);
            this.BtnAñadirUsuario.Name = "BtnAñadirUsuario";
            this.BtnAñadirUsuario.Size = new System.Drawing.Size(121, 40);
            this.BtnAñadirUsuario.TabIndex = 1;
            this.BtnAñadirUsuario.Text = "Añadir";
            this.BtnAñadirUsuario.UseVisualStyleBackColor = false;
            this.BtnAñadirUsuario.Click += new System.EventHandler(this.BtnAñadirUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(585, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 40);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraseña.Location = new System.Drawing.Point(424, 307);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(121, 40);
            this.btnCambiarContraseña.TabIndex = 4;
            this.btnCambiarContraseña.Text = "Cambiar Contraseña";
            this.btnCambiarContraseña.UseVisualStyleBackColor = false;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // FrmGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 364);
            this.Controls.Add(this.btnCambiarContraseña);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BtnEliminarUsuario);
            this.Controls.Add(this.BtnEditarUsuario);
            this.Controls.Add(this.BtnAñadirUsuario);
            this.Controls.Add(this.dataGridUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGestionUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.Button BtnEditarUsuario;
        private System.Windows.Forms.Button BtnAñadirUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambiarContraseña;
    }
}