using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BloodElf : Player, IArchery, IRidingHorse, ISword
    {
        public void archery(int archery)
        {
            Console.WriteLine(archery + "şiddetinde ok attı ");
        }

        public override void Attack(int attack)
        {
            Console.WriteLine(attack + " şiddetinde saldırı yaptı");
        }

        public override void Defense(int defense)
        {
           Console.WriteLine(defense+"şiddetinde defense yaptı");
        }

        public void ridinghorse(int ridinghorse)
        {
            Console.WriteLine(ridinghorse + "şiddetinde at ile saldırdı.");
        }

        public void sword(int sword)
        {
            Console.WriteLine(sword+"şiddetinde kılıç ile saldırdı");
        }
    }
}
