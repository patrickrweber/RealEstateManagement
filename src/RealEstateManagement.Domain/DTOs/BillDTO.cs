
using RealEstateManagement.Domain.Models;
using System.Numerics;

namespace RealEstateManagement.Domain.DTOs
{
    public class BillDTO
    {
        public int id { get; set; }
        public double waterBill { get; set; }
        public double energyBill { get; set; }
        public double totalValue { get; set; }
        public double wattsSpent { get; set; }
        public DateTime paidDate { get; set; }
        public int month { get; set; }
        public int year { get; set; }
        public int houseId { get; set; }
        public virtual HouseDTO? houseDTO { get; set; }

        private double CalculateTotalValue()
        {
            return houseDTO.rentValue + waterBill + energyBill;
        }

        public static Bill MapToEntity(BillDTO billDTO)
        {
            return new Bill()
            {
                Id = billDTO.id,
                WaterBill = billDTO.waterBill,
                EnergyBill = billDTO.energyBill,
                TotalValue = billDTO.totalValue,
                WattsSpent = billDTO.wattsSpent,
                PaidDate = billDTO.paidDate,
                Month = billDTO.month,
                Year = billDTO.year,
                HouseId = billDTO.houseId,
                House = HouseDTO.MapToEntity(billDTO.houseDTO)
            };

        }
        public static BillDTO MapToDTO(Bill bill)
        {
            return new BillDTO()
            {
                id = bill.Id,
                waterBill = bill.WaterBill,
                energyBill = bill.EnergyBill,
                totalValue = bill.TotalValue,
                wattsSpent = bill.WattsSpent,
                paidDate = bill.PaidDate,
                month = bill.Month,
                year = bill.Year,
                houseId = bill.HouseId,
                houseDTO = HouseDTO.MapToDTO(bill.House)
            };
        }
    }
}
