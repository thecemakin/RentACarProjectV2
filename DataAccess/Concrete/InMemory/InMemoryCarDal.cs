using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

       

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            { 
                new Car{BrandId = 1,CarId = 1, ColorId = 1,DailyPrice = 250,ModelYear = "250" , Description = "Al bin git." },
                new Car{BrandId = 2,CarId = 2, ColorId = 1,DailyPrice = 250,ModelYear = "250" ,Description = "Al bin git." },
                new Car{BrandId = 2,CarId = 3, ColorId = 3,DailyPrice = 250,ModelYear = "250" ,Description = "Al bin git." },
                new Car{BrandId = 3,CarId = 4, ColorId = 2,DailyPrice = 250,ModelYear = "250" ,Description = "Al bin git." },
                new Car{BrandId = 1,CarId = 5, ColorId = 2,DailyPrice = 250,ModelYear = "250" ,Description = "Al bin git." },
                new Car{BrandId = 2,CarId = 6, ColorId = 1,DailyPrice = 250,ModelYear = "250" ,Description = "Al bin git." }
            };
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(o => o.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(o => o.CarId == Id).ToList();
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDTO> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
        }
    }
}
