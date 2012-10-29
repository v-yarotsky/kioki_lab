namespace CryptographyTemplate
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openFileButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.algorithmDropdownLabel = new System.Windows.Forms.ToolStripLabel();
            this.algorithmDrowdown = new System.Windows.Forms.ToolStripComboBox();
            this.keyInputLabel = new System.Windows.Forms.ToolStripLabel();
            this.keyInput = new System.Windows.Forms.ToolStripTextBox();
            this.decryptButton = new System.Windows.Forms.ToolStripButton();
            this.encryptButton = new System.Windows.Forms.ToolStripButton();
            this.ioContainer = new System.Windows.Forms.TableLayoutPanel();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip.SuspendLayout();
            this.ioContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.saveFileButton,
            this.toolStripSeparator,
            this.algorithmDropdownLabel,
            this.algorithmDrowdown,
            this.keyInputLabel,
            this.keyInput,
            this.decryptButton,
            this.encryptButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(692, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            // 
            // openFileButton
            // 
            this.openFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(57, 22);
            this.openFileButton.Text = "Открыть";
            this.openFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(66, 22);
            this.saveFileButton.Text = "Сохранить";
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // algorithmDropdownLabel
            // 
            this.algorithmDropdownLabel.Name = "algorithmDropdownLabel";
            this.algorithmDropdownLabel.Size = new System.Drawing.Size(44, 22);
            this.algorithmDropdownLabel.Text = "Метод:";
            // 
            // algorithmDrowdown
            // 
            this.algorithmDrowdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.algorithmDrowdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.algorithmDrowdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmDrowdown.Items.AddRange(new object[] {
            "Железнодорожная изгородь",
            "\"Ключевая фраза\"",
            "Метод поворачивающейся решетки",
            "Шифр Вижинера",
            "Криптосистема Рабина",
            "Цифровая подпись RSA"});
            this.algorithmDrowdown.Name = "algorithmDrowdown";
            this.algorithmDrowdown.Size = new System.Drawing.Size(170, 25);
            // 
            // keyInputLabel
            // 
            this.keyInputLabel.Name = "keyInputLabel";
            this.keyInputLabel.Size = new System.Drawing.Size(39, 22);
            this.keyInputLabel.Text = "Ключ:";
            // 
            // keyInput
            // 
            this.keyInput.Name = "keyInput";
            this.keyInput.Size = new System.Drawing.Size(120, 25);
            // 
            // decryptButton
            // 
            this.decryptButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.decryptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decryptButton.Image = ((System.Drawing.Image)(resources.GetObject("decryptButton.Image")));
            this.decryptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(86, 22);
            this.decryptButton.Text = "Расшифровать";
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.encryptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.encryptButton.Image = ((System.Drawing.Image)(resources.GetObject("encryptButton.Image")));
            this.encryptButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(81, 22);
            this.encryptButton.Text = "Зашифровать";
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // ioContainer
            // 
            this.ioContainer.ColumnCount = 2;
            this.ioContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ioContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ioContainer.Controls.Add(this.inputText, 0, 0);
            this.ioContainer.Controls.Add(this.outputText, 1, 0);
            this.ioContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioContainer.Location = new System.Drawing.Point(0, 25);
            this.ioContainer.Name = "ioContainer";
            this.ioContainer.RowCount = 1;
            this.ioContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.ioContainer.Size = new System.Drawing.Size(692, 341);
            this.ioContainer.TabIndex = 1;
            // 
            // inputText
            // 
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputText.Location = new System.Drawing.Point(3, 3);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(340, 335);
            this.inputText.TabIndex = 2;
            this.inputText.Text = "";
            // 
            // outputText
            // 
            this.outputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputText.Location = new System.Drawing.Point(349, 3);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(340, 335);
            this.outputText.TabIndex = 3;
            this.outputText.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "input";
            this.openFileDialog.Filter = "Text files (*.txt) | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "output";
            this.saveFileDialog.Filter = "Text files (*.txt) | *.txt";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 366);
            this.Controls.Add(this.ioContainer);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "MainWindow";
            this.Text = "Cryptography Yarotsky V.";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ioContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton openFileButton;
        private System.Windows.Forms.ToolStripComboBox algorithmDrowdown;
        private System.Windows.Forms.ToolStripTextBox keyInput;
        private System.Windows.Forms.ToolStripButton encryptButton;
        private System.Windows.Forms.ToolStripButton decryptButton;
        private System.Windows.Forms.ToolStripLabel algorithmDropdownLabel;
        private System.Windows.Forms.ToolStripLabel keyInputLabel;
        private System.Windows.Forms.TableLayoutPanel ioContainer;
        private System.Windows.Forms.ToolStripButton saveFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.RichTextBox outputText;
    }
}

