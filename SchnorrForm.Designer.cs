namespace CryptographyTemplate
{
    partial class SchnorrForm
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
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbT = new System.Windows.Forms.TextBox();
            this.tbS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGenerateSchnorr = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnGenerateCall = new System.Windows.Forms.Button();
            this.btnGenerateChallenge = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRespond = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(35, 12);
            this.tbP.Name = "tbP";
            this.tbP.ReadOnly = true;
            this.tbP.Size = new System.Drawing.Size(100, 20);
            this.tbP.TabIndex = 0;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(35, 39);
            this.tbQ.Name = "tbQ";
            this.tbQ.ReadOnly = true;
            this.tbQ.Size = new System.Drawing.Size(100, 20);
            this.tbQ.TabIndex = 1;
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(35, 66);
            this.tbH.Name = "tbH";
            this.tbH.ReadOnly = true;
            this.tbH.Size = new System.Drawing.Size(100, 20);
            this.tbH.TabIndex = 2;
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(35, 93);
            this.tbG.Name = "tbG";
            this.tbG.ReadOnly = true;
            this.tbG.Size = new System.Drawing.Size(100, 20);
            this.tbG.TabIndex = 3;
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(35, 120);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(100, 20);
            this.tbT.TabIndex = 4;
            this.tbT.TextChanged += new System.EventHandler(this.tbT_TextChanged);
            // 
            // tbS
            // 
            this.tbS.Location = new System.Drawing.Point(35, 176);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(100, 20);
            this.tbS.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "P:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "H:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "G:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "T:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "S:";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(35, 202);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "A:";
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(234, 12);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(100, 20);
            this.tbR.TabIndex = 14;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(234, 39);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "R:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "X:";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(234, 94);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(100, 20);
            this.tbE.TabIndex = 18;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(235, 149);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 19;
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(234, 204);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(100, 20);
            this.tbZ.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "E:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(211, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Z:";
            // 
            // btnGenerateSchnorr
            // 
            this.btnGenerateSchnorr.Location = new System.Drawing.Point(35, 147);
            this.btnGenerateSchnorr.Name = "btnGenerateSchnorr";
            this.btnGenerateSchnorr.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateSchnorr.TabIndex = 24;
            this.btnGenerateSchnorr.Text = "Сгенерировать";
            this.btnGenerateSchnorr.UseVisualStyleBackColor = true;
            this.btnGenerateSchnorr.Click += new System.EventHandler(this.btnGenerateSchnorr_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(35, 229);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateKeys.TabIndex = 25;
            this.btnGenerateKeys.Text = "Сгенерировать";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnGenerateCall
            // 
            this.btnGenerateCall.Location = new System.Drawing.Point(234, 65);
            this.btnGenerateCall.Name = "btnGenerateCall";
            this.btnGenerateCall.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateCall.TabIndex = 26;
            this.btnGenerateCall.Text = "Сгенерировать";
            this.btnGenerateCall.UseVisualStyleBackColor = true;
            this.btnGenerateCall.Click += new System.EventHandler(this.btnGenerateCall_Click);
            // 
            // btnGenerateChallenge
            // 
            this.btnGenerateChallenge.Location = new System.Drawing.Point(234, 121);
            this.btnGenerateChallenge.Name = "btnGenerateChallenge";
            this.btnGenerateChallenge.Size = new System.Drawing.Size(100, 23);
            this.btnGenerateChallenge.TabIndex = 27;
            this.btnGenerateChallenge.Text = "Сгенерировать";
            this.btnGenerateChallenge.UseVisualStyleBackColor = true;
            this.btnGenerateChallenge.Click += new System.EventHandler(this.btnGenerateChallenge_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(235, 229);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(100, 23);
            this.btnVerify.TabIndex = 28;
            this.btnVerify.Text = "Проверить";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(234, 260);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 29;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRespond
            // 
            this.btnRespond.Location = new System.Drawing.Point(235, 175);
            this.btnRespond.Name = "btnRespond";
            this.btnRespond.Size = new System.Drawing.Size(99, 23);
            this.btnRespond.TabIndex = 30;
            this.btnRespond.Text = "Вычислить";
            this.btnRespond.UseVisualStyleBackColor = true;
            this.btnRespond.Click += new System.EventHandler(this.btnRespond_Click);
            // 
            // SchnorrForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 295);
            this.Controls.Add(this.btnRespond);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnGenerateChallenge);
            this.Controls.Add(this.btnGenerateCall);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.btnGenerateSchnorr);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbS);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.tbP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchnorrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SchnorrForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SchnorrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnGenerateSchnorr;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnGenerateCall;
        private System.Windows.Forms.Button btnGenerateChallenge;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnRespond;
    }
}