
namespace practicaHerencia
{
    partial class frmOperaciones
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
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Chocolate;
            this.btnAbrir.ForeColor = System.Drawing.Color.Maroon;
            this.btnAbrir.Location = new System.Drawing.Point(124, 189);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(112, 34);
            this.btnAbrir.TabIndex = 2;
            this.btnAbrir.Text = "Abrir cuenta con $1000";
            this.btnAbrir.UseVisualStyleBackColor = false;
            // 
            // btnRetirar
            // 
            this.btnRetirar.BackColor = System.Drawing.Color.Chocolate;
            this.btnRetirar.ForeColor = System.Drawing.Color.Maroon;
            this.btnRetirar.Location = new System.Drawing.Point(504, 189);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(112, 34);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = false;
            // 
            // btnDepositar
            // 
            this.btnDepositar.BackColor = System.Drawing.Color.Chocolate;
            this.btnDepositar.ForeColor = System.Drawing.Color.Maroon;
            this.btnDepositar.Location = new System.Drawing.Point(656, 189);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(112, 34);
            this.btnDepositar.TabIndex = 4;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(109, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "¿Nuevo usuario?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(563, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿Ya tiene cuenta?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frmOperaciones";
            this.Text = "frmOperaciones";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            this.Controls.SetChildIndex(this.btnAbrir, 0);
            this.Controls.SetChildIndex(this.btnRetirar, 0);
            this.Controls.SetChildIndex(this.btnDepositar, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}