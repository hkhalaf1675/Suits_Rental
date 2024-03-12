using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suits_Rental.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Type { get; set; }
        public int? RentDays { get; set; }
        public int? ItemsCount { get; set; }
        public string? BetAttachment { get; set; }
        public decimal? TotalPrice { get; set; }
        public decimal? PaidAmount { get; set; }
        public Status Status { get; set; } 
        public decimal? RemainAmount { get; set; }
        public int Discount { get; set; }
        public string Notes { get; set; }
        public string UserName { get; set; }
        [ForeignKey("Customer")]
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public List<SuitOrder> OrderSuits { get; set; }
    }

    public enum Status
    {
        Sale,
        Outside,
        Inside
    }
}
