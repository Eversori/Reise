using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReise
{
    class Reise
    {
        private Reiseteilnehmer alleTeilnehmer;
        private Reiseteilnehmer anzahlTeilnehmer;
        private DateTime von;
        private DateTime bis;
        private string ziel;
        private double preis;
        private int maxAnzahl;

        public Reise(DateTime von, DateTime bis, string ziel, double preis, int maxAnzahl)
        {
            this.von = von;
            this.bis = bis;
            this.ziel = ziel;
            this.preis = preis;
            this.maxAnzahl = maxAnzahl;
        }


        public int MaxAnzahl
        {
            get
            {
                return maxAnzahl;
            }

            set
            {
                maxAnzahl = value;
            }
        }

        public double Preis
        {
            get
            {
                return preis;
            }

            set
            {
                preis = value;
            }
        }

        public string Ziel
        {
            get
            {
                return ziel;
            }

            set
            {
                ziel = value;
            }
        }

        public DateTime Bis
        {
            get
            {
                return bis;
            }

            set
            {
                bis = value;
            }
        }

        public DateTime Von
        {
            get
            {
                return von;
            }

            set
            {
                von = value;
            }
        }

        public string Reisen()
        {
            return ziel;
        }

        public Boolean TeilnehmerAufnehmen(Reiseteilnehmer teilnehmer)
        {
            return teilnehmer;
        }
    }
}
