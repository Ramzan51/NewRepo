using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valeur;

            do
            {
                {
                    Console.WriteLine("Entrez un nombre entre 0 et 20 : ");
                    valeur = int.Parse(Console.ReadLine());
                }
            } while (valeur < 0 || valeur > 20);

            Console.WriteLine("Votre nombre est correct : " + valeur);
            Console.ReadLine();
        }
    }
}
