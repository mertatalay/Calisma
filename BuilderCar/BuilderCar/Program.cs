using BuilderCar.Abstract;
using BuilderCar.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderCar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarBuilder carBuilder=new CarConcrete();

            UseCar usecar1=new UseCar();

            usecar1.usecar(carBuilder);
            Console.WriteLine(carBuilder.Car.ToString());
            Console.ReadLine(); 
        }
    }
}
