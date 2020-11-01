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
using System.Windows.Forms;

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

            t.DateTime = Convert.ToDateTime(dgv.CurrentRow.Cells[1].Value.ToString());
            t.PeluqueroId = Convert.ToInt32(dgv.CurrentRow.Cells[2].Value.ToString());
            t.ClienteId = Convert.ToInt32(DNI);

            dt.ABMTurnos("Alta", t);
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
            this.Close();
        }

        private void txt_Peluquero_TextChanged(object sender, EventArgs e)
        {
            CargaDgv();
        }
    }
}