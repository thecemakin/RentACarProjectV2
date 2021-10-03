using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyReporsitoryBase<Car, RentACarProjectContext>, ICarDal
    {
        public List<CarDetailDTO> GetCarDetails()
        {
            using (RentACarProjectContext context = new RentACarProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             
                             
                             on c.BrandId equals b.BrandId
                            
                             
                             select new CarDetailDTO { BrandName=b.BrandName,CarId=c.CarId,ModelName=c.ModelName,DailyPrice =c.DailyPrice,Description= c.Description,BrandId=b.BrandId,};
                return result.ToList();
            }
        }

       
    }

    

        
    }
    

