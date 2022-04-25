using BuilderCar.Abstract;
using BuilderCar.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar.Concrete
{
    public class CarConcrete : CarBuilder
    {
        public CarConcrete()
        {
            car = new Car();

        }

        public override void CerateBrandName()
        {
            car.BrandName = "BMW";
        }

        public override void CreateColor()
        {
            car.Color = "Siyah";
        }

        public override void CreateModelName()
        {
            car.ModelName = "3.20";
        }
    }
}
