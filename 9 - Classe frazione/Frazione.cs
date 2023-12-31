﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9___Classe_frazione
{
    public class Frazione
    {
        private int _numeratore;
        private int _denominatore;

        public int Numeratore
        {
            get { return _numeratore; }
            set { _numeratore = value; }
        }

        public int Denominatore
        {
            get { return _denominatore; }
            set
            {
                if (value != 0)
                {
                    _denominatore = value;
                }
                else
                {
                    _denominatore = 1;
                }
            }
        }

        public Frazione()
        {
            Numeratore = 1;
            Denominatore = 1;
        }

        public Frazione(int numer, int denom)
        {
            Numeratore = numer;
            Denominatore = denom;
        }

        public Frazione(Frazione frazioneVecchia)
        {
            Numeratore = frazioneVecchia.Numeratore;
            Denominatore = frazioneVecchia.Denominatore;
        }

        public object Clona(Frazione frazioneVecchia)
        {
            Frazione fraz = (Frazione)frazioneVecchia.MemberwiseClone();
            return fraz;
        }

        public static int MaxComDiv(int numer, int denom)
        {
            while (denom != 0)
            {
                int temp = denom;
                denom = numer % denom;
                numer = temp;
            }

            return numer;
        }

        //public static int MinComMul(int numer, int denom)
        //{
        //    return (numer * denom) / MaxComDiv(numer, denom);
        //}

        public (int, int) Semplifica(Frazione frazione)
        {
            int mcd = MaxComDiv(frazione.Numeratore, frazione.Denominatore);

            int simpNumer = Numeratore / mcd;
            int simpDenom = Denominatore / mcd;

            return (simpNumer, simpDenom);
        }

        public (int, int) Somma(Frazione frazione1, Frazione frazione2)
        {
            int totNumer = frazione1.Numeratore * frazione2.Denominatore + frazione2.Numeratore * frazione1.Denominatore;
            int comuneDenom = frazione1.Denominatore * frazione2.Denominatore;

            return (totNumer, comuneDenom);
        }

        public (int, int) Sottrai(Frazione frazione1, Frazione frazione2)
        {
            int totNumer = frazione1.Numeratore * frazione2.Denominatore - frazione2.Numeratore * Denominatore;
            int comuneDenom = frazione1.Denominatore * frazione2.Denominatore;

            return (totNumer, comuneDenom);
        }

        public (int, int) Moltiplica(Frazione frazione1, Frazione frazione2)
        {
            int totNumer = frazione1.Numeratore * frazione2.Numeratore;
            int comuneDenom = frazione2.Denominatore * frazione2.Denominatore;

            return (totNumer, comuneDenom);
        }

        public (int, int) Dividi(Frazione frazione1, Frazione frazione2)
        {
            int totNumer = frazione1.Numeratore * frazione2.Denominatore;
            int comuneDenom = frazione1.Denominatore * frazione2.Numeratore;

            return (totNumer, comuneDenom);
        }
    }

    class FrazioneEstesa : Frazione
    {
        public FrazioneEstesa() : base()
        {

        }

        public FrazioneEstesa(int numeratore, int denominatore) : base(numeratore, denominatore)
        {

        }

        public FrazioneEstesa(Frazione frazioneVecchia) : base(frazioneVecchia)
        {

        }

        public double FrazDec(FrazioneEstesa frazione)
        {
            double ret = (double)frazione.Numeratore / (double)frazione.Denominatore;
            return ret;
        }

        public (int, int) DecFraz(string val)
        {
            double numer = 0, denom = 0;

            if (val.Contains(','))
            {
                val.Replace(',', '.');
            }

            string[] intDec = val.Split('.');
            numer = int.Parse(intDec[0] + intDec[1]);

            denom = Math.Pow(10.0, intDec[1].Length);

            return ((int)numer, (int)denom);
        }

        public (int, int) Potenza(FrazioneEstesa frazioneBase, double esponente)
        {
            double numer = 0, denom = 0;

            numer = Math.Pow(frazioneBase.Numeratore, esponente);
            denom = Math.Pow(frazioneBase.Denominatore, esponente);

            return ((int)numer, (int)denom);
        }
    }
}
