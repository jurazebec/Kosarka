using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka_Jura_Zebec.Igraci
{
    public class Klub
    {
        private string naziv;
        private string drzava;
        private Liga liga;
        private int brojTitula;

        // konstruktor
        public Klub(string naziv, string drzava, Liga liga, int brojTitula)
        {
            this.naziv = naziv;
            this.drzava = drzava;
            this.liga = liga;
            this.brojTitula = brojTitula;
        }

        // vrati - metode
        public string VratiNaziv()
        {
            return naziv;
        }

        public string VratiDrzavu()
        {
            return drzava;
        }

        public Liga VratiLigu()
        {
            return liga;
        }

        public int VratiBrojTitula()
        {
            return brojTitula;
        }
    }
}
