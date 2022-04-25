using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Undead : Player, IMagic
    {
        public override void Attack(int attack)
        {
            Console.WriteLine(attack + " şiddetinde saldırı yaptı");
        }

        public override void Defense(int defense)
        {
            Console.WriteLine(defense + "şiddetinde defense yaptı");
        }
    }
}
