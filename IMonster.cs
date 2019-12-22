using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal interface IMonster : IStats
    {
        ///Galimi Padarų metodai ???
        ///
        int ExpWorth { get; set; }//Custom exp prop
        void Attack(IHero hero);
        void GetDamage(int dmg);


        //Could be like DoT attack = Damage over time
        //poison or burn
        //maybe use Thread.Sleep(miliseconds)
        void SpecialAttack();

        void DropSomething();

        
    }
}