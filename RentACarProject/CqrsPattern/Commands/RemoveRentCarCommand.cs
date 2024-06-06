namespace RentACarProject.CqrsPattern.Commands
{
    public class RemoveRentCarCommand
    {
        public int CarID { get; set; }

        public RemoveRentCarCommand(int carID)
        {
            CarID = carID;
        }
    }
}
