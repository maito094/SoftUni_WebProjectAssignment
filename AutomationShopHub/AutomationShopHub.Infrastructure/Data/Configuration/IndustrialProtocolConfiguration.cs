using AutomationShopHub.Infrastructure.Data.Entities.ProductTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomationShopHub.Infrastructure.Data.Configuration
{
   internal class IndustrialProtocolConfiguration : IEntityTypeConfiguration<IndustrialProtocol>
   {
      public void Configure(EntityTypeBuilder<IndustrialProtocol> builder)
      {
         builder
            .HasData(
            new IndustrialProtocol()
            {
               Id = 1,
               Name = "None",
               Description = "This product does not have an industrial communication protocol"
            },
            new IndustrialProtocol()
            {
               Id = 2,
               Name = "EtherCat",
               Description = "EtherCAT is a real-time Industrial Ethernet technology originally developed by Beckhoff Automation. The EtherCAT protocol which is disclosed in the IEC standard IEC61158 is suitable for hard and soft real-time requirements in automation technology, in test and measurement and many other applications." +
               "The main focus during the development of EtherCAT was on short cycle times(≤ 100 µs),low jitter for accurate synchronization (≤ 1 µs) and low hardware costs."
            },
            new IndustrialProtocol()
            {
               Id = 3,
               Name = "Profibus",
               Description = "Profibus is a standard for fieldbus communication in automation technology and was first promoted in 1989 by BMBF and then used by Siemens. It should not be confused with the Profinet standard for Industrial Ethernet. Profibus is openly published as part of IEC 61158."
            },
            new IndustrialProtocol()
            {
               Id = 4,
               Name = "Profinet",
               Description = "Profinet is an industry technical standard for data communication over Industrial Ethernet, designed for collecting data from, and controlling equipment in industrial systems, with a particular strength in delivering data under tight time constraints."
            },
            new IndustrialProtocol()
            {
               Id = 5,
               Name = "EthernetIP",
               Description = "EtherNet/IP is an industrial network protocol that adapts the Common Industrial Protocol to standard Ethernet. EtherNet/IP is one of the leading industrial protocols in the United States and is widely used in a range of industries including factory, hybrid and process."
            },
            new IndustrialProtocol()
            {
               Id = 6,
               Name = "CC-Link",
               Description = "The CC-Link Open Automation Networks Family are a group of open industrial networks that enable devices from numerous manufacturers to communicate. They are used in a wide variety of industrial automation applications at the machine, cell and line levels."
            },
            new IndustrialProtocol()
            {
               Id = 7,
               Name = "Modbus",
               Description = "Modbus is a data communications protocol originally published by Modicon in 1979 for use with its programmable logic controllers. Modbus has become a de facto standard communication protocol and is now a commonly available means of connecting industrial electronic devices."
            },
            new IndustrialProtocol()
            {
               Id = 8,
               Name = "IO-Link",
               Description = "IO-Link is a simple communications protocol. It is used primarily for communications to simple 3 wire sensors and actuators. A Master has slave devices, such as an actuator or sensor, attached to it."
            }

            );
      }
   }
}
