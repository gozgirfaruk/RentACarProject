using RentACarProject.CqrsPattern.Commands;
using RentACarProject.DAL;

namespace RentACarProject.CqrsPattern.Handlers
{
    public class RemoveRentCarCommandHandler
    {
        private readonly RentContext _context;

        public RemoveRentCarCommandHandler(RentContext context)
        {
            _context = context;
        }

        public void Handle(RemoveRentCarCommand command)
        {
            var values = _context.Cars.Find(command.CarID);
            _context.Cars.Remove(values);
            _context.SaveChanges(); 
        }
    }
}
