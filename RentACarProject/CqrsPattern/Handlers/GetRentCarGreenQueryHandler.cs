using RentACarProject.CqrsPattern.Results;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class GetRentCarGreenQueryHandler
    {
        private readonly RentContext _context;

        public GetRentCarGreenQueryHandler(RentContext context)
        {
            _context = context;
        }

        public List<GetRentCarGreenQueryResult> Handle()
        {
            var values = _context.Cars.Where(x => x.Status == true).Select(y => new GetRentCarGreenQueryResult
            {
                CarID = y.CarID,
                Brand = y.Brand,
                Status = y.Status,
                Location = y.Location,
                Model = y.Model,
                Price = y.Price
            }).ToList();
            return values;
        }
    }
}
