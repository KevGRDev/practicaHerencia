using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaHerencia
{
    public partial class frmOperaciones : frmBase
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmAbrir nvCuenta = new frmAbrir();
            this.Hide();
            nvCuenta.Show();
        }

     

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            frmRetirar retirar = new frmRetirar();
            this.Hide();
            retirar.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            frmDepositar depositar = new frmDepositar();
            this.Hide();
            depositar.Show();
        }
    }
}
