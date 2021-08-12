using Business.Concretes;
using DataAccess.Concretes.EntityFreamwork;
using DataAccess.Concretes.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.Description);

            }
            

        }
    }
}
