using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar.Entity
{
    public class Car
    {
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "Brand Name: " + BrandName + " Model Name: " + ModelName + " Color: " + Color;
        }
    }
}
