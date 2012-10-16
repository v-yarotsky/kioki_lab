namespace CryptographyTemplate
{
    partial class GridForm
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
            this.gridSizeSpinBox = new System.Windows.Forms.NumericUpDown();
            this.gridSizeSpinBoxLabel = new System.Windows.Forms.Label();
            this.gridLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeSpinBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSizeSpinBox
            // 
            this.gridSizeSpinBox.Location = new System.Drawing.Point(113, 7);
            this.gridSizeSpinBox.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.gridSizeSpinBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gridSizeSpinBox.Name = "gridSizeSpinBox";
            this.gridSizeSpinBox.Size = new System.Drawing.Size(49, 20);
            this.gridSizeSpinBox.TabIndex = 0;
            this.gridSizeSpinBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gridSizeSpinBox.ValueChanged += new System.EventHandler(this.gridSizeSpinBox_ValueChanged);
            // 
            // gridSizeSpinBoxLabel
            // 
            this.gridSizeSpinBoxLabel.AutoSize = true;
            this.gridSizeSpinBoxLabel.Location = new System.Drawing.Point(12, 9);
            this.gridSizeSpinBoxLabel.Name = "gridSizeSpinBoxLabel";
            this.gridSizeSpinBoxLabel.Size = new System.Drawing.Size(95, 13);
            this.gridSizeSpinBoxLabel.TabIndex = 1;
            this.gridSizeSpinBoxLabel.Text = "Размер решетки:";
            // 
            // gridLayout
            // 
            this.gridLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gridLayout.ColumnCount = 1;
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridLayout.Location = new System.Drawing.Point(15, 33);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.RowCount = 1;
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.gridLayout.Size = new System.Drawing.Size(400, 400);
            this.gridLayout.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(15, 439);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(400, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // GridForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 470);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.gridSizeSpinBoxLabel);
            this.Controls.Add(this.gridSizeSpinBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.GridForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gridSizeSpinBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown gridSizeSpinBox;
        private System.Windows.Forms.Label gridSizeSpinBoxLabel;
        private System.Windows.Forms.TableLayoutPanel gridLayout;
        private System.Windows.Forms.Button btnOk;
    }
}