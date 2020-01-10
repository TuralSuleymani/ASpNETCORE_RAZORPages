using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerSalesApp.Models
{
    public class Order
    {
        public int Id{get;set;}
        public int CustomerId{get;set;}
        public Customer Customer{get;set;}

        [DataType(DataType.DateTime)]
        [Column(TypeName="smalldatetime")]
        [Required]
        public DateTime OrderDate{get;set;}
         
         [Column(TypeName="decimal(6,2)")]
          [Required]
         public decimal Freight{get;set;}

          [DataType(DataType.DateTime)]
           [Required]
         [Column(TypeName="smalldatetime")]
         public DateTime ShipDate{get;set;}

    }
}