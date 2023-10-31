using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

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

        public static int MinComMul(int numer, int denom)
        {
            return (numer * denom) / MaxComDiv(numer, denom);
        }

        public (int, int) Semplifica()
        {
            int mcd = MaxComDiv(Numeratore, Denominatore);

            int simpNumer = Numeratore / mcd;
            int simpDenom = Denominatore / mcd;

            return (simpNumer, simpDenom);
        }

        public (int, int) Somma(int numer, int denom)
        {
            int totNumer = Numeratore * denom + numer * Denominatore;
            int comuneDenom = Denominatore * denom;

            return (totNumer, comuneDenom);
        }

        public (int, int) Sottrai(int numer, int denom)
        {
            int totNumer = Numeratore * denom - numer * Denominatore;
            int comuneDenom = Denominatore * denom;

            return (totNumer, comuneDenom);
        }

        public (int, int) Moltiplica(int numer, int denom)
        {
            int totNumber = Numeratore * Denominatore;
            int comuneDenom = Denominatore * denom;

            return (totNumber, comuneDenom);
        }


    }
}
