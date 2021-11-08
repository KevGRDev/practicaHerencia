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
    public partial class frmAbrir : frmBase
    {
        public frmAbrir()
        {
            InitializeComponent();
        }

        private void frmAbrir_Load(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void txAbrir_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            frmOperaciones menu = new frmOperaciones();

            abrirCuenta abrir = new abrirCuenta();

            abrir.Saldo = Convert.ToSingle(txtAbrir.Text);

            if (abrir.Saldo >= 1000)
            {
                MessageBox.Show("Cuenta generada con exito!");

                menu.Name = txNombre.Text;
                menu.Nip = Convert.ToSingle(txtNip.Text);
                menu.Balance = Convert.ToSingle(txtAbrir.Text);

                this.Hide();
                menu.Show();

            }
            else
            {
                lbError.Visible = true;
            }
        }

        private void txtAbrir_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
           
        }

        private void txtNip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
