using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class Client
   {
      [Key]
      public Guid Id { get; set; }

      [Required]
      public string UserId { get; set; } = null!;

      [ForeignKey(nameof(UserId))]
      public IdentityUser User { get; set; } = null!;

      [Required]
      [Phone]
      public string TelephoneNumber { get; set; } = null!;

      [Required]
      [StringLength(80)]
      public string DeliveryAddress { get; set; } = null!;

      public string? ImageProfileUrl { get; set; }

      public List<Order> Orders { get; set; } = new List<Order>();
   }
}
