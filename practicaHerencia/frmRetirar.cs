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
    public partial class frmRetirar : frmBase
    {


        private float balance1;
        private float retiro;

        public float Balance1 { get => balance1; set => balance1 = value; }

        public frmRetirar()
        {
            InitializeComponent();
        }

        private void frmRetirar_Load(object sender, EventArgs e)
        {
            lbSaldores.Visible = false;
            lbSaldo.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            
            retiro = Convert.ToSingle(txCantidad.Text);

            this.Balance1 = this.Balance1 - Convert.ToSingle(retiro);


            if (this.Balance1 <= Balance1)
            {

                if(this.Balance1>=20)
                {

                lbSaldores.Visible = true;
                lbSaldo.Visible = true;

                lbSaldo.Text = Convert.ToString(this.Balance1);
               

                 }
                else 
                {
                lbSaldo.Visible = true;
                lbSaldores.Visible = false;
                lbSaldo.Text = Convert.ToString(this.Balance1);
                }

            }
            else
            {
                lbSaldo.Visible = true;
                lbSaldores.Visible = false;
                lbSaldo.Text = Convert.ToString("No puedes retirar más del almacenado");
            }
        }

        private void lbSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
