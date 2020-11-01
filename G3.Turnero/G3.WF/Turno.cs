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
        public Turno(string dni)
        {
            InitializeComponent();
        }

        private void Turno_Load(object sender, EventArgs e)
        {

        }

        private void lblPeluquero_Click(object sender, EventArgs e)
        {

        }

        private void listBoxPelluqueros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenido b = new Bienvenido();
            b.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
