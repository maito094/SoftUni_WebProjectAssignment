using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomationShopHub.Infrastructure.Migrations
{
    public partial class SeedCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fcfd061-6371-4fe8-95e3-f7a33f763ea2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c05ba048-d03f-4c3a-afb3-6367c80f7130", "AQAAAAEAACcQAAAAEGjmFOP4mQZuKCc67iCxYcjDx8TWR239BwM0/QLOTfHY4NhddzXMAoWkjez98ZdU7g==", "806b0a90-63ad-4b79-8f87-f79cf7f0a6d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49e48785-2dd4-43d8-9085-382f97dc4cf2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0815f726-b502-477e-aef9-589f98436a71", "AQAAAAEAACcQAAAAENefOpxa3Md78N8Csuor+pyIexGtRs2XqNqFLu5fW/E9Lhwr/3U5yYZaIaJXGRNazg==", "9b755a11-6f78-42ba-b973-6e8507bd1cc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5719f15c-9e1b-4ee0-a3df-a23e397c8944", "AQAAAAEAACcQAAAAEDuElHjo8DD9KpUGjFlQQayApKp6/aFJ5sd0cqlt3wuthfDyMRTE7Kk19R4AfM8VYw==", "5f623cc3-3af9-4e72-b32c-49b52836e728" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7b5466b-260a-4a17-adc2-0f291e0fa3c7", "AQAAAAEAACcQAAAAEKSW/RmjO5oYw7QgKNtRQxPMA3hOdrzDhFIAxZJNA9D4cd7Dd6/uDUBv42qRW39pbg==", "aa0c504c-d8cf-447d-a542-2535879e4970" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cca4b5a6-d054-40af-9d42-6288a33cfa8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3b73d04-a248-4bf3-b20e-9a3224c9ba1b", "AQAAAAEAACcQAAAAEELzI9i38hS2u8XEijAvR9wR/16EFXAukFL59MqiRxMyLHCK4fvUIa+KN8YxOM8wAw==", "50166bbd-d740-4501-8ade-e96799ce8483" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ProductId", "ReplyId", "UserId" },
                values: new object[,]
                {
                    { new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1"), "It is indeed!", null, null, "7377b78d-4057-4cd3-bfe5-eb07a490be7f" },
                    { new Guid("dfb02da2-d26f-4658-b5da-22cf4521215d"), "Is there any discount for a certain price point or quantity?", null, null, "49e48785-2dd4-43d8-9085-382f97dc4cf2" },
                    { new Guid("f7cd96d0-90a5-4d09-b05c-2bb5a92023e6"), "What would be the delivery date for this?", null, null, "7377b78d-4057-4cd3-bfe5-eb07a490be7f" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 24, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 15, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 28, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 21, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 17, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 1, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 2, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 21, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21585ca4-fb50-46ab-a840-f985e1594856"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 5, 26, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 1, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 20, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 26, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 6, 21, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 2, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 11, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 5, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 12, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 17, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 15, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 19, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 26, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 29, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 26, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 26, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 4, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 19, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 2, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 19, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 2, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 11, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 28, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 19, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 14, 13, 38, 15, 571, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ProductId", "ReplyId", "UserId" },
                values: new object[] { new Guid("978c72d3-f4ff-4ace-bbd2-69110d153bea"), "Excellent product!", null, new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1"), "49e48785-2dd4-43d8-9085-382f97dc4cf2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("978c72d3-f4ff-4ace-bbd2-69110d153bea"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("dfb02da2-d26f-4658-b5da-22cf4521215d"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("f7cd96d0-90a5-4d09-b05c-2bb5a92023e6"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("771f5f2d-67ea-4436-86bf-3244e96030e1"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fcfd061-6371-4fe8-95e3-f7a33f763ea2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88067164-3eeb-49fa-b01d-7ff6c530f398", "AQAAAAEAACcQAAAAEDKBdNeQ5Qqn8A3JhxiObObp0WlMzvCYS/WlUykZ2fjVgEXnwcDM6ZCSFx6FzAUjvg==", "73e4be50-8879-4dfd-aa9d-82eec25a541e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49e48785-2dd4-43d8-9085-382f97dc4cf2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62ea4723-9476-44ca-955a-c0174b93c496", "AQAAAAEAACcQAAAAEDeq4JxUC2/FfYyz/sCRCC/O4Y/aohil7xB1EmxSl7YWSKVG3Yhz2afEyd6SSZKu4w==", "315761db-3c92-4799-93a8-b704dbad84cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a992d335-ffee-453c-8ab2-44110a32f767", "AQAAAAEAACcQAAAAEHD/sJJZyjhp3L335Mv7gLh0RTSDRob+SWIeb4j7zeGP5YlEd8z92g4gaONSuJHaVA==", "2043e1c2-456a-41bb-afca-0be36bcc4df9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14ff1c94-9f16-421d-95e7-77a4e1c20cb6", "AQAAAAEAACcQAAAAENnJHTRg3F5hjvSokhDZfcIc8ChQKT7qYDRb7rPMIJxDb9Cbeo8QBxx+2gkiEXIjog==", "01764330-9fa0-41b0-b69f-9d6197b669cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cca4b5a6-d054-40af-9d42-6288a33cfa8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dda8ca61-dd7f-4cbd-ad31-7c3b5a628426", "AQAAAAEAACcQAAAAECfhTrJgv8CIsz9uv348JEshVRQRLrcRlHc94Y/fWM6F2mZoRygChI+tfz1OZvuuRQ==", "6d404777-5687-4a30-93ac-82eb7594e8a3" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 24, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 15, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 28, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 21, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 17, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 1, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 2, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 21, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21585ca4-fb50-46ab-a840-f985e1594856"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 5, 26, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 1, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 20, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 26, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 6, 21, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 12, 2, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 11, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 5, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 12, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 17, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 15, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 19, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 26, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 29, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 26, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 26, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 4, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 19, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 2, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 19, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 2, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 11, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 28, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 19, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 14, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3549));
        }
    }
}
