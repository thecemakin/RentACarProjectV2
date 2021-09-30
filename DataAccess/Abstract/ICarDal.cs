using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
    public interface ICarDal : IEntitiyRepository<Car>
    {
<<<<<<< HEAD
        List<CarDetailDTO> GetCarDetails();
=======
        List<CarDetailDTO> GetProductDetails();
>>>>>>> 7997ff351badfac3fbb4105f9af98cc2abe78bc1
    }
}
