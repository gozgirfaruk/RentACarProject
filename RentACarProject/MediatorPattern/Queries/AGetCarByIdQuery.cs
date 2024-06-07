using MediatR;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Queries
{
	public class AGetCarByIdQuery : IRequest<AGetCarByIdQueryResult>
	{
		public int CarID { get; set; }

		public AGetCarByIdQuery(int carID)
		{
			CarID = carID;
		}
	}
}
