using Kosarka_Jura_Zebec.Igraci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarka_Jura_Zebec
{
    class Program
    {
        static void Main(string[] args)
        {
            Kosarkas k1 = new Kosarkas("LeBron James", "Akron", Spol.Muski, 33, 113, 2.03);
            Kosarkas k2 = new Kosarkas("Bojan Bogdanovic", "Mostar", Spol.Muski, 29, 102, 2.00);
            Kosarkas k3 = new Kosarkas("Luka Doncic", "Ljubljana", Spol.Muski, 19, 99, 2.01);
            Kosarkas k4 = new Kosarkas("Antonia Misura", "Sibenik", Spol.Zenski, 30, 71, 1.78);
            Kosarkas k5 = new Kosarkas("Candace Parker", "St.Louis", Spol.Zenski, 32, 82, 1.91);

            Klub t1 = new Klub("Los Angeles Lakers", "Sjedinjene Americke Drzave", Liga.NBA, 16);
            Klub t2 = new Klub("Miami Heat", "Sjedinjene Americke Drzave", Liga.NBA, 3);
            Klub t3 = new Klub("Real Madrid", "Spanjolska", Liga.Euroliga, 10);
            Klub t4 = new Klub("Fenerbahce", "Turska", Liga.Euroliga, 1);
            Klub t5 = new Klub("KK Zadar", "Hrvatska", Liga.ABA, 1);

            Console.ReadLine();

        }
    }
}
