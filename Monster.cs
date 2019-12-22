using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal class Monster : IMonster
    {
        //Stats
        public int ExpWorth { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; } = 50; //testing
        public int ChanceToDodge { get; set; }
        public int MinimumDamage { get; set; } = 1; //testing
        public int MaximumDamage { get; set; } = 2; //testing
        public int CriticalStrike { get; set; }
        public int CriticalStrikeDamage { get; set; }
        public double AttackSpeed { get; set; } = 4; //testing
        public int Accuracy { get; set; }
        public int ArmorPenetration { get; set; }
        public int Armor { get; set; }


        //Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Luck { get; set; }
        public int Mastery { get; set; }


        public void AssignStats()
        {           
        }       

        public void GetDamage(int dmg)
        {
            CurrentHealth -= dmg;
            if (CurrentHealth <= 0)
            {
                Console.WriteLine($"Monster died");
            }
            else
            {
                Console.WriteLine($"Monster got hit for {dmg} damage.");
            }
            
        }
        public void Attack(IHero hero)
        {
            hero.GetDamage(RandomDamage());
        }

        private int RandomDamage()
        {
            Random rng = new Random();
            return rng.Next(MinimumDamage, MaximumDamage);
        }
        public void SpecialAttack()
        {

        }

        public void DropSomething()
        {            
        }

        
    }
}