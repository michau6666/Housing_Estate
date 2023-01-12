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

            Flat RisovByt = new Flat(1325, 50, 2);
            RisovByt.inhabitants.Add("tetaJurcova");
            RisovByt.inhabitants.Add("risovaSegra");
            RisovByt.inhabitants.Add("riso");
            Console.WriteLine(RisovByt.ToString());
        }
    }
}