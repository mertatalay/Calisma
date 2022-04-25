using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class DoorProcess 
    {

        

        internal bool OpenDoor(Door door)
        {
            Employee employee=new Employee();

            if (door.ID != employee.ID)
            {
                Console.WriteLine("Yetkiniz bulunmamaktadır");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.WriteLine("Giriş yapıldı");
                Console.ReadLine();
                return true;
            }
            
        }
    }
}
