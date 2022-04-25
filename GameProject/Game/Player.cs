using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public abstract class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public short Level { get; set; }
        public int Warrior { get; set; }
        public string Hunter { get; set; }
        public int Mage { get; set; }
        public string Priest { get; set; }

        public abstract void Attack(int attack);
        public abstract void Defense(int defense);


    }
}
