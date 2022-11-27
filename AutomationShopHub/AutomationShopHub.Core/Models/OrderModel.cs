using AutomationShopHub.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models
{
    public class OrderModel
    {
      [Key]
      public Guid Id { get; set; }


      [Required]
      public Guid ClientId { get; set; }

      [Required]
      public Client Client { get; set; } = null!;

      [Required]
      public Guid SalesAgentId { get; set; }
      [Required]
      public SalesAgentModel SalesAgent { get; set; } = null!;

      [Required]
      public List<OrderProductModel> OrderProducts { get; set; } = new List<OrderProductModel> ();

      [Required]
      [StringLength(80)]
      public string DeliveryAddress { get; set; } = null!;

      [Required]
      public DateTime OrderDateCreated { get; set; }

      public bool isDeleted { get; set; }

      [Required]
      [Range(typeof(decimal), "10.00", "1000000.00")]
      public decimal TotalAmount { get; set; }

      [Required]
      public bool isConfirmed { get; set; }
   }
}
