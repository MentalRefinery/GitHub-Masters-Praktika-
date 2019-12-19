using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    class Warrior : IHero
    {
        public int HeroLevel { get ; set; }
        public double HeroExperience { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }

        public double HeavyAtack { get; set; }
        public double LightAttack { get; set; }
        public double Skill { get; set; }
        public double UltimateSkill { get; set; }
        public void GetDamage(int dmg)
        {
            
        }
        

        void IHero.Leveling(int heroLVL)
        {
            HeroLevel = 1;
            HeroExperience = 10;

        }

        void IHero._HeavyAtack(IMonster monster)
        {
            Strength = 2 * HeroLevel;
            HeavyAtack = HeroLevel * Strength;
            
        }

        void IHero._LightAtack(IMonster monster)
        {
            
        }

        void IHero._Skill(IMonster monster)
        {
            
        }

        void IHero.Ultimate(IMonster monster)
        {
            
        }
    }
}
