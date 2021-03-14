using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.EntitiyFramework
{
    public class EfRentalBrandDal : EfEntityRepositoryBase<Rental, RecapProjectDBContext>, ICarRentalDal
    {
 
         public List<RentalDetailDTO> GetRentalDetails()
{
    using (RecapProjectDBContext context = new RecapProjectDBContext())
    {
        var result = from r in context.Rentals
                     join c in context.Cars
                     on r.CarId equals c.Id
                     join m in context.Customers
                     on r.UserId equals m.UserId
                     join k in context.Users
                     on m.UserId equals k.UserId
                     select new RentalDetailDTO
                     {
                         RentalId = r.RentalId,
                         CarId = c.Id,
                         UserId = m.UserId,                    
                         FirstName = k.FirstName,
                         LastName = k.LastName,
                         RentDate = r.RentDate,
                         ReturnDate = r.ReturnDate,
                         CompanyName = m.CompanyName
                     };
        return result.ToList();
    }
}
        public RentalDetailDTO GetRentalDetailsByCarId(int rentalId)
        {
            using (RecapProjectDBContext context = new RecapProjectDBContext())
            {
                var result = (from r in context.Rentals
                              join c in context.Cars
                              on r.CarId equals c.Id
                              join m in context.Customers
                              on r.UserId equals m.UserId
                              join k in context.Users
                              on m.UserId equals k.UserId
                              where r.RentalId == rentalId
                              orderby r.RentalId ascending
                              select new RentalDetailDTO
                              {
                                  RentalId = r.RentalId,
                                  CarId = c.Id,
                                  UserId = m.UserId,
                                  FirstName = k.FirstName,
                                  LastName = k.LastName,
                                  CompanyName = m.CompanyName,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate
                              }).LastOrDefault(); 
                return result;
            }

        }

            }
        }
