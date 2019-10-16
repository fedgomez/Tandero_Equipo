namespace Proyecto
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
            this.lbTandas = new System.Windows.Forms.ListBox();
            this.btnUnirTanda = new System.Windows.Forms.Button();
            this.tbUnirATanda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTandas
            // 
            this.lbTandas.FormattingEnabled = true;
            this.lbTandas.ItemHeight = 16;
            this.lbTandas.Items.AddRange(new object[] {
            "Tanda 3",
            "Tanda 10"});
            this.lbTandas.Location = new System.Drawing.Point(12, 27);
            this.lbTandas.Name = "lbTandas";
            this.lbTandas.Size = new System.Drawing.Size(297, 276);
            this.lbTandas.TabIndex = 0;
            this.lbTandas.DoubleClick += new System.EventHandler(this.lbTandas_DoubleClick);
            // 
            // btnUnirTanda
            // 
            this.btnUnirTanda.Location = new System.Drawing.Point(207, 349);
            this.btnUnirTanda.Name = "btnUnirTanda";
            this.btnUnirTanda.Size = new System.Drawing.Size(102, 23);
            this.btnUnirTanda.TabIndex = 1;
            this.btnUnirTanda.Text = "Unir a Tanda";
            this.btnUnirTanda.UseVisualStyleBackColor = true;
            this.btnUnirTanda.Click += new System.EventHandler(this.btnUnirTanda_Click);
            // 
            // tbUnirATanda
            // 
            this.tbUnirATanda.Location = new System.Drawing.Point(13, 349);
            this.tbUnirATanda.Name = "tbUnirATanda";
            this.tbUnirATanda.Size = new System.Drawing.Size(188, 22);
            this.tbUnirATanda.TabIndex = 2;
            // 
            // TandasParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 414);
            this.Controls.Add(this.tbUnirATanda);
            this.Controls.Add(this.btnUnirTanda);
            this.Controls.Add(this.lbTandas);
            this.Name = "TandasParticipante";
            this.Text = "TandasParticipante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTandas;
        private System.Windows.Forms.Button btnUnirTanda;
        private System.Windows.Forms.TextBox tbUnirATanda;
    }
}