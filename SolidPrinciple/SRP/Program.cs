using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {

           Door door = new Door();
            door.ID = 1;
            door.DoorName = "Mutfak";
            Employee employee = new Employee();
            employee.ID = 1;
          

            DoorProcess doorProcess = new DoorProcess();
            string result = doorProcess.OpenDoor(door) ? "Başarılı" : "Hatalı";
            Console.WriteLine(result);
            Console.ReadLine();


        }
    }
}
