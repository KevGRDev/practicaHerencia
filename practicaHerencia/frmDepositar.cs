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
    public partial class frmDepositar : frmBase
    {
        public frmDepositar()
        {
            InitializeComponent();
        }

        private void frmDepositar_Load(object sender, EventArgs e)
        {
            lbActual.Visible = false;
            lbSaldo.Visible = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            Depositos depositos = new Depositos();
            depositos.Depo = Convert.ToSingle(txDeposito.Text);
        }

        private void lbActual_Click(object sender, EventArgs e)
        {

        }

        private void lbSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
