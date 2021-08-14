using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFreamwork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsContext context= new CarsContext())
            {
                var result = from p in context.Cars
                             join b in context.Brands
                             on p.BrandId equals b.Id
                             join c in context.Colors
                             on p.ColorId equals c.Id
                             select new CarDetailDto { CarName = p.Description, BrandName = b.Name, ColorName = c.Name, DailyPrice = p.DailyPrice };
                return result.ToList();
            }
        }
    }
}
