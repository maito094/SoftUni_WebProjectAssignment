using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomationShopHub.Infrastructure.Migrations
{
    public partial class SeedDbData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0fcfd061-6371-4fe8-95e3-f7a33f763ea2", 0, "62b316eb-4d4b-4749-b6ce-3ec2799668ab", "SalesAgent_1@mail.com", false, false, null, "salesagent_1@mail.com", "salesagent_1@mail.com", "AQAAAAEAACcQAAAAEHJfmcvednh/T3n/pN1D5RzNmwqOPoZZB8P//HZy1pKqYE026d1Fjg5NClwTK9a4AA==", null, false, "8a2b422d-264f-4cf1-8527-52186c42bd3c", false, "SalesAgent_1@mail.com" },
                    { "49e48785-2dd4-43d8-9085-382f97dc4cf2", 0, "6415d73c-c62d-4651-b3d1-e4d2832dc798", "Client_1@mail.com", false, false, null, "client_1@mail.com", "client_1@mail.com", "AQAAAAEAACcQAAAAEGHf7wERC/yqLOVrC2iR8qjxO94wTP6CPhaO63/HVoA8xmh8ayIPi33wc9trXMilAQ==", null, false, "9f8ae0bf-11dc-49e4-b837-b1c99654c214", false, "Client_1@mail.com" },
                    { "7377b78d-4057-4cd3-bfe5-eb07a490be7f", 0, "0303e555-fd19-4c3c-bf3f-f5493f1e36a4", "Client_2@mail.com", false, false, null, "client_2@mail.com", "client_2@mail.com", "AQAAAAEAACcQAAAAEDVGAo1HjwME5y1+7LSmWu6WKl+VtDPMeFDkPIod4dHo8LSiSa4oWJucsDmNrBDIJQ==", null, false, "952138c5-b74f-42c0-b5a0-26d156f38cdb", false, "Client_2@mail.com" },
                    { "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2", 0, "862420c4-3321-44cc-9d52-9b7c97a78a9b", "SalesAgent_2@mail.com", false, false, null, "salesagent_2@mail.com", "salesagent_2@mail.com", "AQAAAAEAACcQAAAAEJUzpmyg14j17VGwn6L1Cf9Ckbw7bv3I5w4rW0VH6GiHzrhdH1GP8uBXDaltLU+Qug==", null, false, "a6a2b22a-4795-462b-b20f-1d68ecbcb36f", false, "SalesAgent_2@mail.com" },
                    { "cca4b5a6-d054-40af-9d42-6288a33cfa8e", 0, "87e55930-8577-4e7b-8f72-51520b961254", "SalesAgent_3@mail.com", false, false, null, "salesagent_2@mail.com", "salesagent_3@mail.com", "AQAAAAEAACcQAAAAEBrIA286NiG4LSb6fHAt3kOWR/U0hC/seE2J43SVlPDKGg/ZgJ2lypsXVF2m7qs4vQ==", null, false, "83a4bcee-331e-4702-a6fe-2c7439bfd46f", false, "SalesAgent_3@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Mitsubishi Electric Corporation, established on 15 January 1921, is a Japanese multinational electronics and electrical equipment manufacturing company headquartered in Tokyo, Japan. It is one of the core companies of Mitsubishi.", "Mitsubishi Electric" },
                    { 2, "Stäubli is a Swiss mechatronics company, primarily known for its textile machinery, connectors and robotics products.", "Staubli" },
                    { 3, "FANUC is a Japanese group of companies that provide automation products and services such as robotics and computer numerical control wireless systems.", "FANUC" },
                    { 4, "ABB is a Swedish-Swiss multinational corporation headquartered in Zürich, Switzerland. The company was formed in 1988 when Sweden's Allmänna Svenska Elektriska Aktiebolaget and Switzerland's Brown, Boveri & Cie merged to create ASEA Brown Boveri, later simplified to the initials ABB.", "ABB" },
                    { 5, "Since Beckhoff’s foundation in 1980, the development of innovative products and solutions on the basis of PC-based control technology has been the foundation of the company's continued success. We recognized many standards in automation technology that are taken for granted today at an early stage and successfully introduced to the market as innovations. Beckhoff’s philosophy of PC-based control as well as the invention of the Lightbus system and TwinCAT automation software are milestones in automation technology and have proven themselves as powerful alternatives to traditional control technology. EtherCAT, the real-time Ethernet solution, provides a powerful and future-oriented technology for a new generation of control concepts.", "Beckhoff" },
                    { 6, "WAGO is a German company based in Minden, Germany that manufactures components for electrical connection technology and electronic components for automation technology.", "WAGO" },
                    { 7, "Siemens AG is a German multinational conglomerate corporation and the largest industrial manufacturing company in Europe headquartered in Munich with branch offices abroad.", "Siemens" },
                    { 8, "Omron Corporation, styled as OMRON, is a Japanese electronics company based in Kyoto, Japan. Omron was established by Kazuma Tateishi in 1933 and incorporated in 1948. The company originated in an area of Kyoto called \"Omuro\", from which the name \"Omron\" was derived. ", "Omron" },
                    { 9, "Festo is a German automation company based in Esslingen am Neckar, Germany. Festo produces and sells pneumatic and electrical control systems and drive technology for factories and process automation.", "Festo" },
                    { 10, "KUKA is a German manufacturer of industrial robots and systems for factory automation. It has been predominantly owned by the Chinese company Midea Group since 2016.", "KUKA" },
                    { 11, "SICK is one of the world’s leading solutions providers for sensor-based applications in the industrial sector. Founded in 1946 by Dr.-Ing. e. h. Erwin Sick, the company with headquarters in Waldkirch im Breisgau near Freiburg ranks among the technological market leaders. With more than 50 subsidiaries and equity investments as well as numerous agencies, SICK maintains a presence around the globe. SICK has more than 11,000 employees worldwide and a group revenue of around EUR 2 billion (fiscal year 2021).", "SICK" },
                    { 12, "Schneider Electric SE is a French multinational company that specializes in digital automation and energy management. It addresses homes, buildings, data centers, infrastructure and industries, by combining energy technologies, real-time automation, software, and services.", "Schneider Electric" },
                    { 13, "Balluff is a medium-sized company that has been family-run for four generations, was founded in Neuhausen auf den Fildern near Stuttgart and now has grown into a cosmopolitan, leading global player. We are a sensor and automation specialist with tradition and long-standing customer relationships, which at the same time is an important innovation partner for its customers.", "Balluff" },
                    { 14, "Innovative product diversity ifm’s exceptionally large product portfolio does not only cover all relevant standard solutions but also the special requirements of individual industries.In addition to position and process sensors,sensors for motion control and safety technology are part of the product range.Furthermore,ifm offers products for industrial image processing and communication as well as identification systems and systems for mobile machines. ifm develops innovative Industry 4.0 solutions and the corresponding software and cloud products to improve digital utilisation of existing business processes and to provide new, complete control options for sustainable efficiency and cost optimisations.", "IFM" },
                    { 15, "Keyence Corporation is a direct sales organization that develops and manufactures automation sensors, vision systems, barcode readers, laser markers, measuring instruments, and digital microscopes.", "Keyence" },
                    { 16, "Cognex Corporation is an American manufacturer of machine vision systems, software and sensors used in automated manufacturing to inspect and identify parts, detect defects, verify product assembly, and guide assembly robots.", "Cognex" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Type of automated machine that can execute specific tasks with little or no human intervention and with speed and precision. A robot is a machine—especially one programmable by a computer—capable of carrying out a complex series of actions automatically. A robot can be guided by an external control device, or the control may be embedded within.", "Robots" },
                    { 2, "A programmable logic controller or programmable controller is an industrial computer that has been ruggedized and adapted for the control of manufacturing processes, such as assembly lines, machines, robotic devices, or any activity that requires high reliability, ease of programming, and process fault diagnosis.", "PLCs" },
                    { 3, "Detect and measure some physical effect, providing this information to the control system.", "Sensors" },
                    { 4, "Also known as Machinve Vision. Machine vision (MV) is the technology and methods used to provide imaging-based automatic inspection and analysis for such applications as automatic inspection, process control, and robot guidance, usually in industry. Machine vision refers to many technologies, software and hardware products, integrated systems, actions, methods and expertise.", "VisionSystem" }
                });

            migrationBuilder.InsertData(
                table: "IndustrialProtocols",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This product does not have an industrial communication protocol", "None" },
                    { 2, "EtherCAT is a real-time Industrial Ethernet technology originally developed by Beckhoff Automation. The EtherCAT protocol which is disclosed in the IEC standard IEC61158 is suitable for hard and soft real-time requirements in automation technology, in test and measurement and many other applications.The main focus during the development of EtherCAT was on short cycle times(≤ 100 µs),low jitter for accurate synchronization (≤ 1 µs) and low hardware costs.", "EtherCat" },
                    { 3, "Profibus is a standard for fieldbus communication in automation technology and was first promoted in 1989 by BMBF and then used by Siemens. It should not be confused with the Profinet standard for Industrial Ethernet. Profibus is openly published as part of IEC 61158.", "Profibus" },
                    { 4, "Profinet is an industry technical standard for data communication over Industrial Ethernet, designed for collecting data from, and controlling equipment in industrial systems, with a particular strength in delivering data under tight time constraints.", "Profinet" },
                    { 5, "EtherNet/IP is an industrial network protocol that adapts the Common Industrial Protocol to standard Ethernet. EtherNet/IP is one of the leading industrial protocols in the United States and is widely used in a range of industries including factory, hybrid and process.", "EthernetIP" },
                    { 6, "The CC-Link Open Automation Networks Family are a group of open industrial networks that enable devices from numerous manufacturers to communicate. They are used in a wide variety of industrial automation applications at the machine, cell and line levels.", "CC-Link" },
                    { 7, "Modbus is a data communications protocol originally published by Modicon in 1979 for use with its programmable logic controllers. Modbus has become a de facto standard communication protocol and is now a commonly available means of connecting industrial electronic devices.", "Modbus" },
                    { 8, "IO-Link is a simple communications protocol. It is used primarily for communications to simple 3 wire sensors and actuators. A Master has slave devices, such as an actuator or sensor, attached to it.", "IO-Link" }
                });

            migrationBuilder.InsertData(
                table: "RobotTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cobot" },
                    { 2, "Delta" },
                    { 3, "SCARA" },
                    { 4, "6-Axis" }
                });

            migrationBuilder.InsertData(
                table: "SensorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Magnetic" },
                    { 2, "Inductive" },
                    { 3, "Capacitive" },
                    { 4, "Ultrasonic" },
                    { 5, "Optical" }
                });

            migrationBuilder.InsertData(
                table: "SensorTypes",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "Laser" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "DeliveryAddress", "ImageProfileUrl", "TelephoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("8bd3a0a0-00b2-4478-b29e-3203caed4a90"), "Plovdiv \"Bulgaria\" Blvd. 42", "https://www.kindpng.com/picc/m/153-1530388_mario-head-png-png-download-people-profile-pic.png", "+359888989898", "7377b78d-4057-4cd3-bfe5-eb07a490be7f" },
                    { new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"), "Sofia \"Opalchenska\" Str. 105", "https://www.kindpng.com/picc/m/153-1530388_mario-head-png-png-download-people-profile-pic.png", "+359888123123", "49e48785-2dd4-43d8-9085-382f97dc4cf2" }
                });

            migrationBuilder.InsertData(
                table: "SalesAgents",
                columns: new[] { "Id", "ImageProfileUrl", "TelephoneNumber", "UserId" },
                values: new object[,]
                {
                    { new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg", "+359895081023", "cca4b5a6-d054-40af-9d42-6288a33cfa8e" },
                    { new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg", "+359898443311", "0fcfd061-6371-4fe8-95e3-f7a33f763ea2" },
                    { new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), "https://st.depositphotos.com/2101611/3925/v/600/depositphotos_39258143-stock-illustration-businessman-avatar-profile-picture.jpg", "+420899121223", "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "DeliveryAddress", "OrderDateCreated", "SalesAgentId", "TotalAmount", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("8bd3a0a0-00b2-4478-b29e-3203caed4a90"), "Plovdiv \"Bulgaria\" Blvd. 42", new DateTime(2022, 11, 18, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5679), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), 22000.00m, false },
                    { new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"), new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"), "Sofia \"Opalchenska\" Str. 105", new DateTime(2022, 11, 9, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5675), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), 36000.00m, false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Description", "Name", "ProductDateAdded", "ProductDateModified", "SalesAgentId", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("0378fadf-917c-4aba-81df-eabce425f35f"), 5, 2, "This is a Beckhoff product PLCs", "CP6501-0001-0090", new DateTime(2022, 7, 22, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5358), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"), 11, 3, "This is an IFM Electronics product sensor", "UGQ00300EOKG/IO-Link/US", new DateTime(2022, 9, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5312), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"), 3, 1, "This is a FANUC Corp. Robot", "M-3iA/6A", new DateTime(2022, 11, 11, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5286), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"), 7, 2, "This is a Siemens product PLCs", "SIMATIC S7-1200", new DateTime(2022, 6, 25, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), false },
                    { new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"), 11, 3, "This is a SICK automation product sensor", "WTT4SLC-3B0062B03", new DateTime(2022, 11, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5295), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"), 3, 1, "This is a FANUC Corp. Robot", "CR-4iA", new DateTime(2022, 11, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5281), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("21585ca4-fb50-46ab-a840-f985e1594856"), 1, 2, "This is a Mitsubishi Electrics product PLCs", "MELSEC iQ-F FX5U", new DateTime(2022, 5, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5346), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"), 3, 1, "This is a FANUC Corp. Robot", "LR Mate 200iD/7L", new DateTime(2022, 11, 25, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5284), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"), 5, 2, "This is a Beckhoff product PLCs", "C6915-0020", new DateTime(2022, 7, 14, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5355), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("26c49e9c-b173-465a-abee-95dd9792f135"), 15, 4, "This is a Keyence product Vision System", "IV-HG500CA", new DateTime(2022, 11, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5362), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"), 1, 2, "This is a Mitsubishi Electrics product PLCs", "MELSEC-Q25PRHCPU", new DateTime(2022, 6, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"), 1, 1, "This is a Mitsubishi Electrics Robot", "RV-5AS-D", new DateTime(2022, 11, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5245), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"), 11, 3, "This is an IFM Electronics product sensor", "O4H-FPKG/US100", new DateTime(2022, 10, 5, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5316), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"), 1, 2, "This is a Mitsubishi Electrics product PLCs", "MELSEC iQ-R-R120PCPU", new DateTime(2022, 8, 30, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5348), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"), 11, 3, "This is a SICK automation product sensor", "CQ35-25NPP-KC1", new DateTime(2022, 11, 6, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5291), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"), 11, 3, "This is a SICK automation product sensor", "IMS18-08BPOVC0S", new DateTime(2022, 11, 11, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5300), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), false },
                    { new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"), 16, 4, "This is a Cognex product Vision System", "is-2000-130", new DateTime(2022, 9, 9, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5365), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"), 11, 3, "This is an IFM Electronics product sensor", "KQ-3120NFPKG", new DateTime(2022, 10, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5309), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"), 11, 3, "This is an IFM Electronics product sensor", "OGH-FPKG/US/CUBE", new DateTime(2022, 9, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"), 11, 3, "This is an IFM Electronics product sensor", "MKT3028BBPOG/G/0,3M/ZH/AS", new DateTime(2022, 10, 23, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5314), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"), 15, 4, "This is a Keyence product Vision System", "IV-H500CA", new DateTime(2022, 9, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5360), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"), 7, 2, "This is a Siemens product PLCs", "SIMATIC S7-400", new DateTime(2022, 10, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5351), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), false },
                    { new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"), 1, 1, "This is a Mitsubishi Electrics Robot", "RH-12FRH", new DateTime(2022, 10, 29, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5279), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"), 11, 3, "This is an IFM Electronics product sensor", "IGK4008A2PKG/IO/US", new DateTime(2022, 9, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5307), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"), 16, 4, "This is a Cognex product Vision System", "is-9912", new DateTime(2022, 9, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5367), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"), 1, 1, "This is a Mitsubishi Electrics Robot", "RV-4FRL", new DateTime(2022, 8, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5275), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"), 11, 3, "This is a SICK automation product sensor", "MM12-60APS-ZCK", new DateTime(2022, 10, 27, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5293), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"), 11, 3, "This is a SICK automation product sensor", "WTB4FP-21311120ZZZ", new DateTime(2022, 11, 5, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5302), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), false },
                    { new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"), 3, 1, "This is a FANUC Corp. Robot", "M-3iA/6S", new DateTime(2022, 10, 22, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5288), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"), false },
                    { new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"), 11, 3, "This is an IFM Electronics product sensor", "CSM-WP117A2P", new DateTime(2022, 8, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"), false },
                    { new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"), 11, 3, "This is a SICK automation product sensor", "UC30-21516B", new DateTime(2022, 11, 8, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5298), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"), false }
                });

            migrationBuilder.InsertData(
                table: "OrderProduct",
                columns: new[] { "OrderId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540") },
                    { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629") },
                    { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9") },
                    { new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"), new Guid("0378fadf-917c-4aba-81df-eabce425f35f") },
                    { new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"), new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d") }
                });

            migrationBuilder.InsertData(
                table: "PLCs",
                columns: new[] { "Id", "CommunicationProtocolId", "DatasheetUrl", "Description", "GuaranteePeriod", "ImageUrl", "MaxInputsOutputs", "ModelReference", "Price", "ProductId", "ScanTime" },
                values: new object[,]
                {
                    { 1, 2, "https://download.beckhoff.com/download/Document/ipc/industrial-pc/cp65xxen.pdf", "12-inch display 800 x 600, without keys, touch screen. The Panel PC series CP65xx is designed for installation in the front of a control cabinet. A built-in Control Panel with DVI and USB interface is the front of the Panel PC. ", 18, "https://multimedia.beckhoff.com/media/cp65xx_front__web_preview.png", 2048, "CP6501-0001-0090", 1800.00m, new Guid("0378fadf-917c-4aba-81df-eabce425f35f"), 1.00m },
                    { 2, 3, "https://download.beckhoff.com/download/Document/ipc/industrial-pc/c6915en.pdf", "The C69xx Industrial PC series is characterized by its compact design, the robust aluminum housings, and an especially wide choice of components and interfaces.", 18, "https://multimedia.beckhoff.com/media/c6915__web_main_preview.png", 4096, "C6915-0020", 7400.00m, new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"), 0.010m },
                    { 3, 3, "https://cache.industry.siemens.com/dl/files/550/23904550/att_98310/v1/CPU_data_en_en-US.pdf", "The S7-400 has been designed for system solutions in the fields of manufacturing and process automation. This process controller is ideal for data-intensive tasks that are especially typical for the process industry.", 18, "https://assets.new.siemens.com/siemens/assets/api/uuid:a68ed0a0267def8ef60d303bb27debd390f09fef/width:750/crop:0:0,125:1:0,8425/quality:high/simatic-s7-400.jpg", 1048, "SIMATIC S7-400", 6000.00m, new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"), 1.00m },
                    { 4, 4, "https://cache.industry.siemens.com/dl/files/241/109797241/att_1066673/v1/s71200_system_manual_en-US_en-US.pdf", "SIMATIC S7-1200 controllers by Siemens are the intelligent choice for compact automation solutions with extended communication options and integrated technology functions.", 18, "https://assets.new.siemens.com/siemens/assets/api/uuid:feaa95f1-babd-48fc-9adf-3808b1ab9a37/width:750/crop:0,125:0,25467:0,737:0,55467/quality:high/simatic-s7-1200-plc.jpg", 2048, "SIMATIC S7-1200", 8000.00m, new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"), 0.100m },
                    { 5, 6, "https://www.manualslib.com/products/Mitsubishi-Electric-Melsec-Iq-R-R120pcpu-9092058.html", "To succeed in highly competitive markets, it's important to build automation systems that ensure high productivity and consistent product quality.MELSEC iQ - R is taking a three - point approach to solving these problems: Reducing TCO, increasing Reliability and Reuse of existing assets.", 24, "https://www.mitsubishielectric.com/fa/products/cnt/plcr/items/img/01lp3plcr_t001.jpg", 4096, "MELSEC iQ-R-R120PCPU", 4500.00m, new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"), 1m },
                    { 6, 6, "https://dl.mitsubishielectric.com/dl/fa/document/manual/plcf/jy997d55301/jy997d55301u.pdf", "The Mitsubishi MELSEC-F series undergone many advancements, making way for the next generation MELSEC iQ-F Series, with enhanced high speed bus, expanded built-in functions, advanced SSCNET III/H support, and improved engineering evironment with parameter settings in GXW3 engineering software.", 18, "https://www.mitsubishielectric.com/fa/products/cnt/plcf/items/img/01lp3plciqf_t001.jpg", 2048, "MELSEC iQ-F FX5U", 2400.00m, new Guid("21585ca4-fb50-46ab-a840-f985e1594856"), 10.00m },
                    { 7, 6, "https://dl.mitsubishielectric.com/dl/fa/document/manual/plc/sh080483eng/sh080483engay.pdf", "With its nano-order speed basic command processes, the next generation MELSEC-Q Series dramatically improves system and machine performance. As equipment and manufacturing facilities continue to evolve on a daily basis, the series enables high-speed, high-accuracy and large volume data processing and machine control.", 18, "https://www.mitsubishielectric.com/fa/products/cnt/plcq/items/img/01lp3_t001.jpg", 4096, "MELSEC-Q25PRHCPU", 6000.00m, new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"), 0.5m }
                });

            migrationBuilder.InsertData(
                table: "Robots",
                columns: new[] { "Id", "CommunicationProtocolId", "DatasheetUrl", "Description", "GuaranteePeriod", "ImageUrl", "ModelReference", "NumberOfAxis", "Payload", "Price", "ProductId", "Reach", "RobotTypeId", "Speed" },
                values: new object[,]
                {
                    { 1, 6, "https://dl.mitsubishielectric.com/dl/fa/document/catalog/robot/l(na)-09104eng/I09104b.pdf", "Industrial Cobot Melfa Assista RV-5AS-D 6-axis; 5kg; 910mm; CR800; H1 grease. \n Mitsubishi Electric Collaborative Robot - MELFA ASSISTA can share a workspace with humans.\n Simpler, Easier and more flexible.This robot will change your perception of what a \"ROBOT\" is.", 12, "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt3dc6f90ab814a068/6174281c39e7f70c7378128c/502313.jpg?fit=bounds&width=280&height=280", "RV-5AS-D", 6, 5m, 36000.00m, new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"), 910.00m, 1, 250.00m },
                    { 2, 6, "https://eu-assets.contentstack.com/v3/assets/blt5412ff9af9aef77f/blta5c4b84935903df0/62e796f9ccb3425e80d74d81/bfp-a3470t.pdf", "Industrial Robot RV-4FR-D 6-axis; +/- 0,02mm; 4kg; 649mm; IP40; incl. CR800 \n The Mitsubishi RV-4FRL robot is a 6-axis robot arm, it offers a 4.0 kg payload and 649 mm reach. The repeatability of the Mitsubishi RV-4FRL robot is 0.02 mm.\n Common applications of the Mitsubishi RV-4FRL robot include: arc welding, dispensing, remote tcp, and spot welding.", 12, "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/bltfab71d6a3325a818/617426bdb04cff6af9e6afb0/313088.jpg?fit=bounds&width=280&height=280", "RV-4FRL", 6, 4m, 24000.00m, new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"), 649.00m, 4, 9048.00m },
                    { 3, 6, "https://eu-assets.contentstack.com/v3/assets/blt5412ff9af9aef77f/bltf2e83af069f9e12a/62e796d911ef5d6c4b64da8a/bfp-a3468t.pdf", "Industrial Robot RH-12FRH-D 4-axis; +/- 0,015mm; 12kg; 850/350mm; incl. CR800 \n The RH-FR series allows for fast palletizing, targeted re-sort, perfect fit: and all of this in record time.\n \"Next-generation intelligent functions\", \"Safe, collaborative work applications\", and \"FA-IT integration functions\".With these 3 key features, the FR Series is capable of handling virtually all your automation needs", 12, "https://eu-images.contentstack.com/v3/assets/blt5412ff9af9aef77f/blt30a436c112f0dcc1/617427ea99d38b0f5a497792/313672.jpg?fit=bounds&width=280&height=280", "RH-12FRH", 4, 12m, 22000.00m, new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"), 700.00m, 3, 9048.00m },
                    { 4, 5, "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/collaborative%20robots/datasheet-cr4ia-en.pdf?la=en", "Hi, I am the smallest of the collaborative robot range, with six axis in my arm, and my maximum payload is 4kg. Similar to my fellow collaborative robots, I handle lightweight tasks that are tedious, highly manual. My compact nature enables me to perform smaller jobs in areas with limited space requirements. It is possible for me to be wall- or invert-mounted, offering me a wider range of motion without interfering with the operator’s workspace.", 12, "https://www.fanuc.eu/~/media/corporate/products/robots/collaborative/cr4ia/400x400/pr-whitebg-cr4ia.jpg?w=280", "CR-4iA", 6, 4m, 18000.00m, new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"), 550.00m, 1, 1000.00m },
                    { 5, 5, "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/lr-mate/datasheet%20lrmate-200id-7l.pdf?la=en", "Fast at handling small payloads, this compact multi-purpose industrial robot offers an enhanced reach. Like all LR Mate robots, it is also available with a range of options including integrated intelligent (vision & force) functionality, special application packages and standard IP67 protection.", 12, "https://www.fanuc.eu/~/media/corporate/products/robots/lrmate/generic/400x600/int-ro-pr-lrm2007l-l-1.jpg?w=280", "LR Mate 200iD/7L", 6, 7m, 18000.00m, new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"), 911.00m, 4, 1200.00m },
                    { 6, 5, "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/m-3ia/datasheet%20m-3ia-6a.pdf?la=en", "This high-speed 6-axis robot is perfect for picking, packaging and assembly. Its 3-axis wrist means it is capable of freely rotating workpieces and tools as required for assembly applications. Its clever design also means it makes best use of available workspace.", 12, "https://www.fanuc.eu/~/media/corporate/products/robots/delta/m3/generic/400x600/int-ro-pr-m36a-1.jpg?w=280", "M-3iA/6A", 6, 6m, 22000.00m, new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"), 1350.00m, 2, 2400.00m },
                    { 7, 5, "https://www.fanuc.eu/~/media/files/pdf/products/robots/robots-datasheets-en/m-3ia/datasheet%20m-3ia-6s.pdf?la=en", "Fittted with powerful servomotors for high acceleration and short cycle times, this model is ideal for high speed picking operations. Its four axes and high-speed single axis wrist provide increased dexterity, while its long reach makes it ideal for picking applications across multiple conveyors.", 12, "https://www.fanuc.eu/~/media/corporate/products/robots/delta/m3/generic/400x600/int-ro-pr-m36s-1.jpg?w=280", "M-3iA/6S", 4, 6m, 18000.00m, new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"), 1350.00m, 2, 2400.00m }
                });

            migrationBuilder.InsertData(
                table: "Sensors",
                columns: new[] { "Id", "CommunicationProtocolId", "DatasheetUrl", "Description", "GuaranteePeriod", "ImageUrl", "ModelReference", "Price", "ProductId", "SensorTypeId", "isDiscreteType", "isRangeAdjustable" },
                values: new object[,]
                {
                    { 1, 1, "https://cdn.sick.com/media/pdf/7/67/267/dataSheet_CQ35-25NPP-KC1_6020479_en.pdf", "Capacitive proximity sensors", 6, "https://cdn.sick.com/media/150/9/89/689/IM0029689.png", "CQ35-25NPP-KC1", 240.00m, new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"), 3, true, true },
                    { 2, 1, "https://cdn.sick.com/media/pdf/4/54/154/dataSheet_MM12-60APS-ZCK_1040070_en.pdf", "Magnetic proximity sensors", 6, "https://cdn.sick.com/media/150/5/05/305/IM0045305.png", "MM12-60APS-ZCK", 300.00m, new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"), 1, true, false },
                    { 3, 8, "https://cdn.sick.com/media/pdf/2/72/672/dataSheet_WTT4SLC-3B0062B03_1118144_en.pdf", "MultiTask photoelectric sensors PowerProx", 6, "https://cdn.sick.com/media/150/9/29/029/IM0079029.png", "WTT4SLC-3B0062B03", 650.00m, new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"), 6, false, true },
                    { 4, 8, "https://cdn.sick.com/media/pdf/4/14/214/dataSheet_UC30-21516B_6068453_en.pdf", "Ultrasonic sensors UC30 / UC30 - 2", 6, "https://cdn.sick.com/media/150/9/89/389/IM0057389.png", "UC30-21516B", 620.00m, new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"), 4, true, true },
                    { 5, 1, "https://cdn.sick.com/media/pdf/2/62/962/dataSheet_IMS18-08BPOVC0S_1097646_en.pdf", "Inductive proximity sensors IMS", 6, "https://cdn.sick.com/media/150/4/84/984/IM0083984.png", "IMS18-08BPOVC0S", 120.00m, new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"), 2, true, false },
                    { 6, 1, "https://cdn.sick.com/media/pdf/1/51/151/dataSheet_WTB4FP-21311120ZZZ_1222999_en.pdf", "Miniature photoelectric sensors W4F", 6, "https://cdn.sick.com/media/150/7/07/707/IM0085707.png", "WTB4FP-21311120ZZZ", 280.00m, new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"), 6, true, true },
                    { 7, 8, "https://cdn.sick.com/media/pdf/4/44/444/dataSheet_CSM-WP117A2P_1067294_en.pdf", "Color sensors CSM", 6, "https://cdn.sick.com/media/150/6/76/576/IM0100576.png", "CSM-WP117A2P", 400.00m, new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"), 5, false, true },
                    { 8, 8, "https://www.ifm.com/de/en/product/IG6084", "inductive analogue sensor with IO-Link IG6084", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/4106e7f09ede1947bfdf514d1b76d2d1/-B900-FJPG/IG6084", "IGK4008A2PKG/IO/US", 180.00m, new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"), 2, true, true },
                    { 9, 8, "https://www.ifm.com/de/en/product/KQ5100", "Capacitive sensor KQ5100", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/776a84cc38f1934ab331d7c520ed465c/-B900-FJPG/KQ5100", "KQ-3120NFPKG", 180.00m, new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"), 3, true, true },
                    { 10, 8, "https://www.ifm.com/de/en/product/UGT592?tab=details", "Ultrasonic sensor UGT592", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/3644e93c9899f449b727942f5853a10f/-B900-FJPG/UGT592", "UGQ00300EOKG/IO-Link/US", 280.00m, new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"), 4, true, true },
                    { 11, 1, "https://www.ifm.com/de/en/product/MK5101?tab=details", "T-slot cylinder sensor MK5101", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/079d1e50e71c7a44bf90b5c400347406/-B900-FJPG/MK5101", "MKT3028BBPOG/G/0,3M/ZH/AS", 120.00m, new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"), 1, true, false },
                    { 12, 1, "https://www.ifm.com/de/en/product/O4H500?tab=details", "Diffuse reflection sensor with background suppression O4H500", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/5098372aa1fa4349ad3e0d8b38514a65/-B900-FJPG/O4H500", "O4H-FPKG/US100", 260.00m, new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"), 6, true, true },
                    { 13, 8, "https://www.ifm.com/de/en/product/OGH580?tab=details", "Diffuse reflection sensor with background suppression OGH580", 3, "https://media.ifm.com/CIP/mediadelivery/rendition/cd00bcfcb62fbe47924f6772ad77f4dc/-B900-FJPG/OGH580", "OGH-FPKG/US/CUBE", 350.00m, new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"), 5, false, true }
                });

            migrationBuilder.InsertData(
                table: "VisionSystems",
                columns: new[] { "Id", "CommunicationProtocolId", "DatasheetUrl", "Description", "GuaranteePeriod", "ImageUrl", "ModelReference", "Price", "ProductId", "hasBuiltInController", "hasBuiltInLens", "hasBuiltInLight" },
                values: new object[,]
                {
                    { 1, 1, "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_244H5CA&downloadZipFlag=0", "Standard, Color, Automatic focus model IV - H500CA", 12, "https://www.keyence.com/img/products/model/AS_2189_L.jpg", "IV-H500CA", 5000.00m, new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"), true, true, true },
                    { 2, 1, "https://www.keyence.com/mykeyence/downloadFromDLList?downloadAssetId=DS_24HG5CA&downloadZipFlag=0", "Sensor Head, Standard, Color, Automatic focus model IV-HG500CA", 12, "https://www.keyence.com/img/products/model/AS_68875_L.jpg", "IV-HG500CA", 3000.00m, new Guid("26c49e9c-b173-465a-abee-95dd9792f135"), false, true, true },
                    { 3, 1, "https://www.manualslib.com/manual/1620089/Cognex-In-Sight-2000-Mini-Poe-Series.html#product-In-Sight%202000", "Cognex In-Sight 2000 vision sensors combine the power of In-Sight vision systems with the simplicity and affordability of an industrial sensor.", 12, "https://www.cognex.com/library/media/products/in-sight-2000-vision-sensors/is2000-and-is2000-mini-cta.png?sc_lang=en-bg", "is-2000-130", 3800.00m, new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"), true, true, true },
                    { 4, 1, "https://www.manualslib.com/manual/2005617/Cognex-9000-Seriein-Sights.html", "The In-Sight 9000 is a rugged, ultra-high-resolution line of standalone vision systems. With its ability to acquire and process exceptionally detailed images, the In-Sight 9000 delivers high accuracy part location, measurement, and inspection over a large area—even when mounted at longer distances.", 12, "https://www.cognex.com/library/media/products/in-sight-9000/is9000-cta.jpg?sc_lang=en-bg", "is-9912", 18000.00m, new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"), true, false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"), new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"), new Guid("0378fadf-917c-4aba-81df-eabce425f35f") });

            migrationBuilder.DeleteData(
                table: "OrderProduct",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"), new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d") });

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PLCs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Robots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sensors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "VisionSystems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VisionSystems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VisionSystems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VisionSystems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IndustrialProtocols",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0378fadf-917c-4aba-81df-eabce425f35f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21585ca4-fb50-46ab-a840-f985e1594856"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c49e9c-b173-465a-abee-95dd9792f135"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"));

            migrationBuilder.DeleteData(
                table: "RobotTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RobotTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RobotTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RobotTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SensorTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8bd3a0a0-00b2-4478-b29e-3203caed4a90"));

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: new Guid("8d95c7db-8fe9-408f-a707-0eea86ce8966"));

            migrationBuilder.DeleteData(
                table: "SalesAgents",
                keyColumn: "Id",
                keyValue: new Guid("245bc862-fb6b-42ab-8ce4-646f9967e3ee"));

            migrationBuilder.DeleteData(
                table: "SalesAgents",
                keyColumn: "Id",
                keyValue: new Guid("403889bc-c7ec-455f-af18-fe64fbf58240"));

            migrationBuilder.DeleteData(
                table: "SalesAgents",
                keyColumn: "Id",
                keyValue: new Guid("41d03bd6-5219-46b8-9f6b-35e48e46b44f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fcfd061-6371-4fe8-95e3-f7a33f763ea2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49e48785-2dd4-43d8-9085-382f97dc4cf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7377b78d-4057-4cd3-bfe5-eb07a490be7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cca4b5a6-d054-40af-9d42-6288a33cfa8e");
        }
    }
}
