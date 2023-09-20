using Core.Entities;

namespace Entities.DTOs
{
    public class UserForRegisterDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }        
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        
    }
}
