using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models
{
   public class SalesAgentModel
   {
      [Required]
      public Guid SalesAgentId { get; set; }

      [Required]
      public string AgentUserId { get; set; } = null!;
      [Required]
      public string AgentName { get; set; } = null!;

      [Required]
      [Phone]
      [StringLength(15, MinimumLength = 7)]
      [Display(Name = "Phone number")]
      public string TelephoneNumber { get; set; } = null!;

      [StringLength(512)]
      public string? ImageProfileUrl { get; set; }
   }
}
