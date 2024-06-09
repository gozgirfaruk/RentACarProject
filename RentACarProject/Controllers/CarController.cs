using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.Models;

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

		public async Task<IActionResult> CarFilter(string location)
		{
			var values = await _mediator.Send(new AGetRentCarByLocationQuery(location));
			return View(values);
		}


	}
}
