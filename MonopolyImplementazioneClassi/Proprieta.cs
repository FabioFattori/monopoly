using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyImplementazioneClassi
{
    public class Proprieta:Casella
    {
        private float _prezzo;
        private float _valoreIpotecato;
        public Proprieta(string nome, float prezzo) : base(nome)
        {
            Prezzo = prezzo;
            ValoreIpotecato = Prezzo;
        }

        public float Prezzo
        {
            get
            {
                return _prezzo;
            }
            set
            {
                _prezzo = value;
            }
        }

        public float ValoreIpotecato
        {
            get
            {
                return _valoreIpotecato;
            }
            private set
            {
                _valoreIpotecato = value / 2;
            }
        }
    }
}