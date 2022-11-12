using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomationShopHub.Infrastructure.Data.Entities
{
   public class Comment
   {
      [Key]
      public Guid Id { get; set; }

      [Required]
      [StringLength(250)]
      public string Content { get; set; } = null!;

      [Required]
      public string UserId { get; set; } = null!;

      [ForeignKey(nameof(UserId))]
      public IdentityUser User { get; set; } = null!;

      public Guid? ReplyId { get; set; }

      [ForeignKey(nameof(ReplyId))]
      public Comment? Reply { get; set; }


      public List<Comment> Replies { get; set; } = new List<Comment>();

   }
}
