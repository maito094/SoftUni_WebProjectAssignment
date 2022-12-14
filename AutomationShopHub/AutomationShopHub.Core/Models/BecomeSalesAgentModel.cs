using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models
{
   public class BecomeSalesAgentModel
   {

      [Required]
      [Phone]
      [StringLength(15, MinimumLength = 7)]
      [Display(Name = "Phone number")]
      public string TelephoneNumber { get; set; } = null!;

      [StringLength(512)]
      [Display(Name = "Profile Image Url")]
      public string ImageProfileUrl { get; set; } = null!;
   }
}
