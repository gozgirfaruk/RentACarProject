using MediatR;
using RentACarProject.MediatorPattern.Results;

namespace RentACarProject.MediatorPattern.Queries
{
    public class AGetRentCarByLocationQuery : IRequest<List<AGetRentCarByLocationQueryResult>>
    {
        public string Location { get; set; }

        public AGetRentCarByLocationQuery(string location)
        {
            Location = location;
        }
    }
}
