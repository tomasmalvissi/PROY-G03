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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPeluquero = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Tintura = new System.Windows.Forms.RadioButton();
            this.rb_Crema = new System.Windows.Forms.RadioButton();
            this.rb_Lavado = new System.Windows.Forms.RadioButton();
            this.rb_Corte = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Id_Hs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPeluquero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peluquero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Peluquero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPeluquero
            // 
            this.lblPeluquero.AutoSize = true;
            this.lblPeluquero.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblPeluquero.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeluquero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblPeluquero.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeluquero.Location = new System.Drawing.Point(12, 48);
            this.lblPeluquero.Name = "lblPeluquero";
            this.lblPeluquero.Size = new System.Drawing.Size(489, 33);
            this.lblPeluquero.TabIndex = 6;
            this.lblPeluquero.Text = "Busque su peluquero de preferencia";
            this.lblPeluquero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Location = new System.Drawing.Point(549, 48);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(392, 33);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Seleccione una fecha y hora";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnContinuar
            // 
            this.btnContinuar.BackColor = System.Drawing.Color.Honeydew;
            this.btnContinuar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.Location = new System.Drawing.Point(477, 389);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(155, 44);
            this.btnContinuar.TabIndex = 10;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(308, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 44);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(75, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Seleccione un servicio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Tintura);
            this.groupBox1.Controls.Add(this.rb_Crema);
            this.groupBox1.Controls.Add(this.rb_Lavado);
            this.groupBox1.Controls.Add(this.rb_Corte);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicio";
            // 
            // rb_Tintura
            // 
            this.rb_Tintura.AutoSize = true;
            this.rb_Tintura.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Tintura.Location = new System.Drawing.Point(201, 68);
            this.rb_Tintura.Name = "rb_Tintura";
            this.rb_Tintura.Size = new System.Drawing.Size(88, 27);
            this.rb_Tintura.TabIndex = 3;
            this.rb_Tintura.TabStop = true;
            this.rb_Tintura.Text = "Tintura";
            this.rb_Tintura.UseVisualStyleBackColor = true;
            // 
            // rb_Crema
            // 
            this.rb_Crema.AutoSize = true;
            this.rb_Crema.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Crema.Location = new System.Drawing.Point(41, 68);
            this.rb_Crema.Name = "rb_Crema";
            this.rb_Crema.Size = new System.Drawing.Size(92, 27);
            this.rb_Crema.TabIndex = 2;
            this.rb_Crema.TabStop = true;
            this.rb_Crema.Text = "Crema";
            this.rb_Crema.UseVisualStyleBackColor = true;
            // 
            // rb_Lavado
            // 
            this.rb_Lavado.AutoSize = true;
            this.rb_Lavado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Lavado.Location = new System.Drawing.Point(201, 20);
            this.rb_Lavado.Name = "rb_Lavado";
            this.rb_Lavado.Size = new System.Drawing.Size(98, 27);
            this.rb_Lavado.TabIndex = 1;
            this.rb_Lavado.TabStop = true;
            this.rb_Lavado.Text = "Lavado";
            this.rb_Lavado.UseVisualStyleBackColor = true;
            // 
            // rb_Corte
            // 
            this.rb_Corte.AutoSize = true;
            this.rb_Corte.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Corte.Location = new System.Drawing.Point(41, 20);
            this.rb_Corte.Name = "rb_Corte";
            this.rb_Corte.Size = new System.Drawing.Size(79, 27);
            this.rb_Corte.TabIndex = 0;
            this.rb_Corte.TabStop = true;
            this.rb_Corte.Text = "Corte";
            this.rb_Corte.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Hs,
            this.FechaHora,
            this.IdPeluquero,
            this.Peluquero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "f";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Location = new System.Drawing.Point(524, 104);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(430, 242);
            this.dgv.TabIndex = 16;
            // 
            // Id_Hs
            // 
            this.Id_Hs.HeaderText = "Id_Hs";
            this.Id_Hs.Name = "Id_Hs";
            this.Id_Hs.ReadOnly = true;
            this.Id_Hs.Visible = false;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle2.NullValue = null;
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            this.FechaHora.Width = 93;
            // 
            // IdPeluquero
            // 
            this.IdPeluquero.HeaderText = "IdPeluquero";
            this.IdPeluquero.Name = "IdPeluquero";
            this.IdPeluquero.ReadOnly = true;
            this.IdPeluquero.Visible = false;
            // 
            // Peluquero
            // 
            this.Peluquero.HeaderText = "Peluquero";
            this.Peluquero.Name = "Peluquero";
            this.Peluquero.ReadOnly = true;
            this.Peluquero.Width = 88;
            // 
            // txt_Peluquero
            // 
            this.txt_Peluquero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Peluquero.Location = new System.Drawing.Point(95, 104);
            this.txt_Peluquero.Name = "txt_Peluquero";
            this.txt_Peluquero.Size = new System.Drawing.Size(277, 31);
            this.txt_Peluquero.TabIndex = 17;
            this.txt_Peluquero.TextChanged += new System.EventHandler(this.txt_Peluquero_TextChanged);
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(985, 473);
            this.Controls.Add(this.txt_Peluquero);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblPeluquero);
            this.Name = "Turno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeluquero;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Tintura;
        private System.Windows.Forms.RadioButton rb_Crema;
        private System.Windows.Forms.RadioButton rb_Lavado;
        private System.Windows.Forms.RadioButton rb_Corte;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txt_Peluquero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPeluquero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peluquero;
    }
}