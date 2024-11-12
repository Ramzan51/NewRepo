using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float prixht, TVA;

            Console.WriteLine("Entrez votre prix ht : ");
            prixht = float.Parse(Console.ReadLine());

            Console.WriteLine("Entrez votre TVA : ");
            TVA = float.Parse(Console.ReadLine());

            Console.WriteLine("Le prix TTC = " + prixht * (1 + (TVA / 100)));
            Console. ReadLine();
        }
    }
}
