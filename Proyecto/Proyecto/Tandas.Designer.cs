namespace Proyecto
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
            this.SuspendLayout();
            // 
            // btnCrearTanda
            // 
            this.btnCrearTanda.Location = new System.Drawing.Point(208, 294);
            this.btnCrearTanda.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearTanda.Name = "btnCrearTanda";
            this.btnCrearTanda.Size = new System.Drawing.Size(100, 28);
            this.btnCrearTanda.TabIndex = 1;
            this.btnCrearTanda.Text = "Crear tanda";
            this.btnCrearTanda.UseVisualStyleBackColor = true;
            this.btnCrearTanda.Click += new System.EventHandler(this.btnCrearTanda_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(208, 15);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 28);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnParticipante
            // 
            this.btnParticipante.Location = new System.Drawing.Point(107, 220);
            this.btnParticipante.Margin = new System.Windows.Forms.Padding(4);
            this.btnParticipante.Name = "btnParticipante";
            this.btnParticipante.Size = new System.Drawing.Size(100, 28);
            this.btnParticipante.TabIndex = 3;
            this.btnParticipante.Text = "Participante";
            this.btnParticipante.UseVisualStyleBackColor = true;
            this.btnParticipante.Click += new System.EventHandler(this.btnParticipante_Click);
            // 
            // btnOrganizador
            // 
            this.btnOrganizador.Location = new System.Drawing.Point(107, 142);
            this.btnOrganizador.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrganizador.Name = "btnOrganizador";
            this.btnOrganizador.Size = new System.Drawing.Size(100, 28);
            this.btnOrganizador.TabIndex = 4;
            this.btnOrganizador.Text = "Organizador";
            this.btnOrganizador.UseVisualStyleBackColor = true;
            this.btnOrganizador.Click += new System.EventHandler(this.btnOrganizador_Click_1);
            // 
            // Tandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 344);
            this.Controls.Add(this.btnOrganizador);
            this.Controls.Add(this.btnParticipante);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrearTanda);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tandas";
            this.Text = "Tandas";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnParticipante;
        private System.Windows.Forms.Button btnOrganizador;
        private System.Windows.Forms.Button btnCrearTanda;
    }
}