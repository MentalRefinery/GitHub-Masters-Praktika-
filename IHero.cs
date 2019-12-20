using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    internal interface IHero : IStats
    {
        
        
        ///Herojaus Lygis, Konvertavę Herojaus patirtį į Int galime gauti Herojaus lygį, +1 nes Herojus pradeda nuo lvl 1.
        int HeroLevel { get; set; }

        //Herojaus patirtis
        int HeroExperience { get; set; }

        ///Herojaus Spec atakos (Skills)
        ///Heavy Attack, Light Atack, Skill, Ultimate
        double HeavyAtack { get; set; }
        double LightAttack { get; set; }
        double Skill { get; set; }
        double UltimateSkill { get; set; }

        ///Herojaus metodai kaip Puolimas, Specialios atakos ir t.t.
        void GetDamage(int dmg);
        void HeavyAtackMethod(IMonster monster);
        void LightAtackMethod(IMonster monster);

        //Kiekviena klase tures specifini skilla.
        void SpecialSkill(IMonster monster);
        void Ultimate(IMonster monster);

        int Leveling(int exp);
        

    }
}