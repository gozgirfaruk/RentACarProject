using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RentACarProject.DAL;
using RentACarProject.MediatorPattern.Queries;
using RentACarProject.Models;

namespace RentACarProject.Controllers
{
	public class CarController : Controller
	{
		private readonly IMediator _mediator;
		private readonly RentContext _context;
		public CarController(IMediator mediator, RentContext context)
		{
			_mediator = mediator;
			_context = context;
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
		[HttpGet]
		public IActionResult SearhCar()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> CarFilter(CarFilterViewModel model, DateTime startDate , DateTime endDate)
		{
			var values = await _mediator.Send(new AGetRentCarByLocationQuery(model.Location));
		
			TimeSpan difference =endDate.Subtract(startDate);
			ViewBag.days = difference.Days;

			return View(values);
		}


	}
}
