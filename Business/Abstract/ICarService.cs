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
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<CarDetailDTO> GetCarDetails();
    }
}
