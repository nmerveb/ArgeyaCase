using ContactForm.Domain.Entities;
using ContactForm.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm.Application.Features.ContactForms
{
    public class CreateContactFormCommandHandler : IRequestHandler<CreateContactFormCommand, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateContactFormCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateContactFormCommand request, CancellationToken cancellationToken)
        {
            var contactForm = new ContactFormInfo
            {
                Name = request.Name,
                Surname = request.Surname,
                Phone = request.Phone,
                Email = request.Email,
                DepartmentId = request.DepartmentId,
                Message = request.Message
            };

            _context.ContactForms.Add(contactForm);
            await _context.SaveChangesAsync(cancellationToken);

            return contactForm.Id;
        }
    }
}
