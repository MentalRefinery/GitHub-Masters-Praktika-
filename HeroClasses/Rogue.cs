using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    class Rogue : IHero
    {
        public int HeroLevel { get; set; }
        public double HeroExperience { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; }
        public double HeavyAtack { get; set; }
        public double LightAttack { get; set; }
        public double Skill { get; set; }
        public double UltimateSkill { get; set; }       
        public int ChanceToDodge { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int CriticalStrike { get; set; }
        public int CriticalStrikeDamage { get; set; }
        public int AttackSpeed { get; set; }
        public int Accuracy { get; set; }
        public int ArmorPenetration { get; set; }
        public int armor { get; set; }


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

        public void Leveling(IHero hero)
        {
            if (hero.HeroExperience < 100)
            {
                hero.HeroLevel = 1;
            }
            else if (hero.HeroExperience < 200)
            {
                hero.HeroLevel = 2;
            }
            else if (hero.HeroExperience < 400)
            {
                hero.HeroLevel = 3;
            }
            else if (hero.HeroExperience < 700)
            {
                hero.HeroLevel = 4;

                //Current Maximum Level
            }
        }

        private int RandomDamage()
        {
            Random rng = new Random();
            return rng.Next(MinimumDamage, MaximumDamage);
        }


        //Attack types        
        public void Ultimate(IMonster monster)
        {
        }
        public void SpecialSkill(IMonster monster)
        {
            monster.GetDamage(RandomDamage());
            monster.GetDamage(RandomDamage());
        }
        public void HeavyAtackMethod(IMonster monster)
        {
            monster.GetDamage(RandomDamage() + (RandomDamage() / 2));
        }
        public void LightAtackMethod(IMonster monster)
        {
            {
                monster.GetDamage(RandomDamage());
            }

        }

    }
}
