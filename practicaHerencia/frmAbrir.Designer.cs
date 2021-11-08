
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
            this.txNombre = new System.Windows.Forms.TextBox();
            this.lbError = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAbrir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(27, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposita la cantidad correspondiente ($1,000.00):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(225, 114);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(100, 20);
            this.txNombre.TabIndex = 7;
            this.txNombre.TextChanged += new System.EventHandler(this.txAbrir_TextChanged);
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
            this.btnValidar.Location = new System.Drawing.Point(98, 247);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(112, 34);
            this.btnValidar.TabIndex = 10;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnRetirar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // txtAbrir
            // 
            this.txtAbrir.Location = new System.Drawing.Point(441, 187);
            this.txtAbrir.Name = "txtAbrir";
            this.txtAbrir.Size = new System.Drawing.Size(100, 20);
            this.txtAbrir.TabIndex = 12;
            this.txtAbrir.TextChanged += new System.EventHandler(this.txtAbrir_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crear NIP (4 digitos)";
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(225, 153);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(100, 20);
            this.txtNip.TabIndex = 14;
            this.txtNip.TextChanged += new System.EventHandler(this.txtNip_TextChanged);
            // 
            // frmAbrir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAbrir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label2);
            this.Name = "frmAbrir";
            this.Text = "frmAbrir";
            this.Load += new System.EventHandler(this.frmAbrir_Load);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txNombre, 0);
            this.Controls.SetChildIndex(this.lbError, 0);
            this.Controls.SetChildIndex(this.btnValidar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAbrir, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNip, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAbrir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNip;
    }
}