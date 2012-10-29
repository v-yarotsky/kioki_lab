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
        public enum Mode { Encrypt, Decrypt };

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
                if (IsSignatureMode())
                {
                    Signer s = GetSigner();
                    outputText.Text = s.sign(inputText.Text, signKey).ToString();
                }
                else
                {
                    EncryptionStrategy s = GetEncryptionStrategy();
                    outputText.Text = s.encrypt();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private EncryptionStrategy GetEncryptionStrategy(Mode mode = Mode.Encrypt)
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
                case "Криптосистема Рабина":
                    RabinKeyForm keyForm = new RabinKeyForm(mode);
                    if (keyForm.ShowDialog() == DialogResult.OK)
                    {
                        result = new EncryptionStrategies.RabinEncryptionStrategy(input, mode == Mode.Encrypt ? keyForm.PublicKey : keyForm.PrivateKey);
                    } break;
                default:
                    throw new ArgumentException("Выберите метод шифрования");
            }

            return result;
        }

        private SignKey signKey;

        public Signer GetSigner(Mode mode = Mode.Encrypt)
        {
            Signer result = null;
            String input = inputText.Text;

            switch (algorithmDrowdown.Text)
            {
                case "Цифровая подпись RSA":
                    RSAKeyForm rsaKeyForm = new RSAKeyForm(mode);
                    if (rsaKeyForm.ShowDialog() == DialogResult.OK)
                    {
                        signKey = mode == Mode.Encrypt ? rsaKeyForm.PrivateKey : rsaKeyForm.PublicKey;
                        result = new RSASigner();
                    }
                    break;
                default:
                    throw new ArgumentException("Выберите метод подписи");
            }

            return result;
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSignatureMode())
                {
                    Signer s = GetSigner(Mode.Decrypt);
                    if (s.checkSignature(new SignedString(inputText.Text), signKey))
                    {
                        System.Windows.Forms.MessageBox.Show("Подпись верна");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Подпись НЕ верна");
                    }
                }
                else
                {
                    EncryptionStrategy s = GetEncryptionStrategy(Mode.Decrypt);
                    outputText.Text = s.decrypt();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsSignatureMode()
        {
            return algorithmDrowdown.Text == "Цифровая подпись RSA";
        }
    }
}
