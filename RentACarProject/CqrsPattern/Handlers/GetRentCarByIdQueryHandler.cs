using RentACarProject.CqrsPattern.Queries;
using RentACarProject.CqrsPattern.Results;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class GetRentCarByIdQueryHandler
    {
        private readonly RentContext _context;

        public GetRentCarByIdQueryHandler(RentContext context)
        {
            _context = context;
        }

        public GetRentCarByIdQueryResult Handle(GetRentCarByIdQuery query)
        {
            var values = _context.Cars.Find(query.CarID);
            return new GetRentCarByIdQueryResult
            {
                CarID = values.CarID,
                Brand = values.Brand,
                AdultCount = values.AdultCount,
                DoorCount = values.DoorCount,
                FuelType = values.FuelType,
                ImageUrl = values.ImageUrl,
                Location = values.Location,
                Model = values.Model,
                Price = values.Price,
                VitesType = values.VitesType,
                Year = values.Year,
                Status = values.Status
            };
        }
    }
}

