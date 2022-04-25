﻿using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BloodElf : Player, IArchery, IRidingHorse, ISword
    {
        public override void Attack(int attack)
        {
            Console.WriteLine(attack + " şiddetinde saldırı yaptı");
        }

        public override void Defense(int defense)
        {
           Console.WriteLine(defense+"şiddetinde defense yaptı");
        }
    }
}
