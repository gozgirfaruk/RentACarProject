using MediatR;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Queries
{
	public class AGetCarQuery : IRequest<List<AGetCarQueryResult>>
	{
	}
}
