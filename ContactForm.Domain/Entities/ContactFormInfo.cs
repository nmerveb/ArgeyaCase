using ContactForm.Domain.Enums;

namespace ContactForm.Domain.Entities
{
    public class ContactFormInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Department DepartmentId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
