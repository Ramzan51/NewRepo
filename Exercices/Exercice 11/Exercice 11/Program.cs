using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            float somme = 0, notes;


            for ( k = 1; k <= 5; k++)
            {
                Console.WriteLine("Entrez une note : ");
                notes = int.Parse(Console.ReadLine());
                somme += notes;
                
            }
            Console.WriteLine("moyenne = " + somme / 5);
            Console.ReadLine();
        }
    }
}
