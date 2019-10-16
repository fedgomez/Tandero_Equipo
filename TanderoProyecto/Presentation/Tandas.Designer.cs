namespace Presentation
{
    partial class Tandas
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
            this.btnCrearTanda = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnParticipante = new System.Windows.Forms.Button();
            this.btnOrganizador = new System.Windows.Forms.Button();
            this.btnUnirse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearTanda
            // 
            this.btnCrearTanda.Location = new System.Drawing.Point(156, 239);
            this.btnCrearTanda.Name = "btnCrearTanda";
            this.btnCrearTanda.Size = new System.Drawing.Size(75, 23);
            this.btnCrearTanda.TabIndex = 1;
            this.btnCrearTanda.Text = "Crear tanda";
            this.btnCrearTanda.UseVisualStyleBackColor = true;
            this.btnCrearTanda.Click += new System.EventHandler(this.btnCrearTanda_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(156, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnParticipante
            // 
            this.btnParticipante.Location = new System.Drawing.Point(80, 113);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(75, 23);
            this.btnParticipante.TabIndex = 3;
            this.btnParticipante.Text = "Participante";
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // btnOrganizador
            // 
            this.btnOrganizador.Location = new System.Drawing.Point(80, 64);
            this.btnOrganizador.Name = "btnOrganizador";
            this.btnOrganizador.Size = new System.Drawing.Size(75, 23);
            this.btnOrganizador.TabIndex = 4;
            this.btnOrganizador.Text = "Organizador";
            this.btnOrganizador.UseVisualStyleBackColor = true;
            this.btnOrganizador.Click += new System.EventHandler(this.BtnOrganizador_Click_1);
            // 
            // btnUnirse
            // 
            this.btnUnirse.Location = new System.Drawing.Point(70, 161);
            this.btnUnirse.Name = "btnUnirse";
            this.btnUnirse.Size = new System.Drawing.Size(95, 23);
            this.btnUnirse.TabIndex = 5;
            this.btnUnirse.Text = "Unirse a tandas";
            this.btnUnirse.UseVisualStyleBackColor = true;
            this.btnUnirse.Click += new System.EventHandler(this.BtnUnirse_Click_1);
            // 
            // Tandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 280);
            this.Controls.Add(this.btnUnirse);
            this.Controls.Add(this.btnOrganizador);
            this.Controls.Add(this.btnParticipante);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrearTanda);
            this.Name = "Tandas";
            this.Text = "Tandas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Button btnOrganizador;
        private System.Windows.Forms.Button btnCrearTanda;
        private System.Windows.Forms.Button btnUnirse;
    }
}