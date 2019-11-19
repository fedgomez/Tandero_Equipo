using System.Windows.Forms;
using Domain;

namespace Proyecto
{
    partial class LoginTandero
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(39, 224);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 29);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(48, 71);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(205, 22);
            this.email.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(48, 161);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(205, 22);
            this.password.TabIndex = 2;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(45, 39);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(127, 17);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Correo del Usuario";
            this.labelMail.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(45, 132);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(81, 17);
            this.labelPass.TabIndex = 4;
            this.labelPass.Text = "Contraseña";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(189, 224);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(96, 30);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginTandero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 334);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.btnLogin);
            this.Name = "LoginTandero";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Button btnRegister;

    }
}

