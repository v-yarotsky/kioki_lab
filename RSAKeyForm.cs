using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;

namespace CryptographyTemplate
{
    public partial class RSAKeyForm : Form
    {
        private SignKey publicKey;
        private SignKey privateKey;
        private MainWindow.Mode mode;

        public SignKey PublicKey
        { 
            get { return publicKey; }
            private set
            {
                publicKey = value;
                tbPubKeyE.Text = publicKey.Exponent.ToString();
                tbPubKeyN.Text = publicKey.Modulus.ToString();
            }
        }

        public SignKey PrivateKey
        { 
            get { return privateKey; }
            private set
            {
                privateKey = value;
                tbPrivKeyD.Text = privateKey.Exponent.ToString();
                tbPrivKeyN.Text = privateKey.Modulus.ToString();
            }
        }

        private RSAKeyGenerator generator;

        public RSAKeyForm(MainWindow.Mode mode = MainWindow.Mode.Encrypt)
        {
            InitializeComponent();
            this.mode = mode;
            if (mode == MainWindow.Mode.Decrypt)
            {
                btnGenerate.Enabled = false;
                tbPrivKeyD.Enabled = false;
                tbPrivKeyN.Enabled = false;
            }
            else
            {
                generator = new RSAKeyGenerator();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generator.Generate();

            lblPOut.Text = generator.P.ToString();
            lblQOut.Text = generator.Q.ToString();
            lblNOut.Text = generator.N.ToString();
            lblPhiOut.Text = generator.Phi.ToString();

            PrivateKey = generator.PrivateKey;
            PublicKey = generator.PublicKey;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (mode == MainWindow.Mode.Encrypt)
            {
                privateKey = new SignKey(BigInteger.Parse(tbPrivKeyD.Text), BigInteger.Parse(tbPrivKeyN.Text));
            }
            publicKey = new SignKey(BigInteger.Parse(tbPubKeyE.Text), BigInteger.Parse(tbPubKeyN.Text));
            DialogResult = DialogResult.OK;
        }
    }
}
