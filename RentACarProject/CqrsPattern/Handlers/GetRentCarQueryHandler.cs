using RentACarProject.CqrsPattern.Results;
using RentACarProject.DAL;
using System.Security.Policy;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class GetRentCarQueryHandler
    {
        private readonly RentContext _context;

        public GetRentCarQueryHandler(RentContext context)
        {
            _context = context;
        }

        public List<GetRentCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetRentCarQueryResult
            {
                CarID = x.CarID,
                Brand = x.Brand,
                Location = x.Location,
                Price = x.Price,
                Status = x.Status,
                Model=x.Model
            }).ToList();
            return values;
        }
    }
}
