﻿namespace Proyecto
{
    partial class CalificarUsuario
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
            this.btnCalificarUsuario = new System.Windows.Forms.Button();
            this.textBoxCalificarUsuario = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelRaring = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalificarUsuario
            // 
            this.btnCalificarUsuario.Location = new System.Drawing.Point(151, 83);
            this.btnCalificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificarUsuario.Name = "btnCalificarUsuario";
            this.btnCalificarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnCalificarUsuario.TabIndex = 2;
            this.btnCalificarUsuario.Text = "Calificar";
            this.btnCalificarUsuario.UseVisualStyleBackColor = true;
            this.btnCalificarUsuario.Click += new System.EventHandler(this.btnCalificarUsuario_Click);
            // 
            // textBoxCalificarUsuario
            // 
            this.textBoxCalificarUsuario.Location = new System.Drawing.Point(13, 83);
            this.textBoxCalificarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCalificarUsuario.Name = "textBoxCalificarUsuario";
            this.textBoxCalificarUsuario.Size = new System.Drawing.Size(132, 22);
            this.textBoxCalificarUsuario.TabIndex = 3;
            this.textBoxCalificarUsuario.Text = "Calificar usuario";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(22, 24);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(49, 17);
            this.labelR.TabIndex = 4;
            this.labelR.Text = "Rating";
           
            // 
            // labelRaring
            // 
            this.labelRaring.AutoSize = true;
            this.labelRaring.Location = new System.Drawing.Point(99, 24);
            this.labelRaring.Name = "labelRaring";
            this.labelRaring.Size = new System.Drawing.Size(79, 17);
            this.labelRaring.TabIndex = 5;
            this.labelRaring.Text = "labelRating";
            // 
            // CalificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 144);
            this.Controls.Add(this.labelRaring);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxCalificarUsuario);
            this.Controls.Add(this.btnCalificarUsuario);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalificarUsuario";
            this.Text = "Calificar Usuario";
            this.Load += new System.EventHandler(this.CalificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalificarUsuario;
        private System.Windows.Forms.TextBox textBoxCalificarUsuario;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelRaring;
    }
}