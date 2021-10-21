
namespace practicaHerencia
{
    partial class frmAbrir
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
            this.txAbrir = new System.Windows.Forms.TextBox();
            this.lbExito = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(25, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposita la cantidad correspondiente ($1,000.00):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txAbrir
            // 
            this.txAbrir.Location = new System.Drawing.Point(399, 159);
            this.txAbrir.Name = "txAbrir";
            this.txAbrir.Size = new System.Drawing.Size(100, 20);
            this.txAbrir.TabIndex = 7;
            this.txAbrir.TextChanged += new System.EventHandler(this.txAbrir_TextChanged);
            // 
            // lbExito
            // 
            this.lbExito.AutoSize = true;
            this.lbExito.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExito.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbExito.Location = new System.Drawing.Point(331, 272);
            this.lbExito.Name = "lbExito";
            this.lbExito.Size = new System.Drawing.Size(191, 17);
            this.lbExito.TabIndex = 8;
            this.lbExito.Text = "Cuenta generada con exito";
            this.lbExito.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(253, 317);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(338, 17);
            this.lbError.TabIndex = 9;
            this.lbError.Text = "La cuenta no puede ser creada (Valor erroneo)";
            this.lbError.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.Chocolate;
            this.btnValidar.ForeColor = System.Drawing.Color.Maroon;
            this.btnValidar.Location = new System.Drawing.Point(166, 207);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(112, 34);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnRetirar_Click_1);
            // 
            // frmAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.lbExito);
            this.Controls.Add(this.txAbrir);
            this.Controls.Add(this.label2);
            this.Name = "frmAbrir";
            this.Text = "frmAbrir";
            this.Load += new System.EventHandler(this.frmAbrir_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txAbrir, 0);
            this.Controls.SetChildIndex(this.lbExito, 0);
            this.Controls.SetChildIndex(this.lbError, 0);
            this.Controls.SetChildIndex(this.btnValidar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txAbrir;
        private System.Windows.Forms.Label lbExito;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnValidar;
    }
}