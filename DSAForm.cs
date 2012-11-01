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
    public partial class DSAForm : Form
    {
        public SignKey PrivateKey
        {
            get { return new SignKey(BigInteger.Parse(tbX.Text)); }
            set { tbX.Text = value.Value.ToString(); }
        }

        public SignKey PublicKey
        {
            get { return new SignKey(BigInteger.Parse(tbY.Text)); }
            set { tbY.Text = value.Value.ToString(); }
        }

        public DomainParameters Domain
        {
            get { return new DomainParameters(BigInteger.Parse(tbP.Text), BigInteger.Parse(tbQ.Text), BigInteger.Parse(tbG.Text)); }
            set
            {
                tbP.Text = value.P.ToString();
                tbQ.Text = value.Q.ToString();
                tbG.Text = value.G.ToString();
            }
        }

        private MainWindow.Mode mode;

        private DSAKeyGenerator generator;

        public DSAForm(MainWindow.Mode mode = MainWindow.Mode.Sign)
        {
            this.mode = mode;
            InitializeComponent();
            Generate();
        }

        private void Generate()
        {
            int minQ = (int)sbMinQ.Value;
            int maxQ = (int)sbMaxQ.Value;
            Domain = DomainParameters.GenerateDomainParameters(minQ, maxQ);
            generator = new DSAKeyGenerator(Domain);
            PrivateKey = generator.PrivateKey;
            PublicKey = generator.PublicKey;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }
    }
}
