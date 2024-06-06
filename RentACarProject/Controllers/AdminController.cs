using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RentACarProject.CqrsPattern.Commands;
using RentACarProject.CqrsPattern.Handlers;

namespace RentACarProject.Controllers
{
    public class AdminController : Controller
    {
        private readonly GetRentCarQueryHandler _handler;
        private readonly CreateRentCarCommandHandler _handlerCreate;
        private readonly RemoveRentCarCommandHandler? _handlerRemove;
        private readonly GetRentCarByIdQueryHandler _handlerGetById;
        private readonly UpdateRentCarCommandHandler _handlerUpdate;
        private readonly GetRentCarGreenQueryHandler _handlerGetGreen;
        private readonly GetRentCarRedQueryHandler _handlerGetRed;

        public AdminController(GetRentCarQueryHandler handler, CreateRentCarCommandHandler handlerCreate, RemoveRentCarCommandHandler? handlerRemove, GetRentCarByIdQueryHandler handlerGetById, UpdateRentCarCommandHandler handlerUpdate, GetRentCarGreenQueryHandler handlerGetGreen, GetRentCarRedQueryHandler handlerGetRed)
        {
            _handler = handler;
            _handlerCreate = handlerCreate;
            _handlerRemove = handlerRemove;
            _handlerGetById = handlerGetById;
            _handlerUpdate = handlerUpdate;
            _handlerGetGreen = handlerGetGreen;
            _handlerGetRed = handlerGetRed;
        }

        public IActionResult Index()
        {
            var values = _handlerGetGreen.Handle();
            return View(values);
        }
        public IActionResult IndexRed()
        {
            var values = _handlerGetRed.Handle();
            return View(values);
        }

        public IActionResult CarList()
        {
            var values = _handler.Handle();
            return View(values);

        }
        [HttpGet]
        public IActionResult CreateCar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(CreateRentCarCommand command)
        {
            command.Status = true;
           _handlerCreate.Handle(command);
            return RedirectToAction("CarList");
        }
        public IActionResult DeleteCar(int id)
        {
            _handlerRemove.Handle(new RemoveRentCarCommand(id));
            return RedirectToAction("CarList");
        }
        [HttpGet]
        public IActionResult GetCar(int id)
        {
            var values = _handlerGetById.Handle(new CqrsPattern.Queries.GetRentCarByIdQuery(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult GetCar(UpdateRentCarCommand command)
        {
           _handlerUpdate.Handle(command);
            return RedirectToAction("CarList");
        }


    }
}
