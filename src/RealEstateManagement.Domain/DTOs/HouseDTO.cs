
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

        public double rentValue { get; set; }

        public virtual ICollection<BillDTO>? bills { get; set; }
        public virtual ICollection<PersonDTO>? people { get; set; }

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
                Bills = houseDTO.bills.Select(bill => BillDTO.MapToEntity(bill)).ToList(),
                People = houseDTO.people.Select(person => PersonDTO.MapToEntity(person)).ToList(),
                RentValue = houseDTO.rentValue,
            };
        }
        public static HouseDTO MapToDTO(House house)
        {
            return new HouseDTO()
            {
                id = house.Id,
                roomsNumber = house.RoomsNumber,
                bathRoomsNumber = house.BathRoomsNumber,
                haveLaundry = house.HaveLaundry,
                haveGarage = house.HaveGarage,
                zipCode = house.ZipCode,
                country = house.Country,
                state = house.State,
                city = house.City,
                district = house.District,
                address = house.Address,
                adressNumber = house.AdressNumber,
                bills = house.Bills.Select(bill => BillDTO.MapToDTO(bill)).ToList(),
                people = house.People.Select(person => PersonDTO.MapToDTO(person)).ToList(),
                rentValue = house.RentValue
            };
        }
    }
}
