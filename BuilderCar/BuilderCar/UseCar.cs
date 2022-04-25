using BuilderCar.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar
{
    public class UseCar
    {
        public void usecar(CarBuilder car)
        {
            car.CerateBrandName();
            car.CreateModelName();
            car.CreateColor();  
        }

    }
}
