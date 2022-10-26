using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testna_aplikacija
{
    public class PrijavniPodatki
    {
        string ime, priimek, eNaslov, geslo;

        public PrijavniPodatki(string Ime, string Priimek, string ENaslov, string Geslo) {
            ime = Ime;
            priimek = Priimek;
            eNaslov = ENaslov;
            geslo = Geslo;
        }

        string izpisImenainPriimka() {
            return ime + " " + priimek;
        }
    }
}
