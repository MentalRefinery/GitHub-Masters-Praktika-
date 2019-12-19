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
        void Attack(IHero hero);
    }
}