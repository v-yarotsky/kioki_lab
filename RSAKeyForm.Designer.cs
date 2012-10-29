namespace CryptographyTemplate
{
    partial class RSAKeyForm
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
            this.gbPublicKey = new System.Windows.Forms.GroupBox();
            this.gbPrivateKey = new System.Windows.Forms.GroupBox();
            this.lblPubKeyE = new System.Windows.Forms.Label();
            this.lblPubKeyN = new System.Windows.Forms.Label();
            this.lblPrivKeyD = new System.Windows.Forms.Label();
            this.lblPrivKeyN = new System.Windows.Forms.Label();
            this.tbPubKeyE = new System.Windows.Forms.TextBox();
            this.tbPubKeyN = new System.Windows.Forms.TextBox();
            this.tbPrivKeyD = new System.Windows.Forms.TextBox();
            this.tbPrivKeyN = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQOut = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblPOut = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblNOut = new System.Windows.Forms.Label();
            this.lblPhi = new System.Windows.Forms.Label();
            this.lblPhiOut = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbPublicKey.SuspendLayout();
            this.gbPrivateKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPublicKey
            // 
            this.gbPublicKey.Controls.Add(this.tbPubKeyN);
            this.gbPublicKey.Controls.Add(this.tbPubKeyE);
            this.gbPublicKey.Controls.Add(this.lblPubKeyN);
            this.gbPublicKey.Controls.Add(this.lblPubKeyE);
            this.gbPublicKey.Location = new System.Drawing.Point(13, 6);
            this.gbPublicKey.Name = "gbPublicKey";
            this.gbPublicKey.Size = new System.Drawing.Size(198, 79);
            this.gbPublicKey.TabIndex = 0;
            this.gbPublicKey.TabStop = false;
            this.gbPublicKey.Text = "Открытый ключ";
            // 
            // gbPrivateKey
            // 
            this.gbPrivateKey.Controls.Add(this.tbPrivKeyN);
            this.gbPrivateKey.Controls.Add(this.tbPrivKeyD);
            this.gbPrivateKey.Controls.Add(this.lblPrivKeyN);
            this.gbPrivateKey.Controls.Add(this.lblPrivKeyD);
            this.gbPrivateKey.Location = new System.Drawing.Point(217, 6);
            this.gbPrivateKey.Name = "gbPrivateKey";
            this.gbPrivateKey.Size = new System.Drawing.Size(198, 79);
            this.gbPrivateKey.TabIndex = 1;
            this.gbPrivateKey.TabStop = false;
            this.gbPrivateKey.Text = "Секретный ключ";
            // 
            // lblPubKeyE
            // 
            this.lblPubKeyE.AutoSize = true;
            this.lblPubKeyE.Location = new System.Drawing.Point(7, 26);
            this.lblPubKeyE.Name = "lblPubKeyE";
            this.lblPubKeyE.Size = new System.Drawing.Size(17, 13);
            this.lblPubKeyE.TabIndex = 0;
            this.lblPubKeyE.Text = "E:";
            // 
            // lblPubKeyN
            // 
            this.lblPubKeyN.AutoSize = true;
            this.lblPubKeyN.Location = new System.Drawing.Point(7, 52);
            this.lblPubKeyN.Name = "lblPubKeyN";
            this.lblPubKeyN.Size = new System.Drawing.Size(18, 13);
            this.lblPubKeyN.TabIndex = 1;
            this.lblPubKeyN.Text = "N:";
            // 
            // lblPrivKeyD
            // 
            this.lblPrivKeyD.AutoSize = true;
            this.lblPrivKeyD.Location = new System.Drawing.Point(6, 22);
            this.lblPrivKeyD.Name = "lblPrivKeyD";
            this.lblPrivKeyD.Size = new System.Drawing.Size(18, 13);
            this.lblPrivKeyD.TabIndex = 2;
            this.lblPrivKeyD.Text = "D:";
            // 
            // lblPrivKeyN
            // 
            this.lblPrivKeyN.AutoSize = true;
            this.lblPrivKeyN.Location = new System.Drawing.Point(6, 55);
            this.lblPrivKeyN.Name = "lblPrivKeyN";
            this.lblPrivKeyN.Size = new System.Drawing.Size(18, 13);
            this.lblPrivKeyN.TabIndex = 3;
            this.lblPrivKeyN.Text = "N:";
            // 
            // tbPubKeyE
            // 
            this.tbPubKeyE.Location = new System.Drawing.Point(30, 19);
            this.tbPubKeyE.Name = "tbPubKeyE";
            this.tbPubKeyE.Size = new System.Drawing.Size(153, 20);
            this.tbPubKeyE.TabIndex = 2;
            // 
            // tbPubKeyN
            // 
            this.tbPubKeyN.Location = new System.Drawing.Point(31, 49);
            this.tbPubKeyN.Name = "tbPubKeyN";
            this.tbPubKeyN.Size = new System.Drawing.Size(153, 20);
            this.tbPubKeyN.TabIndex = 3;
            // 
            // tbPrivKeyD
            // 
            this.tbPrivKeyD.Location = new System.Drawing.Point(30, 19);
            this.tbPrivKeyD.Name = "tbPrivKeyD";
            this.tbPrivKeyD.Size = new System.Drawing.Size(153, 20);
            this.tbPrivKeyD.TabIndex = 4;
            // 
            // tbPrivKeyN
            // 
            this.tbPrivKeyN.Location = new System.Drawing.Point(30, 52);
            this.tbPrivKeyN.Name = "tbPrivKeyN";
            this.tbPrivKeyN.Size = new System.Drawing.Size(153, 20);
            this.tbPrivKeyN.TabIndex = 5;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(12, 99);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 13);
            this.lblP.TabIndex = 2;
            this.lblP.Text = "P:";
            // 
            // lblQOut
            // 
            this.lblQOut.AutoSize = true;
            this.lblQOut.Location = new System.Drawing.Point(40, 122);
            this.lblQOut.Name = "lblQOut";
            this.lblQOut.Size = new System.Drawing.Size(0, 13);
            this.lblQOut.TabIndex = 3;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(12, 122);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(18, 13);
            this.lblQ.TabIndex = 4;
            this.lblQ.Text = "Q:";
            // 
            // lblPOut
            // 
            this.lblPOut.AutoSize = true;
            this.lblPOut.Location = new System.Drawing.Point(40, 99);
            this.lblPOut.Name = "lblPOut";
            this.lblPOut.Size = new System.Drawing.Size(0, 13);
            this.lblPOut.TabIndex = 5;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(112, 99);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "N:";
            // 
            // lblNOut
            // 
            this.lblNOut.AutoSize = true;
            this.lblNOut.Location = new System.Drawing.Point(136, 99);
            this.lblNOut.Name = "lblNOut";
            this.lblNOut.Size = new System.Drawing.Size(0, 13);
            this.lblNOut.TabIndex = 6;
            // 
            // lblPhi
            // 
            this.lblPhi.AutoSize = true;
            this.lblPhi.Location = new System.Drawing.Point(105, 122);
            this.lblPhi.Name = "lblPhi";
            this.lblPhi.Size = new System.Drawing.Size(25, 13);
            this.lblPhi.TabIndex = 9;
            this.lblPhi.Text = "Phi:";
            // 
            // lblPhiOut
            // 
            this.lblPhiOut.AutoSize = true;
            this.lblPhiOut.Location = new System.Drawing.Point(136, 122);
            this.lblPhiOut.Name = "lblPhiOut";
            this.lblPhiOut.Size = new System.Drawing.Size(0, 13);
            this.lblPhiOut.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(217, 112);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(117, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(340, 112);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // RSAKeyForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 148);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblPhi);
            this.Controls.Add(this.lblPhiOut);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblNOut);
            this.Controls.Add(this.lblPOut);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblQOut);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.gbPrivateKey);
            this.Controls.Add(this.gbPublicKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RSAKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ключ";
            this.TopMost = true;
            this.gbPublicKey.ResumeLayout(false);
            this.gbPublicKey.PerformLayout();
            this.gbPrivateKey.ResumeLayout(false);
            this.gbPrivateKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPublicKey;
        private System.Windows.Forms.TextBox tbPubKeyN;
        private System.Windows.Forms.TextBox tbPubKeyE;
        private System.Windows.Forms.Label lblPubKeyN;
        private System.Windows.Forms.Label lblPubKeyE;
        private System.Windows.Forms.GroupBox gbPrivateKey;
        private System.Windows.Forms.TextBox tbPrivKeyN;
        private System.Windows.Forms.TextBox tbPrivKeyD;
        private System.Windows.Forms.Label lblPrivKeyN;
        private System.Windows.Forms.Label lblPrivKeyD;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQOut;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblPOut;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblNOut;
        private System.Windows.Forms.Label lblPhi;
        private System.Windows.Forms.Label lblPhiOut;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOk;
    }
}