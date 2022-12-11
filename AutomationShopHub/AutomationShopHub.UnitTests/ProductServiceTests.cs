using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Services;
using AutomationShopHub.Infrastructure.Data;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace AutomationShopHub.UnitTests
{
   [TestFixture]
   public class ProductServiceTests
   {

      private IRepository repo;
      private IProductService productService;
      private ApplicationDbContext applicationDbContext;


      [SetUp]
      public void Setup()
      {
         var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("ProductDb")
            .Options;

         applicationDbContext = new ApplicationDbContext(contextOptions);

         applicationDbContext.Database.EnsureDeleted();
         applicationDbContext.Database.EnsureCreated();

      }

      [Test]
      public async Task TestAllPLCQueryNumberAndNotDeletedInMemory()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<PLC> mockDataCollection = new List<PLC>()
         {
            new PLC()
            {
               Id = 101,
               ModelReference = "CP6501-0001-0090",
               ProductId = new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
               Description= "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ",
               ScanTime=1.00M,
               MaxInputsOutputs=2048,
               Price=1800.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=2,
               DatasheetUrl= "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf",
               ImageUrl= "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png",
            },
            new PLC()
            {
               Id = 102,
               ModelReference = "C6915-0020",
               ProductId = new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"),
               Description= "The C69xx Industrial PC series is characterized by its compact design, the robust aluminum housings, and an especially wide choice of components and interfaces.",
               ScanTime=0.010M,
               MaxInputsOutputs=4096,
               Price=7400.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=3,
               DatasheetUrl= "https://download.beckhoff.com/download/Document/ipc/industrial-pc/c6915en.pdf",
               ImageUrl= "https://multimedia.beckhoff.com/media/c6915__web_main_preview.png",
            },
            new PLC()
            {
               Id = 103,
               ModelReference = "SIMATIC S7-400",
               ProductId = new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"),
               Description= "The S7-400 has been designed for system solutions in the fields of manufacturing and process automation. This process controller is ideal for data-intensive tasks that are especially typical for the process industry.",
               ScanTime=1.00M,
               MaxInputsOutputs=1048,
               Price=6000.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=3,
               DatasheetUrl= "https://cache.industry.siemens.com/dl/files/550/23904550/att_98310/v1/CPU_data_en_en-US.pdf",
               ImageUrl= "https://assets.new.siemens.com/siemens/assets/api/uuid:a68ed0a0267def8ef60d303bb27debd390f09fef/width:750/crop:0:0,125:1:0,8425/quality:high/simatic-s7-400.jpg",
                Product= new Product()
               {
                   Description="generic",
                  Name="generic",
                  isDeleted=true,
               }
            },
            new PLC()
            {
               Id = 104,
               ModelReference = "SIMATIC S7-1200",
               ProductId = new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"),
               Description= "SIMATIC S7-1200 controllers by Siemens are the intelligent choice for compact automation solutions with extended communication options and integrated technology functions.",
               ScanTime=0.100M,
               MaxInputsOutputs=2048,
               Price=8000.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=4,
               DatasheetUrl= "https://cache.industry.siemens.com/dl/files/241/109797241/att_1066673/v1/s71200_system_manual_en-US_en-US.pdf",
               ImageUrl= "https://assets.new.siemens.com/siemens/assets/api/uuid:feaa95f1-babd-48fc-9adf-3808b1ab9a37/width:750/crop:0,125:0,25467:0,737:0,55467/quality:high/simatic-s7-1200-plc.jpg",
               Product= new Product()
               {
                  Description="generic",
                  Name="generic",
                  isDeleted=true,
               }
            }
         };

         var mockDataCount = await repo.AllReadonly<PLC>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();



         var productCollection = await productService.AllPLCsQuery().ToListAsync();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
         Assert.That(productCollection.Any(p => p.Id == 104), Is.False);
      }

      //[Test] - Does NOT Work with Async!!!
      //public async Task TestAllPLCQueryNumberAndNotDeleted()
      //{
      //   IQueryable<PLC> products = new List<PLC>()
      //   {
      //      new PLC()  {Id = 1, Product= new Product(){
      //         isDeleted=false,
      //      }},
      //      new PLC() { Id = 2,Product= new Product(){
      //         isDeleted=false,
      //      } },
      //      new PLC() { Id = 3,Product= new Product(){
      //         isDeleted=true,
      //      } },
      //      new PLC() { Id = 4, Product= new Product(){
      //         isDeleted=true,
      //      } },

      //   }.AsQueryable();

      //   var repoMock = new Mock<IRepository>();
      //   repoMock.Setup(r => r.AllReadonly<PLC>())
      //         .Returns(products);

      //   repo = repoMock.Object;

      //   productService = new ProductService(repo);

      //   var collection = productService.AllPLCsQuery();

      //   var productCollection = await collection.ToListAsync();

      //   Assert.That(productCollection.Count(), Is.EqualTo(2));
      //   Assert.That(productCollection.Any(p => p.Id == 3), Is.False);
      //   Assert.That(productCollection.Any(p => p.Id == 4), Is.False);
      //}

      [TearDown]
      public void TearDown()
      {
         applicationDbContext.Dispose();
      }

   }
}
