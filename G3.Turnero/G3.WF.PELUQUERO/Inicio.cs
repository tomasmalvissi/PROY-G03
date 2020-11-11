using G3.CLASS;
using G3.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3.WF.PELUQUERO
{
    public partial class Inicio : Form
    {
        DatosPeluquero dp = new DatosPeluquero();

        int espejo = 0;
        int flag = 0;
        public Inicio()
        {
            InitializeComponent();
        }

        #region METODOS
        public void ConsultaCliente(string dni)
        {
            string valor = string.Empty;

            DataSet ds = new DataSet();

            ds.Clear();
            ds = dp.ConsultaPeluquero(dni);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                valor = dr[0].ToString();
            }

            if (valor == "")
            {
                txt_Nombre.Visible = true;
                lblNombre.Visible = true;
                gr_espejo.Visible = true;
                lblEspejo.Visible = true;
                Alta(dni);
            }
            if (valor != "")
            {
                Panel p = new Panel(dni);
                this.Hide();
                p.Show();
            }
        }

        public void Alta(string dni)
        {
            if (txt_Nombre.Text != "")
            {
                if (rb1.Checked == true)
                {
                    espejo = 1;
                }
                if (rb2.Checked == true)
                {
                    espejo = 2;
                }
                if (rb3.Checked == true)
                {
                    espejo = 3;
                }
                if (rb4.Checked == true)
                {
                    espejo = 4;
                }

                Peluquero peluquero = new Peluquero(int.Parse(dni), txt_Nombre.Text, espejo);
                dp.AltaPeluquero("Alta", peluquero);
            }
        }
        #endregion

        #region VALIDACIÓN
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Escriba un DNI valido");
            }
            else
            {
                string dni = txtDNI.Text;
                ConsultaCliente(dni);
                flag++;

                if (flag == 2)
                {
                    Panel p = new Panel(dni);
                    this.Hide();
                    p.Show();

                    flag = 0;
                }
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}