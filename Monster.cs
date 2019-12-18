using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal class Monster : IMonster
    {
        //Still in development
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Strength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Dexterity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack(IHero hero)
        {
            hero.GetDamage(RandomDamage());
        }

        private int RandomDamage()
        {
            Random rng = new Random();
            return rng.Next();
        }
    }
}