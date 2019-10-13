namespace Proyecto
{
    partial class CalificarOrganizador
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCalificarOrg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Calificar Organizador";
            // 
            // btnCalificarOrg
            // 
            this.btnCalificarOrg.Location = new System.Drawing.Point(112, 63);
            this.btnCalificarOrg.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalificarOrg.Name = "btnCalificarOrg";
            this.btnCalificarOrg.Size = new System.Drawing.Size(100, 28);
            this.btnCalificarOrg.TabIndex = 1;
            this.btnCalificarOrg.Text = "Calificar";
            this.btnCalificarOrg.UseVisualStyleBackColor = true;
            this.btnCalificarOrg.Click += new System.EventHandler(this.btnCalificarOrg_Click);
            // 
            // CalificarOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 138);
            this.Controls.Add(this.btnCalificarOrg);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalificarOrganizador";
            this.Text = "Calificar Organizador";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCalificarOrg;
    }
}