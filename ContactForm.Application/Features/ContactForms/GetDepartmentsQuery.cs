using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContactForm.Application.Features.ContactForms
{
    public class GetDepartmentsQuery : IRequest<List<SelectListItem>>
    {
    }
}
