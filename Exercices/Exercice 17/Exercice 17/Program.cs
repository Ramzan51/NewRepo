using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisissez un nombre : ");
            int nombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrez la racine carré : ");
            double racine = double.Parse(Console.ReadLine());

            if (racine == Math.Sqrt(nombre))
            {
                Console.WriteLine("Bravo ! ");
            }
            else
            {
                Console.WriteLine("la racine carré de " + nombre + " est " + Math.Sqrt(nombre));
            }
            Console.ReadLine();
        }
    }
}
