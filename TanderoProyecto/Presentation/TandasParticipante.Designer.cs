namespace Presentation
{
    partial class TandasParticipante
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
            this.lbTandasActuales = new System.Windows.Forms.ListBox();
            this.btnUnirTanda = new System.Windows.Forms.Button();
            this.tbUnirATanda = new System.Windows.Forms.TextBox();
            this.labelTandasActuales = new System.Windows.Forms.Label();
            this.labelTandasPasadas = new System.Windows.Forms.Label();
            this.lbTandasPasadas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbTandasActuales
            // 
            this.lbTandasActuales.FormattingEnabled = true;
            this.lbTandasActuales.ItemHeight = 16;
            this.lbTandasActuales.Items.AddRange(new object[] {
            "Tanda 3",
            "Tanda 10"});
            this.lbTandasActuales.Location = new System.Drawing.Point(12, 38);
            this.lbTandasActuales.Name = "lbTandasActuales";
            this.lbTandasActuales.Size = new System.Drawing.Size(318, 148);
            this.lbTandasActuales.TabIndex = 0;
            this.lbTandasActuales.DoubleClick += new System.EventHandler(this.lbTandasActuales_DoubleClick);
            // 
            // btnUnirTanda
            // 
            this.btnUnirTanda.Location = new System.Drawing.Point(228, 379);
            this.btnUnirTanda.Name = "btnUnirTanda";
            this.btnUnirTanda.Size = new System.Drawing.Size(102, 23);
            this.btnUnirTanda.TabIndex = 1;
            this.btnUnirTanda.Text = "Unir a Tanda";
            this.btnUnirTanda.UseVisualStyleBackColor = true;
            this.btnUnirTanda.Click += new System.EventHandler(this.btnUnirTanda_Click);
            // 
            // tbUnirATanda
            // 
            this.tbUnirATanda.Location = new System.Drawing.Point(15, 379);
            this.tbUnirATanda.Name = "tbUnirATanda";
            this.tbUnirATanda.Size = new System.Drawing.Size(188, 22);
            this.tbUnirATanda.TabIndex = 2;
            // 
            // labelTandasActuales
            // 
            this.labelTandasActuales.AutoSize = true;
            this.labelTandasActuales.Location = new System.Drawing.Point(12, 18);
            this.labelTandasActuales.Name = "labelTandasActuales";
            this.labelTandasActuales.Size = new System.Drawing.Size(114, 17);
            this.labelTandasActuales.TabIndex = 3;
            this.labelTandasActuales.Text = "Tandas Actuales";
            // 
            // labelTandasPasadas
            // 
            this.labelTandasPasadas.AutoSize = true;
            this.labelTandasPasadas.Location = new System.Drawing.Point(12, 189);
            this.labelTandasPasadas.Name = "labelTandasPasadas";
            this.labelTandasPasadas.Size = new System.Drawing.Size(115, 17);
            this.labelTandasPasadas.TabIndex = 4;
            this.labelTandasPasadas.Text = "Tandas Pasadas";
            // 
            // lbTandasPasadas
            // 
            this.lbTandasPasadas.FormattingEnabled = true;
            this.lbTandasPasadas.ItemHeight = 16;
            this.lbTandasPasadas.Items.AddRange(new object[] {
            "Tanda 3",
            "Tanda 10"});
            this.lbTandasPasadas.Location = new System.Drawing.Point(12, 209);
            this.lbTandasPasadas.Name = "lbTandasPasadas";
            this.lbTandasPasadas.Size = new System.Drawing.Size(318, 148);
            this.lbTandasPasadas.TabIndex = 5;
            this.lbTandasPasadas.DoubleClick += new System.EventHandler(this.lbTandasPasadas_DoubleClick);
            // 
            // TandasParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 414);
            this.Controls.Add(this.lbTandasPasadas);
            this.Controls.Add(this.labelTandasPasadas);
            this.Controls.Add(this.labelTandasActuales);
            this.Controls.Add(this.tbUnirATanda);
            this.Controls.Add(this.btnUnirTanda);
            this.Controls.Add(this.lbTandasActuales);
            this.Name = "TandasParticipante";
            this.Text = "TandasParticipante";
            this.Load += new System.EventHandler(this.TandasParticipante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTandasActuales;
        private System.Windows.Forms.Button btnUnirTanda;
        private System.Windows.Forms.TextBox tbUnirATanda;
        private System.Windows.Forms.Label labelTandasActuales;
        private System.Windows.Forms.Label labelTandasPasadas;
        private System.Windows.Forms.ListBox lbTandasPasadas;
    }
}