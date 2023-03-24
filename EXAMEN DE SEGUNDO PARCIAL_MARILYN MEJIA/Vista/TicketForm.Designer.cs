namespace Vista
{
    partial class TicketForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SoportecomboBox = new System.Windows.Forms.ComboBox();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.RespuestatextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Problema_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IdentidadtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DescuentotextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.ISVtextBox = new System.Windows.Forms.TextBox();
            this.SubtotaltextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GenerarBoletobutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Ticketbutton = new System.Windows.Forms.Button();
            this.Buscrabutton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Ticketbutton);
            this.groupBox3.Controls.Add(this.SoportecomboBox);
            this.groupBox3.Controls.Add(this.NumerotextBox);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.RespuestatextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Problema_textBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Candara", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(12, 211);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 97);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BOLETO";
            // 
            // SoportecomboBox
            // 
            this.SoportecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoportecomboBox.FormattingEnabled = true;
            this.SoportecomboBox.Items.AddRange(new object[] {
            "Reparacion de Hardware.",
            "Mantenimiento de software.",
            "Configuracion y personalizacion.",
            "Soporte tecnico remoto."});
            this.SoportecomboBox.Location = new System.Drawing.Point(489, 25);
            this.SoportecomboBox.Name = "SoportecomboBox";
            this.SoportecomboBox.Size = new System.Drawing.Size(241, 26);
            this.SoportecomboBox.TabIndex = 13;
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(489, 62);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(69, 26);
            this.NumerotextBox.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(403, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 18);
            this.label.TabIndex = 11;
            this.label.Text = "Ticket:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(370, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 18);
            this.label15.TabIndex = 9;
            this.label15.Text = "Tipo De Soporte:";
            // 
            // RespuestatextBox
            // 
            this.RespuestatextBox.Location = new System.Drawing.Point(95, 57);
            this.RespuestatextBox.Name = "RespuestatextBox";
            this.RespuestatextBox.Size = new System.Drawing.Size(241, 26);
            this.RespuestatextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Respuesta:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Problema_textBox
            // 
            this.Problema_textBox.Location = new System.Drawing.Point(95, 25);
            this.Problema_textBox.Name = "Problema_textBox";
            this.Problema_textBox.Size = new System.Drawing.Size(241, 26);
            this.Problema_textBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Problema:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Buscrabutton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NombretextBox);
            this.groupBox2.Controls.Add(this.IdentidadtextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Candara", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(895, 88);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENTE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(515, 23);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(238, 26);
            this.NombretextBox.TabIndex = 8;
            // 
            // IdentidadtextBox
            // 
            this.IdentidadtextBox.Location = new System.Drawing.Point(95, 25);
            this.IdentidadtextBox.Name = "IdentidadtextBox";
            this.IdentidadtextBox.Size = new System.Drawing.Size(238, 26);
            this.IdentidadtextBox.TabIndex = 6;
            this.IdentidadtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IdentidadtextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.CodigotextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USUARIO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(597, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Ticket:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Font = new System.Drawing.Font("Candara", 11.25F);
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker.Location = new System.Drawing.Point(737, 33);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(109, 26);
            this.FechadateTimePicker.TabIndex = 4;
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(95, 33);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.ReadOnly = true;
            this.CodigotextBox.Size = new System.Drawing.Size(238, 26);
            this.CodigotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADQUISICION DE BOLETOS";
            // 
            // DescuentotextBox
            // 
            this.DescuentotextBox.Font = new System.Drawing.Font("Candara", 11.25F);
            this.DescuentotextBox.Location = new System.Drawing.Point(135, 403);
            this.DescuentotextBox.Name = "DescuentotextBox";
            this.DescuentotextBox.Size = new System.Drawing.Size(130, 26);
            this.DescuentotextBox.TabIndex = 23;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Font = new System.Drawing.Font("Candara", 11.25F);
            this.TotaltextBox.Location = new System.Drawing.Point(135, 435);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(130, 26);
            this.TotaltextBox.TabIndex = 22;
            // 
            // ISVtextBox
            // 
            this.ISVtextBox.Font = new System.Drawing.Font("Candara", 11.25F);
            this.ISVtextBox.Location = new System.Drawing.Point(135, 371);
            this.ISVtextBox.Name = "ISVtextBox";
            this.ISVtextBox.ReadOnly = true;
            this.ISVtextBox.Size = new System.Drawing.Size(130, 26);
            this.ISVtextBox.TabIndex = 21;
            // 
            // SubtotaltextBox
            // 
            this.SubtotaltextBox.Font = new System.Drawing.Font("Candara", 11.25F);
            this.SubtotaltextBox.Location = new System.Drawing.Point(135, 339);
            this.SubtotaltextBox.Name = "SubtotaltextBox";
            this.SubtotaltextBox.Size = new System.Drawing.Size(130, 26);
            this.SubtotaltextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label11.Location = new System.Drawing.Point(35, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 18);
            this.label11.TabIndex = 19;
            this.label11.Text = "ISV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label10.Location = new System.Drawing.Point(35, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label9.Location = new System.Drawing.Point(35, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F);
            this.label8.Location = new System.Drawing.Point(35, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio:";
            // 
            // GenerarBoletobutton
            // 
            this.GenerarBoletobutton.Image = global::Vista.Properties.Resources.boleto;
            this.GenerarBoletobutton.Location = new System.Drawing.Point(628, 371);
            this.GenerarBoletobutton.Name = "GenerarBoletobutton";
            this.GenerarBoletobutton.Size = new System.Drawing.Size(172, 49);
            this.GenerarBoletobutton.TabIndex = 26;
            this.GenerarBoletobutton.Text = "GENERAR BOLETO";
            this.GenerarBoletobutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GenerarBoletobutton.UseVisualStyleBackColor = true;
            this.GenerarBoletobutton.Click += new System.EventHandler(this.GenerarBoletobutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Font = new System.Drawing.Font("Candara", 11.25F);
            this.Cancelarbutton.Image = global::Vista.Properties.Resources.cancelar_boleto;
            this.Cancelarbutton.Location = new System.Drawing.Point(450, 371);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(172, 49);
            this.Cancelarbutton.TabIndex = 25;
            this.Cancelarbutton.Text = "CANCELAR BOLETO";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Ticketbutton
            // 
            this.Ticketbutton.Image = global::Vista.Properties.Resources.recibo;
            this.Ticketbutton.Location = new System.Drawing.Point(577, 57);
            this.Ticketbutton.Name = "Ticketbutton";
            this.Ticketbutton.Size = new System.Drawing.Size(44, 35);
            this.Ticketbutton.TabIndex = 14;
            this.Ticketbutton.UseVisualStyleBackColor = true;
            this.Ticketbutton.Click += new System.EventHandler(this.Ticketbutton_Click);
            // 
            // Buscrabutton
            // 
            this.Buscrabutton.Image = global::Vista.Properties.Resources.lupa;
            this.Buscrabutton.Location = new System.Drawing.Point(339, 20);
            this.Buscrabutton.Name = "Buscrabutton";
            this.Buscrabutton.Size = new System.Drawing.Size(43, 34);
            this.Buscrabutton.TabIndex = 10;
            this.Buscrabutton.UseVisualStyleBackColor = true;
            this.Buscrabutton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscrabutton_KeyPress);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(931, 560);
            this.Controls.Add(this.GenerarBoletobutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.DescuentotextBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.ISVtextBox);
            this.Controls.Add(this.SubtotaltextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox RespuestatextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Problema_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox IdentidadtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescuentotextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.TextBox ISVtextBox;
        private System.Windows.Forms.TextBox SubtotaltextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GenerarBoletobutton;
        private System.Windows.Forms.Button Buscrabutton;
        private System.Windows.Forms.ComboBox SoportecomboBox;
        private System.Windows.Forms.Button Ticketbutton;
    }
}