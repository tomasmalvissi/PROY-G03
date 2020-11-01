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

namespace G3.WF.PELUQUERO
{
    public partial class Panel : Form
    {
        private string DNI;
        DatosTurnos dt = new DatosTurnos();
        G3.CLASS.Turno t = new CLASS.Turno();
        DatosHorarios dh = new DatosHorarios();
        public Panel(string dni)
        {
            InitializeComponent();

            this.DNI = dni;

            CargaDgHorarios();
            CargaDgTurnos();        
        }

        #region METODOS
        public void CargaDgHorarios()
        {
            dgv_Horarios.Rows.Clear();
            DataSet ds = new DataSet();
            ds = dh.MostrarHorarioPorDni(DNI);
            if(ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Horarios.Rows.Add(dr[0], dr[1]);
                }
            }
        }

        public void CargaDgTurnos()
        {
            dgv_Turnos.Rows.Clear();
            DataSet ds = new DataSet();
            ds = dt.MostrarTurnosporPeluquero(DNI);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_Turnos.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio i = new Inicio();
            i.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Peluquero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}