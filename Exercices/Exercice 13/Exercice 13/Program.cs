using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entier;
            
            do
            {
                Console.WriteLine("Entrez un entier entre 1 et 9 : ");
                entier = int.Parse(Console.ReadLine());
            } while (entier < 1 || entier > 9);
            
            for (int k = 0; k <= 10; k++)
            {
                Console.WriteLine(entier + " x " + k + " = " + entier * k);
            }
            Console.ReadLine();
        }
    }
}
