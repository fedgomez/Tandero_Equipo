namespace Proyecto
{
    partial class Perfil
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRatingO = new System.Windows.Forms.Label();
            this.labelRatingP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rating Organizador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rating Usuario";
            // 
            // labelRatingO
            // 
            this.labelRatingO.AutoSize = true;
            this.labelRatingO.Location = new System.Drawing.Point(15, 224);
            this.labelRatingO.Name = "labelRatingO";
            this.labelRatingO.Size = new System.Drawing.Size(46, 17);
            this.labelRatingO.TabIndex = 2;
            this.labelRatingO.Text = "label3";
            // 
            // labelRatingP
            // 
            this.labelRatingP.AutoSize = true;
            this.labelRatingP.Location = new System.Drawing.Point(15, 291);
            this.labelRatingP.Name = "labelRatingP";
            this.labelRatingP.Size = new System.Drawing.Size(46, 17);
            this.labelRatingP.TabIndex = 3;
            this.labelRatingP.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Correo";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 100);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 17);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Nombre";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(3, 3);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "<- Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(12, 158);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(33, 17);
            this.labelEmail.TabIndex = 9;
            this.labelEmail.Text = "mail";
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 371);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelRatingP);
            this.Controls.Add(this.labelRatingO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRatingO;
        private System.Windows.Forms.Label labelRatingP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label labelEmail;
    }
}