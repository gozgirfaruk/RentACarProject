using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Handlers
{
	public class AGetCarQueryHandler : IRequestHandler<AGetCarQuery, List<AGetCarQueryResult>>
	{
		private readonly RentContext _context;

		public AGetCarQueryHandler(RentContext context)
		{
			_context = context;
		}

		public async Task<List<AGetCarQueryResult>> Handle(AGetCarQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Cars.Select(x => new AGetCarQueryResult
			{
				Brand = x.Brand,
				Location = x.Location,
				Model = x.Model,
				Price = x.Price,
				CarID = x.CarID,
				FuelType = x.FuelType,
				ImageUrl = x.ImageUrl,
				Year = x.Year
				
			}).ToListAsync();
			return values;
		}
	}
}
