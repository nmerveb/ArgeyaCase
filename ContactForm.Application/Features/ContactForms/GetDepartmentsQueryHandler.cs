using ContactForm.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ContactForm.Application.Features.ContactForms
{
    public class GetDepartmentsQueryHandler : IRequestHandler<GetDepartmentsQuery, List<SelectListItem>>
    {
        public async Task<List<SelectListItem>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = Enum.GetValues(typeof(Department))
                .Cast<Department>()
                .Select(d => new SelectListItem
                {
                    Value = ((int)d).ToString(),
                    Text = d.ToString()
                })
                .ToList();

            return await Task.FromResult(departments);
        }
    }
}
