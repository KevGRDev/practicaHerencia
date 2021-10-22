
namespace practicaHerencia
{
    partial class frmRetirar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.lbSaldores = new System.Windows.Forms.Label();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(53, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese la cantidad que desea retirar (Saldo inicial $1,000.000): ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(553, 160);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(100, 20);
            this.txCantidad.TabIndex = 8;
            // 
            // lbSaldores
            // 
            this.lbSaldores.AutoSize = true;
            this.lbSaldores.Location = new System.Drawing.Point(120, 250);
            this.lbSaldores.Name = "lbSaldores";
            this.lbSaldores.Size = new System.Drawing.Size(81, 13);
            this.lbSaldores.TabIndex = 9;
            this.lbSaldores.Text = "Saldo restante: ";
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(207, 250);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(51, 13);
            this.lbSaldo.TabIndex = 10;
            this.lbSaldo.Text = "saldoRes";
            this.lbSaldo.Click += new System.EventHandler(this.lbSaldo_Click);
            // 
            // btnRetiro
            // 
            this.btnRetiro.BackColor = System.Drawing.Color.Chocolate;
            this.btnRetiro.ForeColor = System.Drawing.Color.Maroon;
            this.btnRetiro.Location = new System.Drawing.Point(631, 265);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(112, 34);
            this.btnRetiro.TabIndex = 11;
            this.btnRetiro.Text = "Retirar";
            this.btnRetiro.UseVisualStyleBackColor = false;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // frmRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.lbSaldo);
            this.Controls.Add(this.lbSaldores);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label2);
            this.Name = "frmRetirar";
            this.Text = "frmRetirar";
            this.Load += new System.EventHandler(this.frmRetirar_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txCantidad, 0);
            this.Controls.SetChildIndex(this.lbSaldores, 0);
            this.Controls.SetChildIndex(this.lbSaldo, 0);
            this.Controls.SetChildIndex(this.btnRetiro, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label lbSaldores;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.Button btnRetiro;
    }
}