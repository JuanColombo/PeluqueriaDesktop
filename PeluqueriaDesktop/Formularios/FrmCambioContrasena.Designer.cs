﻿
namespace PeluqueriaDesktop
{
    partial class FrmCambioContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCambioContrasena));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarContraseña = new System.Windows.Forms.Button();
            this.lblContraseñaActual = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseñaNueva = new System.Windows.Forms.TextBox();
            this.txtContraseñaActual = new System.Windows.Forms.TextBox();
            this.lblContraseñaNueva = new System.Windows.Forms.Label();
            this.lblContraseñaNuevaConfirmacion = new System.Windows.Forms.Label();
            this.txtConfirmacionContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(283, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 40);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarContraseña
            // 
            this.btnGuardarContraseña.BackColor = System.Drawing.Color.DarkCyan;
            this.btnGuardarContraseña.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarContraseña.ForeColor = System.Drawing.Color.White;
            this.btnGuardarContraseña.Location = new System.Drawing.Point(109, 206);
            this.btnGuardarContraseña.Name = "btnGuardarContraseña";
            this.btnGuardarContraseña.Size = new System.Drawing.Size(121, 40);
            this.btnGuardarContraseña.TabIndex = 3;
            this.btnGuardarContraseña.Text = "Guardar Contraseña";
            this.btnGuardarContraseña.UseVisualStyleBackColor = false;
            this.btnGuardarContraseña.Click += new System.EventHandler(this.btnGuardarContraseña_Click);
            // 
            // lblContraseñaActual
            // 
            this.lblContraseñaActual.AutoSize = true;
            this.lblContraseñaActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseñaActual.Location = new System.Drawing.Point(129, 87);
            this.lblContraseñaActual.Name = "lblContraseñaActual";
            this.lblContraseñaActual.Size = new System.Drawing.Size(139, 21);
            this.lblContraseñaActual.TabIndex = 9;
            this.lblContraseñaActual.Text = "Contraseña Actual:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.Location = new System.Drawing.Point(161, 35);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 21);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContraseñaNueva
            // 
            this.txtContraseñaNueva.Location = new System.Drawing.Point(292, 123);
            this.txtContraseñaNueva.Name = "txtContraseñaNueva";
            this.txtContraseñaNueva.PasswordChar = '*';
            this.txtContraseñaNueva.Size = new System.Drawing.Size(151, 23);
            this.txtContraseñaNueva.TabIndex = 1;
            // 
            // txtContraseñaActual
            // 
            this.txtContraseñaActual.Location = new System.Drawing.Point(292, 89);
            this.txtContraseñaActual.Name = "txtContraseñaActual";
            this.txtContraseñaActual.PasswordChar = '*';
            this.txtContraseñaActual.Size = new System.Drawing.Size(151, 23);
            this.txtContraseñaActual.TabIndex = 0;
            // 
            // lblContraseñaNueva
            // 
            this.lblContraseñaNueva.AutoSize = true;
            this.lblContraseñaNueva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseñaNueva.Location = new System.Drawing.Point(127, 121);
            this.lblContraseñaNueva.Name = "lblContraseñaNueva";
            this.lblContraseñaNueva.Size = new System.Drawing.Size(141, 21);
            this.lblContraseñaNueva.TabIndex = 12;
            this.lblContraseñaNueva.Text = "Contraseña Nueva:";
            // 
            // lblContraseñaNuevaConfirmacion
            // 
            this.lblContraseñaNuevaConfirmacion.AutoSize = true;
            this.lblContraseñaNuevaConfirmacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContraseñaNuevaConfirmacion.Location = new System.Drawing.Point(52, 149);
            this.lblContraseñaNuevaConfirmacion.Name = "lblContraseñaNuevaConfirmacion";
            this.lblContraseñaNuevaConfirmacion.Size = new System.Drawing.Size(216, 21);
            this.lblContraseñaNuevaConfirmacion.TabIndex = 13;
            this.lblContraseñaNuevaConfirmacion.Text = "Confirmar Nueva Contraseña:";
            // 
            // txtConfirmacionContraseña
            // 
            this.txtConfirmacionContraseña.Location = new System.Drawing.Point(292, 152);
            this.txtConfirmacionContraseña.Name = "txtConfirmacionContraseña";
            this.txtConfirmacionContraseña.PasswordChar = '*';
            this.txtConfirmacionContraseña.Size = new System.Drawing.Size(151, 23);
            this.txtConfirmacionContraseña.TabIndex = 2;
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsuarioActivo.Location = new System.Drawing.Point(252, 35);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(67, 21);
            this.lblUsuarioActivo.TabIndex = 14;
            this.lblUsuarioActivo.Text = "Usuario:";
            // 
            // FrmCambioContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 275);
            this.Controls.Add(this.lblUsuarioActivo);
            this.Controls.Add(this.txtConfirmacionContraseña);
            this.Controls.Add(this.lblContraseñaNuevaConfirmacion);
            this.Controls.Add(this.lblContraseñaNueva);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarContraseña);
            this.Controls.Add(this.lblContraseñaActual);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContraseñaNueva);
            this.Controls.Add(this.txtContraseñaActual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambioContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarContraseña;
        private System.Windows.Forms.Label lblContraseñaActual;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseñaNueva;
        private System.Windows.Forms.TextBox txtContraseñaActual;
        private System.Windows.Forms.Label lblContraseñaNueva;
        private System.Windows.Forms.Label lblContraseñaNuevaConfirmacion;
        private System.Windows.Forms.TextBox txtConfirmacionContraseña;
        private System.Windows.Forms.Label lblUsuarioActivo;
    }
}