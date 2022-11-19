using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutomationShopHub.Infrastructure.Migrations
{
    public partial class OrderIsConfirmAndURLsLengthLimit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "VisionSystems",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "VisionSystems",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Sensors",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "Sensors",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Robots",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "Robots",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PLCs",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "PLCs",
                type: "nvarchar(512)",
                maxLength: 512,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "isConfirmed",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "OrderDateCreated", "isConfirmed" },
                values: new object[] { new DateTime(2022, 11, 24, 13, 24, 21, 27, DateTimeKind.Local).AddTicks(3870), true });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isConfirmed",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "VisionSystems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "VisionSystems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Sensors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "Sensors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Robots",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "Robots",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PLCs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.AlterColumn<string>(
                name: "DatasheetUrl",
                table: "PLCs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(512)",
                oldMaxLength: 512);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fcfd061-6371-4fe8-95e3-f7a33f763ea2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62b316eb-4d4b-4749-b6ce-3ec2799668ab", "AQAAAAEAACcQAAAAEHJfmcvednh/T3n/pN1D5RzNmwqOPoZZB8P//HZy1pKqYE026d1Fjg5NClwTK9a4AA==", "8a2b422d-264f-4cf1-8527-52186c42bd3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49e48785-2dd4-43d8-9085-382f97dc4cf2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6415d73c-c62d-4651-b3d1-e4d2832dc798", "AQAAAAEAACcQAAAAEGHf7wERC/yqLOVrC2iR8qjxO94wTP6CPhaO63/HVoA8xmh8ayIPi33wc9trXMilAQ==", "9f8ae0bf-11dc-49e4-b837-b1c99654c214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7377b78d-4057-4cd3-bfe5-eb07a490be7f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0303e555-fd19-4c3c-bf3f-f5493f1e36a4", "AQAAAAEAACcQAAAAEDVGAo1HjwME5y1+7LSmWu6WKl+VtDPMeFDkPIod4dHo8LSiSa4oWJucsDmNrBDIJQ==", "952138c5-b74f-42c0-b5a0-26d156f38cdb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d7fd9f2-488e-4f51-9b40-09ac1a762cc2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "862420c4-3321-44cc-9d52-9b7c97a78a9b", "AQAAAAEAACcQAAAAEJUzpmyg14j17VGwn6L1Cf9Ckbw7bv3I5w4rW0VH6GiHzrhdH1GP8uBXDaltLU+Qug==", "a6a2b22a-4795-462b-b20f-1d68ecbcb36f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cca4b5a6-d054-40af-9d42-6288a33cfa8e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87e55930-8577-4e7b-8f72-51520b961254", "AQAAAAEAACcQAAAAEBrIA286NiG4LSb6fHAt3kOWR/U0hC/seE2J43SVlPDKGg/ZgJ2lypsXVF2m7qs4vQ==", "83a4bcee-331e-4702-a6fe-2c7439bfd46f" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("36a3a03f-492b-4b9a-827b-7d73f9a779a4"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 18, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("421f7b83-3f09-4752-93e7-a8c4d11c60da"),
                column: "OrderDateCreated",
                value: new DateTime(2022, 11, 9, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0378fadf-917c-4aba-81df-eabce425f35f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 22, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0410e9f4-c4ba-4ad8-8c91-717e0b3f6efb"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab11e4e-8cf8-4f24-bb72-b6e6a3977540"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 11, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0cf5127a-025f-4647-99a7-de98c8e058a9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 6, 25, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("12442fb1-09d5-40ed-863a-50f8bebfcc27"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15be50a2-572b-4833-a3d7-0e52ff3265d0"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21585ca4-fb50-46ab-a840-f985e1594856"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 5, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("224dbcbc-1acd-47c1-b531-d316e71f75e2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 25, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5284));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("22796eaf-573a-4425-be80-cc1f6b3d192d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 7, 14, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26c49e9c-b173-465a-abee-95dd9792f135"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("400d29e8-adbc-46b2-a673-41039ff7f596"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 6, 15, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("44285875-cce9-401a-aa5a-2f48a595fa8d"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4451d49b-fd6b-4ecb-afea-c32f7051f3b5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 5, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b1b60e8-3229-4a1b-8c5e-2c23bd8b7925"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 30, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c9149b2-8fb8-40b2-99cc-7da146628629"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 6, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7235e11d-a3f5-444f-9318-0e7c5d44236b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 11, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8904891e-48d2-4fd6-b09a-061c913b427e"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 9, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eebbe89-35c9-4bb9-9aab-f2171df80e33"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a11c7320-4fd5-4730-8262-f8d25f205ac3"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb3c5b4-f411-464c-8dbe-e1569f85c4ca"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 23, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6ed768f-637d-471e-b36e-ebca4b6f0af9"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bdeac1a5-43e4-45d4-9b90-d15a5e845af5"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 20, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c10d758e-160e-4add-becc-c5c9bc787b5f"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 29, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c5d39d35-9a06-4b12-b577-ff40ea5be9cc"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d13d95a0-27b7-4aef-8265-4701a204ce2a"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 9, 26, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2baf47b-cc25-4906-a692-2797c885d76b"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f4feb50c-6f1a-41c2-8e17-21100edd4a47"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 27, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f53ee029-9ea4-42c2-ad2a-8e1499b32794"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 5, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f6d3759f-b373-47a0-96a0-eb988e26a99c"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 10, 22, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f82ac642-96ba-4e00-a535-a3d41080b4b2"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 8, 13, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f8d7302f-b5ab-499c-91bc-0f9049aed281"),
                column: "ProductDateAdded",
                value: new DateTime(2022, 11, 8, 18, 36, 45, 192, DateTimeKind.Local).AddTicks(5298));
        }
    }
}
