using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFreamwork
{
    public class EfCustomerDal :EfEntityRepositoryBase<Customer,CarsContext>,ICustomerDal
    {
    }
}
