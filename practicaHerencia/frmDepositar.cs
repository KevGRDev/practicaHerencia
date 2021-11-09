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
        private float balance2;
        private float deposito;

        public float Balance2 { get => balance2; set => balance2 = value; }
        

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
            deposito = Convert.ToSingle(txDeposito.Text);

            this.Balance2 = this.Balance2 + Convert.ToSingle(deposito);
          

            lbActual.Text = Convert.ToString(this.Balance2);
            lbActual.Visible = true;
            lbSaldo.Visible = true;
            
        }

        private void lbActual_Click(object sender, EventArgs e)
        {

        }

        private void lbSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
