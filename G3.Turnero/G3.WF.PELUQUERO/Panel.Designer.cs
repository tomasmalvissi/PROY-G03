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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.combo_TareaId = new System.Windows.Forms.ComboBox();
            this.picker_turno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picker_horario = new System.Windows.Forms.DateTimePicker();
            this.btn_modifica_turno = new System.Windows.Forms.Button();
            this.btn_eliminar_turno = new System.Windows.Forms.Button();
            this.btn_eliminar_horario = new System.Windows.Forms.Button();
            this.btn_modifica_horario = new System.Windows.Forms.Button();
            this.btn_alta_horario = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_id_turno = new System.Windows.Forms.Label();
            this.lbl_id_horario = new System.Windows.Forms.Label();
            this.lblClienteId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turnos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblDateTime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDateTime.Location = new System.Drawing.Point(538, 34);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(142, 39);
            this.lblDateTime.TabIndex = 8;
            this.lblDateTime.Text = "Horarios";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Honeydew;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgv_Horarios.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Hs,
            this.FechaHora});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Horarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Horarios.Location = new System.Drawing.Point(545, 138);
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Horarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Horarios.Size = new System.Drawing.Size(350, 248);
            this.dgv_Horarios.TabIndex = 16;
            this.dgv_Horarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Horarios_CellContentClick);
            // 
            // Id_Hs
            // 
            this.Id_Hs.HeaderText = "Id_Hs";
            this.Id_Hs.Name = "Id_Hs";
            this.Id_Hs.ReadOnly = true;
            this.Id_Hs.Width = 62;
            // 
            // FechaHora
            // 
            dataGridViewCellStyle2.Format = "f";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaHora.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaHora.HeaderText = "FechaHora";
            this.FechaHora.Name = "FechaHora";
            this.FechaHora.ReadOnly = true;
            this.FechaHora.Width = 93;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.BackColor = System.Drawing.Color.PapayaWhip;
            this.lblTurno.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblTurno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTurno.Location = new System.Drawing.Point(36, 36);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(112, 39);
            this.lblTurno.TabIndex = 17;
            this.lblTurno.Text = "Turnos";
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_Turnos
            // 
            this.dgv_Turnos.AllowUserToAddRows = false;
            this.dgv_Turnos.AllowUserToDeleteRows = false;
            this.dgv_Turnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_Turnos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Turnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.dataGridViewTextBoxColumn2,
            this.TareaId,
            this.ClienteId});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Turnos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Turnos.Location = new System.Drawing.Point(43, 138);
            this.dgv_Turnos.Name = "dgv_Turnos";
            this.dgv_Turnos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Turnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turnos.Size = new System.Drawing.Size(446, 248);
            this.dgv_Turnos.TabIndex = 18;
            this.dgv_Turnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Turnos_CellContentClick);
            // 
            // Id
            // 
            dataGridViewCellStyle6.NullValue = null;
            this.Id.DefaultCellStyle = dataGridViewCellStyle6;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 44;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle7.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "FechaHora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 93;
            // 
            // TareaId
            // 
            this.TareaId.HeaderText = "TareaId";
            this.TareaId.Name = "TareaId";
            this.TareaId.ReadOnly = true;
            this.TareaId.Width = 75;
            // 
            // ClienteId
            // 
            this.ClienteId.HeaderText = "ClienteId";
            this.ClienteId.Name = "ClienteId";
            this.ClienteId.ReadOnly = true;
            this.ClienteId.Width = 82;
            // 
            // combo_TareaId
            // 
            this.combo_TareaId.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_TareaId.FormattingEnabled = true;
            this.combo_TareaId.Items.AddRange(new object[] {
            "1-Corte",
            "2-Baño de crema",
            "3-Lavado",
            "4-Tintura"});
            this.combo_TareaId.Location = new System.Drawing.Point(224, 98);
            this.combo_TareaId.Name = "combo_TareaId";
            this.combo_TareaId.Size = new System.Drawing.Size(110, 25);
            this.combo_TareaId.TabIndex = 20;
            // 
            // picker_turno
            // 
            this.picker_turno.CalendarFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_turno.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_turno.Location = new System.Drawing.Point(43, 100);
            this.picker_turno.Name = "picker_turno";
            this.picker_turno.Size = new System.Drawing.Size(143, 22);
            this.picker_turno.TabIndex = 21;
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
            this.label2.Location = new System.Drawing.Point(221, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tarea";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "DNI Cliente";
            // 
            // picker_horario
            // 
            this.picker_horario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_horario.Location = new System.Drawing.Point(545, 98);
            this.picker_horario.Name = "picker_horario";
            this.picker_horario.Size = new System.Drawing.Size(350, 22);
            this.picker_horario.TabIndex = 25;
            // 
            // btn_modifica_turno
            // 
            this.btn_modifica_turno.BackColor = System.Drawing.Color.Honeydew;
            this.btn_modifica_turno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica_turno.Location = new System.Drawing.Point(224, 41);
            this.btn_modifica_turno.Name = "btn_modifica_turno";
            this.btn_modifica_turno.Size = new System.Drawing.Size(100, 32);
            this.btn_modifica_turno.TabIndex = 26;
            this.btn_modifica_turno.Text = "Modificar";
            this.btn_modifica_turno.UseVisualStyleBackColor = false;
            this.btn_modifica_turno.Click += new System.EventHandler(this.btn_modifica_turno_Click);
            // 
            // btn_eliminar_turno
            // 
            this.btn_eliminar_turno.BackColor = System.Drawing.Color.Honeydew;
            this.btn_eliminar_turno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_turno.Location = new System.Drawing.Point(369, 41);
            this.btn_eliminar_turno.Name = "btn_eliminar_turno";
            this.btn_eliminar_turno.Size = new System.Drawing.Size(100, 32);
            this.btn_eliminar_turno.TabIndex = 27;
            this.btn_eliminar_turno.Text = "Eliminar";
            this.btn_eliminar_turno.UseVisualStyleBackColor = false;
            this.btn_eliminar_turno.Click += new System.EventHandler(this.btn_eliminar_turno_Click);
            // 
            // btn_eliminar_horario
            // 
            this.btn_eliminar_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_eliminar_horario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar_horario.Location = new System.Drawing.Point(811, 60);
            this.btn_eliminar_horario.Name = "btn_eliminar_horario";
            this.btn_eliminar_horario.Size = new System.Drawing.Size(84, 32);
            this.btn_eliminar_horario.TabIndex = 29;
            this.btn_eliminar_horario.Text = "Eliminar";
            this.btn_eliminar_horario.UseVisualStyleBackColor = false;
            this.btn_eliminar_horario.Click += new System.EventHandler(this.btn_eliminar_horario_Click);
            // 
            // btn_modifica_horario
            // 
            this.btn_modifica_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_modifica_horario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifica_horario.Location = new System.Drawing.Point(705, 60);
            this.btn_modifica_horario.Name = "btn_modifica_horario";
            this.btn_modifica_horario.Size = new System.Drawing.Size(100, 32);
            this.btn_modifica_horario.TabIndex = 28;
            this.btn_modifica_horario.Text = "Modificar";
            this.btn_modifica_horario.UseVisualStyleBackColor = false;
            this.btn_modifica_horario.Click += new System.EventHandler(this.btn_modifica_horario_Click);
            // 
            // btn_alta_horario
            // 
            this.btn_alta_horario.BackColor = System.Drawing.Color.Honeydew;
            this.btn_alta_horario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alta_horario.Location = new System.Drawing.Point(705, 22);
            this.btn_alta_horario.Name = "btn_alta_horario";
            this.btn_alta_horario.Size = new System.Drawing.Size(190, 32);
            this.btn_alta_horario.TabIndex = 30;
            this.btn_alta_horario.Text = "Alta";
            this.btn_alta_horario.UseVisualStyleBackColor = false;
            this.btn_alta_horario.Click += new System.EventHandler(this.btn_alta_horario_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(221, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 15);
            this.lbl1.TabIndex = 31;
            this.lbl1.Text = "Id:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(566, 77);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 15);
            this.lbl2.TabIndex = 32;
            this.lbl2.Text = "Id:";
            // 
            // lbl_id_turno
            // 
            this.lbl_id_turno.AutoSize = true;
            this.lbl_id_turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_turno.Location = new System.Drawing.Point(245, 22);
            this.lbl_id_turno.Name = "lbl_id_turno";
            this.lbl_id_turno.Size = new System.Drawing.Size(15, 16);
            this.lbl_id_turno.TabIndex = 33;
            this.lbl_id_turno.Text = "0";
            // 
            // lbl_id_horario
            // 
            this.lbl_id_horario.AutoSize = true;
            this.lbl_id_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_horario.Location = new System.Drawing.Point(592, 77);
            this.lbl_id_horario.Name = "lbl_id_horario";
            this.lbl_id_horario.Size = new System.Drawing.Size(15, 16);
            this.lbl_id_horario.TabIndex = 34;
            this.lbl_id_horario.Text = "0";
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteId.Location = new System.Drawing.Point(387, 105);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(15, 16);
            this.lblClienteId.TabIndex = 35;
            this.lblClienteId.Text = "0";
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(946, 492);
            this.Controls.Add(this.lblClienteId);
            this.Controls.Add(this.lbl_id_horario);
            this.Controls.Add(this.lbl_id_turno);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btn_alta_horario);
            this.Controls.Add(this.btn_eliminar_horario);
            this.Controls.Add(this.btn_modifica_horario);
            this.Controls.Add(this.btn_eliminar_turno);
            this.Controls.Add(this.btn_modifica_turno);
            this.Controls.Add(this.picker_horario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picker_turno);
            this.Controls.Add(this.combo_TareaId);
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
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.DataGridView dgv_Turnos;
        private System.Windows.Forms.ComboBox combo_TareaId;
        private System.Windows.Forms.DateTimePicker picker_turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker picker_horario;
        private System.Windows.Forms.Button btn_modifica_turno;
        private System.Windows.Forms.Button btn_eliminar_turno;
        private System.Windows.Forms.Button btn_eliminar_horario;
        private System.Windows.Forms.Button btn_modifica_horario;
        private System.Windows.Forms.Button btn_alta_horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Hs;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClienteId;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_id_turno;
        private System.Windows.Forms.Label lbl_id_horario;
        private System.Windows.Forms.Label lblClienteId;
    }
}