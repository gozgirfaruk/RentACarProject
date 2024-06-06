namespace RentACarProject.CqrsPattern.Commands
{
    public class CreateRentCarCommand
    {
        public string Brand { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public Decimal Price { get; set; }
        public int DoorCount { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string VitesType { get; set; }
        public string FuelType { get; set; }
        public bool Status { get; set; }
        public int AdultCount { get; set; }
    }
}
