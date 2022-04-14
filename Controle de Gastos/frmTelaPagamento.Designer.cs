namespace Controle_de_Gastos
{
    partial class frmTelaPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPagamento));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.checkVisa = new System.Windows.Forms.CheckBox();
            this.checkDinheiro = new System.Windows.Forms.CheckBox();
            this.checkMastercard = new System.Windows.Forms.CheckBox();
            this.checkPayPal = new System.Windows.Forms.CheckBox();
            this.buttonPagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(464, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(255, 143);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 213);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(261, 249);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // checkVisa
            // 
            this.checkVisa.AutoSize = true;
            this.checkVisa.Location = new System.Drawing.Point(307, 109);
            this.checkVisa.Name = "checkVisa";
            this.checkVisa.Size = new System.Drawing.Size(15, 14);
            this.checkVisa.TabIndex = 5;
            this.checkVisa.UseVisualStyleBackColor = true;
            // 
            // checkDinheiro
            // 
            this.checkDinheiro.AutoSize = true;
            this.checkDinheiro.Location = new System.Drawing.Point(307, 356);
            this.checkDinheiro.Name = "checkDinheiro";
            this.checkDinheiro.Size = new System.Drawing.Size(15, 14);
            this.checkDinheiro.TabIndex = 6;
            this.checkDinheiro.UseVisualStyleBackColor = true;
            // 
            // checkMastercard
            // 
            this.checkMastercard.AutoSize = true;
            this.checkMastercard.Location = new System.Drawing.Point(768, 109);
            this.checkMastercard.Name = "checkMastercard";
            this.checkMastercard.Size = new System.Drawing.Size(15, 14);
            this.checkMastercard.TabIndex = 7;
            this.checkMastercard.UseVisualStyleBackColor = true;
            // 
            // checkPayPal
            // 
            this.checkPayPal.AutoSize = true;
            this.checkPayPal.Location = new System.Drawing.Point(768, 294);
            this.checkPayPal.Name = "checkPayPal";
            this.checkPayPal.Size = new System.Drawing.Size(15, 14);
            this.checkPayPal.TabIndex = 8;
            this.checkPayPal.UseVisualStyleBackColor = true;
            // 
            // buttonPagamento
            // 
            this.buttonPagamento.Location = new System.Drawing.Point(494, 477);
            this.buttonPagamento.Name = "buttonPagamento";
            this.buttonPagamento.Size = new System.Drawing.Size(128, 33);
            this.buttonPagamento.TabIndex = 9;
            this.buttonPagamento.Text = "Realizar pagamento";
            this.buttonPagamento.UseVisualStyleBackColor = true;
            // 
            // frmTelaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 621);
            this.Controls.Add(this.buttonPagamento);
            this.Controls.Add(this.checkPayPal);
            this.Controls.Add(this.checkMastercard);
            this.Controls.Add(this.checkDinheiro);
            this.Controls.Add(this.checkVisa);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTelaPagamento";
            this.Text = "Formas de Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox checkVisa;
        private System.Windows.Forms.CheckBox checkDinheiro;
        private System.Windows.Forms.CheckBox checkMastercard;
        private System.Windows.Forms.CheckBox checkPayPal;
        private System.Windows.Forms.Button buttonPagamento;
    }
}