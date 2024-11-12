using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un montant = ");
            float montant = float.Parse(Console.ReadLine());
            if (montant > 40)
            {
                montant = montant * 90 / 100;
                Console.WriteLine("montant = " + montant + " avec une remise de 10%");
            }
            if (montant >= 20 && montant <= 40)
            {
                montant = montant * 95 / 100;
                Console.WriteLine("montant = " + montant + " avec une remise de 5%");
            }
            if (montant < 20)
            {
                Console.WriteLine("montant = " + montant + " avec une remise de 0%");
            }
            Console.ReadLine();
        }
    }
}
