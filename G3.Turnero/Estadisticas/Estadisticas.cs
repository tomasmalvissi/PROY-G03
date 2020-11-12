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
using System.Windows.Forms.DataVisualization.Charting;

namespace Estadisticas
{
    public partial class Estadisticas : Form
    {
        DatosTurnos dt = new DatosTurnos();
        public Estadisticas()
        {
            InitializeComponent();

            TurnosPeluqueros();
            TurnosClientes();

            Graficos();
        }

        public void TurnosClientes()
        {
            DataSet ds = new DataSet();
            ds.Clear();
            ds = dt.TurnosClientes();

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_clientes.Rows.Add(dr[0], dr[1]);
                }
            }
        }

        public void TurnosPeluqueros()
        {
            DataSet ds = new DataSet();
            ds.Clear();
            ds = dt.TurnosPeluqueros();

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                   dgv_peluca.Rows.Add(dr[0], dr[1]);
                }
            }
        }

        public void Graficos()
        {
            grafico_clientes.Palette = ChartColorPalette.BrightPastel;

            List<string> clientes = new List<string>();
            List<string> turnoclientes = new List<string>();
            List<string> peluqueros = new List<string>();
            List<string> turnopeluqueros = new List<string>();

            grafico_clientes.Series.Clear();
            grafico_clientes.Series.Add("Cantidad").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            grafico_peluca.Series.Clear();
            grafico_peluca.Series.Add("Cantidad").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (DataGridViewRow fila in dgv_clientes.Rows)
            {
                clientes.Add(fila.Cells[0].Value.ToString());
                turnoclientes.Add(fila.Cells[1].Value.ToString());
            }

            foreach (DataGridViewRow fila in dgv_peluca.Rows)
            {
                peluqueros.Add(fila.Cells[0].Value.ToString());
                turnopeluqueros.Add(fila.Cells[1].Value.ToString());
            }

            string[] clientesarray = clientes.ToArray();
            string[] turnosclientea = turnoclientes.ToArray();
            string[] peluquerosarray = peluqueros.ToArray();
            string[] turnopeluqa = turnopeluqueros.ToArray();

            for (int i = 0; i < clientesarray.Length; i++)
            {
                grafico_clientes.Series["Cantidad"].Points.AddXY(clientesarray[i], turnosclientea[i]);
            }

            for (int i = 0; i < peluquerosarray.Length; i++)
            {
                grafico_peluca.Series["Cantidad"].Points.AddXY(peluquerosarray[i], turnopeluqa[i]);
            }

        }
    }
}
