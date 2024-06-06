using RentACarProject.CqrsPattern.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class CreateRentCarCommandHandler
    {
        private readonly RentContext _context;

        public CreateRentCarCommandHandler(RentContext context)
        {
            _context = context;
        }

        public void Handle(CreateRentCarCommand command)
        {
            _context.Cars.Add(new Car
            {
                Brand = command.Brand,
                ImageUrl = command.ImageUrl,
                Price = command.Price,
                Location = command.Location,
                DoorCount = command.DoorCount,
                Model = command.Model,
                Year = command.Year,
                VitesType = command.VitesType,
                FuelType = command.FuelType,
                AdultCount = command.AdultCount,
                Status = command.Status
                
            });
            _context.SaveChanges();
        }
    }
}
