
using RealEstateManagement.Domain.Models;
using System.Numerics;

namespace RealEstateManagement.Domain.DTOs
{
    public class BillDTO
    {
        public int id { get; set; }
        public decimal rentValue { get; set; }
        public decimal waterBill { get; set; }
        public decimal energyBill { get; set; }
        public decimal totalValue { get; set; }
        public long wattsSpent { get; set; }
        public DateTime paidDate { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int houseId { get; set; }
        public virtual House? house { get; set; }

        private decimal CalculateTotalValue()
        {
            return rentValue + waterBill + energyBill;
        }

        public Bill MapToEntity(BillDTO billDTO)
        {
            return new Bill() 
            { 
                Id = billDTO.id,
                RentValue= billDTO.rentValue,
                WaterBill = billDTO.waterBill,
                EnergyBill = billDTO.energyBill,
                TotalValue = billDTO.totalValue,
                WattsSpent= billDTO.wattsSpent,
                PaidDate = billDTO.paidDate,
                Month= billDTO.month,
                Year= billDTO.year,
                HouseId= billDTO.houseId,
                House = billDTO.house
            };

        }
        public BillDTO MapToDTO(Bill bill)
        {
            return new BillDTO()
            {
                id = bill.Id,
                rentValue = bill.RentValue,
                waterBill = bill.WaterBill,
                energyBill = bill.EnergyBill,
                totalValue = bill.TotalValue,
                wattsSpent = bill.WattsSpent,
                paidDate = bill.PaidDate,
                month = bill.Month,
                year = bill.Year,
                houseId = bill.HouseId,
                house = bill.House
            };
        }
    }
}
