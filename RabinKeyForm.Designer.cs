namespace CryptographyTemplate
{
    partial class RabinKeyForm
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
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(13, 13);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 13);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "P:";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(12, 39);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(18, 13);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Q:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 66);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "N:";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(54, 10);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(141, 20);
            this.tbP.TabIndex = 3;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(54, 36);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(141, 20);
            this.tbQ.TabIndex = 4;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(54, 63);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(141, 20);
            this.tbN.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(16, 116);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(98, 23);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(120, 116);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // RabinKeyForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 151);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RabinKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ключи";
            this.Load += new System.EventHandler(this.RabinKeyForm_Load);
            this.Shown += new System.EventHandler(this.RabinKeyForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnOk;
    }
}