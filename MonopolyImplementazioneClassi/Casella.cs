using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyImplementazioneClassi
{
    public abstract class Casella
    {
        private string _nomeCasella;
        private uint _ID;
        public Casella(string nomeCasella,uint __ID)
        {
            NomeCasella = nomeCasella;
            ID = __ID;
        }

        public uint ID
        {
            get
            {
                return _ID;
            }
            private set
            {
                _ID = value;
            }
        }

        public string NomeCasella
        {
            get
            {
                return _nomeCasella;
            }
            set
            {
                _nomeCasella = value;
            }
        }

    }
}