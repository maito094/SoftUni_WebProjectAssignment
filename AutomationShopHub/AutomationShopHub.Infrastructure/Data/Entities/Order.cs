using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class Order
   {

      [Key]
      public Guid Id { get; set; }


      [Required]
      public Guid ClientId { get; set; }

      [ForeignKey(nameof(ClientId))]
      public Client Client { get; set; } = null!;

      [Required]
      public Guid SalesAgentId { get; set; }

      [ForeignKey(nameof(SalesAgentId))]
      public SalesAgent SalesAgent { get; set; } = null!;

      public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();

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
