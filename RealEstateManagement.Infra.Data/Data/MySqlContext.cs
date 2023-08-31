using Microsoft.EntityFrameworkCore;
using RealEstateManagement.Domain.DTOs;
using RealEstateManagement.Domain.Models;

namespace RealEstateManagement.Infra.Data.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var house = new House() 
            {
                Id = 1,
                RoomsNumber = 2,
                BathRoomsNumber = 1,
                HaveLaundry = true,
                HaveGarage = true,
                ZipCode = "89072040",
                Country = "Brasil",
                State = "Santa Catarina",
                City = "Blumenau",
                District = "Badenfurt",
                Address = "Leopoldo Haerchen",
                AdressNumber = "658",
                RentValue = 650.00
            };
            modelBuilder.Entity<House>().HasData(house);

            var bill = new Bill()
            {
                Id = 1,
                WaterBill = 50.00,
                EnergyBill = 150.00,
                TotalValue = 850.00,
                WattsSpent = 1000,
                PaidDate = DateTime.Now,
                Month = DateTime.Now.Month,
                Year = DateTime.Now.Year,
                HouseId = house.Id
            };
            modelBuilder.Entity<Bill>().HasData(bill);

            var person = new Person()
            {
                Id = 1,
                Name = "Patrick",
                IdentificationCard = "06262485902",
                Age = 21,
                PhoneNumber = "47989098585",
                Email = "patrick@gmail.com",
                HouseId = house.Id
            };
            modelBuilder.Entity<Person>().HasData(person);

        }

        #region DbSets
        public DbSet<House> House { get; set; }
        public DbSet<Bill> Bill { get; set; }
        public DbSet<Person> Person { get; set; }
        #endregion
    }
}
