namespace Presentation
{
    partial class CrearTanda
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
            this.diapago = new System.Windows.Forms.TextBox();
            this.participantes = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // diapago
            // 
            this.diapago.Location = new System.Drawing.Point(47, 315);
            this.diapago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diapago.Name = "diapago";
            this.diapago.Size = new System.Drawing.Size(205, 22);
            this.diapago.TabIndex = 0;
            this.diapago.Tag = "NombreTanda";
            // 
            // participantes
            // 
            this.participantes.Location = new System.Drawing.Point(47, 363);
            this.participantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.participantes.Name = "participantes";
            this.participantes.Size = new System.Drawing.Size(205, 22);
            this.participantes.TabIndex = 1;
            this.participantes.Tag = "NombreTanda";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(388, 478);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 28);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha inicio";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 295);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dia pago";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero de participantes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 402);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(47, 422);
            this.monto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(205, 22);
            this.monto.TabIndex = 8;
            this.monto.TextChanged += new System.EventHandler(this.TextBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(47, 484);
            this.codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(205, 22);
            this.codigo.TabIndex = 10;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(47, 267);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(205, 22);
            this.nombre.TabIndex = 11;
            this.nombre.Tag = "NombreTanda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre ";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(47, 49);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.Value = new System.DateTime(2019, 10, 12, 0, 0, 0, 0);
            // 
            // CrearTanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 521);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.participantes);
            this.Controls.Add(this.diapago);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearTanda";
            this.ShowIcon = false;
            this.Text = "Crear Tanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox diapago;
        private System.Windows.Forms.TextBox participantes;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}