namespace CryptographyTemplate
{
    partial class DSAForm
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
            this.gbDomainParameters = new System.Windows.Forms.GroupBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPublicKey = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbPrivateKey = new System.Windows.Forms.GroupBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbGenerationParameters = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sbMaxQ = new System.Windows.Forms.NumericUpDown();
            this.sbMinQ = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbDomainParameters.SuspendLayout();
            this.gbPublicKey.SuspendLayout();
            this.gbPrivateKey.SuspendLayout();
            this.gbGenerationParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbMaxQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbMinQ)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDomainParameters
            // 
            this.gbDomainParameters.Controls.Add(this.tbG);
            this.gbDomainParameters.Controls.Add(this.tbP);
            this.gbDomainParameters.Controls.Add(this.tbQ);
            this.gbDomainParameters.Controls.Add(this.label3);
            this.gbDomainParameters.Controls.Add(this.label2);
            this.gbDomainParameters.Controls.Add(this.label1);
            this.gbDomainParameters.Location = new System.Drawing.Point(12, 12);
            this.gbDomainParameters.Name = "gbDomainParameters";
            this.gbDomainParameters.Size = new System.Drawing.Size(195, 124);
            this.gbDomainParameters.TabIndex = 0;
            this.gbDomainParameters.TabStop = false;
            this.gbDomainParameters.Text = "Доменные параметры";
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(31, 79);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(153, 20);
            this.tbG.TabIndex = 5;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(31, 53);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(153, 20);
            this.tbP.TabIndex = 4;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(31, 27);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(153, 20);
            this.tbQ.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "G:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "P:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Q:";
            // 
            // gbPublicKey
            // 
            this.gbPublicKey.Controls.Add(this.tbY);
            this.gbPublicKey.Controls.Add(this.label6);
            this.gbPublicKey.Location = new System.Drawing.Point(213, 77);
            this.gbPublicKey.Name = "gbPublicKey";
            this.gbPublicKey.Size = new System.Drawing.Size(195, 59);
            this.gbPublicKey.TabIndex = 6;
            this.gbPublicKey.TabStop = false;
            this.gbPublicKey.Text = "Открытый ключ";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(31, 27);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(153, 20);
            this.tbY.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Y:";
            // 
            // gbPrivateKey
            // 
            this.gbPrivateKey.Controls.Add(this.tbX);
            this.gbPrivateKey.Controls.Add(this.label4);
            this.gbPrivateKey.Location = new System.Drawing.Point(213, 12);
            this.gbPrivateKey.Name = "gbPrivateKey";
            this.gbPrivateKey.Size = new System.Drawing.Size(195, 59);
            this.gbPrivateKey.TabIndex = 7;
            this.gbPrivateKey.TabStop = false;
            this.gbPrivateKey.Text = "Секретный ключ";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(31, 27);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(153, 20);
            this.tbX.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "X:";
            // 
            // gbGenerationParameters
            // 
            this.gbGenerationParameters.Controls.Add(this.label7);
            this.gbGenerationParameters.Controls.Add(this.sbMaxQ);
            this.gbGenerationParameters.Controls.Add(this.sbMinQ);
            this.gbGenerationParameters.Controls.Add(this.label5);
            this.gbGenerationParameters.Location = new System.Drawing.Point(12, 142);
            this.gbGenerationParameters.Name = "gbGenerationParameters";
            this.gbGenerationParameters.Size = new System.Drawing.Size(396, 61);
            this.gbGenerationParameters.TabIndex = 9;
            this.gbGenerationParameters.TabStop = false;
            this.gbGenerationParameters.Text = "Параметры генерирования";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Max Q:";
            // 
            // sbMaxQ
            // 
            this.sbMaxQ.Location = new System.Drawing.Point(245, 29);
            this.sbMaxQ.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.sbMaxQ.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sbMaxQ.Name = "sbMaxQ";
            this.sbMaxQ.Size = new System.Drawing.Size(134, 20);
            this.sbMaxQ.TabIndex = 2;
            this.sbMaxQ.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // sbMinQ
            // 
            this.sbMinQ.Location = new System.Drawing.Point(50, 29);
            this.sbMinQ.Maximum = new decimal(new int[] {
            9999998,
            0,
            0,
            0});
            this.sbMinQ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sbMinQ.Name = "sbMinQ";
            this.sbMinQ.Size = new System.Drawing.Size(134, 20);
            this.sbMinQ.TabIndex = 1;
            this.sbMinQ.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min Q:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(213, 209);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 23);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(317, 209);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // DSAForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 244);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gbGenerationParameters);
            this.Controls.Add(this.gbPrivateKey);
            this.Controls.Add(this.gbPublicKey);
            this.Controls.Add(this.gbDomainParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DSAForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DSAForm";
            this.gbDomainParameters.ResumeLayout(false);
            this.gbDomainParameters.PerformLayout();
            this.gbPublicKey.ResumeLayout(false);
            this.gbPublicKey.PerformLayout();
            this.gbPrivateKey.ResumeLayout(false);
            this.gbPrivateKey.PerformLayout();
            this.gbGenerationParameters.ResumeLayout(false);
            this.gbGenerationParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbMaxQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbMinQ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDomainParameters;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPublicKey;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbPrivateKey;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbGenerationParameters;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown sbMaxQ;
        private System.Windows.Forms.NumericUpDown sbMinQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOk;
    }
}