using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person FeroSpara = new Person("Fero", "Spara", 64);
            Console.WriteLine(FeroSpara.ToString());
            Person TetaJurcova = new Person("teta", "jurcova", 26);
            Person RisovaSestra = new Person("risova", "sestra", 40);
            Person Riso = new Person("riso", "jurco", 17);

            Flat RisovByt = new Flat(1325, 50, 2);
            RisovByt.AddInhabitant(TetaJurcova);
            RisovByt.AddInhabitant(RisovaSestra);
            RisovByt.AddInhabitant(Riso);
            Console.WriteLine(RisovByt.ToString());
            foreach(var inhabitant in RisovByt.inhabitants)
            {
                Console.WriteLine(inhabitant.ToString());
            }

        }
    }
}
