using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Dwarf : Player, IHummerThrow, IRidingHorse
    {
        public override void Attack(int attack)
        {
            Console.WriteLine(attack + " şiddetinde saldırı yaptı");
        }

        public override void Defense(int defense)
        {
            Console.WriteLine(defense + "şiddetinde defense yaptı");
        }

        public void hummer(int hummer)
        {
            throw new NotImplementedException();
        }

        public void ridinghorse(int ridinghorse)
        {
            throw new NotImplementedException();
        }
    }
}
