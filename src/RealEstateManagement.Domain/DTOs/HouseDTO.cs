
using RealEstateManagement.Domain.Models;

namespace RealEstateManagement.Domain.DTOs
{
    public class HouseDTO
    {
        public int id { get; set; }
        public int roomsNumber { get; set; }
        public int bathRoomsNumber { get; set; }
        public bool haveLaundry { get; set; }
        public bool haveGarage { get; set; }
        public string? zipCode { get; set; }
        public string? country { get; set; }
        public string? state { get; set; }
        public string? city { get; set; }
        public string? district { get; set; }
        public string? address { get; set; }
        public string? adressNumber { get; set; }

        public virtual ICollection<Bill>? bills { get; set; }
        public virtual ICollection<Person>? people { get; set; }

        public static House MapToEntity(HouseDTO houseDTO)
        {
            return new House()
            {
                Id = houseDTO.id,
                RoomsNumber = houseDTO.roomsNumber,
                BathRoomsNumber = houseDTO.bathRoomsNumber,
                HaveLaundry = houseDTO.haveLaundry,
                HaveGarage = houseDTO.haveGarage,
                ZipCode = houseDTO.zipCode,
                Country = houseDTO.country,
                State = houseDTO.state,
                City = houseDTO.city,
                District = houseDTO.district,
                Address = houseDTO.address,
                AdressNumber = houseDTO.adressNumber,
                Bills = houseDTO.bills,
                People = houseDTO.people,
            };
        }
        public static HouseDTO MapToDTO(House houseDTO)
        {
            return new HouseDTO()
            {
                id = houseDTO.Id,
                roomsNumber = houseDTO.RoomsNumber,
                bathRoomsNumber = houseDTO.BathRoomsNumber,
                haveLaundry = houseDTO.HaveLaundry,
                haveGarage = houseDTO.HaveGarage,
                zipCode = houseDTO.ZipCode,
                country = houseDTO.Country,
                state = houseDTO.State,
                city = houseDTO.City,
                district = houseDTO.District,
                address = houseDTO.Address,
                adressNumber = houseDTO.AdressNumber,
                bills = houseDTO.Bills,
                people = houseDTO.People,
            };
        }
    }
}
