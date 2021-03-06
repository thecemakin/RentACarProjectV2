using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Abstract
{
    public interface ICarDal : IEntitiyRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
    }
}
