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

            picker_horario.Format = DateTimePickerFormat.Custom;
            picker_horario.CustomFormat = "dd/MM/yyyy HH:mm";

            picker_turno.Format = DateTimePickerFormat.Custom;
            picker_turno.CustomFormat = "dd/MM/yyyy HH:mm";

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
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
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

        public void GridToHorarios()
        {
            lbl_id_horario.Text = dgv_Horarios.CurrentRow.Cells[0].Value.ToString();
            picker_horario.Value = Convert.ToDateTime(dgv_Horarios.CurrentRow.Cells[1].Value.ToString());
        }

        public void GridToTurnos()
        {
            if (dgv_Turnos.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                combo_TareaId.SelectedIndex = 0;
            }
            if (dgv_Turnos.CurrentRow.Cells[2].Value.ToString() == "2")
            {
                combo_TareaId.SelectedIndex = 1;
            }
            if (dgv_Turnos.CurrentRow.Cells[2].Value.ToString() == "3")
            {
                combo_TareaId.SelectedIndex = 2;
            }
            if (dgv_Turnos.CurrentRow.Cells[2].Value.ToString() == "4")
            {
                combo_TareaId.SelectedIndex = 3;
            }

            lbl_id_turno.Text = dgv_Turnos.CurrentRow.Cells[0].Value.ToString();
            picker_turno.Value = Convert.ToDateTime(dgv_Turnos.CurrentRow.Cells[1].Value.ToString());
            txt_ClienteId.Text = dgv_Turnos.CurrentRow.Cells[3].Value.ToString();
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio i = new Inicio();
            i.Show();
        }

        private void dgv_Horarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToHorarios();
        }

        private void dgv_Turnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GridToTurnos();
        }
    }
}