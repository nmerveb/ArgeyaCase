using ContactForm.Domain.Enums;
using MediatR;

namespace ContactForm.Application.Features.ContactForms
{
    public class CreateContactFormCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Department DepartmentId { get; set; }
        public string Message { get; set; }
    }

}
