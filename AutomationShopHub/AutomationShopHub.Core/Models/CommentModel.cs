using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationShopHub.Core.Models
{
    public class CommentModel
    {
      [Key]
      public Guid Id { get; set; }

      [Required]
      [StringLength(250)]
      public string Content { get; set; } = null!;

      [Required]
      public string UserId { get; set; } = null!;

      public List<CommentModel> Replies { get; set; } = new List<CommentModel>();
   }
}
