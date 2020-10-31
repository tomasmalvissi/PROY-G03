namespace G3.WF
{
    partial class Turno
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
            this.lblPeluquero = new System.Windows.Forms.Label();
            this.listBoxPelluqueros = new System.Windows.Forms.ListBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBoxTarea = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblPeluquero
            // 
            this.lblPeluquero.AutoSize = true;
            this.lblPeluquero.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblPeluquero.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluquero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPeluquero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeluquero.Location = new System.Drawing.Point(141, 35);
            this.lblPeluquero.Name = "lblPeluquero";
            this.lblPeluquero.Size = new System.Drawing.Size(375, 36);
            this.lblPeluquero.TabIndex = 6;
            this.lblPeluquero.Text = "Seleccioná un profesional";
            this.lblPeluquero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeluquero.Click += new System.EventHandler(this.lblPeluquero_Click);
            // 
            // listBoxPelluqueros
            // 
            this.listBoxPelluqueros.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPelluqueros.FormattingEnabled = true;
            this.listBoxPelluqueros.ItemHeight = 24;
            this.listBoxPelluqueros.Items.AddRange(new object[] {
            "Peluquero A",
            "Peluquero B",
            "Peluquero C",
            "Peluquero D"});
            this.listBoxPelluqueros.Location = new System.Drawing.Point(147, 87);
            this.listBoxPelluqueros.Name = "listBoxPelluqueros";
            this.listBoxPelluqueros.Size = new System.Drawing.Size(369, 28);
            this.listBoxPelluqueros.TabIndex = 7;
            this.listBoxPelluqueros.SelectedIndexChanged += new System.EventHandler(this.listBoxPelluqueros_SelectedIndexChanged);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblDateTime.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Location = new System.Drawing.Point(161, 146);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(345, 36);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Seleccioná fecha y hora";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(167, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(333, 28);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Honeydew;
            this.btnContinuar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(352, 408);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(152, 44);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(183, 408);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 44);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(107, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Elegí el/los servicio/s que quieras";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkedListBoxTarea
            // 
            this.checkedListBoxTarea.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxTarea.FormattingEnabled = true;
            this.checkedListBoxTarea.Items.AddRange(new object[] {
            "Corte",
            "Tintura",
            "Lavado",
            "Baño de crema"});
            this.checkedListBoxTarea.Location = new System.Drawing.Point(173, 295);
            this.checkedListBoxTarea.Name = "checkedListBoxTarea";
            this.checkedListBoxTarea.Size = new System.Drawing.Size(343, 96);
            this.checkedListBoxTarea.TabIndex = 13;
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(692, 473);
            this.Controls.Add(this.checkedListBoxTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.listBoxPelluqueros);
            this.Controls.Add(this.lblPeluquero);
            this.Name = "Turno";
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeluquero;
        private System.Windows.Forms.ListBox listBoxPelluqueros;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBoxTarea;
    }
}