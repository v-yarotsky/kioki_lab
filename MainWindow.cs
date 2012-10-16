using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptographyTemplate
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            String input = System.IO.File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);
            inputText.Text = input;
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            System.IO.File.WriteAllText(saveFileDialog.FileName, outputText.Text, Encoding.UTF8);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            algorithmDrowdown.SelectedIndex = 0;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionStrategy s = GetEncryptionStrategy();
                outputText.Text = s.encrypt();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EncryptionStrategy GetEncryptionStrategy()
        {
            EncryptionStrategy result = null;
            String input = inputText.Text;

            switch (algorithmDrowdown.Text)
            {
                case "Железнодорожная изгородь":
                    try
                    {
                        int key = int.Parse(keyInput.Text);
                        result = new EncryptionStrategies.RailwayFenceEncryptionStrategy(input, key);
                    }
                    catch (FormatException err)
                    {
                        throw new ArgumentException("Ключ должен быть числом");
                    }
                    break;
                case "\"Ключевая фраза\"": 
                    result = new EncryptionStrategies.PassPhraseEncryptionStrategy(input, keyInput.Text); break;
                case "Метод поворачивающейся решетки":
                    GridForm gridForm = new GridForm();
                    if (gridForm.ShowDialog() == DialogResult.OK)
                    {
                        result = new EncryptionStrategies.RotatingGridEncryptionStrategy(input, gridForm.GetGrid());
                    } break;
                case "Шифр Вижинера": 
                    result = new EncryptionStrategies.VigenereEncryptionStrategy(input, keyInput.Text); break;
                default:
                    throw new ArgumentException("Выберите метод шифрования");
            }

            return result;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                EncryptionStrategy s = GetEncryptionStrategy();
                outputText.Text = s.decrypt();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
