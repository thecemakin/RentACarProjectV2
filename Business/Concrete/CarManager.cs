using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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

     

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(p => p.DailyPrice <= min && p.DailyPrice  >= max);
        }
    }
}
