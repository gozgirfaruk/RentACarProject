using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Handlers
{
    public class AGetRentCarByLocationQueryHandler : IRequestHandler<AGetRentCarByLocationQuery, List<AGetRentCarByLocationQueryResult>>
    {
        private readonly RentContext _context;

        public AGetRentCarByLocationQueryHandler(RentContext context)
        {
            _context = context;
        }

        public async Task<List<AGetRentCarByLocationQueryResult>> Handle(AGetRentCarByLocationQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Cars.Select(x => new AGetRentCarByLocationQueryResult
            {
                Brand = x.Brand,
                FuelType = x.FuelType,
                Location = x.Location,
                CarID = x.CarID,
                ImageUrl = x.ImageUrl,
                Model = x.Model,
                Price = x.Price,
                Year = x.Year
            }).Where(y=>y.Location==request.Location).ToListAsync();
             return values;
        }
    }
}
