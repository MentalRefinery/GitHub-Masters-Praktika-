﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Masters__Praktika_
{
    interface IStats
    {
        ///Visos galimos Herojaus ir padarų Charakteristikos.

        //Attributai
        int Constitution { get; set; }//Every X +1Health
        //Jėga
        int Strength { get; set; } // every X +1 Attack
        //Vikrumas
        int Dexterity { get; set; }//Every X +0.01% to dodge
        //Sekme
        int Luck { get; set; }//Crit rate and crit damage ++
        //Meistriskumas
        int Mastery { get; set; }//Increase damage or increase chance to hit ??


        //Stats        
        int Health { get; set; }
        int ChanceToDodge { get; set; }
        int MinimumDamage { get; set; }
        int MaximumDamage { get; set; }



        //Methods
        //Nuskaityt Atributu reiksmes ir atitinkamai paverst jas i stats
        void AssignHeroStats();


    }
}
