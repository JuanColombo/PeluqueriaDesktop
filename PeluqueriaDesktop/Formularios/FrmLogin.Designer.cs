
namespace PeluqueriaDesktop
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContraseña = new System.Windows.Forms.TextBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(98, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtUsuario.Location = new System.Drawing.Point(192, 29);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(161, 29);
            this.TxtUsuario.TabIndex = 0;
            // 
            // TxtContraseña
            // 
            this.TxtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtContraseña.Location = new System.Drawing.Point(192, 77);
            this.TxtContraseña.Name = "TxtContraseña";
            this.TxtContraseña.PasswordChar = '*';
            this.TxtContraseña.Size = new System.Drawing.Size(161, 29);
            this.TxtContraseña.TabIndex = 1;
            this.TxtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtContraseña_KeyDown);
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAcceder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnAcceder.ForeColor = System.Drawing.Color.White;
            this.BtnAcceder.Location = new System.Drawing.Point(98, 137);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(121, 40);
            this.BtnAcceder.TabIndex = 2;
            this.BtnAcceder.Text = "&Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(243, 137);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(121, 40);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 205);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAcceder);
            this.Controls.Add(this.TxtContraseña);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso a ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContraseña;
        private System.Windows.Forms.Button BtnAcceder;
        private System.Windows.Forms.Button BtnCancelar;
    }
}