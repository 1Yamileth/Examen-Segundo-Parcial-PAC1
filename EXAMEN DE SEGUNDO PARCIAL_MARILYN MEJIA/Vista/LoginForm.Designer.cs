namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Contra_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Usuario_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Mostrar_button = new System.Windows.Forms.Button();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.Ingresar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Contra_textBox
            // 
            this.Contra_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contra_textBox.Location = new System.Drawing.Point(153, 84);
            this.Contra_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Contra_textBox.Name = "Contra_textBox";
            this.Contra_textBox.PasswordChar = '*';
            this.Contra_textBox.Size = new System.Drawing.Size(234, 26);
            this.Contra_textBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // Usuario_textBox
            // 
            this.Usuario_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario_textBox.Location = new System.Drawing.Point(153, 33);
            this.Usuario_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Usuario_textBox.Name = "Usuario_textBox";
            this.Usuario_textBox.Size = new System.Drawing.Size(234, 26);
            this.Usuario_textBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "USUARIO:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mostrar_button
            // 
            this.Mostrar_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mostrar_button.Image = global::Vista.Properties.Resources.ver;
            this.Mostrar_button.Location = new System.Drawing.Point(395, 87);
            this.Mostrar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Mostrar_button.Name = "Mostrar_button";
            this.Mostrar_button.Size = new System.Drawing.Size(39, 28);
            this.Mostrar_button.TabIndex = 13;
            this.Mostrar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mostrar_button.UseVisualStyleBackColor = true;
            this.Mostrar_button.Click += new System.EventHandler(this.Mostrar_button_Click);
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar_Button.Image = global::Vista.Properties.Resources.boton_x;
            this.Cancelar_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelar_Button.Location = new System.Drawing.Point(231, 147);
            this.Cancelar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(138, 33);
            this.Cancelar_Button.TabIndex = 12;
            this.Cancelar_Button.Text = "CANCELAR";
            this.Cancelar_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelar_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            this.Cancelar_Button.Click += new System.EventHandler(this.Cancelar_Button_Click);
            // 
            // Ingresar_button
            // 
            this.Ingresar_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresar_button.Image = global::Vista.Properties.Resources.cheque;
            this.Ingresar_button.Location = new System.Drawing.Point(395, 147);
            this.Ingresar_button.Margin = new System.Windows.Forms.Padding(4);
            this.Ingresar_button.Name = "Ingresar_button";
            this.Ingresar_button.Size = new System.Drawing.Size(138, 33);
            this.Ingresar_button.TabIndex = 9;
            this.Ingresar_button.Text = "INGRESAR";
            this.Ingresar_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ingresar_button.UseVisualStyleBackColor = true;
            this.Ingresar_button.Click += new System.EventHandler(this.Ingresar_button_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Ingresar_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.CancelButton = this.Cancelar_Button;
            this.ClientSize = new System.Drawing.Size(539, 191);
            this.ControlBox = false;
            this.Controls.Add(this.Mostrar_button);
            this.Controls.Add(this.Cancelar_Button);
            this.Controls.Add(this.Contra_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ingresar_button);
            this.Controls.Add(this.Usuario_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mostrar_button;
        private System.Windows.Forms.Button Cancelar_Button;
        private System.Windows.Forms.TextBox Contra_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Ingresar_button;
        private System.Windows.Forms.TextBox Usuario_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

