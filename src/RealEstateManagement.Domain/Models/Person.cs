
namespace RealEstateManagement.Domain.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? IdentificationCard { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int HouseId { get; set; }
        public virtual House? House { get; set; }
    }
}
