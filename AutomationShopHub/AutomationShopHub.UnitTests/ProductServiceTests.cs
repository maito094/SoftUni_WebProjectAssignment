using AutomationShopHub.Core.Contracts;
using AutomationShopHub.Core.Models.Product;
using AutomationShopHub.Core.Models.Product.ProductTypes;
using AutomationShopHub.Core.Services;
using AutomationShopHub.Infrastructure.Data;
using AutomationShopHub.Infrastructure.Data.Common;
using AutomationShopHub.Infrastructure.Data.Entities;
using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Moq;
using System.Reflection.Metadata;

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
      public async Task TestAllPLCQueryNumberAndNotDeleted()
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

      [Test]
      public async Task TestAllRobotQueryNumberAndNotDeleted()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Robot> mockDataCollection = new List<Robot>()
         {
            new Robot()
            {
               Id = 101,
               ModelReference = "RV-5AS-D",
               RobotTypeId = 1,
               NumberOfAxis = 6,
               Reach = 910.00M,
               Speed = 250.00M,
               Payload = 5M,
               CommunicationProtocolId = 6,
               ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
               GuaranteePeriod = 12,
               Price = 36000.00M,
               Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
               DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
               ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

            },
            new Robot()
            {
               Id = 102,
               ModelReference = "RV-4FRL",
               RobotTypeId = 4,
               NumberOfAxis = 6,
               Reach = 649.00M,
               Speed = 9048.00M,
               Payload = 4M,
               CommunicationProtocolId = 6,
               ProductId = new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
               GuaranteePeriod = 12,
               Price = 24000.00M,
               Description = "Industrial Robot RV-4FR-D 6-axis; +/- 0,02mm; 4kg; 649mm; IP40; incl. CR800 \n The Mitsubishi RV-4FRL robot is a 6-axis robot arm, it offers a 4.0 kg payload and 649 mm reach. The repeatability of the Mitsubishi RV-4FRL robot is 0.02 mm.\n Common applications of the Mitsubishi RV-4FRL robot include: arc welding, dispensing, remote tcp, and spot welding.",
               DatasheetUrl = "https://eu-assets.contentstack.com/v3/assets/blt5412ff9af9aef77f/blta5c4b84935903df0/62e796f9ccb3425e80d74d81/bfp-a3470t.pdf",
               ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/bltfab71d6a3325a818/617426bdb04cff6af9e6afb0/313088.jpg?fit=bounds&width=280&height=280",
                Product= new Product()
               {
                  Description="generic",
                  Name="generic",
                  isDeleted=true,
               }

            },
         };

         var mockDataCount = await repo.AllReadonly<Robot>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();



         var productCollection = await productService.AllRobotsQuery().ToListAsync();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 1));
         Assert.That(productCollection.Any(p => p.Id == 102), Is.False);
      }

      [Test]
      public async Task TestAllSensorQueryNumberAndNotDeleted()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Sensor> mockDataCollection = new List<Sensor>()
         {
            new Sensor()
            {
               Id = 101,
               ModelReference = "CQ35-25NPP-KC1",
               isDiscreteType = true,
               isRangeAdjustable = true,
               Description = "Capacitive proximity sensors",
               ProductId = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
               CommunicationProtocolId = 1,
               SensorTypeId = 3,
               GuaranteePeriod = 6,
               Price = 240.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

            },
            new Sensor()
            {
               Id = 102,
               ModelReference = "MM12-60APS-ZCK",
               isDiscreteType = true,
               isRangeAdjustable = false,
               Description = "Magnetic proximity sensors",
               ProductId = new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
               CommunicationProtocolId = 1,
               SensorTypeId = 1,
               GuaranteePeriod = 6,
               Price = 300.00M,
               DatasheetUrl = "https://cdn.sick.com/media/pdf/4/54/154/dataSheet_MM12-60APS-ZCK_1040070_en.pdf",
               ImageUrl = "https://cdn.sick.com/media/150/5/05/305/IM0045305.png",
                     Product = new Product()
               {
                  Description = "generic",
                  Name = "generic",
                  isDeleted = true,
               }

            }

         };

         var mockDataCount = await repo.AllReadonly<Sensor>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();



         var productCollection = await productService.AllSensorsQuery().ToListAsync();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 1));
         Assert.That(productCollection.Any(p => p.Id == 102), Is.False);
      }

      [Test]
      public async Task TestAllVisionSystemQueryNumberAndNotDeleted()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<VisionSystem> mockDataCollection = new List<VisionSystem>()
         {
            new VisionSystem()
            {
               Id = 101,
               ModelReference = "IV-H500CA",
               hasBuiltInController = true,
               hasBuiltInLens = true,
               hasBuiltInLight = true,
               Description = "Standard, Color, Automatic focus model IV - H500CA",
               ProductId = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 5000.00M,
               DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
               ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
            },
            new VisionSystem()
            {
               Id = 102,
               ModelReference = "IV-HG500CA",
               hasBuiltInController = false,
               hasBuiltInLens = true,
               hasBuiltInLight = true,
               Description = "Sensor Head, Standard, Color, Automatic focus model IV-HG500CA",
               ProductId = new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
               GuaranteePeriod = 12,
               CommunicationProtocolId = 1,
               Price = 3000.00M,
               DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_24HG5CA&downloadZipFlag=0",
               ImageUrl = "https://www.keyence.com/img/products/model/AS_68875_L.jpg",
               Product = new Product()
               {
                  Description = "generic",
                  Name = "generic",
                  isDeleted = true,
               }
            }

         };

         var mockDataCount = await repo.AllReadonly<VisionSystem>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();



         var productCollection = await productService.AllVisionSystemsQuery().ToListAsync();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 1));
         Assert.That(productCollection.Any(p => p.Id == 102), Is.False);
      }

      [Test] // Counting on the already seeded data
      public async Task TestAllProductsQueryNumberAndNotDeleted()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var productCount = await repo.AllReadonly<Product>(o => true).CountAsync();

         var productCollection = productService.AllProductsQuery();

         Assert.That(productCollection.Sum(o => o.Count()), Is.EqualTo(productCount));
      }

      [Test]
      public async Task TestAllRobotTypesQueryNumber()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<RobotType> mockDataCollection = new List<RobotType>()
         {
             new RobotType()
            {
               Id=101,
               Name="Cobot",
            },
            new RobotType()
            {
               Id=102,
               Name="Delta",
            }
         };

         var mockDataCount = await repo.AllReadonly<RobotType>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productCollection = await productService.AllRobotTypes();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
      }

      [Test]
      public async Task TestRobotTypesExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<RobotType> mockDataCollection = new List<RobotType>()
         {
            new RobotType()
            {
               Id=101,
               Name="Cobot",
            },
            new RobotType()
            {
               Id=102,
               Name="Delta",
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.RobotTypeExists(101);

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestRobotTypesExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<RobotType> mockDataCollection = new List<RobotType>()
         {

             new RobotType()
            {
               Id=101,
               Name="Cobot",
            },
            new RobotType()
            {
               Id=102,
               Name="Delta",
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.RobotTypeExists(103);

         Assert.That(productExists, Is.False);
      }


      [Test]
      public async Task TestAllProtocolTypesQueryNumber()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<IndustrialProtocol> mockDataCollection = new List<IndustrialProtocol>()
         {
          new IndustrialProtocol()
            {
               Id = 101,
               Name = "None",
               Description = "This product does not have an industrial communication protocol"
            },
            new IndustrialProtocol()
            {
               Id = 102,
               Name = "EtherCat",
               Description = "EtherCAT is a real-time Industrial Ethernet technology originally developed by Beckhoff Automation. The EtherCAT protocol which is disclosed in the IEC standard IEC61158 is suitable for hard and soft real-time requirements in automation technology, in test and measurement and many other applications." +
               "The main focus during the development of EtherCAT was on short cycle times(≤ 100 µs),low jitter for accurate synchronization (≤ 1 µs) and low hardware costs."
            },
         };

         var mockDataCount = await repo.AllReadonly<IndustrialProtocol>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productCollection = await productService.AllProtocolTypes();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
      }


      [Test]
      public async Task TestProtocolExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<IndustrialProtocol> mockDataCollection = new List<IndustrialProtocol>()
         {
            new IndustrialProtocol()
            {
               Id = 101,
               Name = "None",
               Description = "This product does not have an industrial communication protocol"
            },
            new IndustrialProtocol()
            {
               Id = 102,
               Name = "EtherCat",
               Description = "EtherCAT is a real-time Industrial Ethernet technology originally developed by Beckhoff Automation. The EtherCAT protocol which is disclosed in the IEC standard IEC61158 is suitable for hard and soft real-time requirements in automation technology, in test and measurement and many other applications." +
               "The main focus during the development of EtherCAT was on short cycle times(≤ 100 µs),low jitter for accurate synchronization (≤ 1 µs) and low hardware costs."
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.ProtocolExists(101);

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestProtocolExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<IndustrialProtocol> mockDataCollection = new List<IndustrialProtocol>()
         {

            new IndustrialProtocol()
            {
               Id = 101,
               Name = "None",
               Description = "This product does not have an industrial communication protocol"
            },
            new IndustrialProtocol()
            {
               Id = 102,
               Name = "EtherCat",
               Description = "EtherCAT is a real-time Industrial Ethernet technology originally developed by Beckhoff Automation. The EtherCAT protocol which is disclosed in the IEC standard IEC61158 is suitable for hard and soft real-time requirements in automation technology, in test and measurement and many other applications." +
               "The main focus during the development of EtherCAT was on short cycle times(≤ 100 µs),low jitter for accurate synchronization (≤ 1 µs) and low hardware costs."
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.ProtocolExists(103);

         Assert.That(productExists, Is.False);
      }


      [Test]
      public async Task TestAllSensorTypesQueryNumber()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<SensorType> mockDataCollection = new List<SensorType>()
         {
          new SensorType()
            {
               Id=101,
               Name="Magnetic"
            },
            new SensorType()
            {
               Id=102,
               Name="Inductive"
            }
         };

         var mockDataCount = await repo.AllReadonly<SensorType>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productCollection = await productService.AllSensorTypes();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
      }


      [Test]
      public async Task TestSensorTypeExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<SensorType> mockDataCollection = new List<SensorType>()
         {
            new SensorType()
            {
               Id=101,
               Name="Magnetic"
            },
            new SensorType()
            {
               Id=102,
               Name="Inductive"
            }
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.SensorTypeExists(101);

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestSensorTypeExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<SensorType> mockDataCollection = new List<SensorType>()
         {

             new SensorType()
            {
               Id=101,
               Name="Magnetic"
            },
            new SensorType()
            {
               Id=102,
               Name="Inductive"
            }
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.SensorTypeExists(103);

         Assert.That(productExists, Is.False);
      }


      [Test]
      public async Task TestAllCategoriesQueryNumber()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Category> mockDataCollection = new List<Category>()
         {
            new Category()
             {
             Id = 101,
             Name = "Robots",
             Description= "Type of automated machine that can execute specific tasks with little or no human intervention and with speed and precision. A robot is a machine—especially one programmable by a computer—capable of carrying out a complex series of actions automatically. A robot can be guided by an external control device, or the control may be embedded within."

             },
            new Category()
             {
             Id = 102,
             Name = "PLCs",
             Description = "A programmable logic controller or programmable controller is an industrial computer that has been ruggedized and adapted for the control of manufacturing processes, such as assembly lines, machines, robotic devices, or any activity that requires high reliability, ease of programming, and process fault diagnosis."
             },
         };

         var mockDataCount = await repo.AllReadonly<Category>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productCollection = await productService.AllCategories();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
      }


      [Test]
      public async Task TestCategoryExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Category> mockDataCollection = new List<Category>()
         {
            new Category()
             {
             Id = 101,
             Name = "Robots",
             Description= "Type of automated machine that can execute specific tasks with little or no human intervention and with speed and precision. A robot is a machine—especially one programmable by a computer—capable of carrying out a complex series of actions automatically. A robot can be guided by an external control device, or the control may be embedded within."

             },
            new Category()
             {
             Id = 102,
             Name = "PLCs",
             Description = "A programmable logic controller or programmable controller is an industrial computer that has been ruggedized and adapted for the control of manufacturing processes, such as assembly lines, machines, robotic devices, or any activity that requires high reliability, ease of programming, and process fault diagnosis."
             },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.CategoryExists(101);

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestCategoryExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Category> mockDataCollection = new List<Category>()
         {
            new Category()
             {
             Id = 101,
             Name = "Robots",
             Description= "Type of automated machine that can execute specific tasks with little or no human intervention and with speed and precision. A robot is a machine—especially one programmable by a computer—capable of carrying out a complex series of actions automatically. A robot can be guided by an external control device, or the control may be embedded within."

             },
            new Category()
             {
             Id = 102,
             Name = "PLCs",
             Description = "A programmable logic controller or programmable controller is an industrial computer that has been ruggedized and adapted for the control of manufacturing processes, such as assembly lines, machines, robotic devices, or any activity that requires high reliability, ease of programming, and process fault diagnosis."
             },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.CategoryExists(103);

         Assert.That(productExists, Is.False);
      }

      [Test]
      public async Task TestAllBrandsQueryNumber()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Brand> mockDataCollection = new List<Brand>()
         {
             new Brand()
            {
               Id = 101,
               Name = "Mitsubishi Electric",
               Description = "Mitsubishi Electric Corporation, established on 15 January 1921, is a Japanese multinational electronics and electrical equipment manufacturing company headquartered in Tokyo, Japan. It is one of the core companies of Mitsubishi."
            },
            new Brand()
            {
               Id = 102,
               Name = "Staubli",
               Description = "Stäubli is a Swiss mechatronics company, primarily known for its textile machinery, connectors and robotics products."
            },
         };

         var mockDataCount = await repo.AllReadonly<Brand>(o => true).CountAsync();
         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productCollection = await productService.AllBrands();

         Assert.That(productCollection.Count(), Is.EqualTo(mockDataCount + 2));
         Assert.That(productCollection.Any(p => p.Id == 103), Is.False);
      }


      [Test]
      public async Task TestBrandExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Brand> mockDataCollection = new List<Brand>()
         {
             new Brand()
            {
               Id = 101,
               Name = "Mitsubishi Electric",
               Description = "Mitsubishi Electric Corporation, established on 15 January 1921, is a Japanese multinational electronics and electrical equipment manufacturing company headquartered in Tokyo, Japan. It is one of the core companies of Mitsubishi."
            },
            new Brand()
            {
               Id = 102,
               Name = "Staubli",
               Description = "Stäubli is a Swiss mechatronics company, primarily known for its textile machinery, connectors and robotics products."
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.BrandExists(101);

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestBrandExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Brand> mockDataCollection = new List<Brand>()
         {
             new Brand()
            {
               Id = 101,
               Name = "Mitsubishi Electric",
               Description = "Mitsubishi Electric Corporation, established on 15 January 1921, is a Japanese multinational electronics and electrical equipment manufacturing company headquartered in Tokyo, Japan. It is one of the core companies of Mitsubishi."
            },
            new Brand()
            {
               Id = 102,
               Name = "Staubli",
               Description = "Stäubli is a Swiss mechatronics company, primarily known for its textile machinery, connectors and robotics products."
            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.CategoryExists(103);

         Assert.That(productExists, Is.False);
      }


      [Test]
      public async Task TestGetProductById()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var commentMock = new Comment()
         {
            Id = new Guid("1deb9971-4b89-49d1-8b34-cb02f9644165"),
            Content = "Excellent product!",
            UserId = "49e48785-2dd4-43d8-9085-382f97dc4cf2",
            ReplyId = new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1")

         };

         var orderProductMock = new OrderProduct()
         {
            OrderId = new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
            ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
         };

         var productMock = new Product()
         {
            Id = new Guid("bd9e8dd5-593b-4ac0-91a4-3a764f6c51d8"),
            Name = "RV-5AS-D",
            ProductDateAdded = DateTime.Now.AddDays(13),
            BrandId = 1,
            CategoryId = 1,
            Description = "This is a Mitsubishi Electrics Robot",
            isDeleted = false,
            SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),
            Comments = new List<Comment>() { commentMock },
            OrderProducts = new List<OrderProduct> { orderProductMock }

         };



         List<Product> mockDataCollection = new List<Product>()
         {
            productMock,
            new Product()
            {
               Id = new Guid("15e07bcc-0b72-41ad-a69e-2cebefb1831c"),
               Name = "RV-4FRL",
               ProductDateAdded = DateTime.Now.AddMonths(-3),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var product = await productService.GetProductByIdAsync(new Guid("bd9e8dd5-593b-4ac0-91a4-3a764f6c51d8"));

         Assert.That(productMock.Id == product.Id, Is.True);
         Assert.That(productMock.Comments.Any(c => c.Id == new Guid("1deb9971-4b89-49d1-8b34-cb02f9644165")));
         Assert.That(productMock.OrderProducts.Any(o => o.OrderId == new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da")));

      }


      [Test]
      public async Task TestProductExistsPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Product> mockDataCollection = new List<Product>()
         {
             new Product()
            {
               Id = new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"),
               Name = "RV-5AS-D",
               ProductDateAdded = DateTime.Now.AddDays(13),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            }
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.ProductExists(new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"));

         Assert.That(productExists, Is.True);
      }

      [Test]
      public async Task TestProductExistsNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Product> mockDataCollection = new List<Product>()
         {

            new Product()
            {
               Id = new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"),
               Name = "RV-4FRL",
               ProductDateAdded = DateTime.Now.AddMonths(-3),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = true,
               SalesAgentId = new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"),

            },
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var productExists = await productService.ProductExists(new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"));

         Assert.That(productExists, Is.False);
      }

      [Test]
      public async Task TestCreateRobot()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockRobot =
           new RobotModel()
           {
              ModelReference = "RV-5AS-D",
              RobotTypeId = 1,
              NumberOfAxis = 6,
              Reach = 910.00M,
              Speed = 250.00M,
              Payload = 5M,
              CommunicationProtocolId = 6,
              ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
              GuaranteePeriod = 12,
              Price = 36000.00M,
              Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
              DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
              ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

           };

         var robotId = await productService.CreateRobot(mockRobot);
         var robot = await repo.GetByIdAsync<Robot>(robotId);


         Assert.That(robotId, Is.EqualTo(robot.Id));
         Assert.That(robot.ModelReference, Is.EqualTo(mockRobot.ModelReference));
      }

      [Test]
      public async Task TestCreatePLC()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockPLC =
            new PLCModel()
            {
               ModelReference = "CP6501-0001-0090",
               ProductId = new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
               Description = "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ",
               ScanTime = 1.00M,
               MaxInputsOutputs = 2048,
               Price = 1800.00M,
               GuaranteePeriod = 18,
               CommunicationProtocolId = 2,
               DatasheetUrl = "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf",
               ImageUrl = "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png",
            };

         var plcId = await productService.CreatePLC(mockPLC);
         var plc = await repo.GetByIdAsync<PLC>(plcId);


         Assert.That(plcId, Is.EqualTo(plc.Id));
         Assert.That(plc.ModelReference, Is.EqualTo(mockPLC.ModelReference));
      }

      [Test]
      public async Task TestCreateSensor()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockSensor =
              new SensorModel()
              {
                 ModelReference = "CQ35-25NPP-KC1",
                 isDiscreteType = true,
                 isRangeAdjustable = true,
                 Description = "Capacitive proximity sensors",
                 ProductId = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
                 CommunicationProtocolId = 1,
                 SensorTypeId = 3,
                 GuaranteePeriod = 6,
                 Price = 240.00M,
                 DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
                 ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

              };

         var sensorId = await productService.CreateSensor(mockSensor);
         var sensor = await repo.GetByIdAsync<Sensor>(sensorId);


         Assert.That(sensorId, Is.EqualTo(sensor.Id));
         Assert.That(sensor.ModelReference, Is.EqualTo(mockSensor.ModelReference));
      }

      [Test]
      public async Task TestCreateVisionSystem()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockVisionSystem =
              new VisionSystemModel()
              {
                 ModelReference = "IV-H500CA",
                 hasBuiltInController = true,
                 hasBuiltInLens = true,
                 hasBuiltInLight = true,
                 Description = "Standard, Color, Automatic focus model IV - H500CA",
                 ProductId = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
                 GuaranteePeriod = 12,
                 CommunicationProtocolId = 1,
                 Price = 5000.00M,
                 DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
                 ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
              };

         var visionSystemId = await productService.CreateVisionSystem(mockVisionSystem);
         var visionSystem = await repo.GetByIdAsync<VisionSystem>(visionSystemId);


         Assert.That(visionSystemId, Is.EqualTo(visionSystem.Id));
         Assert.That(visionSystem.ModelReference, Is.EqualTo(mockVisionSystem.ModelReference));
      }

      [Test]
      public async Task TestCreateProduct()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockProduct =
               new ProductModel()
               {
                  Name = "RV-5AS-D",
                  ProductDateAdded = DateTime.Now.AddDays(13),
                  BrandId = 1,
                  CategoryId = 1,
                  Description = "This is a Mitsubishi Electrics Robot",
                  isDeleted = false,
                  SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

               };

         var productId = await productService.CreateProduct(mockProduct);
         var product = await repo.GetByIdAsync<Product>(productId);


         Assert.That(productId, Is.EqualTo(product.Id));
         Assert.That(product.Name, Is.EqualTo(mockProduct.Name));
      }

      [Test]
      public async Task TestGetRobotTypePositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockRobotType =
               new RobotType()
               {
                  Name = "TestType",
               };

         await repo.AddAsync(mockRobotType);
         await repo.SaveChangesAsync();
         var robotTypeDb = await repo.AllReadonly<RobotType>().FirstOrDefaultAsync(rt => rt.Name == "TestType");

         var robotType = await productService.GetRobotType(robotTypeDb.Id);

         Assert.That(robotTypeDb.Id, Is.EqualTo(robotType.Id));
         Assert.That(robotTypeDb.Name, Is.EqualTo(robotType.Name));
      }
      [Test]
      public async Task TestGetRobotTypeNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);


         Assert.ThrowsAsync<NullReferenceException>(() => productService.GetRobotType(1001));
      }


      [Test]
      public async Task TestGetProtocolTypePositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockProtocolType =
               new IndustrialProtocol()
               {
                  Name = "TestType",
                  Description = "This product does not have an industrial communication protocol"
               };

         await repo.AddAsync(mockProtocolType);
         await repo.SaveChangesAsync();
         var protocolDb = await repo.AllReadonly<IndustrialProtocol>().FirstOrDefaultAsync(rt => rt.Name == "TestType");

         var protocolType = await productService.GetProtocolType(protocolDb.Id);

         Assert.That(protocolDb.Id, Is.EqualTo(protocolType.Id));
         Assert.That(protocolDb.Name, Is.EqualTo(protocolType.Name));
      }
      [Test]
      public async Task TestGetProtocolTypeNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);


         Assert.ThrowsAsync<NullReferenceException>(() => productService.GetProtocolType(1001));
      }


      [Test]
      public async Task TestGetSensorTypePositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockSensorType =
               new SensorType()
               {
                  Name = "TestType"
               };

         await repo.AddAsync(mockSensorType);
         await repo.SaveChangesAsync();
         var sensorDb = await repo.AllReadonly<SensorType>().FirstOrDefaultAsync(rt => rt.Name == "TestType");

         var sensorType = await productService.GetSensorType(sensorDb.Id);

         Assert.That(sensorDb.Id, Is.EqualTo(sensorType.Id));
         Assert.That(sensorDb.Name, Is.EqualTo(sensorType.Name));
      }
      [Test]
      public async Task TestGetSensorTypeNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);


         Assert.ThrowsAsync<NullReferenceException>(() => productService.GetSensorType(1001));
      }

      [Test]
      public async Task TestGetCategoryPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockCategory =
               new Category()
               {
                  Name = "TestType",
                  Description = "General Description"
               };

         await repo.AddAsync(mockCategory);
         await repo.SaveChangesAsync();
         var categoryDb = await repo.AllReadonly<Category>().FirstOrDefaultAsync(rt => rt.Name == "TestType");

         var category = await productService.GetCategory(categoryDb.Id);

         Assert.That(categoryDb.Id, Is.EqualTo(category.Id));
         Assert.That(categoryDb.Name, Is.EqualTo(category.Name));
      }
      [Test]
      public async Task TestGetCategoryNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);


         Assert.ThrowsAsync<NullReferenceException>(() => productService.GetCategory(1001));
      }

      [Test]
      public async Task TestGetBrandPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockBrand =
               new Brand()
               {
                  Name = "TestType",
                  Description = "General Description"
               };

         await repo.AddAsync(mockBrand);
         await repo.SaveChangesAsync();
         var brandDb = await repo.AllReadonly<Brand>().FirstOrDefaultAsync(rt => rt.Name == "TestType");

         var brand = await productService.GetBrand(brandDb.Id);

         Assert.That(brandDb.Id, Is.EqualTo(brand.Id));
         Assert.That(brandDb.Name, Is.EqualTo(brand.Name));
      }
      [Test]
      public async Task TestGetBrandNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);


         Assert.ThrowsAsync<NullReferenceException>(() => productService.GetBrand(1001));
      }

      [Test]
      public async Task TestEditRobot()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new Robot()
               {
                  ModelReference = "TestReference",
                  RobotTypeId = 1,
                  NumberOfAxis = 6,
                  Reach = 910.00M,
                  Speed = 250.00M,
                  Payload = 5M,
                  CommunicationProtocolId = 6,
                  ProductId = new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                  GuaranteePeriod = 12,
                  Price = 36000.00M,
                  Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
                  DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
                  ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Robot>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         await productService.EditRobot(
               modelData.Id,
               modelData.Description,
               modelData.CommunicationProtocolId,
               modelData.RobotTypeId,
               "TestReferenceEdited",
               modelData.GuaranteePeriod,
               modelData.Reach,
               modelData.Speed,
               modelData.Payload,
               modelData.NumberOfAxis,
               modelData.DatasheetUrl,
               modelData.ImageUrl,
               modelData.Price
             );

         var modelDataEdited = await repo.AllReadonly<Robot>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReferenceEdited");


         Assert.That(modelDataEdited.Id, Is.EqualTo(modelData.Id));
         Assert.That(modelDataEdited.ModelReference, Is.EqualTo("TestReferenceEdited"));
      }


      [Test]
      public async Task TestEditPLC()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new PLC()
               {

                  ModelReference = "TestReference",
                  ProductId = new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
                  Description = "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ",
                  ScanTime = 1.00M,
                  MaxInputsOutputs = 2048,
                  Price = 1800.00M,
                  GuaranteePeriod = 18,
                  CommunicationProtocolId = 2,
                  DatasheetUrl = "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf",
                  ImageUrl = "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png",
               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<PLC>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         await productService.EditPLC(
               modelData.Id,
               modelData.Description,
               modelData.CommunicationProtocolId,
               "TestReferenceEdited",
               modelData.GuaranteePeriod,
               modelData.MaxInputsOutputs,
               modelData.ScanTime,
               modelData.DatasheetUrl,
               modelData.ImageUrl,
               modelData.Price
             );

         var modelDataEdited = await repo.AllReadonly<PLC>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReferenceEdited");


         Assert.That(modelDataEdited.Id, Is.EqualTo(modelData.Id));
         Assert.That(modelDataEdited.ModelReference, Is.EqualTo("TestReferenceEdited"));
      }

      [Test]
      public async Task TestEditSensor()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new Sensor()
               {
                  ModelReference = "TestReference",
                  isDiscreteType = true,
                  isRangeAdjustable = true,
                  Description = "Capacitive proximity sensors",
                  ProductId = new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
                  CommunicationProtocolId = 1,
                  SensorTypeId = 3,
                  GuaranteePeriod = 6,
                  Price = 240.00M,
                  DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
                  ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Sensor>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         await productService.EditSensor(
               modelData.Id,
               modelData.Description,
               modelData.CommunicationProtocolId,
               modelData.SensorTypeId,
               "TestReferenceEdited",
               modelData.GuaranteePeriod,
               modelData.isDiscreteType,
               modelData.isRangeAdjustable,
               modelData.DatasheetUrl,
               modelData.ImageUrl,
               modelData.Price
             );

         var modelDataEdited = await repo.AllReadonly<Sensor>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReferenceEdited");


         Assert.That(modelDataEdited.Id, Is.EqualTo(modelData.Id));
         Assert.That(modelDataEdited.ModelReference, Is.EqualTo("TestReferenceEdited"));
      }


      [Test]
      public async Task TestEditVisionSystem()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
                new VisionSystem()
                {

                   ModelReference = "TestReference",
                   hasBuiltInController = true,
                   hasBuiltInLens = true,
                   hasBuiltInLight = true,
                   Description = "Standard, Color, Automatic focus model IV - H500CA",
                   ProductId = new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
                   GuaranteePeriod = 12,
                   CommunicationProtocolId = 1,
                   Price = 5000.00M,
                   DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
                   ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
                };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<VisionSystem>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         await productService.EditVisionSystem(
               modelData.Id,
               modelData.Description,
               modelData.CommunicationProtocolId,
               "TestReferenceEdited",
               modelData.GuaranteePeriod,
               modelData.hasBuiltInController,
               modelData.hasBuiltInLight,
               modelData.hasBuiltInLens,
               modelData.DatasheetUrl,
               modelData.ImageUrl,
               modelData.Price
             );

         var modelDataEdited = await repo.AllReadonly<VisionSystem>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReferenceEdited");


         Assert.That(modelDataEdited.Id, Is.EqualTo(modelData.Id));
         Assert.That(modelDataEdited.ModelReference, Is.EqualTo("TestReferenceEdited"));
      }

      [Test]
      public async Task TestGetRobotByProductId()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new Robot()
               {
                  ModelReference = "TestReference",
                  RobotTypeId = 1,
                  NumberOfAxis = 6,
                  Reach = 910.00M,
                  Speed = 250.00M,
                  Payload = 5M,
                  CommunicationProtocolId = 6,
                  ProductId = new Guid("841caf64-5fb2-4d5c-a67c-5935d1229fb0"),
                  GuaranteePeriod = 12,
                  Price = 36000.00M,
                  Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
                  DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
                  ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Robot>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetRobotByProductId(mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetPLCByProductId()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
                new PLC()
                {
                   ModelReference = "TestReference",
                   ProductId = new Guid("89ace7ba-d15a-43e9-b7d7-4c169642ee70"),
                   Description = "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ",
                   ScanTime = 1.00M,
                   MaxInputsOutputs = 2048,
                   Price = 1800.00M,
                   GuaranteePeriod = 18,
                   CommunicationProtocolId = 2,
                   DatasheetUrl = "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf",
                   ImageUrl = "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png",
                };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<PLC>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetPLCByProductId(mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetSensorByProductId()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
                new Sensor()
                {
                   ModelReference = "TestReference",
                   isDiscreteType = true,
                   isRangeAdjustable = true,
                   Description = "Capacitive proximity sensors",
                   ProductId = new Guid("902ecd9a-7103-4b27-96aa-ccb67a80625e"),
                   CommunicationProtocolId = 1,
                   SensorTypeId = 3,
                   GuaranteePeriod = 6,
                   Price = 240.00M,
                   DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
                   ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

                };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Sensor>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetSensorByProductId(mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetVisionSystemByProductId()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new VisionSystem()
               {
                  ModelReference = "TestReference",
                  hasBuiltInController = true,
                  hasBuiltInLens = true,
                  hasBuiltInLight = true,
                  Description = "Standard, Color, Automatic focus model IV - H500CA",
                  ProductId = new Guid("eb4209c6-8ca7-4aea-9566-3c403d029cce"),
                  GuaranteePeriod = 12,
                  CommunicationProtocolId = 1,
                  Price = 5000.00M,
                  DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
                  ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<VisionSystem>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetVisionSystemByProductId(mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }


      [Test]
      public async Task TestGetProductTypeByCategoryAndProductId_Robot()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new Robot()
               {
                  ModelReference = "TestReference",
                  RobotTypeId = 1,
                  NumberOfAxis = 6,
                  Reach = 910.00M,
                  Speed = 250.00M,
                  Payload = 5M,
                  CommunicationProtocolId = 6,
                  ProductId = new Guid("841caf64-5fb2-4d5c-a67c-5935d1229fb0"),
                  GuaranteePeriod = 12,
                  Price = 36000.00M,
                  Description = "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.",
                  DatasheetUrl = "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf",
                  ImageUrl = "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280"

               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Robot>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetProductTypeByCategoryAndProductId(1, mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetProductTypeByCategoryAndProductId_PLC()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new PLC()
               {
                  ModelReference = "TestReference",
                  ProductId = new Guid("89ace7ba-d15a-43e9-b7d7-4c169642ee70"),
                  Description = "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ",
                  ScanTime = 1.00M,
                  MaxInputsOutputs = 2048,
                  Price = 1800.00M,
                  GuaranteePeriod = 18,
                  CommunicationProtocolId = 2,
                  DatasheetUrl = "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf",
                  ImageUrl = "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png",
               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<PLC>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetProductTypeByCategoryAndProductId(2, mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetProductTypeByCategoryAndProductId_Sensor()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
               new Sensor()
               {
                  ModelReference = "TestReference",
                  isDiscreteType = true,
                  isRangeAdjustable = true,
                  Description = "Capacitive proximity sensors",
                  ProductId = new Guid("902ecd9a-7103-4b27-96aa-ccb67a80625e"),
                  CommunicationProtocolId = 1,
                  SensorTypeId = 3,
                  GuaranteePeriod = 6,
                  Price = 240.00M,
                  DatasheetUrl = "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf",
                  ImageUrl = "https://cdn.sick.com/media/150/9/89/689/IM0029689.png"

               };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<Sensor>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetProductTypeByCategoryAndProductId(3, mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetProductTypeByCategoryAndProductId_VisionSystem()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
                       new VisionSystem()
                       {
                          ModelReference = "TestReference",
                          hasBuiltInController = true,
                          hasBuiltInLens = true,
                          hasBuiltInLight = true,
                          Description = "Standard, Color, Automatic focus model IV - H500CA",
                          ProductId = new Guid("eb4209c6-8ca7-4aea-9566-3c403d029cce"),
                          GuaranteePeriod = 12,
                          CommunicationProtocolId = 1,
                          Price = 5000.00M,
                          DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
                          ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
                       };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<VisionSystem>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetProductTypeByCategoryAndProductId(4, mockData.ProductId);


         Assert.That(modelData.Id, Is.EqualTo(getModelData.Id));
         Assert.That(modelData.ProductId, Is.EqualTo(getModelData.ProductId));
         Assert.That(getModelData.ModelReference, Is.EqualTo("TestReference"));
      }

      [Test]
      public async Task TestGetProductTypeByCategoryAndProductId_CategoryNotFoundException()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         var mockData =
                       new VisionSystem()
                       {
                          ModelReference = "TestReference",
                          hasBuiltInController = true,
                          hasBuiltInLens = true,
                          hasBuiltInLight = true,
                          Description = "Standard, Color, Automatic focus model IV - H500CA",
                          ProductId = new Guid("eb4209c6-8ca7-4aea-9566-3c403d029cce"),
                          GuaranteePeriod = 12,
                          CommunicationProtocolId = 1,
                          Price = 5000.00M,
                          DatasheetUrl = "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0",
                          ImageUrl = "https://www.keyence.com/img/products/model/AS_2189_L.jpg"
                       };

         await repo.AddAsync(mockData);
         await repo.SaveChangesAsync();
         var modelData = await repo.AllReadonly<VisionSystem>().FirstOrDefaultAsync(rt => rt.ModelReference == "TestReference");

         var getModelData = await productService.GetProductTypeByCategoryAndProductId(4, mockData.ProductId);

         Assert.ThrowsAsync<ArgumentException>(() => productService.GetProductTypeByCategoryAndProductId(5, mockData.ProductId));
      }


      [Test]
      public async Task TestDeleteProduct()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Product> mockDataCollection = new List<Product>()
         {

            new Product()
            {
               Id = new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"),
               Name = "RV-4FRL",
               ProductDateAdded = DateTime.Now.AddMonths(-3),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"),

            }
         };

         var mockDataCount = await repo.AllReadonly<Product>(o => !o.isDeleted).CountAsync();

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();


         await productService.Delete(new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"));


         var mockDataCountAfterDelete = await repo.AllReadonly<Product>(o => !o.isDeleted).CountAsync();



         Assert.That(mockDataCount, Is.EqualTo(mockDataCountAfterDelete));


         var productExists = await productService.ProductExists(new Guid("242f22a8-1469-4e8a-b11e-e9d11a14c737"));

         Assert.That(productExists, Is.False);
      }

      [Test]
      public async Task TestProductHasAgentWithIdPositiveCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Product> mockDataCollection = new List<Product>()
         {
             new Product()
            {
               Id = new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"),
               Name = "RV-5AS-D",
               ProductDateAdded = DateTime.Now.AddDays(13),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            }
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var hasAgentWithId = await productService.HasAgentWithId(new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"));

         Assert.That(hasAgentWithId, Is.True);


      }
      [Test]
      public async Task TestProductHasAgentWithIdNegativeCase()
      {
         var repo = new Repository(applicationDbContext);

         productService = new ProductService(repo);

         List<Product> mockDataCollection = new List<Product>()
         {
             new Product()
            {
               Id = new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"),
               Name = "RV-5AS-D",
               ProductDateAdded = DateTime.Now.AddDays(13),
               BrandId = 1,
               CategoryId = 1,
               Description = "This is a Mitsubishi Electrics Robot",
               isDeleted = false,
               SalesAgentId = new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"),

            }
         };

         await repo.AddRangeAsync(mockDataCollection);

         await repo.SaveChangesAsync();

         var hasAgentWithId = await productService.HasAgentWithId(new Guid("070cd1ed-44dd-45ad-9ddd-9ea28e11f9b1"), new Guid("bd9e8dd5-593b-4ac0-91a4-3a764f6c51d8"));

         Assert.That(hasAgentWithId, Is.False);


      }

      [TearDown]
      public void TearDown()
      {
         applicationDbContext.Dispose();
      }

   }
}
