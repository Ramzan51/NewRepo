using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entier;
            char reponse;
            do
            {
                do
                {
                    Console.WriteLine("Entrez un entier entre 1 et 9 : ");
                    entier = int.Parse(Console.ReadLine());
                } while (entier < 1 || entier > 9);

                for (int k = 0; k <= 10; k++)
                {
                    Console.WriteLine(entier + " x " + k + " = " + entier * k);
                }

                do
                {
                    Console.WriteLine("Voulez-vous affcihez une nouvelle table de multiplication (O/N) : ");
                    reponse = Console.ReadKey().KeyChar;
                } while (reponse != 'O' && reponse != 'N');

                Console.Clear();

            } while (reponse == 'O');



        }
    }
}
