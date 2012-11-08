﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using CryptographyTemplate.Utils;
using CryptographyTemplate.Extensions;

namespace CryptographyTemplate
{
    public class Schnorr
    {
        private const int T_MIN = 40;

        public DomainParameters Domain { get; set; }
        public BigInteger T { get; set; }
        private RandomGenerator numbers;

        public Schnorr(DomainParameters domain)
        {
            numbers = new RandomNumberGenerator();
            Domain = domain;
            T = GenerateT();
        }

        public BigInteger GenerateT()
        {
            BigInteger result = numbers.Next(T_MIN, Domain.Q - 1);
            return result;
        }
    }

    public class SchorrProver
    {
        public BigInteger Secret { get; private set; }
        public BigInteger PublicKey { get; private set; }
        public DomainParameters Domain { get; private set; }
        public BigInteger R { get; private set; }
        public BigInteger X { get; private set; }
        public BigInteger Y { get; private set; }

        private RandomGenerator numbers;
        
        public SchorrProver(Schnorr schorrParameters)
        {
            Domain = schorrParameters.Domain;
            numbers = new RandomNumberGenerator();
        }

        public void GenerateKeys()
        {
            Secret = numbers.Next(1, Domain.Q - 1);
            PublicKey = BigInteger.ModPow(Domain.G.ModInverse(Domain.P), Secret, Domain.P);
        }

        public BigInteger Call()
        {
            R = numbers.Next(1, Domain.Q - 1);
            X = BigInteger.ModPow(Domain.G, R, Domain.P);
            return X;
        }

        public BigInteger Response(BigInteger challenge)
        {
            Y = (Secret * challenge + R) % Domain.P;
            return Y;
        }
    }

    public class SchorrVerifier
    {
        public DomainParameters Domain { get; private set; }
        public BigInteger T { get; private set; }
        public BigInteger E { get; private set; }
        public BigInteger X { get; private set; }
        public BigInteger Z { get; private set; }

        private RandomGenerator numbers;

        public SchorrVerifier(Schnorr schorrParameters)
        {
            Domain = schorrParameters.Domain;
            T = schorrParameters.T;
            numbers = new RandomNumberGenerator();
        }

        public BigInteger Challenge(BigInteger x)
        {
            X = x;
            BigInteger exp = numbers.Next(0, (int)T, n => BigInteger.Pow(2, (int)n) < Domain.Q);
            E = BigInteger.Pow(2, (int)exp);
            return E;
        }

        public bool VerifyResponse(BigInteger publicKey, BigInteger response)
        {
            Z = (BigInteger.ModPow(Domain.G, response, Domain.P) * BigInteger.ModPow(publicKey, E, Domain.P)) % Domain.P;
            return Z == X;
        }
    }
}
