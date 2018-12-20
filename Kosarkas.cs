using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka_Jura_Zebec.Igraci
{
    public class Kosarkas
    {
        private string ime;
        private string mjestoRodenja;
        private Spol spol;
        private int starost;
        private int tezina;
        private double visina;

        // konstruktor
        public Kosarkas(string ime, string mjestoRodenja, Spol spol, int starost, int tezina, double visina)
        {
            this.ime = ime;
            this.mjestoRodenja = mjestoRodenja;
            this.spol = spol;
            this.starost = starost;
            this.tezina = tezina;
            this.visina = visina;
        }

        // vrati - metode
        public string VratiIme()
        {
            return ime;
        }

        public string VratiMjestoRodenja()
        {
            return mjestoRodenja;
        }

        public Spol VratiSpol()
        {
            return spol;
        }

        public int VratiStarost()
        {
            return starost;
        }

        public int VratiTezinu()
        {
            return tezina;
        }

        public double VratiVisinu()
        {
            return visina;
        }
    }
}
