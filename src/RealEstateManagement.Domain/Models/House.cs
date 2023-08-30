namespace RealEstateManagement.Domain.Models
{
    public class House
    {
        public int Id { get; set; }
        public int RoomsNumber { get; set; }
        public int BathRoomsNumber { get; set; }
        public bool HaveLaundry { get; set; }
        public bool HaveGarage { get; set; }
        public string? ZipCode { get; set; }
        public string? Country { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public string? AdressNumber { get; set; }

        public virtual ICollection<Bill>? Bills { get; set; }
        public virtual ICollection<Person>? People { get; set; }
    }
}
