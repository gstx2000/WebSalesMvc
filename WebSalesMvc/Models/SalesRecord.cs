using System;
using System.ComponentModel.DataAnnotations;
using WebSalesMvc.Models.Enums;

namespace WebSalesMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        
        [Required]
        [Display(Name = "Valor")]
        public double Amount { get; set; }
        
        [Required]
        [Display(Name = "Status")]
        public SaleStatus Status { get; set; }
       
        [Required]
        [Display(Name = "Vendedor")]
        public Seller Seller { get; set; }

      
        public SalesRecord()
        {
        }
        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
