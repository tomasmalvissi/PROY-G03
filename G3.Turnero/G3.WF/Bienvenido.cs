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

namespace G3.WF
{
    public partial class Bienvenido : Form
    {
        DatosClientes dc = new DatosClientes();
        
        int flag = 0;
        public Bienvenido()
        {
            InitializeComponent();
        }

        #region METODOS
        public void ConsultaCliente(string dni)
        {
            string valor = string.Empty;

            DataSet ds = new DataSet();

            ds.Clear();
            ds = dc.ConsultaCliente(dni);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                valor = dr[0].ToString();
            }

            if (valor == "")
            {
                txt_Nombre.Visible = true;
                lblNombre.Visible = true;
                Alta(dni);
            }
            if (valor != "")
            {
                Turno t = new Turno(dni);
                this.Hide();
                t.Show();
            }
        }

        public void Alta(string dni)
        {
            if (txt_Nombre.Text != "")
            {
                Cliente cliente = new Cliente(int.Parse(dni), txt_Nombre.Text);
                dc.AltaClientes("Alta", cliente);
            }
        }
        #endregion

        #region VALIDACION
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
                    Turno t = new Turno(dni);
                    this.Hide();
                    t.Show();

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