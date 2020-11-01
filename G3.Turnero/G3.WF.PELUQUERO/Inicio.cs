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
        Peluquero p = new Peluquero();
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
                //Turno t = new Turno(dni);
                //this.Hide();
                //t.Show();
            }
        }

        public void Alta(string dni)
        {
            if (txt_Nombre.Text != "")
            {
                //c.Nombre_Apellido = txt_Nombre.Text;
                //c.Id = int.Parse(dni);
                //dc.AltaClientes("Alta", c);
            }
            else
            {

            }
        }
        #endregion

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            ConsultaCliente(dni);
            flag++;

            if (flag == 2)
            {
                //Turno t = new Turno(dni);
                //this.Hide();
                //t.Show();

                flag = 0;
            }
        }
    }
}
