using System.ComponentModel.DataAnnotations;

namespace AutomationShopHub.Core.Models
{
   public class BecomeClientModel
    {
      [Required]
      [Phone]
      [StringLength(15, MinimumLength = 7)]
      [Display(Name = "Phone number")]
      public string TelephoneNumber { get; set; } = null!;

      [Required]
      [StringLength(80)]
      [Display(Name = "Delivery Address")]

      public string DeliveryAddress { get; set; } = null!;

      [StringLength(512)]
      [Display(Name = "Profile Image Url")]
      public string ImageProfileUrl { get; set; } = null!;
   }
}
