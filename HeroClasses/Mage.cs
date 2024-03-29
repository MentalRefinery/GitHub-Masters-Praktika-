﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GitHub_Masters__Praktika_
{
    internal class Mage : IHero
    {
        public int HeroLevel { get; set; }
        public int HeroExperience { get; set; }
        public int MaximumHealth { get; set; }
        public int CurrentHealth { get; set; } = 50; //testing
        public double HeavyAtack { get; set; }
        public double LightAttack { get; set; }
        public double Skill { get; set; }
        public double UltimateSkill { get; set; }        
        public int ChanceToDodge { get; set; }
        public int MinimumDamage { get; set; } = 1; //testing
        public int MaximumDamage { get; set; } = 2; //testing
        public int CriticalStrike { get; set; }
        public int CriticalStrikeDamage { get; set; }
        public double AttackSpeed { get; set; } = 2;
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
                Console.WriteLine("You died");
            }
            else
            {
                Console.WriteLine($"You got hit for {dmg} damage.");
            }

        }

        public int Leveling(int exp)
        {
            if (exp < 100)
            {
                 return  HeroLevel = 1;
            }
            else if (exp < 200)
            {
                return HeroLevel = 2;
            }
            else if (exp < 400)
            {
                return HeroLevel = 3;
            }
            else if (exp < 700)
            {
                return HeroLevel = 4;

                //Current Maximum Level
            }
            else
            {
                return HeroLevel;
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
        }

        public void HeavyAtackMethod(IMonster monster)
        {
            monster.GetDamage(RandomDamage() + (RandomDamage() / 2));

            if (monster.CurrentHealth <= 0)
            {                
                monster.DropSomething();
                GetExperience(monster);
                Leveling(HeroExperience);                
            }            
        }       

        public void LightAtackMethod(IMonster monster)
        {
            {
                monster.GetDamage(RandomDamage());
                if (monster.CurrentHealth <= 0)
                {
                    monster.DropSomething();
                    GetExperience(monster);
                    Leveling(HeroExperience);
                }
            }

        }
        private int GetExperience(IMonster monster)
        {
            return HeroExperience += monster.ExpWorth;
        }
    }
}
