using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float prix, total = 0;
            char reponse;

            Console.WriteLine("Avez-vous un prix à saisir O/N : ");
            reponse = Console.ReadKey().KeyChar;

            while (reponse == 'O') 
            {
                Console.WriteLine(" Entrez votre prix : ");
                prix = float.Parse(Console.ReadLine());

                total += prix;

                Console.WriteLine(" Avez-vous un prix à saisir O/N : ");
                reponse = Console.ReadKey().KeyChar;
            }

            Console.WriteLine(" Prix total = " + total);
            Console.ReadLine();
        }
    }
}
