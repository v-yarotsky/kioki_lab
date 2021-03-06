﻿using System;
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
    public partial class SchnorrForm : Form
    {
        private DomainParameters domain;
        private Schnorr schnorr;
        private SchorrProver prover;
        private SchorrVerifier verifier;

        private BigInteger call;
        private BigInteger challenge;

        public SchnorrForm()
        {
            InitializeComponent();
        }

        private void SchnorrForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateSchnorr_Click(object sender, EventArgs e)
        {
            
            domain = DomainParameters.GenerateDomainParameters(100000, 999999);
            schnorr = new Schnorr(domain);

            tbP.Text = domain.P.ToString();
            tbQ.Text = domain.Q.ToString();
            tbH.Text = domain.H.ToString();
            tbG.Text = domain.G.ToString();
            tbT.Text = schnorr.T.ToString();

            ResetForm();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            prover.GenerateKeys();
            tbS.Text = prover.Secret.ToString();
            tbA.Text = prover.PublicKey.ToString();
        }

        private void btnGenerateCall_Click(object sender, EventArgs e)
        {
            prover.Call();
            tbR.Text = prover.R.ToString();
            tbX.Text = prover.X.ToString();
        }

        private void btnGenerateChallenge_Click(object sender, EventArgs e)
        {
            challenge = verifier.Challenge();
            tbE.Text = challenge.ToString();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            BigInteger x = BigInteger.Parse(tbX.Text);
            BigInteger res = BigInteger.Parse(tbY.Text);
            BigInteger pub = BigInteger.Parse(tbA.Text);
            verifier.X = x;
            bool result = verifier.VerifyResponse(pub, res);

            tbZ.Text = verifier.Z.ToString();
            if (result)
            {
                MessageBox.Show("Доказано");
            }
            else
            {
                MessageBox.Show("НЕ доказано");
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnRespond_Click(object sender, EventArgs e)
        {
            BigInteger secret = BigInteger.Parse(tbS.Text);
            prover.Secret = secret;
            BigInteger ch = BigInteger.Parse(tbE.Text);
            prover.Response(ch);
            tbY.Text = prover.Y.ToString();
        }

        private void tbT_TextChanged(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            schnorr.T = BigInteger.Parse(tbT.Text);

            prover = new SchorrProver(schnorr);
            verifier = new SchorrVerifier(schnorr);
            
            tbS.Text = "";
            tbA.Text = "";
            tbR.Text = "";
            tbX.Text = "";
            tbE.Text = "";
            tbY.Text = "";
            tbZ.Text = "";
        }
    }
}
