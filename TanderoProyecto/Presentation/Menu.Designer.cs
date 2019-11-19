namespace Proyecto
{
    partial class Menu
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.btnTandas = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(38, 42);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(58, 17);
            this.nombreLabel.TabIndex = 1;
            this.nombreLabel.Text = "Nombre";
            this.nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // btnTandas
            // 
            this.btnTandas.Location = new System.Drawing.Point(41, 135);
            this.btnTandas.Name = "btnTandas";
            this.btnTandas.Size = new System.Drawing.Size(75, 23);
            this.btnTandas.TabIndex = 3;
            this.btnTandas.Text = "Tandas";
            this.btnTandas.UseVisualStyleBackColor = true;
            this.btnTandas.Click += new System.EventHandler(this.btnTandas_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(147, 135);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(252, 135);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(109, 23);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button3_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(262, 13);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(49, 17);
            this.Rating.TabIndex = 6;
            this.Rating.Text = "Rating";
            this.Rating.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(265, 42);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(46, 17);
            this.labelRating.TabIndex = 7;
            this.labelRating.Text = "label2";
            this.labelRating.Click += new System.EventHandler(this.label2_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(383, 189);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(20, 23);
            this.helpButton.TabIndex = 8;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 215);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnTandas);
            this.Controls.Add(this.nombreLabel);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button btnTandas;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Button helpButton;
    }
}