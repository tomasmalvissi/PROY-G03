using G3.CLASS;
using G3.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace G3.WF
{
    public partial class Turno : Form
    {
        private string DNI;
        DatosTurnos dt = new DatosTurnos();
        G3.CLASS.Turno t = new CLASS.Turno();
        DatosHorarios dh = new DatosHorarios();
        public Turno(string dni)
        {
            InitializeComponent();

            CargaDgv();

            this.DNI = dni;
        }

        #region METODOS
        public void CargaDgv()
        {
            dgv.Rows.Clear();
            DataSet ds = new DataSet();
            ds = dh.MostrarHorarios(txt_Peluquero.Text);
            if(ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }

        }
        public void AltaTurno()
        {
            if (rb_Corte.Checked == true)
            {
                t.TareaId = 1;  
            }
            if (rb_Crema.Checked == true)
            {
                t.TareaId = 2;
            }
            if(rb_Lavado.Checked == true)
            {
                t.TareaId = 3;
            }
            if (rb_Tintura.Checked == true)
            {
                t.TareaId = 4;
            }

            var horario = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            var date = Convert.ToDateTime(dgv.CurrentRow.Cells[1].EditedFormattedValue);
            t.DateTime = date;
            t.PeluqueroId = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            t.ClienteId = Convert.ToInt32(DNI);


            dt.AltaTurnos(t, horario);
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenido b = new Bienvenido();
            b.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            AltaTurno();
            MessageBoxResult result = MessageBox.Show("Su turno para el dia " + t.DateTime + " fue cargado con éxito!. \n\r Desea solicitar otro turno?", "OK", (MessageBoxButton)MessageBoxButtons.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    CargaDgv();
                    break;
                case MessageBoxResult.No:
                    this.Close();
                    break;
            }
        }

        private void txt_Peluquero_TextChanged(object sender, EventArgs e)
        {
            CargaDgv();
        }
    }
}