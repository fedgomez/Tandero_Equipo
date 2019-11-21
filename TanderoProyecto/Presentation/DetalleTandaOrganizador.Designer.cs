namespace Proyecto
{
    partial class DetalleTandaOrganizador
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
            this.LabelOrganizador = new System.Windows.Forms.Label();
            this.labelParticipntes = new System.Windows.Forms.Label();
            this.lbParticipantes = new System.Windows.Forms.ListBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelOrganizador
            // 
            this.LabelOrganizador.AutoSize = true;
            this.LabelOrganizador.Location = new System.Drawing.Point(12, 9);
            this.LabelOrganizador.Name = "LabelOrganizador";
            this.LabelOrganizador.Size = new System.Drawing.Size(87, 17);
            this.LabelOrganizador.TabIndex = 0;
            this.LabelOrganizador.Text = "Organizador";
            // 
            // labelParticipntes
            // 
            this.labelParticipntes.AutoSize = true;
            this.labelParticipntes.Location = new System.Drawing.Point(12, 75);
            this.labelParticipntes.Name = "labelParticipntes";
            this.labelParticipntes.Size = new System.Drawing.Size(90, 17);
            this.labelParticipntes.TabIndex = 1;
            this.labelParticipntes.Text = "Participantes";
            // 
            // lbParticipantes
            // 
            this.lbParticipantes.FormattingEnabled = true;
            this.lbParticipantes.ItemHeight = 16;
            this.lbParticipantes.Location = new System.Drawing.Point(15, 108);
            this.lbParticipantes.Name = "lbParticipantes";
            this.lbParticipantes.Size = new System.Drawing.Size(199, 276);
            this.lbParticipantes.TabIndex = 2;
            this.lbParticipantes.DoubleClick += new System.EventHandler(this.lbParticipantes_DoubleClick);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(15, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(246, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // DetalleTandaOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 429);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.lbParticipantes);
            this.Controls.Add(this.labelParticipntes);
            this.Controls.Add(this.LabelOrganizador);
            this.Name = "DetalleTandaOrganizador";
            this.Text = "DetalleTandaOrganizador";
            this.Load += new System.EventHandler(this.DetalleTandaOrganizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOrganizador;
        private System.Windows.Forms.Label labelParticipntes;
        private System.Windows.Forms.ListBox lbParticipantes;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnEliminar;
    }
}