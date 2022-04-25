using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class NightElf : Player, ISword, IArchery, IRidingHorse
    {
        public void archery(int archery)
        {
            throw new NotImplementedException();
        }

        public override void Attack(int attack)
        {
            Console.WriteLine(attack + " şiddetinde saldırı yaptı");
        }

        public override void Defense(int defense)
        {
            Console.WriteLine(defense + "şiddetinde defense yaptı");
        }

        public void ridinghorse(int ridinghorse)
        {
            throw new NotImplementedException();
        }

        public void sword(int sword)
        {
            throw new NotImplementedException();
        }
    }
}
