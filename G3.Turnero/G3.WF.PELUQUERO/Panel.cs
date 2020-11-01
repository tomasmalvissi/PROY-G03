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
        G3.CLASS.Horario h = new CLASS.Horario();
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
            lblClienteId.Text = dgv_Turnos.CurrentRow.Cells[3].Value.ToString();
        }

        public void ABMHorario(string accion)
        {
            h.Id = Convert.ToInt32(lbl_id_horario.Text);
            h.DiaHora = picker_horario.Value;
            h.PeluqueroId = Convert.ToInt32(DNI);
            switch (accion)
            {
                case "Alta":
                    dh.ABMHorarios("Alta", h);
                    break;
                case "Modificar":
                    dh.ABMHorarios("Modificar", h);
                    break;
                case "Eliminar":
                    dh.ABMHorarios("Eliminar", h);
                    break;
            }
        }

        public void ABMTurnos(string accion)
        {
            t.Id = Convert.ToInt32(lbl_id_turno.Text);
            t.DateTime = picker_turno.Value;
            t.TareaId = combo_TareaId.SelectedIndex + 1;
            t.PeluqueroId = Convert.ToInt32(DNI);
            t.ClienteId = Convert.ToInt32(lblClienteId.Text);

            switch (accion)
            {
                case "Alta":
                    dt.ABMTurnos("Alta", t);
                    break;
                case "Modificar":
                    dt.ABMTurnos("Modificar", t);
                    break;
                case "Eliminar":
                    dt.ABMTurnos("Eliminar", t);
                    break;
            }
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

        private void btn_alta_horario_Click(object sender, EventArgs e)
        {
            ABMHorario("Alta");
            CargaDgHorarios();
        }

        private void btn_modifica_horario_Click(object sender, EventArgs e)
        {
            ABMHorario("Modificar");
            CargaDgHorarios();
        }

        private void btn_eliminar_horario_Click(object sender, EventArgs e)
        {
            ABMHorario("Eliminar");
            CargaDgHorarios();
        }

        private void btn_modifica_turno_Click(object sender, EventArgs e)
        {
            ABMTurnos("Modificar");
            CargaDgTurnos();
        }

        private void btn_eliminar_turno_Click(object sender, EventArgs e)
        {
            ABMTurnos("Eliminar");
            CargaDgTurnos();
        }
    }
}