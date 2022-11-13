using AutomationShopHub.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class BrandConfiguration : IEntityTypeConfiguration<Brand>
   {
      public void Configure(EntityTypeBuilder<Brand> builder)
      {
         builder
            .HasData(
            new Brand()
            {
               Id = 1,
               Name = "Mitsubishi Electric",
               Description = "Mitsubishi Electric Corporation, established on 15 January 1921, is a Japanese multinational electronics and electrical equipment manufacturing company headquartered in Tokyo, Japan. It is one of the core companies of Mitsubishi."
            },
            new Brand()
            {
               Id = 2,
               Name = "Staubli",
               Description = "Stäubli is a Swiss mechatronics company, primarily known for its textile machinery, connectors and robotics products."
            },
            new Brand()
            {
               Id = 3,
               Name = "FANUC",
               Description = "FANUC is a Japanese group of companies that provide automation products and services such as robotics and computer numerical control wireless systems."
            },
            new Brand()
            {
               Id = 4,
               Name = "ABB",
               Description = "ABB is a Swedish-Swiss multinational corporation headquartered in Zürich, Switzerland. The company was formed in 1988 when Sweden's Allmänna Svenska Elektriska Aktiebolaget and Switzerland's Brown, Boveri & Cie merged to create ASEA Brown Boveri, later simplified to the initials ABB."
            },
             new Brand()
             {
                Id = 5,
                Name = "Beckhoff",
                Description = "Since Beckhoff’s foundation in 1980, the development of innovative products and solutions on the basis of PC-based control technology has been the foundation of the company's continued success. We recognized many standards in automation technology that are taken for granted today at an early stage and successfully introduced to the market as innovations. Beckhoff’s philosophy of PC-based control as well as the invention of the Lightbus system and TwinCAT automation software are milestones in automation technology and have proven themselves as powerful alternatives to traditional control technology. EtherCAT, the real-time Ethernet solution, provides a powerful and future-oriented technology for a new generation of control concepts."
             },
             new Brand()
             {
                Id = 6,
                Name = "WAGO",
                Description = "WAGO is a German company based in Minden, Germany that manufactures components for electrical connection technology and electronic components for automation technology."
             },
             new Brand()
             {
                Id = 7,
                Name = "Siemens",
                Description = "Siemens AG is a German multinational conglomerate corporation and the largest industrial manufacturing company in Europe headquartered in Munich with branch offices abroad."
             },
             new Brand()
             {
                Id = 8,
                Name = "Omron",
                Description = "Omron Corporation, styled as OMRON, is a Japanese electronics company based in Kyoto, Japan. Omron was established by Kazuma Tateishi in 1933 and incorporated in 1948. The company originated in an area of Kyoto called \"Omuro\", from which the name \"Omron\" was derived. "
             },
             new Brand()
             {
                Id = 9,
                Name = "Festo",
                Description = "Festo is a German automation company based in Esslingen am Neckar, Germany. Festo produces and sells pneumatic and electrical control systems and drive technology for factories and process automation."
             },
             new Brand()
             {
                Id = 10,
                Name = "KUKA",
                Description = "KUKA is a German manufacturer of industrial robots and systems for factory automation. It has been predominantly owned by the Chinese company Midea Group since 2016."
             },
             new Brand()
             {
                Id = 11,
                Name = "SICK",
                Description = "SICK is one of the world’s leading solutions providers for sensor-based applications in the industrial sector. Founded in 1946 by Dr.-Ing. e. h. Erwin Sick, the company with headquarters in Waldkirch im Breisgau near Freiburg ranks among the technological market leaders. With more than 50 subsidiaries and equity investments as well as numerous agencies, SICK maintains a presence around the globe. SICK has more than 11,000 employees worldwide and a group revenue of around EUR 2 billion (fiscal year 2021)."
             },
             new Brand()
             {
                Id = 12,
                Name = "Schneider Electric",
                Description = "Schneider Electric SE is a French multinational company that specializes in digital automation and energy management. It addresses homes, buildings, data centers, infrastructure and industries, by combining energy technologies, real-time automation, software, and services."
             },
             new Brand()
             {
                Id = 13,
                Name = "Balluff",
                Description = "Balluff is a medium-sized company that has been family-run for four generations, was founded in Neuhausen auf den Fildern near Stuttgart and now has grown into a cosmopolitan, leading global player. We are a sensor and automation specialist with tradition and long-standing customer relationships, which at the same time is an important innovation partner for its customers."
             },
             new Brand()
             {
                Id = 14,
                Name = "IFM",
                Description = "Innovative product diversity ifm’s exceptionally large product portfolio does not only cover all relevant standard solutions but also the special requirements of individual industries.In addition to position and process sensors,sensors for motion control and safety technology are part of the product range.Furthermore,ifm offers products for industrial image processing and communication as well as identification systems and systems for mobile machines. ifm develops innovative Industry 4.0 solutions and the corresponding software and cloud products to improve digital utilisation of existing business processes and to provide new, complete control options for sustainable efficiency and cost optimisations."
             },
             new Brand()
             {
                Id = 15,
                Name = "Keyence",
                Description = "Keyence Corporation is a direct sales organization that develops and manufactures automation sensors, vision systems, barcode readers, laser markers, measuring instruments, and digital microscopes."
             }
             ,
             new Brand()
             {
                Id = 16,
                Name = "Cognex",
                Description = "Cognex Corporation is an American manufacturer of machine vision systems, software and sensors used in automated manufacturing to inspect and identify parts, detect defects, verify product assembly, and guide assembly robots."
             }


            );
      }
   }
}
