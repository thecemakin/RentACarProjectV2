using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.BrandId = 1;
            car.ColorId = 1;
            car.DailyPrice = 10;
            car.Description = "sdsvsd";
            car.ModelName = "wrewf";



            Car car2 = new Car();
            car.BrandId = 2;
            car.ColorId = 1;
            car.DailyPrice = 10;
            car.Description = "sdsvsd";
            car.ModelName = "wrewf";

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.add(car2);

            Console.WriteLine(carManager.GetCarDetails());

            

         
            
            Console.WriteLine(car.Description);
        
        
        
        
        }
    }
}
