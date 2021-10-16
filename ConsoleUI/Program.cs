using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
       

        public static void Main(string[] args)
        {
            //TestUsers();
            //GetCarDetail();
            TestBrands();




        }

        public static void TestBrands()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Lexus" });
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandId + "/" + brand.BrandName);
            }
        }

        public static void GetCarDetail()
        {
            Car car = new Car();
            car.BrandId = 1;
            car.ColorId = 2;
            car.DailyPrice = 250;
            car.Description = "açıklama";
            car.ModelName = "Clio";
            car.ModelYear = "1996";

            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car1 in carManager.GetAll().Data)
            {
                Console.WriteLine(/*car1.BrandName*/ "/" + car.ModelName + "/" + car.Description + "/" + car.DailyPrice);
            }
        }

        public static void TestUsers()
        {
            //User user1 = new User
            //{

            //    FirstName = "Rıdvan",
            //    LastName = "Günay",
            //    EMail = "ri@w.com",
            //    Password = "123456"
            //};
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Rıdvan",
                LastName = "Günay",
                EMail = "ri@w.com",
                Password = "123456"
            });
            foreach ( var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + user.LastName);
            }

        }
    }
}
