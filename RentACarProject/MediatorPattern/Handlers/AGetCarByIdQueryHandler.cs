using MediatR;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Handlers
{
	public class AGetCarByIdQueryHandler : IRequestHandler<AGetCarByIdQuery, AGetCarByIdQueryResult>
	{
		private readonly RentContext _context;

		public AGetCarByIdQueryHandler(RentContext context)
		{
			_context = context;
		}

		public async Task<AGetCarByIdQueryResult> Handle(AGetCarByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _context.Cars.FindAsync(request.CarID);
			return new AGetCarByIdQueryResult
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
				Year = values.Year
			};
		}
	}
}
