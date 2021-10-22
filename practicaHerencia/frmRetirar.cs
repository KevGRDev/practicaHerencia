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
            hacerRetiro retirar = new hacerRetiro();
            retirar.Retiro = Convert.ToSingle(txCantidad.Text);
            
            if(retirar.Retiro>0)
            {

                lbSaldores.Visible = true;
                lbSaldo.Visible = true;

                lbSaldo.Text = Convert.ToString(retirar.Retirar());
               

            }
            else
            {
                lbSaldo.Visible = true;
                lbSaldores.Visible = false;
                lbSaldo.Text = Convert.ToString("No puedes retirar más del almacenado");
            }
        }
    }
}
