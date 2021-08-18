using Business.Concretes;
using DataAccess.Concretes.EntityFreamwork;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarGetAllTest();
            //BrandGetAllTest();
            //BrandGetByIdTest();

            //CarDetailTest();

            CarDetailTest();

            //ColorDeleteTest();
            //colorUpdateTest();
            //ColorAddTest();
            //BrandAddTest();
            // CustomerAddTest();
            //RentalAddTest();
        }

        private static void RentalAddTest()
        {
            RentalManager addRental = new RentalManager(new EfRentalDal());
            addRental.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 07, 12, 10, 45, 00),
                ReturnDate = new DateTime(2021, 09, 17, 20, 30, 00)
            });
        }

        private static void CustomerAddTest()
        {
            CustomerManager addCustomer = new CustomerManager(new EfCustomerDal());
            addCustomer.Add(new Customer { UserId = 2, CompanyName = "bbb" });
        }

        private static void BrandAddTest()
        {
            BrandManager addBrand = new BrandManager(new EfBrandDal());
            addBrand.Add(new Brand { Name = "Fiat Doblo" });
        }

        private static void ColorAddTest()
        {
            ColorManager addColor = new ColorManager(new EfColorDal());
            addColor.Add(new Color
            {
                Name = "pembe"
            });
        }

        private static void colorUpdateTest()
        {
            ColorManager updateColor = new ColorManager(new EfColorDal());
            updateColor.Update(new Color { Id = 2, Name = "Beyaz" });
        }

        private static void ColorDeleteTest()
        {
            ColorManager deleteColor = new ColorManager(new EfColorDal());
            deleteColor.Delete(new Color { Id = 4 });
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "---" + car.BrandName + "---" + car.ColorName + "---" + car.DailyPrice);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
      





        /* private static void BrandGetByIdTest()
         {
             BrandManager brandManager = new BrandManager(new EfBrandDal());
             foreach (var brand in brandManager.GetById(1))
             {
                 Console.WriteLine(brand.Name);
             }
         }

         private static void BrandGetAllTest()
         {
             BrandManager brandManager = new BrandManager(new EfBrandDal());
             foreach (var brand in brandManager.GetAll())
             {
                 Console.WriteLine(brand.Name);
             }
         }

         private static void CarGetAllTest()
         {
             CarManager carManager = new CarManager(new EfCarDal());
             foreach (var car in carManager.GetAll())
             {
                 Console.WriteLine(car.Description);

             }
         }*/

    }
}