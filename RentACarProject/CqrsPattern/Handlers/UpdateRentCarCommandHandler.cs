using RentACarProject.CqrsPattern.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class UpdateRentCarCommandHandler
    {
        private readonly RentContext _context;

        public UpdateRentCarCommandHandler(RentContext context)
        {
            _context = context;
        }

        public void Handle(UpdateRentCarCommand command)
        {
            var values = _context.Cars.Find(command.CarID);
            values.Brand = command.Brand;
            values.Year = command.Year;
            values.AdultCount = command.AdultCount;
            values.DoorCount = command.DoorCount;
            values.FuelType = command.FuelType;
            values.ImageUrl = command.ImageUrl;
            values.Location = command.Location;
            values.Price = command.Price;
            values.Model = command.Model;
            values.VitesType = command.VitesType;

            _context.SaveChanges();
        }
    }
}
