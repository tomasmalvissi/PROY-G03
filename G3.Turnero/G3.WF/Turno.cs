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
        DatosHorarios dh = new DatosHorarios();
        public string fechaturno = "";
        public int tarea;
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
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
        }

        public void AltaTurno()
        {
            if (rb_Corte.Checked == true)
            {
                CreaTurno(1);
            }
            if (rb_Crema.Checked == true)
            {
                CreaTurno(2);
            }
            if (rb_Lavado.Checked == true)
            {
                CreaTurno(3);
            }
            if (rb_Tintura.Checked == true)
            {
                CreaTurno(4);
            }
        }

        public void CreaTurno(int tarea)
        {
            var horario = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            var date = Convert.ToDateTime(dgv.CurrentRow.Cells[1].EditedFormattedValue);
            var peluquero = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            var dni = Convert.ToInt32(DNI);

            G3.CLASS.Turno turno = new CLASS.Turno(1, date, tarea, peluquero, dni);
            dt.AltaTurnos(turno, horario);

            fechaturno = Convert.ToString(date);
        }
        #endregion

        #region VALIDACION
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenido b = new Bienvenido();
            b.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (!rb_Corte.Checked && !rb_Crema.Checked && !rb_Lavado.Checked && !rb_Tintura.Checked)
            {
                MessageBox.Show("Elija una tarea para confirmar su turno");
            }
            else
            {
                AltaTurno();
                MessageBoxResult result = MessageBox.Show("Su turno para el dia " + fechaturno + " fue cargado con éxito!. \n\r Desea solicitar otro turno?", "OK", (MessageBoxButton)MessageBoxButtons.YesNo);
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
        }
        #endregion

        #region EVENTOS
        private void txt_Peluquero_TextChanged(object sender, EventArgs e)
        {
            CargaDgv();
        }
        #endregion
    }
}