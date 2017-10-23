using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsReise
{
    class Reiseteilnehmer
    {
        private string email;
        private string vorname;
        private string nachname;
        private static int teilnehmernummer;

        public Reiseteilnehmer()
        {

        }

        public Reiseteilnehmer(string email, string vorname, string nachname)
        {
            this.Email = email;
            this.vorname = vorname;
            this.Nachname = nachname;
        }


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Vornarme
        {
            get
            {
                return vorname;
            }

            set
            {
                vorname = value;
            }
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

    }
}
