using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new Result(true);
        }


        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new Result(true);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new Result(true);
        }

        IDataResult<List<Rental>> IRentalService.GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        IDataResult<Rental> IRentalService.GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(c => c.Id == id));
        }
    }
}
