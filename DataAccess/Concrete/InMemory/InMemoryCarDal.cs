using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
            new Car{Id=1,BrandId=1,ColorId=5,DailyPrice=1500,Description="araba1", ModelYear=1995},
            new Car{Id=2,BrandId=1,ColorId=5,DailyPrice=2000,Description="araba2", ModelYear=1996},
            new Car{Id=3,BrandId=2,ColorId=5,DailyPrice=2500,Description="araba3", ModelYear=1998},
            new Car{Id=4,BrandId=2,ColorId=5,DailyPrice=1000,Description="araba4", ModelYear=1999},
            new Car{Id=5,BrandId=2,ColorId=5,DailyPrice=3000,Description="araba5", ModelYear=1999},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c=>c.Id==car.Id);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _car.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
