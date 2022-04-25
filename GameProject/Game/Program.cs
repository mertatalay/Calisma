using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Player bloodelf = new BloodElf();
            Player man = new Man();
            
            bloodelf.Attack(4);
            man.Defense(2);


            Console.WriteLine(bloodelf.ToString()+man.ToString());
            Console.ReadLine();
        }
    }
}
