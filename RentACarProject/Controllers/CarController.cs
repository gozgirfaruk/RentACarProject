using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACarProject.MediatorPattern.Queries;

namespace RentACarProject.Controllers
{
    public class CarController : Controller
    {
        private readonly IMediator _mediator;

		public CarController(IMediator mediator)
		{
			_mediator = mediator;
		}

		public async Task<IActionResult> AllCar()
        {
            var values = await _mediator.Send(new AGetCarQuery());
            return View(values);
        }

        public async Task<IActionResult> CarDetail(int id)
        {
            var values = await _mediator.Send(new AGetCarByIdQuery(id));
            return View(values);
        }


    }
}
