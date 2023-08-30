using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagement.Domain.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal RentValue { get; set; }
        public decimal WaterBill { get;set; }
        public decimal EnergyBill { get; set; }
        public decimal TotalValue { get; set; }
        public long WattsSpent { get; set; }
        public DateTime PaidDate { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int HouseId { get; set; }
        public virtual House? House { get; set; }
    }


}
