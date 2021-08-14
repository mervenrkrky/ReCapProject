using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //car ile ilgili veritabanımda yapacağım operasyonları içeren  interface
    
    public interface ICarDal :IEntityRepository<Car>
    {
        List<CarDetailDto> GetCarDetails();

    }
}
