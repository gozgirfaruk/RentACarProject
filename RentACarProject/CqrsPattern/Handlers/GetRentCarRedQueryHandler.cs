using RentACarProject.CqrsPattern.Results;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class GetRentCarRedQueryHandler
    {
        private readonly RentContext _context;

        public GetRentCarRedQueryHandler(RentContext context)
        {
            _context = context;
        }

        public List<GetRentCarRedQueryResult> Handle()
        {
            var values = _context.Cars.Where(y=>y.Status==false).Select(x=> new GetRentCarRedQueryResult
            {
                Brand=x.Brand,
                Status=x.Status,
                Location=x.Location,
                Model=x.Model,
                Price=x.Price,
                CarID=x.CarID

            }).ToList();
            return values;
        }
    }
}
