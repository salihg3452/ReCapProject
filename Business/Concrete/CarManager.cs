using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        InMemoryCarDal _ınMemoryCarDal;
        public CarManager(InMemoryCarDal memoryCarDal)
        {
            _ınMemoryCarDal = memoryCarDal;
        }
        public void Add(Car car)
        {
            _ınMemoryCarDal.Add(car);
        }

        public void Delete(Car car)
        {
            _ınMemoryCarDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _ınMemoryCarDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _ınMemoryCarDal.GetById(id);
        }

        public void Update(Car car)
        {
            _ınMemoryCarDal.Update(car);
        }

        
    }
}
