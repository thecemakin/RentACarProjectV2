using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
  
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal){
            _carDal = carDal;
        }

<<<<<<< HEAD
        public void add(Car car)
        {
            if (car.DailyPrice < 0)
            {
                Console.WriteLine("Araç Fiyatı sıfır olamaz.");
            }
            
            
            else{ _carDal.Add(car); }
            
=======
        public void Add(Car car)
        {
            _carDal.Add(car);
>>>>>>> 7997ff351badfac3fbb4105f9af98cc2abe78bc1
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(p=>p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(p=>p.CarId ==id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
<<<<<<< HEAD
            return _carDal.GetCarDetails();
=======
            return _carDal.GetProductDetails();
>>>>>>> 7997ff351badfac3fbb4105f9af98cc2abe78bc1
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
