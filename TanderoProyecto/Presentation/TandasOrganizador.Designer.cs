namespace Proyecto
{
    partial class TandasOrganizador
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
            this.lbTandasOrganizador = new System.Windows.Forms.ListBox();
            this.lbTandasPasadas = new System.Windows.Forms.ListBox();
            this.labelTandasActuales = new System.Windows.Forms.Label();
            this.labelTandasPasadas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTandasOrganizador
            // 
            this.lbTandasOrganizador.FormattingEnabled = true;
            this.lbTandasOrganizador.ItemHeight = 16;
            this.lbTandasOrganizador.Items.AddRange(new object[] {
            "Tanda 3",
            "Tanda 7",
            "Tanda 10"});
            this.lbTandasOrganizador.Location = new System.Drawing.Point(12, 27);
            this.lbTandasOrganizador.Name = "lbTandasOrganizador";
            this.lbTandasOrganizador.Size = new System.Drawing.Size(251, 148);
            this.lbTandasOrganizador.TabIndex = 0;
            this.lbTandasOrganizador.DoubleClick += new System.EventHandler(this.lbTandasOrganizador_DoubleClick);
            // 
            // lbTandasPasadas
            // 
            this.lbTandasPasadas.FormattingEnabled = true;
            this.lbTandasPasadas.ItemHeight = 16;
            this.lbTandasPasadas.Items.AddRange(new object[] {
            "Tanda 3",
            "Tanda 7",
            "Tanda 10"});
            this.lbTandasPasadas.Location = new System.Drawing.Point(12, 207);
            this.lbTandasPasadas.Name = "lbTandasPasadas";
            this.lbTandasPasadas.Size = new System.Drawing.Size(251, 148);
            this.lbTandasPasadas.TabIndex = 1;
            this.lbTandasPasadas.DoubleClick += new System.EventHandler(this.lbTandasPasadas_DoubleClick);
            // 
            // labelTandasActuales
            // 
            this.labelTandasActuales.AutoSize = true;
            this.labelTandasActuales.Location = new System.Drawing.Point(12, 7);
            this.labelTandasActuales.Name = "labelTandasActuales";
            this.labelTandasActuales.Size = new System.Drawing.Size(114, 17);
            this.labelTandasActuales.TabIndex = 2;
            this.labelTandasActuales.Text = "Tandas Actuales";
            // 
            // labelTandasPasadas
            // 
            this.labelTandasPasadas.AutoSize = true;
            this.labelTandasPasadas.Location = new System.Drawing.Point(12, 187);
            this.labelTandasPasadas.Name = "labelTandasPasadas";
            this.labelTandasPasadas.Size = new System.Drawing.Size(115, 17);
            this.labelTandasPasadas.TabIndex = 3;
            this.labelTandasPasadas.Text = "Tandas Pasadas";
            // 
            // TandasOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 387);
            this.Controls.Add(this.labelTandasPasadas);
            this.Controls.Add(this.labelTandasActuales);
            this.Controls.Add(this.lbTandasPasadas);
            this.Controls.Add(this.lbTandasOrganizador);
            this.Name = "TandasOrganizador";
            this.Text = "TandasOrganizador";
            this.Load += new System.EventHandler(this.TandasOrganizador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTandasOrganizador;
        private System.Windows.Forms.ListBox lbTandasPasadas;
        private System.Windows.Forms.Label labelTandasActuales;
        private System.Windows.Forms.Label labelTandasPasadas;
    }
}