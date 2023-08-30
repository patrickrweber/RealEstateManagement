
using RealEstateManagement.Domain.Models;

namespace RealEstateManagement.Domain.DTOs
{
    public class PersonDTO
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? identificationCard { get; set; }
        public int age { get; set; }
        public string? phoneNumber { get; set; }
        public string? email { get; set; }
        public int houseId { get; set; }
        public virtual House? house { get; set; }

        public static Person MapToEntity(PersonDTO personDTO)
        {
            return new Person()
            {
                Id = personDTO.id,
                Name = personDTO.name,
                IdentificationCard = personDTO.identificationCard,
                Age = personDTO.age,
                PhoneNumber = personDTO.phoneNumber,
                Email = personDTO.email,
                HouseId = personDTO.houseId,
                House = personDTO.house,
            };
        }
        public static PersonDTO MapToDTO(Person person)
        {
            return new PersonDTO()
            {
                id = person.Id,
                name = person.Name,
                identificationCard = person.IdentificationCard,
                age = person.Age,
                phoneNumber = person.PhoneNumber,
                email = person.Email,
                houseId = person.HouseId,
                house = person.House,
            };
        }
    }
}
