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

        private string name;
        private float nip;
        private float balance;

        public string Name1 { get => name; set => name = value; }
        public float Nip { get => nip; set => nip = value; }
        public float Balance { get => balance; set => balance = value; }

        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void frmOperaciones_Load(object sender, EventArgs e)
        {
            lbName.Text = this.Name;
            lbNip.Text = Convert.ToString(this.Nip);
            lbBalance.Text = Convert.ToString(this.Balance);

            lbName.Visible = true;
            lbNip.Visible = true;
            lbBalance.Visible = true;

            frmDepositar deposito = new frmDepositar();
            frmRetirar retirar = new frmRetirar();

            retirar.Balance1 = Convert.ToSingle(this.Balance);
            deposito.Balance2 = Convert.ToSingle(this.Balance);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

     

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            frmRetirar retirar = new frmRetirar();

            retirar.Balance1 = Convert.ToSingle(this.Balance);


            this.Hide();

            retirar.Show();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            frmDepositar depositar = new frmDepositar();
            depositar.Balance2= Convert.ToSingle(this.Balance);
            this.Hide();
            depositar.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
