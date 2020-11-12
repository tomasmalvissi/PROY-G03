namespace Estadisticas
{
    partial class Estadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grafico_clientes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_cant_peluca = new System.Windows.Forms.Label();
            this.lbl_cant_clientes = new System.Windows.Forms.Label();
            this.grafico_peluca = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.dgv_peluca = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant_Turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePeluquero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Turnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_peluca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peluca)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico_clientes
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico_clientes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico_clientes.Legends.Add(legend1);
            this.grafico_clientes.Location = new System.Drawing.Point(33, 263);
            this.grafico_clientes.Name = "grafico_clientes";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.grafico_clientes.Series.Add(series1);
            this.grafico_clientes.Size = new System.Drawing.Size(246, 152);
            this.grafico_clientes.TabIndex = 0;
            // 
            // lbl_cant_peluca
            // 
            this.lbl_cant_peluca.AutoSize = true;
            this.lbl_cant_peluca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_peluca.Location = new System.Drawing.Point(401, 35);
            this.lbl_cant_peluca.Name = "lbl_cant_peluca";
            this.lbl_cant_peluca.Size = new System.Drawing.Size(93, 18);
            this.lbl_cant_peluca.TabIndex = 1;
            this.lbl_cant_peluca.Text = "Peluqueros";
            // 
            // lbl_cant_clientes
            // 
            this.lbl_cant_clientes.AutoSize = true;
            this.lbl_cant_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cant_clientes.Location = new System.Drawing.Point(53, 35);
            this.lbl_cant_clientes.Name = "lbl_cant_clientes";
            this.lbl_cant_clientes.Size = new System.Drawing.Size(69, 18);
            this.lbl_cant_clientes.TabIndex = 2;
            this.lbl_cant_clientes.Text = "Clientes";
            // 
            // grafico_peluca
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico_peluca.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico_peluca.Legends.Add(legend2);
            this.grafico_peluca.Location = new System.Drawing.Point(392, 263);
            this.grafico_peluca.Name = "grafico_peluca";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.grafico_peluca.Series.Add(series2);
            this.grafico_peluca.Size = new System.Drawing.Size(246, 152);
            this.grafico_peluca.TabIndex = 3;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.AllowUserToAddRows = false;
            this.dgv_clientes.AllowUserToDeleteRows = false;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.Cant_Turnos});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clientes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clientes.Location = new System.Drawing.Point(33, 74);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersVisible = false;
            this.dgv_clientes.Size = new System.Drawing.Size(246, 150);
            this.dgv_clientes.TabIndex = 4;
            // 
            // dgv_peluca
            // 
            this.dgv_peluca.AllowUserToAddRows = false;
            this.dgv_peluca.AllowUserToDeleteRows = false;
            this.dgv_peluca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_peluca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePeluquero,
            this.Cantidad_Turnos});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_peluca.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_peluca.Location = new System.Drawing.Point(392, 74);
            this.dgv_peluca.Name = "dgv_peluca";
            this.dgv_peluca.ReadOnly = true;
            this.dgv_peluca.RowHeadersVisible = false;
            this.dgv_peluca.Size = new System.Drawing.Size(246, 150);
            this.dgv_peluca.TabIndex = 5;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "NombreCliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // Cant_Turnos
            // 
            this.Cant_Turnos.HeaderText = "Cant_Turnos";
            this.Cant_Turnos.Name = "Cant_Turnos";
            this.Cant_Turnos.ReadOnly = true;
            // 
            // NombrePeluquero
            // 
            this.NombrePeluquero.HeaderText = "NombrePeluquero";
            this.NombrePeluquero.Name = "NombrePeluquero";
            this.NombrePeluquero.ReadOnly = true;
            // 
            // Cantidad_Turnos
            // 
            this.Cantidad_Turnos.HeaderText = "Cantidad_Turnos";
            this.Cantidad_Turnos.Name = "Cantidad_Turnos";
            this.Cantidad_Turnos.ReadOnly = true;
            // 
            // Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(700, 466);
            this.Controls.Add(this.dgv_peluca);
            this.Controls.Add(this.dgv_clientes);
            this.Controls.Add(this.grafico_peluca);
            this.Controls.Add(this.lbl_cant_clientes);
            this.Controls.Add(this.lbl_cant_peluca);
            this.Controls.Add(this.grafico_clientes);
            this.Name = "Estadisticas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.grafico_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico_peluca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_peluca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_clientes;
        private System.Windows.Forms.Label lbl_cant_peluca;
        private System.Windows.Forms.Label lbl_cant_clientes;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico_peluca;
        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.DataGridView dgv_peluca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant_Turnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePeluquero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Turnos;
    }
}

