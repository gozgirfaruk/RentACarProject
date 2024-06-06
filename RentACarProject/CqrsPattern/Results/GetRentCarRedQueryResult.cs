namespace RentACarProject.CqrsPattern.Results
{
    public class GetRentCarRedQueryResult
    {
        public int CarID { get; set; }
        public string Brand { get; set; }
        public string Location { get; set; }
        public Decimal Price { get; set; }
        public bool Status { get; set; }
        public string Model { get; set; }
    }
}
