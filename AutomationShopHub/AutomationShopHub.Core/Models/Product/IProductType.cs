namespace AutomationShopHub.Core.Models.Product
{
   public interface IProductType
   {
      public int Id { get; set; }

      public Guid ProductId { get; set; }

      public string ModelReference { get; set; }

      public int CommunicationProtocolId { get; set; }

      public string Description { get; set; }

      public int GuaranteePeriod { get; set; }

      public string ImageUrl { get; set; }

      public string DatasheetUrl { get; set; }

      public decimal Price { get; set; }
   }
}
