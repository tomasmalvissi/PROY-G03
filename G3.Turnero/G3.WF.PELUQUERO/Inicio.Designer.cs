namespace G3.WF.PELUQUERO
{
    partial class Inicio
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEspejo = new System.Windows.Forms.Label();
            this.gr_espejo = new System.Windows.Forms.GroupBox();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.gr_espejo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblBienvenido.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblBienvenido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBienvenido.Location = new System.Drawing.Point(207, 9);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(311, 58);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "¡Bienvenido!";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(124, 137);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(444, 66);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDNI.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDNI.Location = new System.Drawing.Point(210, 91);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(273, 44);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "Ingrese su DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Honeydew;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(245, 446);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(195, 55);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(128, 265);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(444, 66);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Nombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblNombre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombre.Location = new System.Drawing.Point(98, 219);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(539, 44);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Ingrese su Nombre y Apellido";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNombre.Visible = false;
            // 
            // lblEspejo
            // 
            this.lblEspejo.AutoSize = true;
            this.lblEspejo.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblEspejo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspejo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblEspejo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEspejo.Location = new System.Drawing.Point(158, 343);
            this.lblEspejo.Name = "lblEspejo";
            this.lblEspejo.Size = new System.Drawing.Size(396, 44);
            this.lblEspejo.TabIndex = 6;
            this.lblEspejo.Text = "Seleccione su espejo";
            this.lblEspejo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEspejo.Visible = false;
            // 
            // gr_espejo
            // 
            this.gr_espejo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gr_espejo.Controls.Add(this.rb4);
            this.gr_espejo.Controls.Add(this.rb3);
            this.gr_espejo.Controls.Add(this.rb2);
            this.gr_espejo.Controls.Add(this.rb1);
            this.gr_espejo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_espejo.Location = new System.Drawing.Point(106, 389);
            this.gr_espejo.Name = "gr_espejo";
            this.gr_espejo.Size = new System.Drawing.Size(486, 47);
            this.gr_espejo.TabIndex = 7;
            this.gr_espejo.TabStop = false;
            this.gr_espejo.Text = "Espejo";
            this.gr_espejo.Visible = false;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(365, 13);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(104, 27);
            this.rb4.TabIndex = 11;
            this.rb4.TabStop = true;
            this.rb4.Text = "Espejo 4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(253, 13);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(104, 27);
            this.rb3.TabIndex = 10;
            this.rb3.TabStop = true;
            this.rb3.Text = "Espejo 3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(127, 13);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(104, 27);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "Espejo 2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(19, 13);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(104, 27);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "Espejo 1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(689, 513);
            this.Controls.Add(this.gr_espejo);
            this.Controls.Add(this.lblEspejo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.gr_espejo.ResumeLayout(false);
            this.gr_espejo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEspejo;
        private System.Windows.Forms.GroupBox gr_espejo;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
    }
}

