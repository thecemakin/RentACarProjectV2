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
<<<<<<< HEAD
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

       
=======
      


        List<CarDetailDTO> ICarDal.GetProductDetails()
        {
            using (RentACarProjectContext context = new RentACarProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDTO { BrandName = b.BrandName, CarId = c.CarId, CarName = c.CarId.ToString(), DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }
>>>>>>> 7997ff351badfac3fbb4105f9af98cc2abe78bc1
    }

    

        
    }
    

