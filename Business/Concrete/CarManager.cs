using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0)
            {
               return new ErrorDataResult<Car>(Messages.CarNameInvalid);
            }
            
            
            else{
                _carDal.Add(car);
                return new SuccessDataResult<Car>(Messages.CarAdded); }
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
           return new SuccessDataResult<Car> (Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(int min, int max)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p=>p.DailyPrice >= min && p.DailyPrice<= max));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car> (_carDal.Get(p=>p.CarId == carId));
        }

        public IDataResult<List<CarDetailDTO>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDTO>> (_carDal.GetCarDetails());
        }

        public IResult Update(Car car)
        {
           _carDal.Update(car);
            return new SuccessDataResult<Car>(Messages.CarUpdated);
        }
    }
}
