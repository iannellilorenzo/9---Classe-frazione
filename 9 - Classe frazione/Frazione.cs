using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
