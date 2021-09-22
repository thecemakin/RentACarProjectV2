using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Car> GetById(int id);
        void AddCar(Car car);
        void DeleteCar(Car car);
        void UpdateCar(Car car);
    }
}
