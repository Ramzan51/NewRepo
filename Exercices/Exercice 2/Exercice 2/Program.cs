using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prenom, nom;
            int age;

            Console.WriteLine("Entrez votre prenom : ");
            prenom = Console.ReadLine();

            Console.WriteLine("Entrez votre nom : ");
            nom = Console.ReadLine();

            Console.WriteLine("Entrez votre age : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Bonjour "+prenom+" "+age+", vous avez "+age);
            Console.ReadLine();
        }
    }
}
