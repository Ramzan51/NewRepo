using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    /// <summary>
    /// Jeux de nombre caché
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int valeur = 1, essai = 1, nbre = 1;
            bool correct;

            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Choisir le nombre à chercher =");
                    valeur = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
            Console.Clear();

            correct = false;
            while (!correct)
            {
                try
                {
                    Console.Write("Entrez un essai =");
                    essai = int.Parse(Console.ReadLine());
                    correct = true;
                }
                catch
                {
                    Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                }
            }
           
            while (essai != valeur)
            {
                if (essai <= valeur)
                {
                    Console.WriteLine("<-- Tros petit !");
                }
                else
                {
                    Console.WriteLine(" --> Tros grand !");
                }

                correct = false;
                while (!correct);
                {
                    try
                    {
                        Console.WriteLine("Entrez un essai =");
                        essai = int.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }
                }
                        nbre++;
            }
            
            Console.WriteLine("Vous avez trouver le bon nombre en "+nbre+" fois");

            Console.ReadLine();
        }
    }                       
}
