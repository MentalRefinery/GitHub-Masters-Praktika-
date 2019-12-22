using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Timers;

namespace GitHub_Masters__Praktika_
{
    internal class Program
    {

        //Need to work with Timer for attack soon.
        //private static Timer aTimer; 
        private static void Main(string[] args)
        {
            HiAdventurer("Hello Adventurer, What is your Name?");
            PlayOrNot("Would you like to play?");

            //Adventure checkpoint.
            Console.WriteLine("Adventure begins");

            //Wont have to change format if I change the name of classes.
            Question($"Would you like to play { nameof(Mage)}, { nameof(Warrior)}, { nameof(Rogue)} or { nameof(Warlock)}?");
            string chosen = Console.ReadLine();
            IHero chosenHero;

           //for loopas veikia neblogai, tik tiek kad reikia dviguba enter paspausti kad toliau eitu
           


            for (int i = 0; i < 100; i++)
            {
                //Formating answer to lower
                chosen.ToLower();
                //Changing class name to Title Case.
                chosen = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(chosen);

                if (chosen == typeof(Mage).Name)
                {
                    Console.WriteLine("You have chosen a " + chosen);
                    chosenHero = new Mage();
                    break;
                }
                else if (chosen == typeof(Warrior).Name)
                {
                    Console.WriteLine("You have chosen a " + chosen);
                    chosenHero = new Warrior();
                    break;
                }
                else if (chosen == typeof(Rogue).Name)
                {
                    Console.WriteLine("You have chosen a " + chosen);
                    chosenHero = new Rogue();
                    break;
                }
                else if (chosen == typeof(Warlock).Name)
                {
                    Console.WriteLine("You have chosen a " + chosen);
                    chosenHero = new Warlock();
                    break;
                }
                else
                {
                    Question($"Please try again... \nWould you like to play {nameof(Mage)}, {nameof(Warrior)}, {nameof(Rogue)} or {nameof(Warlock)}?");
                    chosen = Console.ReadLine();

                   /* if (chosen == typeof(Mage).Name)
                    {
                        Console.WriteLine("You have chosen a " + chosen);
                        chosenHero = new Mage();

                    }
                    else if (chosen == typeof(Warrior).Name)
                    {
                        Console.WriteLine("You have chosen a " + chosen);
                        chosenHero = new Warrior();
                    }
                    else if (chosen == typeof(Rogue).Name)
                    {
                        Console.WriteLine("You have chosen a " + chosen);
                        chosenHero = new Rogue();
                    }
                    else if (chosen == typeof(Warlock).Name)
                    {
                        Console.WriteLine("You have chosen a " + chosen);
                        chosenHero = new Warlock();
                    }*/
                }


                Console.ReadLine();
            }
           
        }      
        
        private static void HiAdventurer(string greeting)
        {
            Console.WriteLine(greeting);
            string adventurerName = Console.ReadLine();
            Console.WriteLine($"Hello {adventurerName}.");
        }

        private static void PlayOrNot(string question)
        {
            Console.WriteLine($"{question} Y / N?");
            var answer = Convert.ToChar(Console.ReadLine());
            switch (answer)
            {
                case 'Y':
                    break;
                case 'y':
                    break;
                case 'n':
                    ProgramExit();
                    break;
                case 'N':
                    ProgramExit();
                    break;
                default:
                    PlayOrNot("You type something wrong, Would you like to continue?");
                    break;
            }
        }
        private static void Question(string txt)
        {
            //Need to fiddle with delegates soon.
            Console.WriteLine(txt);
        }
       
        //Exit method, security reasons, so I am used to call Exit method if I want to terminate my program.
        private static void ProgramExit()
        {
            Environment.Exit(0);
        }
    }
}