
namespace practicaHerencia
{
    partial class frmDepositar
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
            this.txDeposito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbActual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(21, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingrese la cantidad que desea depositar (Saldo inicial $1,000.000): ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txDeposito
            // 
            this.txDeposito.Location = new System.Drawing.Point(526, 154);
            this.txDeposito.Name = "txDeposito";
            this.txDeposito.Size = new System.Drawing.Size(100, 20);
            this.txDeposito.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Saldo actual: ";
            // 
            // lbActual
            // 
            this.lbActual.AutoSize = true;
            this.lbActual.Location = new System.Drawing.Point(243, 217);
            this.lbActual.Name = "lbActual";
            this.lbActual.Size = new System.Drawing.Size(62, 13);
            this.lbActual.TabIndex = 11;
            this.lbActual.Text = "saldoActual";
            // 
            // frmDepositar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txDeposito);
            this.Controls.Add(this.label2);
            this.Name = "frmDepositar";
            this.Text = "frmDepositar";
            this.Load += new System.EventHandler(this.frmDepositar_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txDeposito, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lbActual, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDeposito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbActual;
    }
}