using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Entrez votre âge : ");
            age = int.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Vous êtes majeur : ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Vous êtes mineur et vous serez majeur dans " + (18 - age) + " an(s)");
                Console.ReadLine();
            }
        }
    }
}
