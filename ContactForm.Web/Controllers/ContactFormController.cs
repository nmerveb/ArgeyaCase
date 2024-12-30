using ContactForm.Application.Features.ContactForms;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ContactForm.Web.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly IMediator _mediator;

        public ContactFormController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _mediator.Send(new GetDepartmentsQuery());
            ViewBag.Departments = departments;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactFormCommand command)
        {
            if (!ModelState.IsValid)
                return View("Index", command);

            await _mediator.Send(command);
            return RedirectToAction("Success");
        }

        public IActionResult Success() => View();
    }

}
