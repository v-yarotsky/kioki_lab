using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CryptographyTemplate.EncryptionStrategies;
using System.Numerics;

namespace CryptographyTemplate
{
    public partial class RabinKeyForm : Form
    {
        public MainWindow.Mode Mode { get; set; }
        public RabinEncryptionStrategy.RabinKey PublicKey { get; private set; }
        public RabinEncryptionStrategy.RabinKey PrivateKey { get; private set; }

        public RabinKeyForm(MainWindow.Mode mode = MainWindow.Mode.Encrypt)
        {
            this.Mode = mode;
            InitializeComponent();
        }

        private void DisablePublicKeyControls()
        {
            btnGenerate.Enabled = false;
            tbN.Enabled = false;
        }

        private void EnablePublicKeyControls()
        {
            btnGenerate.Enabled = true;
            tbN.Enabled = true;
        }

        private void RabinKeyForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            RabinEncryptionStrategy.RabinKeyGenerator generator = new RabinEncryptionStrategy.RabinKeyGenerator(999999);
            generator.GenerateKeys();
            tbP.Text = generator.PrivateKey.P.ToString();
            tbQ.Text = generator.PrivateKey.Q.ToString();
            tbN.Text = generator.PublicKey.N.ToString();
       }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Mode == MainWindow.Mode.Encrypt && tbN.Text != "")
            {
                PublicKey = new RabinEncryptionStrategy.RabinKey(BigInteger.Parse(tbN.Text));
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else if (Mode == MainWindow.Mode.Decrypt && tbP.Text != "" && tbQ.Text != "")
            {
                PrivateKey = new RabinEncryptionStrategy.RabinKey(BigInteger.Parse(tbP.Text), BigInteger.Parse(tbQ.Text));
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void RabinKeyForm_Shown(object sender, EventArgs e)
        {
            if (Mode == MainWindow.Mode.Decrypt)
            {
                DisablePublicKeyControls();
            }
            else if (Mode == MainWindow.Mode.Encrypt)
            {
                EnablePublicKeyControls();
            }
        }
    }
}
