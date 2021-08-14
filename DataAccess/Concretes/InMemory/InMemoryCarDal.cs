using DataAccess.Abstract;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=12,DailyPrice=50000,Description="Mavi araba"},
                new Car{Id=2,BrandId=4,ColorId=2,DailyPrice=100000,Description="Yeşil araba"},
                new Car{Id=3,BrandId=2,ColorId=18,DailyPrice=75000,Description="Kırmızı araba"},
                new Car{Id=4,BrandId=1,ColorId=42,DailyPrice=50000,Description="Sarı araba"}
            };

        }
        public void Add(Car car)
        {
            _car.Add(car);

        }

        //LINQ - Language Integrated Query
        public void Delete(Car car)
        {
            Car carsToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            //c tek tek dolasınca verilecek takma isim 
            _car.Remove(car);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;

        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
           return _car.Where(c => c.Id == Id).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            //gönderdigim id ye sahip olan id yi bul demek
            Car carsToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.ModelYear= car.ModelYear;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;


        }
    }
}
