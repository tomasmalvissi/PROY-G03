namespace G3.WF.PELUQUERO
{
    partial class Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.Id_Hs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTurno = new System.Windows.Forms.Label();
            this.dgv_Turnos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ClienteId = new System.Windows.Forms.TextBox();
            this.combo_TareaId = new System.Windows.Forms.ComboBox();
            this.picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_modifica_turno = new System.Windows.Forms.Button();
            this.btn_eliminar_turno = new System.Windows.Forms.Button();
            this.btn_eliminar_horario = new System.Windows.Forms.Button();
            this.btn_modifica_horario = new System.Windows.Forms.Button();
            this.btn_alta_horario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Location = new System.Drawing.Point(538, 36);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(139, 37);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Horarios";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(415, 421);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(146, 44);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.AllowUserToAddRows = false;
            this.dgv_Horarios.AllowUserToDeleteRows = false;
            this.dgv_Horarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Hs,
            this.FechaHora});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Horarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Horarios.Location = new System.Drawing.Point(545, 138);
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.ReadOnly = true;
            this.dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Horarios.Size = new System.Drawing.Size(350, 248);
            this.dgv_Horarios.TabIndex = 16;
            // 
            // Id_Hs
            // 
            this.Id_Hs.HeaderText = "Id_Hs";
            this.Id_Hs.Name = "Id_Hs";
            this.Id_Hs.ReadOnly = true;
            this.Id_Hs.Width = 60;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle1;
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            this.FechaHora.Width = 85;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTurno.Location = new System.Drawing.Point(36, 36);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(118, 37);
            this.lblTurno.TabIndex = 17;
            this.lblTurno.Text = "Turnos";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_Turnos
            // 
            this.dgv_Turnos.AllowUserToAddRows = false;
            this.dgv_Turnos.AllowUserToDeleteRows = false;
            this.dgv_Turnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2,
            this.TareaId,
            this.ClienteId});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "f";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Turnos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Turnos.Location = new System.Drawing.Point(43, 138);
            this.dgv_Turnos.Name = "dgv_Turnos";
            this.dgv_Turnos.ReadOnly = true;
            this.dgv_Turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turnos.Size = new System.Drawing.Size(414, 248);
            this.dgv_Turnos.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.HeaderText = "FechaHora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 85;
            // 
            // TareaId
            // 
            this.TareaId.HeaderText = "TareaId";
            this.TareaId.Name = "TareaId";
            this.TareaId.ReadOnly = true;
            this.TareaId.Width = 69;
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Width = 73;
            // 
            // txt_ClienteId
            // 
            this.txt_ClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClienteId.Location = new System.Drawing.Point(355, 100);
            this.txt_ClienteId.Name = "txt_ClienteId";
            this.txt_ClienteId.Size = new System.Drawing.Size(100, 21);
            this.txt_ClienteId.TabIndex = 19;
            // 
            // combo_TareaId
            // 
            this.combo_TareaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_TareaId.FormattingEnabled = true;
            this.combo_TareaId.Items.AddRange(new object[] {
            "1-Corte",
            "2-Baño de crema",
            "3-Lavado",
            "4-Tintura"});
            this.combo_TareaId.Location = new System.Drawing.Point(210, 98);
            this.combo_TareaId.Name = "combo_TareaId";
            this.combo_TareaId.Size = new System.Drawing.Size(110, 23);
            this.combo_TareaId.TabIndex = 20;
            // 
            // picker
            // 
            this.picker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker.Location = new System.Drawing.Point(43, 100);
            this.picker.Name = "picker";
            this.picker.Size = new System.Drawing.Size(143, 21);
            this.picker.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Fecha y Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(207, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "DNI Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(545, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // btn_modifica_turno
            // 
            this.btn_modifica_turno.BackColor = System.Drawing.Color.Honeydew;
            this.btn_modifica_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica_turno.Location = new System.Drawing.Point(210, 41);
            this.btn_modifica_turno.Name = "btn_modifica_turno";
            this.btn_modifica_turno.Size = new System.Drawing.Size(100, 32);
            this.btn_modifica_turno.TabIndex = 26;
            this.btn_modifica_turno.Text = "Modificar";
            this.btn_modifica_turno.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_turno
            // 
            this.btn_eliminar_turno.BackColor = System.Drawing.Color.Honeydew;
            this.btn_eliminar_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_turno.Location = new System.Drawing.Point(355, 41);
            this.btn_eliminar_turno.Name = "btn_eliminar_turno";
            this.btn_eliminar_turno.Size = new System.Drawing.Size(100, 32);
            this.btn_eliminar_turno.TabIndex = 27;
            this.btn_eliminar_turno.Text = "Eliminar";
            this.btn_eliminar_turno.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_horario
            // 
            this.btn_eliminar_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_eliminar_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_horario.Location = new System.Drawing.Point(811, 60);
            this.btn_eliminar_horario.Name = "btn_eliminar_horario";
            this.btn_eliminar_horario.Size = new System.Drawing.Size(84, 32);
            this.btn_eliminar_horario.TabIndex = 29;
            this.btn_eliminar_horario.Text = "Eliminar";
            this.btn_eliminar_horario.UseVisualStyleBackColor = false;
            // 
            // btn_modifica_horario
            // 
            this.btn_modifica_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_modifica_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica_horario.Location = new System.Drawing.Point(705, 60);
            this.btn_modifica_horario.Name = "btn_modifica_horario";
            this.btn_modifica_horario.Size = new System.Drawing.Size(87, 32);
            this.btn_modifica_horario.TabIndex = 28;
            this.btn_modifica_horario.Text = "Modificar";
            this.btn_modifica_horario.UseVisualStyleBackColor = false;
            // 
            // btn_alta_horario
            // 
            this.btn_alta_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_alta_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_horario.Location = new System.Drawing.Point(705, 22);
            this.btn_alta_horario.Name = "btn_alta_horario";
            this.btn_alta_horario.Size = new System.Drawing.Size(190, 32);
            this.btn_alta_horario.TabIndex = 30;
            this.btn_alta_horario.Text = "Alta";
            this.btn_alta_horario.UseVisualStyleBackColor = false;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(946, 492);
            this.Controls.Add(this.btn_alta_horario);
            this.Controls.Add(this.btn_eliminar_horario);
            this.Controls.Add(this.btn_modifica_horario);
            this.Controls.Add(this.btn_eliminar_turno);
            this.Controls.Add(this.btn_modifica_turno);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picker);
            this.Controls.Add(this.combo_TareaId);
            this.Controls.Add(this.txt_ClienteId);
            this.Controls.Add(this.dgv_Turnos);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.dgv_Horarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDateTime);
            this.Name = "Panel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel de horarios y turnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgv_Horarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridView dgv_Turnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.TextBox txt_ClienteId;
        private System.Windows.Forms.ComboBox combo_TareaId;
        private System.Windows.Forms.DateTimePicker picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_modifica_turno;
        private System.Windows.Forms.Button btn_eliminar_turno;
        private System.Windows.Forms.Button btn_eliminar_horario;
        private System.Windows.Forms.Button btn_modifica_horario;
        private System.Windows.Forms.Button btn_alta_horario;
    }
}