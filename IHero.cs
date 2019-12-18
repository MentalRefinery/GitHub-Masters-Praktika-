using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    interface IHero : IStats
    {
        ///Herojaus metodai kaip
        ///Puolimas, Specialios atakos ir t.t.
        ///Herojaus Lygis, Konvertavę Herojaus patirtį į Int galime gauti Herojaus lygį, +1 nes Herojus pradeda nuo lvl 1.
        int HeroLevel { get; set; }
        //Herojaus patirtis
        double HeroExperience{ get; set;}

    }
}
