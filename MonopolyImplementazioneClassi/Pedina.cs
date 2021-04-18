using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonopolyImplementazioneClassi
{
    public class Pedina
    {
        private int posizione;
        private float denaroPedina;
        private List<Proprieta> proprietaCheIlGiocatorePossiede;
        private List<Proprieta> proprietaIpotecate;

        public Pedina(float denaro)
        {
            Posizione = 0;
        }
        public int Posizione
        {
            get
            {
                return posizione;
            }
            set
            {
                posizione = value;
            }
        }

        public float DenaroPedina
        {
            get
            {
                return denaroPedina;
            }
            set
            {
                denaroPedina = value;
                if (Fallisci())
                    throw new Exception("il giocatore ha fallito");
            }
        }

        public List<Proprieta> ProprietaIpotecate
        {
            get
            {
                return proprietaIpotecate;
            }
            set
            {
                proprietaIpotecate = value;
            }
        }

        public List<Proprieta> ProprietaCheIlGiocatorePossiede
        {
            get
            {
                return proprietaCheIlGiocatorePossiede;
            }
            set
            {
                proprietaCheIlGiocatorePossiede = value;
            }
        }

        public bool Fallisci()
        {
            if (DenaroPedina < 0)
            {
                return true;
            }
            else
                return false;
        }

        public int Giocata()
        {
            Random r = new Random();

            int dado1 = r.Next(1, 13);
            Posizione += dado1;
            return Posizione;
        }

        public void Ipoteca()
        {
            throw new System.NotImplementedException();
        }
    }
}