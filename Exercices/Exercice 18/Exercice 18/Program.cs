using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le nombre 1 : ");
            double nb1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le nombre 2 : ");
            double nb2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le nombre 3 : ");
            double nb3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Le plus petit nombre est = " + Math.Min(nb1, Math.Min(nb2, nb3)));
            Console.ReadLine();
        }
    }
}
