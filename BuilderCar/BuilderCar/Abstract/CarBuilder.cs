using BuilderCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar.Abstract
{
    public abstract class CarBuilder
    {

        protected Car car;

        public Car Car
        {
            get { return car; } 
        }


        public abstract void CerateBrandName();
        public abstract void CreateModelName();
        public abstract void CreateColor();
    }
}
