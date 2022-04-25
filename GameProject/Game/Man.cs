using Game.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Man : Player, ISword, IArchery, IRidingHorse
    {
        public override void Attack()
        {
           
            
        }

        public override void Defense()
        {
            throw new NotImplementedException();
        }
    }
}
