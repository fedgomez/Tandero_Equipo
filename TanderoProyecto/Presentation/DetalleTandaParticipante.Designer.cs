namespace Proyecto
{
    partial class DetalleTandaParticipante
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbParticipantes = new System.Windows.Forms.ListBox();
            this.btnRating = new System.Windows.Forms.Button();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelMontoTxt = new System.Windows.Forms.Label();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelFechaPagoTxt = new System.Windows.Forms.Label();
            this.labelFechaPago = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organizador";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 40);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Participantes";
            // 
            // lbParticipantes
            // 
            this.lbParticipantes.FormattingEnabled = true;
            this.lbParticipantes.ItemHeight = 16;
            this.lbParticipantes.Location = new System.Drawing.Point(16, 139);
            this.lbParticipantes.Name = "lbParticipantes";
            this.lbParticipantes.Size = new System.Drawing.Size(179, 244);
            this.lbParticipantes.TabIndex = 4;
            // 
            // btnRating
            // 
            this.btnRating.Location = new System.Drawing.Point(171, 27);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(122, 30);
            this.btnRating.TabIndex = 5;
            this.btnRating.Text = "Asignar Rating";
            this.btnRating.UseVisualStyleBackColor = true;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(322, 34);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(44, 17);
            this.labelRating.TabIndex = 6;
            this.labelRating.Text = "rating";
            // 
            // labelMontoTxt
            // 
            this.labelMontoTxt.AutoSize = true;
            this.labelMontoTxt.Location = new System.Drawing.Point(13, 66);
            this.labelMontoTxt.Name = "labelMontoTxt";
            this.labelMontoTxt.Size = new System.Drawing.Size(47, 17);
            this.labelMontoTxt.TabIndex = 7;
            this.labelMontoTxt.Text = "Monto";
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(66, 66);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(47, 17);
            this.labelMonto.TabIndex = 8;
            this.labelMonto.Text = "Monto";
            // 
            // labelFechaPagoTxt
            // 
            this.labelFechaPagoTxt.AutoSize = true;
            this.labelFechaPagoTxt.Location = new System.Drawing.Point(13, 93);
            this.labelFechaPagoTxt.Name = "labelFechaPagoTxt";
            this.labelFechaPagoTxt.Size = new System.Drawing.Size(104, 17);
            this.labelFechaPagoTxt.TabIndex = 9;
            this.labelFechaPagoTxt.Text = "Fecha de Pago";
            // 
            // labelFechaPago
            // 
            this.labelFechaPago.AutoSize = true;
            this.labelFechaPago.Location = new System.Drawing.Point(123, 93);
            this.labelFechaPago.Name = "labelFechaPago";
            this.labelFechaPago.Size = new System.Drawing.Size(104, 17);
            this.labelFechaPago.TabIndex = 10;
            this.labelFechaPago.Text = "Fecha de Pago";
            // 
            // DetalleTandaParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 400);
            this.Controls.Add(this.labelFechaPago);
            this.Controls.Add(this.labelFechaPagoTxt);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.labelMontoTxt);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.btnRating);
            this.Controls.Add(this.lbParticipantes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Name = "DetalleTandaParticipante";
            this.Text = "DetalleTandaParticipante";
            this.Load += new System.EventHandler(this.DetalleTandaParticipante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbParticipantes;
        private System.Windows.Forms.Button btnRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelMontoTxt;
        private System.Windows.Forms.Label labelMonto;
        private System.Windows.Forms.Label labelFechaPagoTxt;
        private System.Windows.Forms.Label labelFechaPago;
    }
}