using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class PLCsConfiguration : IEntityTypeConfiguration<PLC>
   {
      public void Configure(EntityTypeBuilder<PLC> builder)
      {
         builder.
            HasData(
            new PLC()
            {
               Id = 1,
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
               Id = 2,
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
               Id = 3,
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
            }, 
            new PLC()
            {
               Id = 4,
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
            }, 
            new PLC()
            {
               Id = 5,
               ModelReference = "MELSEC iQ-R-R120PCPU",
               ProductId = new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"),
               Description= "To succeed in highly competitive markets, it's important to build automation systems that ensure high productivity and consistent product quality.MELSEC iQ - R is taking a three - point approach to solving these problems: Reducing TCO, increasing Reliability and Reuse of existing assets.",
               ScanTime=1M,
               MaxInputsOutputs=4096,
               Price=4500.00M,
               GuaranteePeriod=24,
               CommunicationProtocolId=6,
               DatasheetUrl= "https://www.manualslib.com/products/Mitsubishi-Electric-Melsec-Iq-R-R120pcpu-9092058.html",
               ImageUrl= "https://www.mitsubishielectric.com/fa/products/cnt/plcr/items/img/01lp3plcr_t001.jpg",
            }, 
            new PLC()
            {
               Id = 6,
               ModelReference = "MELSEC iQ-F FX5U",
               ProductId = new Guid("21585ca4-fb50-46ab-a840-f985e1594856"),
               Description= "The Mitsubishi MELSEC-F series undergone many advancements, making way for the next generation MELSEC iQ-F Series, with enhanced high speed bus, expanded built-in functions, advanced SSCNET III/H support, and improved engineering evironment with parameter settings in GXW3 engineering software.",
               ScanTime=10.00M,
               MaxInputsOutputs=2048,
               Price=2400.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=6,
               DatasheetUrl= "https://dl.mitsubishielectric.com/dl/fa/document/manual/plcf/jy997d55301/jy997d55301u.pdf",
               ImageUrl= "https://www.mitsubishielectric.com/fa/products/cnt/plcf/items/img/01lp3plciqf_t001.jpg",
            }, 
            new PLC()
            {
               Id = 7,
               ModelReference = "MELSEC-Q25PRHCPU",
               ProductId = new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"),
               Description= "With its nano-order speed basic command processes, the next generation MELSEC-Q Series dramatically improves system and machine performance. As equipment and manufacturing facilities continue to evolve on a daily basis, the series enables high-speed, high-accuracy and large volume data processing and machine control.",
               ScanTime=0.5M,
               MaxInputsOutputs=4096,
               Price=6000.00M,
               GuaranteePeriod=18,
               CommunicationProtocolId=6,
               DatasheetUrl= "https://dl.mitsubishielectric.com/dl/fa/document/manual/plc/sh080483eng/sh080483engay.pdf",
               ImageUrl= "https://www.mitsubishielectric.com/fa/products/cnt/plcq/items/img/01lp3_t001.jpg",
            }
            
            ) ;
      }
   }
}
