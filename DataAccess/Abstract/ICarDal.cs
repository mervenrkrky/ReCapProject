using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //car ile ilgili veritabanımda yapacağım operasyonları içeren  interface
    
    public interface ICarDal
    {
        //interface metodları default publictir
        List<Car> GetAll();
        List<Car> GetById(int Id);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);



    }
}
