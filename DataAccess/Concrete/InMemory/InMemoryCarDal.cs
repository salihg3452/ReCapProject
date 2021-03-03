using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=100,ModelYear=1998,Description="Tofaş"},
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=250,ModelYear=2002,Description="Ford"},
                new Car{CarId=3,BrandId=2,ColorId=4,DailyPrice=111,ModelYear=1990,Description="Honda"},
                new Car{CarId=4,BrandId=3,ColorId=2,DailyPrice=950,ModelYear=2021,Description="Audi"},
                new Car{CarId=5,BrandId=3,ColorId=3,DailyPrice=565,ModelYear=2018,Description="BMW"},
                new Car{CarId=6,BrandId=4,ColorId=2,DailyPrice=735,ModelYear=2020,Description="Volvo"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
