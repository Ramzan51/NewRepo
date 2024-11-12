using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float somme;
            int nbre_de_notes;

            Console.WriteLine("Entrez la somme des notes : ");
            somme = float.Parse(Console.ReadLine());

            Console.WriteLine("Entrez le nombre de notes : ");
            nbre_de_notes = int.Parse(Console.ReadLine());

            somme /= nbre_de_notes;

            Console.WriteLine("La moyenne = " + somme);
            Console.ReadLine();
        }
    }
}
