using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        Car GetById(int id);
        List<Car> GetByDailyPrice(int min ,int max);
<<<<<<< HEAD
        void add(Car car);
=======
        void Add(Car car);
>>>>>>> 7997ff351badfac3fbb4105f9af98cc2abe78bc1
        void Delete(Car car);
        void Update(Car car);
        List<CarDetailDTO> GetCarDetails();
    }
}
