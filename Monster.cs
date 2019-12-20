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
        public int Health { get; set; }
        public int ChanceToDodge { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }

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
    }
}