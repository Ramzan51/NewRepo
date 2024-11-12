using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moyennes;

            Console.WriteLine("Entrez votre moyennes : ");
            moyennes = int.Parse(Console.ReadLine());

            if (moyennes >= 16)
            {
                Console.WriteLine("Très bien");
                Console.ReadLine();
            }
            if (moyennes >= 14 || moyennes < 16)
            {
                Console.WriteLine("Bien");
                Console.ReadLine();
            }
            if (moyennes >= 12 || moyennes < 14)
            {
                Console.WriteLine("Assez bien");
                Console.ReadLine();
            }
            if (moyennes >= 10 || moyennes < 12)
            {
                Console.WriteLine("Passable");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("recalé");
                Console.ReadLine();
            }
        }
    }
}
