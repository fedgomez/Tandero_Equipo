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
            this.lbTandasOrganizador.Location = new System.Drawing.Point(12, 12);
            this.lbTandasOrganizador.Name = "lbTandasOrganizador";
            this.lbTandasOrganizador.Size = new System.Drawing.Size(251, 324);
            this.lbTandasOrganizador.TabIndex = 0;
            this.lbTandasOrganizador.DoubleClick += new System.EventHandler(this.lbTandasOrganizador_DoubleClick);
            // 
            // TandasOrganizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 387);
            this.Controls.Add(this.lbTandasOrganizador);
            this.Name = "TandasOrganizador";
            this.Text = "TandasOrganizador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTandasOrganizador;
    }
}