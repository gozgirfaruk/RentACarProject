namespace RentACarProject.CqrsPattern.Queries
{
    public class GetRentCarByIdQuery
    {
        public int CarID { get; set; }

        public GetRentCarByIdQuery(int carID)
        {
            CarID = carID;
        }
    }
}
