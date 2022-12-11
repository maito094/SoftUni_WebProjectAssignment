using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models
{
   public class OrderModel
    {
      [Key]
      public Guid Id { get; set; }


      [Required]
      public Guid ClientId { get; set; }

      public ClientModel Client { get; set; } = null!;

      [Required]
      public Guid SalesAgentId { get; set; }

      public SalesAgentModel SalesAgent { get; set; } = null!;

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
