using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ///Mūsų pagrindinė klasė
            ///
            Console.WriteLine(UserInput("Hello Adventurer! What is your name?"));
            string name = Console.ReadLine();
        }

        //Įvesties metodas
        private static string UserInput(string input)
        {
            //String Interpolation
            Console.WriteLine($"{input}");
            ///Galėtų būti ir
            ///Console.WriteLine("{0}", input);

            return Console.ReadLine(); // Kam to reikia?????
        }
    }
}