using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            List<Car> cars = carManager.GetAll();

            Car car1 = new Car
            {
                CarId = 7,
                BrandId = 4,
                ColorId = 2,
                DailyPrice = 490,
                ModelYear = 2014,
                Description = "Mercedes"
            };

            Car car2 = new Car
            {
                CarId = 8,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 805,
                ModelYear = 2019,
                Description = "Lexus"
            };

            //Kayıt Ekleme
            carManager.Add(car1);
            carManager.Add(car2);

            foreach (var car in cars)
            {
                Console.WriteLine("Id : " + car.CarId);
                Console.WriteLine("BrandId: " + car.BrandId);
                Console.WriteLine("ColorId : " + car.ColorId);
                Console.WriteLine("DailyPrice : " + car.DailyPrice);
                Console.WriteLine("ModelYear : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("------------------------------------------");
            }

            //Kayıt Silme
            //var d= carManager.GetById(4);
            //carManager.Delete(d);

            
            carManager.Delete(car1);

            foreach (var car in cars)
            {
                Console.WriteLine("Id : " + car.CarId);
                Console.WriteLine("BrandId: " + car.BrandId);
                Console.WriteLine("ColorId : " + car.ColorId);
                Console.WriteLine("DailyPrice : " + car.DailyPrice);
                Console.WriteLine("ModelYear : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("------------------------------------------");
            }

            //Referansta Tutarak Kayıt Güncelleme
            car2.DailyPrice = 250;
            carManager.Update(car2);

            foreach (var car in cars)
            {
                Console.WriteLine("Id : " + car.CarId);
                Console.WriteLine("BrandId: " + car.BrandId);
                Console.WriteLine("ColorId : " + car.ColorId);
                Console.WriteLine("DailyPrice : " + car.DailyPrice);
                Console.WriteLine("ModelYear : " + car.ModelYear);
                Console.WriteLine("Description : " + car.Description);
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}
