using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarRentalDal: IEntityRepository<Rental>
    {
        public List<RentalDetailDTO> GetRentalDetails();

        public RentalDetailDTO GetRentalDetailsByCarId(int rentalId);

    }
}
