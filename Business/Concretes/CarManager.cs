﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.Description.Length>1&& car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Update(car);

        }

        public List<Car> GetAll()
        {
            //iş kodları

            return _carDal.GetAll();

        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);

        }

        public void Update(Car Car)
        {
            _carDal.Update(Car);

        }
    }
}
