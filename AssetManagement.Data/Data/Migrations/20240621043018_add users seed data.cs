using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AssetManagement.Data.Data.Migrations
{
    /// <inheritdoc />
    public partial class addusersseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDateTime", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsDisabled", "IsPasswordChanged", "JoinedDate", "LastName", "LastUpdatedDateTime", "Location", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StaffCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("073f88cc-3f6d-48e6-bdca-4c3f972ffcfd"), 0, "c545f7cd-4ab9-4ba4-9350-c38badf6a8a4", new DateTime(2024, 6, 21, 4, 30, 17, 415, DateTimeKind.Utc).AddTicks(7804), new DateTime(1997, 5, 27, 11, 30, 17, 415, DateTimeKind.Local).AddTicks(7786), "user21@gmail.com", false, "UserFirst21", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 415, DateTimeKind.Local).AddTicks(7804), "UserLast21", new DateTime(2024, 6, 21, 4, 30, 17, 415, DateTimeKind.Utc).AddTicks(7805), "HCM", true, null, "USER21@GMAIL.COM", "USER21", "AQAAAAIAAYagAAAAEIMyiGKFbqO9+sPJdYQNQqGxKtDU8enXar0CxQ6LIqYHFR+nK050DJRrd/7wFixT2w==", null, false, "87f3c29e-4921-4e5d-9297-4fe6b8a196b3", "SD0031", false, "user21" },
                    { new Guid("0a365594-90f6-4e14-a2bb-6a267c62f1af"), 0, "da4cbe89-d90f-4990-af71-98a10019bf10", new DateTime(2024, 6, 21, 4, 30, 17, 947, DateTimeKind.Utc).AddTicks(5154), new DateTime(2005, 2, 2, 11, 30, 17, 947, DateTimeKind.Local).AddTicks(5140), "user30@gmail.com", false, "UserFirst30", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 947, DateTimeKind.Local).AddTicks(5153), "UserLast30", new DateTime(2024, 6, 21, 4, 30, 17, 947, DateTimeKind.Utc).AddTicks(5155), "HN", true, null, "USER30@GMAIL.COM", "USER30", "AQAAAAIAAYagAAAAEN/kMI6bCJqf3rCynUksdlIBekZv5jVT4wf9WjIyPRgH7DzJwFku5YpznfO/0FrLmg==", null, false, "b709ed66-16c7-4edd-96aa-0992f7fc8f51", "SD0040", false, "user30" },
                    { new Guid("13643308-7f88-4caf-a83e-3c7ba53685a0"), 0, "88b30c9b-f6ca-4aea-ba9d-a6e57639dbe0", new DateTime(2024, 6, 21, 4, 30, 16, 360, DateTimeKind.Utc).AddTicks(5213), new DateTime(2004, 2, 10, 11, 30, 16, 360, DateTimeKind.Local).AddTicks(5199), "user3@gmail.com", false, "UserFirst3", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 360, DateTimeKind.Local).AddTicks(5213), "UserLast3", new DateTime(2024, 6, 21, 4, 30, 16, 360, DateTimeKind.Utc).AddTicks(5215), "HCM", true, null, "USER3@GMAIL.COM", "USER3", "AQAAAAIAAYagAAAAEKbL5ZWhj2/UYUV84lVZgaUhVwqoPYnBIbJss6F+OUUw1YM/azCVYkDwfPYyH/sTbA==", null, false, "bee0ba38-145b-4e96-8596-1980d32ec375", "SD0013", false, "user3" },
                    { new Guid("1f62e3ba-7b67-4bb5-9990-8ae88fe7412f"), 0, "444a2154-5299-4a77-b493-30b7f7e24551", new DateTime(2024, 6, 21, 4, 30, 17, 770, DateTimeKind.Utc).AddTicks(5572), new DateTime(1998, 10, 5, 11, 30, 17, 770, DateTimeKind.Local).AddTicks(5556), "user27@gmail.com", false, "UserFirst27", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 770, DateTimeKind.Local).AddTicks(5571), "UserLast27", new DateTime(2024, 6, 21, 4, 30, 17, 770, DateTimeKind.Utc).AddTicks(5573), "HCM", true, null, "USER27@GMAIL.COM", "USER27", "AQAAAAIAAYagAAAAEOJqsPKNHJu/ckB8E48vceHTXUM8Fi8PKopKhWHEQqlTYNDJ17/w0JKWUadUAH5q5Q==", null, false, "6add2081-d372-44d3-a52e-24b6257568ce", "SD0037", false, "user27" },
                    { new Guid("1f99777e-749c-4608-a76b-5b8b07f4c855"), 0, "1884ef88-aa4b-4e72-9d14-cffa1778e5fb", new DateTime(2024, 6, 21, 4, 30, 16, 302, DateTimeKind.Utc).AddTicks(7493), new DateTime(1999, 5, 9, 11, 30, 16, 302, DateTimeKind.Local).AddTicks(7480), "user2@gmail.com", false, "UserFirst2", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 302, DateTimeKind.Local).AddTicks(7492), "UserLast2", new DateTime(2024, 6, 21, 4, 30, 16, 302, DateTimeKind.Utc).AddTicks(7494), "HCM", true, null, "USER2@GMAIL.COM", "USER2", "AQAAAAIAAYagAAAAEBjCEaT//CVFRLaTVpcR7L4eOrBDOyNRE/UVGLfz6hbdfpq7hMC7eRar5+7c0WEckw==", null, false, "7eb1bb0d-da5b-4f3f-923f-84d6fd64ac65", "SD0012", false, "user2" },
                    { new Guid("21058f97-dbbf-479a-a7ce-864fc5121638"), 0, "411f18c2-8cd1-4ce3-8e43-11514f8be67f", new DateTime(2024, 6, 21, 4, 30, 16, 830, DateTimeKind.Utc).AddTicks(2982), new DateTime(2006, 5, 7, 11, 30, 16, 830, DateTimeKind.Local).AddTicks(2969), "user11@gmail.com", false, "UserFirst11", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 830, DateTimeKind.Local).AddTicks(2982), "UserLast11", new DateTime(2024, 6, 21, 4, 30, 16, 830, DateTimeKind.Utc).AddTicks(2983), "HCM", true, null, "USER11@GMAIL.COM", "USER11", "AQAAAAIAAYagAAAAEE430QghphE6agzMQfgDgPc9jCEe73QT9qMtDpTp+QXAKv46JISlIr+ObfKhAy2KZQ==", null, false, "25a6bdb1-5a12-4d0b-bb2d-c3a7152d3d7d", "SD0021", false, "user11" },
                    { new Guid("23c25cc5-d6b2-4208-bc8f-a7e153798bbf"), 0, "10b9aa8d-88e0-4743-be51-2229b6c3a917", new DateTime(2024, 6, 21, 4, 30, 16, 592, DateTimeKind.Utc).AddTicks(1961), new DateTime(1996, 2, 16, 11, 30, 16, 592, DateTimeKind.Local).AddTicks(1951), "user7@gmail.com", false, "UserFirst7", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 592, DateTimeKind.Local).AddTicks(1960), "UserLast7", new DateTime(2024, 6, 21, 4, 30, 16, 592, DateTimeKind.Utc).AddTicks(1961), "HCM", true, null, "USER7@GMAIL.COM", "USER7", "AQAAAAIAAYagAAAAEBYqb849VpKCEK3WuccwwkWzlb34PHjqCNyhVaZFj2XgGaPaTnJrR8d3xO00XnkyPA==", null, false, "2a77772e-30ac-4520-8d02-2d0c5b8f9cc4", "SD0017", false, "user7" },
                    { new Guid("24e0b413-4ccf-41be-ab27-7c18c7678d93"), 0, "03f116f8-c8aa-45e8-8cc0-d8bf61cf28f3", new DateTime(2024, 6, 21, 4, 30, 16, 708, DateTimeKind.Utc).AddTicks(8033), new DateTime(2006, 3, 14, 11, 30, 16, 708, DateTimeKind.Local).AddTicks(8019), "user9@gmail.com", false, "UserFirst9", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 708, DateTimeKind.Local).AddTicks(8033), "UserLast9", new DateTime(2024, 6, 21, 4, 30, 16, 708, DateTimeKind.Utc).AddTicks(8034), "HN", true, null, "USER9@GMAIL.COM", "USER9", "AQAAAAIAAYagAAAAEMxPP8xIPf4/d1vFhxL5vhs5UkpH4HZHrcuSX4lRSpPHtYitkeIQnCTIwe0l5uXjPw==", null, false, "eae86c89-381a-4dde-b101-f31953dd15d6", "SD0019", false, "user9" },
                    { new Guid("25b9a0d1-1b61-4597-b9b7-42ed331d6498"), 0, "2f222f3c-3912-46e9-8b0f-4578448109ed", new DateTime(2024, 6, 21, 4, 30, 17, 888, DateTimeKind.Utc).AddTicks(4868), new DateTime(1994, 10, 9, 11, 30, 17, 888, DateTimeKind.Local).AddTicks(4859), "user29@gmail.com", false, "UserFirst29", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 888, DateTimeKind.Local).AddTicks(4868), "UserLast29", new DateTime(2024, 6, 21, 4, 30, 17, 888, DateTimeKind.Utc).AddTicks(4869), "HCM", true, null, "USER29@GMAIL.COM", "USER29", "AQAAAAIAAYagAAAAEGnYTfDbdqFRjBjCqg7hwRU4+xYn8WfT/a3vuAV3CItMy548KIFfaHiYNfECuBRHVA==", null, false, "5e10b253-b42a-41fe-8ef7-84cd7cf362cc", "SD0039", false, "user29" },
                    { new Guid("2e7c830c-aff0-4f7f-93a2-627b45f23371"), 0, "af161bc5-9de0-4e65-b730-601a0678f844", new DateTime(2024, 6, 21, 4, 30, 16, 891, DateTimeKind.Utc).AddTicks(4780), new DateTime(2004, 9, 24, 11, 30, 16, 891, DateTimeKind.Local).AddTicks(4757), "user12@gmail.com", false, "UserFirst12", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 891, DateTimeKind.Local).AddTicks(4779), "UserLast12", new DateTime(2024, 6, 21, 4, 30, 16, 891, DateTimeKind.Utc).AddTicks(4780), "HCM", true, null, "USER12@GMAIL.COM", "USER12", "AQAAAAIAAYagAAAAEDxleJxozhVN+ZY2xkDMGKc5wBehakuxX8RdL+BrtaQWERUJDvz1gHSxRwcIt60R9Q==", null, false, "a481b6f2-17d5-402d-9d5b-5334f0b76879", "SD0022", false, "user12" },
                    { new Guid("30b3d356-fb3f-4957-ab96-bfb83153c289"), 0, "1a5e1747-c50f-4660-8302-5f55410e6954", new DateTime(2024, 6, 21, 4, 30, 17, 592, DateTimeKind.Utc).AddTicks(9720), new DateTime(1995, 10, 3, 11, 30, 17, 592, DateTimeKind.Local).AddTicks(9707), "user24@gmail.com", false, "UserFirst24", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 592, DateTimeKind.Local).AddTicks(9719), "UserLast24", new DateTime(2024, 6, 21, 4, 30, 17, 592, DateTimeKind.Utc).AddTicks(9721), "HCM", true, null, "USER24@GMAIL.COM", "USER24", "AQAAAAIAAYagAAAAEJMHdvC6x7zYcQLhgRkHQcj5ltrR75DVVna60Vjgx7Mnds8v0Q+O+KCw8Yyag1f/8Q==", null, false, "67f47baf-3c6b-4a6f-b340-341aa76046b9", "SD0034", false, "user24" },
                    { new Guid("3bb4080b-c5f2-41af-8111-05173653de3d"), 0, "f9ed6dd2-9730-4a45-868e-a7dffb31396b", new DateTime(2024, 6, 21, 4, 30, 17, 357, DateTimeKind.Utc).AddTicks(5794), new DateTime(2006, 4, 3, 11, 30, 17, 357, DateTimeKind.Local).AddTicks(5779), "user20@gmail.com", false, "UserFirst20", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 357, DateTimeKind.Local).AddTicks(5793), "UserLast20", new DateTime(2024, 6, 21, 4, 30, 17, 357, DateTimeKind.Utc).AddTicks(5794), "HN", true, null, "USER20@GMAIL.COM", "USER20", "AQAAAAIAAYagAAAAEP8Mk9mixKSJP3GpIC+RTddNh436Y8VO9Mh8yk5plq4t2iwyo6/RnGnsEiM13dLvNQ==", null, false, "64d3d6d1-c041-4dc6-8d21-1a207f88d4df", "SD0030", false, "user20" },
                    { new Guid("46247145-edcd-46e8-b0e1-13574884ca6a"), 0, "593baea4-a8d0-4b37-8849-373872c4be37", new DateTime(2024, 6, 21, 4, 30, 16, 769, DateTimeKind.Utc).AddTicks(2458), new DateTime(2002, 8, 14, 11, 30, 16, 769, DateTimeKind.Local).AddTicks(2413), "user10@gmail.com", false, "UserFirst10", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 769, DateTimeKind.Local).AddTicks(2457), "UserLast10", new DateTime(2024, 6, 21, 4, 30, 16, 769, DateTimeKind.Utc).AddTicks(2458), "HN", true, null, "USER10@GMAIL.COM", "USER10", "AQAAAAIAAYagAAAAEKIhTLiIPkdCO4f64L8ZecZ6sIhScBrKL0WKtmcsHS3UFK5CB39TD7rlvmpJFQrwzQ==", null, false, "b124d587-2d3a-4815-8a53-c5f7027bfc47", "SD0020", false, "user10" },
                    { new Guid("49b0e3de-468e-4e65-96b9-ef9f2b3a7a9d"), 0, "b3ba18bf-3d2e-4e19-8f25-c2105ebfc1cf", new DateTime(2024, 6, 21, 4, 30, 17, 183, DateTimeKind.Utc).AddTicks(981), new DateTime(2000, 11, 11, 11, 30, 17, 183, DateTimeKind.Local).AddTicks(912), "user17@gmail.com", false, "UserFirst17", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 183, DateTimeKind.Local).AddTicks(980), "UserLast17", new DateTime(2024, 6, 21, 4, 30, 17, 183, DateTimeKind.Utc).AddTicks(981), "HN", true, null, "USER17@GMAIL.COM", "USER17", "AQAAAAIAAYagAAAAEDQE/3OdVJeZeyOo+HCH17V2+Ruuxz/Q8v4MlRhepZPBjWBdPmXFwTz2UVdUeCtN1Q==", null, false, "ac4b7248-5b42-4695-8bd4-83608eefd1c8", "SD0027", false, "user17" },
                    { new Guid("523b214c-6eac-42f1-96b2-cc1fca0ad2ec"), 0, "bd04ad99-603d-4836-b23d-bce8269af43e", new DateTime(2024, 6, 21, 4, 30, 15, 935, DateTimeKind.Utc).AddTicks(1913), new DateTime(2000, 10, 31, 11, 30, 15, 935, DateTimeKind.Local).AddTicks(1897), "admin6@gmail.com", false, "AdminFirst6", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 935, DateTimeKind.Local).AddTicks(1912), "AdminLast6", new DateTime(2024, 6, 21, 4, 30, 15, 935, DateTimeKind.Utc).AddTicks(1913), "HN", true, null, "ADMIN6@GMAIL.COM", "ADMIN6", "AQAAAAIAAYagAAAAEMqIZ/JWNpwB4lPerwFevheGQwvjITPaSRZlKxUYsq7pGUIx/Lgwau47KKsuiN32Dw==", null, false, "efe2a8ca-f303-418a-a063-922571b6ee03", "SD0006", false, "admin6" },
                    { new Guid("61385cbf-0859-4731-95bf-0bf1d95425e2"), 0, "d9c3827e-ce78-4141-8317-dab0715d9c54", new DateTime(2024, 6, 21, 4, 30, 17, 66, DateTimeKind.Utc).AddTicks(5226), new DateTime(1998, 8, 9, 11, 30, 17, 66, DateTimeKind.Local).AddTicks(5211), "user15@gmail.com", false, "UserFirst15", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 66, DateTimeKind.Local).AddTicks(5225), "UserLast15", new DateTime(2024, 6, 21, 4, 30, 17, 66, DateTimeKind.Utc).AddTicks(5227), "HN", true, null, "USER15@GMAIL.COM", "USER15", "AQAAAAIAAYagAAAAELkbll6e6EcUIRLOdkgRdhIXvlxhzC7qq6ei+dysf8sfebYheDnL7Q910KSN/ODh+A==", null, false, "f7233675-431c-4969-84d0-d4942db93737", "SD0025", false, "user15" },
                    { new Guid("69dece1f-5a5d-43d5-b29b-a8948f9b1ca9"), 0, "df400006-db2e-435e-8b9b-621b8c716d9a", new DateTime(2024, 6, 21, 4, 30, 16, 59, DateTimeKind.Utc).AddTicks(9577), new DateTime(2006, 2, 15, 11, 30, 16, 59, DateTimeKind.Local).AddTicks(9562), "admin8@gmail.com", false, "AdminFirst8", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 59, DateTimeKind.Local).AddTicks(9577), "AdminLast8", new DateTime(2024, 6, 21, 4, 30, 16, 59, DateTimeKind.Utc).AddTicks(9585), "HCM", true, null, "ADMIN8@GMAIL.COM", "ADMIN8", "AQAAAAIAAYagAAAAEOnGKa+/72/0ABtzVXihkVnJxlLcNRVojyv5QX7iMnTIeBl74V5CwjN3J8PYC45MLw==", null, false, "dc5ba411-09e1-4f79-a122-13afb9c592ea", "SD0008", false, "admin8" },
                    { new Guid("6f622bb4-3174-4df3-83ad-4f6f0e012517"), 0, "721ba169-924f-49cb-8b71-3f883a3987fc", new DateTime(2024, 6, 21, 4, 30, 16, 245, DateTimeKind.Utc).AddTicks(1927), new DateTime(2006, 1, 2, 11, 30, 16, 245, DateTimeKind.Local).AddTicks(1912), "user1@gmail.com", false, "UserFirst1", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 245, DateTimeKind.Local).AddTicks(1926), "UserLast1", new DateTime(2024, 6, 21, 4, 30, 16, 245, DateTimeKind.Utc).AddTicks(1928), "HN", true, null, "USER1@GMAIL.COM", "USER1", "AQAAAAIAAYagAAAAEDj4op6c3W7zbYPepU0KsRCvAZaaUDAwaQ5sKsfjOcu4i5LKKz8dhwgK3TRUjWwn7g==", null, false, "8b30b851-bf3f-4c72-a105-53dc4a1be280", "SD0011", false, "user1" },
                    { new Guid("87badc17-7c6a-4caf-b58c-1713fb091128"), 0, "cbed96b5-8ce4-469e-a036-f7cc6462825c", new DateTime(2024, 6, 21, 4, 30, 17, 7, DateTimeKind.Utc).AddTicks(1112), new DateTime(2002, 1, 14, 11, 30, 17, 7, DateTimeKind.Local).AddTicks(1101), "user14@gmail.com", false, "UserFirst14", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 7, DateTimeKind.Local).AddTicks(1111), "UserLast14", new DateTime(2024, 6, 21, 4, 30, 17, 7, DateTimeKind.Utc).AddTicks(1112), "HCM", true, null, "USER14@GMAIL.COM", "USER14", "AQAAAAIAAYagAAAAEEwDbMKfWyolyfhEnJ6zUf/dg2Npn1QiUmH2XvaqV7LgiYuqIbkI16b5ozTx4EQOqA==", null, false, "267a185f-f7ab-4c3d-946a-b23a841fbfbf", "SD0024", false, "user14" },
                    { new Guid("8fe1fcfe-637f-4102-8d19-bba13343e367"), 0, "3211b9ca-05a2-4e96-8989-bea688b73bd1", new DateTime(2024, 6, 21, 4, 30, 16, 534, DateTimeKind.Utc).AddTicks(3852), new DateTime(1995, 2, 25, 11, 30, 16, 534, DateTimeKind.Local).AddTicks(3831), "user6@gmail.com", false, "UserFirst6", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 534, DateTimeKind.Local).AddTicks(3851), "UserLast6", new DateTime(2024, 6, 21, 4, 30, 16, 534, DateTimeKind.Utc).AddTicks(3852), "HN", true, null, "USER6@GMAIL.COM", "USER6", "AQAAAAIAAYagAAAAEOZBwEw7Hutu2AdUNuqWMz3tFtOCQYsdn1xbi+J1DZt0e6/0T9c3kFZNlwzmxPBX/A==", null, false, "2f4472fd-5253-4f64-ac80-975a17cec9bc", "SD0016", false, "user6" },
                    { new Guid("94814fe8-b396-4bb5-9f64-e9d91407c831"), 0, "14e8bc62-0938-459f-b909-8ac1830395a9", new DateTime(2024, 6, 21, 4, 30, 15, 874, DateTimeKind.Utc).AddTicks(9095), new DateTime(2001, 11, 8, 11, 30, 15, 874, DateTimeKind.Local).AddTicks(9081), "admin5@gmail.com", false, "AdminFirst5", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 874, DateTimeKind.Local).AddTicks(9094), "AdminLast5", new DateTime(2024, 6, 21, 4, 30, 15, 874, DateTimeKind.Utc).AddTicks(9096), "HN", true, null, "ADMIN5@GMAIL.COM", "ADMIN5", "AQAAAAIAAYagAAAAEDrrj9HlR0vK5SNQED4tFgsmdCjbyZpXaFxj2Gleqm44S39gmR0Ue8XGo89q7B7wTQ==", null, false, "e1e49b57-b2b2-4969-b56f-aedee6c9689d", "SD0005", false, "admin5" },
                    { new Guid("9f1f22e3-c832-46cf-8313-b814475bc0be"), 0, "1402e816-c66d-4fa3-9a8d-f4144e1b0f88", new DateTime(2024, 6, 21, 4, 30, 17, 124, DateTimeKind.Utc).AddTicks(4013), new DateTime(1998, 3, 25, 11, 30, 17, 124, DateTimeKind.Local).AddTicks(3997), "user16@gmail.com", false, "UserFirst16", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 124, DateTimeKind.Local).AddTicks(4013), "UserLast16", new DateTime(2024, 6, 21, 4, 30, 17, 124, DateTimeKind.Utc).AddTicks(4014), "HN", true, null, "USER16@GMAIL.COM", "USER16", "AQAAAAIAAYagAAAAEMnQCjlDqVxTrH1yGf0YfGlzMB+aOyMIf1gZ6OoLEZaFYRftSybX7GpsTcx/PafFGg==", null, false, "bb752752-38a1-42ed-b1df-416d68917147", "SD0026", false, "user16" },
                    { new Guid("a0250c52-87ef-418d-b625-515c3bc0a6bd"), 0, "8a9b96a1-d999-4e98-8a39-a6c022f2ac6c", new DateTime(2024, 6, 21, 4, 30, 16, 949, DateTimeKind.Utc).AddTicks(3919), new DateTime(2000, 5, 6, 11, 30, 16, 949, DateTimeKind.Local).AddTicks(3904), "user13@gmail.com", false, "UserFirst13", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 949, DateTimeKind.Local).AddTicks(3918), "UserLast13", new DateTime(2024, 6, 21, 4, 30, 16, 949, DateTimeKind.Utc).AddTicks(3920), "HCM", true, null, "USER13@GMAIL.COM", "USER13", "AQAAAAIAAYagAAAAECbf6oL7Bi58T1DlRRQl2IgPYvGgA66Wl1c/oYnO9bCAcQsDUFUHsHJDycfOu83c6A==", null, false, "627c96ff-26bb-442f-bf4b-5710792e0226", "SD0023", false, "user13" },
                    { new Guid("a4fba5a1-0e66-41be-bc1a-a6c1049065cb"), 0, "b0a1c790-9baa-4828-b689-6546f23adcae", new DateTime(2024, 6, 21, 4, 30, 17, 651, DateTimeKind.Utc).AddTicks(8804), new DateTime(2004, 11, 14, 11, 30, 17, 651, DateTimeKind.Local).AddTicks(8795), "user25@gmail.com", false, "UserFirst25", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 651, DateTimeKind.Local).AddTicks(8803), "UserLast25", new DateTime(2024, 6, 21, 4, 30, 17, 651, DateTimeKind.Utc).AddTicks(8805), "HN", true, null, "USER25@GMAIL.COM", "USER25", "AQAAAAIAAYagAAAAEPOw4/DgY0jkCzlgmY8KSAGCDXGmrmp0TJR5vQ+13ydgorLYXaa/mnWdzVrVqWUMWA==", null, false, "9a0d0f55-365e-4f26-9a2f-4cd60aadef87", "SD0035", false, "user25" },
                    { new Guid("aa37189b-926e-4bb8-ae78-5e41e8a16964"), 0, "a4d808e6-900c-483a-93f2-5b59b5dd3bd1", new DateTime(2024, 6, 21, 4, 30, 17, 711, DateTimeKind.Utc).AddTicks(6509), new DateTime(1999, 11, 9, 11, 30, 17, 711, DateTimeKind.Local).AddTicks(6494), "user26@gmail.com", false, "UserFirst26", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 711, DateTimeKind.Local).AddTicks(6508), "UserLast26", new DateTime(2024, 6, 21, 4, 30, 17, 711, DateTimeKind.Utc).AddTicks(6510), "HN", true, null, "USER26@GMAIL.COM", "USER26", "AQAAAAIAAYagAAAAENjOCEFi5r7tfLuAWHXURrv6lbSwrVP1/T0vBqhnTVZQ1bKuQlGg3mClvftx/h48Zw==", null, false, "dc6e5f56-b670-47cb-86d3-74df81798159", "SD0036", false, "user26" },
                    { new Guid("ad9c337a-bb6b-4949-b796-14620afd0f08"), 0, "368ebef8-6228-473c-ae78-c0ebb03b503b", new DateTime(2024, 6, 21, 4, 30, 15, 816, DateTimeKind.Utc).AddTicks(1436), new DateTime(2005, 2, 19, 11, 30, 15, 816, DateTimeKind.Local).AddTicks(1415), "admin4@gmail.com", false, "AdminFirst4", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 816, DateTimeKind.Local).AddTicks(1435), "AdminLast4", new DateTime(2024, 6, 21, 4, 30, 15, 816, DateTimeKind.Utc).AddTicks(1437), "HN", true, null, "ADMIN4@GMAIL.COM", "ADMIN4", "AQAAAAIAAYagAAAAEP46NN4DV6Rn5DkA2C+f+lQrOWGzgMCNGRjHK5bZe76nhdbIB8KD1/93Mid95YTM/A==", null, false, "60b16981-bce4-4510-913d-29e8034a6899", "SD0004", false, "admin4" },
                    { new Guid("af1763bc-7bee-4d7d-aa72-d05ede7df398"), 0, "9245dd5d-6dd1-4358-a7b4-b79dc84cf98e", new DateTime(2024, 6, 21, 4, 30, 17, 299, DateTimeKind.Utc).AddTicks(6464), new DateTime(2006, 1, 15, 11, 30, 17, 299, DateTimeKind.Local).AddTicks(6445), "user19@gmail.com", false, "UserFirst19", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 299, DateTimeKind.Local).AddTicks(6463), "UserLast19", new DateTime(2024, 6, 21, 4, 30, 17, 299, DateTimeKind.Utc).AddTicks(6464), "HN", true, null, "USER19@GMAIL.COM", "USER19", "AQAAAAIAAYagAAAAEHztvIQupEhQXL33EuzNoIE7tEgkiy+wNJ7fXTrenCL1L1H2nUxCtLcMtcA3J0pXxw==", null, false, "35fcdcdc-654b-4987-9ef7-4535755c9b57", "SD0029", false, "user19" },
                    { new Guid("bafc9d75-79bd-4608-abca-7e9931a0d7d4"), 0, "3a322adb-2e91-4bbe-ad3d-949b21ec823d", new DateTime(2024, 6, 21, 4, 30, 15, 757, DateTimeKind.Utc).AddTicks(5917), new DateTime(1997, 3, 3, 11, 30, 15, 757, DateTimeKind.Local).AddTicks(5887), "admin3@gmail.com", false, "AdminFirst3", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 757, DateTimeKind.Local).AddTicks(5916), "AdminLast3", new DateTime(2024, 6, 21, 4, 30, 15, 757, DateTimeKind.Utc).AddTicks(5918), "HN", true, null, "ADMIN3@GMAIL.COM", "ADMIN3", "AQAAAAIAAYagAAAAEPIpG73ebvoKLGp+XWR8wz4ZJNNqeET4c+WCqw62UHpVjh7WHkFD2m8gZYUFuA0iSQ==", null, false, "82db8182-5dd8-49f0-be4e-27fda6d20884", "SD0003", false, "admin3" },
                    { new Guid("bcf2971d-119a-4874-a1e7-911c13bf5eb4"), 0, "1d7df455-34a1-4f19-9823-a9d7be5a2c3a", new DateTime(2024, 6, 21, 4, 30, 16, 418, DateTimeKind.Utc).AddTicks(2277), new DateTime(1996, 11, 25, 11, 30, 16, 418, DateTimeKind.Local).AddTicks(2255), "user4@gmail.com", false, "UserFirst4", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 418, DateTimeKind.Local).AddTicks(2276), "UserLast4", new DateTime(2024, 6, 21, 4, 30, 16, 418, DateTimeKind.Utc).AddTicks(2278), "HCM", true, null, "USER4@GMAIL.COM", "USER4", "AQAAAAIAAYagAAAAEMy6jMXLdWxP10XmDzD0phsTHdqz94qZXkZPiumhHhujJI8gsSsIn6hnw848ZUv8xA==", null, false, "aecb0096-53b5-4145-af30-6d01408a197f", "SD0014", false, "user4" },
                    { new Guid("c0104960-8451-40a9-8331-f0009fb50ee6"), 0, "2cdb84de-70e9-43e8-aec0-d6fa46a178a8", new DateTime(2024, 6, 21, 4, 30, 16, 650, DateTimeKind.Utc).AddTicks(9068), new DateTime(1999, 12, 8, 11, 30, 16, 650, DateTimeKind.Local).AddTicks(9046), "user8@gmail.com", false, "UserFirst8", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 650, DateTimeKind.Local).AddTicks(9067), "UserLast8", new DateTime(2024, 6, 21, 4, 30, 16, 650, DateTimeKind.Utc).AddTicks(9068), "HN", true, null, "USER8@GMAIL.COM", "USER8", "AQAAAAIAAYagAAAAEAjqwIJkmzWPKgbkdPPrnhMIbqDY9wzguXOnkh1mU1EYGhuY21X1DBu0N9nXeq/4ug==", null, false, "a0d3376b-8f87-40f4-bc81-9fb3675ce6bc", "SD0018", false, "user8" },
                    { new Guid("c5408ed6-6101-4b04-8f5b-67d5d57ef7a1"), 0, "89de65e8-ae67-42d9-ba46-a01c1f6a9780", new DateTime(2024, 6, 21, 4, 30, 16, 185, DateTimeKind.Utc).AddTicks(6639), new DateTime(1999, 11, 10, 11, 30, 16, 185, DateTimeKind.Local).AddTicks(6612), "admin10@gmail.com", false, "AdminFirst10", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 185, DateTimeKind.Local).AddTicks(6638), "AdminLast10", new DateTime(2024, 6, 21, 4, 30, 16, 185, DateTimeKind.Utc).AddTicks(6639), "HN", true, null, "ADMIN10@GMAIL.COM", "ADMIN10", "AQAAAAIAAYagAAAAEGIDjZVrzCcYFej7hrQeOaXtg4X5CKZz7VndinK+Tt6dqc1os0LCh07D3J/xtG6FfA==", null, false, "3f7d0e9e-33fd-43a6-a885-ab5b435cf901", "SD0010", false, "admin10" },
                    { new Guid("cc898763-41d5-48f1-ac48-693d57837125"), 0, "6da2d6db-40cd-4f47-8bf4-cc3b930bcd51", new DateTime(2024, 6, 21, 4, 30, 17, 241, DateTimeKind.Utc).AddTicks(1015), new DateTime(2006, 3, 30, 11, 30, 17, 241, DateTimeKind.Local).AddTicks(999), "user18@gmail.com", false, "UserFirst18", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 241, DateTimeKind.Local).AddTicks(1014), "UserLast18", new DateTime(2024, 6, 21, 4, 30, 17, 241, DateTimeKind.Utc).AddTicks(1016), "HN", true, null, "USER18@GMAIL.COM", "USER18", "AQAAAAIAAYagAAAAEKWTDX2/6/wNDpQowyuRij52O6HhskOtifIw/zkBL8Hz6jQ0IwpwdDYClcqq4EtlBw==", null, false, "49d505a2-4f7b-4dfd-a466-abcee928c3d4", "SD0028", false, "user18" },
                    { new Guid("cf3d6527-4bb9-4329-ba81-ee2ee488debc"), 0, "b5192d79-6074-4729-8ab3-e89d8fd55b4f", new DateTime(2024, 6, 21, 4, 30, 17, 533, DateTimeKind.Utc).AddTicks(6655), new DateTime(1997, 3, 30, 11, 30, 17, 533, DateTimeKind.Local).AddTicks(6632), "user23@gmail.com", false, "UserFirst23", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 533, DateTimeKind.Local).AddTicks(6653), "UserLast23", new DateTime(2024, 6, 21, 4, 30, 17, 533, DateTimeKind.Utc).AddTicks(6656), "HN", true, null, "USER23@GMAIL.COM", "USER23", "AQAAAAIAAYagAAAAEG3AqGkR6/i3OkIprmktyUWncP5C0opmcLSy7aerBH3fwKh8wMSM39QgeOBDtAU+nA==", null, false, "5c66c888-73b1-4bec-b858-87637b5d3a3f", "SD0033", false, "user23" },
                    { new Guid("d4dd55be-9b27-4af1-8b55-4edb19be88a9"), 0, "ca297246-db16-4198-8ded-f24c25e82a3b", new DateTime(2024, 6, 21, 4, 30, 17, 474, DateTimeKind.Utc).AddTicks(6564), new DateTime(2004, 3, 25, 11, 30, 17, 474, DateTimeKind.Local).AddTicks(6551), "user22@gmail.com", false, "UserFirst22", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 474, DateTimeKind.Local).AddTicks(6562), "UserLast22", new DateTime(2024, 6, 21, 4, 30, 17, 474, DateTimeKind.Utc).AddTicks(6565), "HCM", true, null, "USER22@GMAIL.COM", "USER22", "AQAAAAIAAYagAAAAEDaY1zNI093rIIg/8Is3frVYiQR46Y2NMszscFLFlGcPHiRJZt0jOSvyMAjQXnp8NQ==", null, false, "310ed73f-ba2a-423a-ad67-e915b4614650", "SD0032", false, "user22" },
                    { new Guid("dcd50553-c31f-4d55-ae06-c6cfb8c98101"), 0, "da715d47-af23-4186-80ce-42b171b682c8", new DateTime(2024, 6, 21, 4, 30, 16, 127, DateTimeKind.Utc).AddTicks(9664), new DateTime(1998, 7, 4, 11, 30, 16, 127, DateTimeKind.Local).AddTicks(9572), "admin9@gmail.com", false, "AdminFirst9", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 127, DateTimeKind.Local).AddTicks(9663), "AdminLast9", new DateTime(2024, 6, 21, 4, 30, 16, 127, DateTimeKind.Utc).AddTicks(9664), "HCM", true, null, "ADMIN9@GMAIL.COM", "ADMIN9", "AQAAAAIAAYagAAAAEAcWpGU05Ve9jdgAlnWZMHJvzonnYKFy40o9wPVcCI8FfGXbZ8oVxIkfX8Qefk6n+Q==", null, false, "32d859c6-8767-4254-8277-aeb693cf2025", "SD0009", false, "admin9" },
                    { new Guid("e11eb642-3086-4b6f-9ef0-d10460968dd5"), 0, "1710d17d-f952-4dc9-bfd5-47a5b378a622", new DateTime(2024, 6, 21, 4, 30, 15, 993, DateTimeKind.Utc).AddTicks(3920), new DateTime(2002, 1, 24, 11, 30, 15, 993, DateTimeKind.Local).AddTicks(3905), "admin7@gmail.com", false, "AdminFirst7", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 993, DateTimeKind.Local).AddTicks(3919), "AdminLast7", new DateTime(2024, 6, 21, 4, 30, 15, 993, DateTimeKind.Utc).AddTicks(3920), "HCM", true, null, "ADMIN7@GMAIL.COM", "ADMIN7", "AQAAAAIAAYagAAAAEDArfG4Da/lszhbZ/EDfcjhI8jtyn/KwxdVQ8jpCnOSolPIfRn3db1k7EfPtXsUp7A==", null, false, "49906a83-ba5d-4737-87fa-5ef4b9e491db", "SD0007", false, "admin7" },
                    { new Guid("e8cd88d7-cdd5-4dd5-8fdf-bc184450ec7b"), 0, "d25d4794-8c92-4400-88c8-58abdd504cfc", new DateTime(2024, 6, 21, 4, 30, 17, 829, DateTimeKind.Utc).AddTicks(7118), new DateTime(2003, 12, 21, 11, 30, 17, 829, DateTimeKind.Local).AddTicks(7102), "user28@gmail.com", false, "UserFirst28", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 17, 829, DateTimeKind.Local).AddTicks(7113), "UserLast28", new DateTime(2024, 6, 21, 4, 30, 17, 829, DateTimeKind.Utc).AddTicks(7119), "HN", true, null, "USER28@GMAIL.COM", "USER28", "AQAAAAIAAYagAAAAEMeJf85V03vSPtCQ5FptYHFswgkI+gfto9grwRptJTeut3whnILg/uLwFmIDDXx7+A==", null, false, "0a2dcfff-165b-412b-a06d-d9aad61a1d54", "SD0038", false, "user28" },
                    { new Guid("fc4e8cc0-be4a-4540-b4d9-c84ddc307c99"), 0, "084b44b6-8b28-4f55-b099-3a528b3ad8ad", new DateTime(2024, 6, 21, 4, 30, 16, 476, DateTimeKind.Utc).AddTicks(5567), new DateTime(2003, 8, 11, 11, 30, 16, 476, DateTimeKind.Local).AddTicks(5552), "user5@gmail.com", false, "UserFirst5", "Male", false, true, new DateTime(2024, 6, 21, 11, 30, 16, 476, DateTimeKind.Local).AddTicks(5566), "UserLast5", new DateTime(2024, 6, 21, 4, 30, 16, 476, DateTimeKind.Utc).AddTicks(5568), "HN", true, null, "USER5@GMAIL.COM", "USER5", "AQAAAAIAAYagAAAAEKXKD9OsaTg0Pt8e9Tuh03ERjMZyAmaPhva1lQpRpDwIdUtI246QsLz54KwAvtmVbQ==", null, false, "389ee5f6-e9b9-4e70-843a-80a4feb228a6", "SD0015", false, "user5" },
                    { new Guid("fe4d7e10-e60c-445a-8c6c-a00edc97e42f"), 0, "7ca9cf31-6b0b-4295-be51-a10654d38049", new DateTime(2024, 6, 21, 4, 30, 15, 699, DateTimeKind.Utc).AddTicks(3448), new DateTime(2005, 5, 20, 11, 30, 15, 699, DateTimeKind.Local).AddTicks(3442), "admin2@gmail.com", false, "AdminFirst2", "Female", false, true, new DateTime(2024, 6, 21, 11, 30, 15, 699, DateTimeKind.Local).AddTicks(3447), "AdminLast2", new DateTime(2024, 6, 21, 4, 30, 15, 699, DateTimeKind.Utc).AddTicks(3448), "HN", true, null, "ADMIN2@GMAIL.COM", "ADMIN2", "AQAAAAIAAYagAAAAEMkeIHmevnOM2KAxnKx+wxE1WZZ+MTCynCpsZ7qGdkumaUOyK/Gd02z1m/Z6PaLofw==", null, false, "1ae30c4f-3699-4ceb-9bb9-f384e3a6a9d2", "SD0002", false, "admin2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("073f88cc-3f6d-48e6-bdca-4c3f972ffcfd"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0a365594-90f6-4e14-a2bb-6a267c62f1af"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("13643308-7f88-4caf-a83e-3c7ba53685a0"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f62e3ba-7b67-4bb5-9990-8ae88fe7412f"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f99777e-749c-4608-a76b-5b8b07f4c855"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("21058f97-dbbf-479a-a7ce-864fc5121638"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23c25cc5-d6b2-4208-bc8f-a7e153798bbf"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("24e0b413-4ccf-41be-ab27-7c18c7678d93"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("25b9a0d1-1b61-4597-b9b7-42ed331d6498"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2e7c830c-aff0-4f7f-93a2-627b45f23371"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("30b3d356-fb3f-4957-ab96-bfb83153c289"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3bb4080b-c5f2-41af-8111-05173653de3d"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("46247145-edcd-46e8-b0e1-13574884ca6a"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49b0e3de-468e-4e65-96b9-ef9f2b3a7a9d"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("523b214c-6eac-42f1-96b2-cc1fca0ad2ec"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("61385cbf-0859-4731-95bf-0bf1d95425e2"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("69dece1f-5a5d-43d5-b29b-a8948f9b1ca9"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6f622bb4-3174-4df3-83ad-4f6f0e012517"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("87badc17-7c6a-4caf-b58c-1713fb091128"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8fe1fcfe-637f-4102-8d19-bba13343e367"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("94814fe8-b396-4bb5-9f64-e9d91407c831"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9f1f22e3-c832-46cf-8313-b814475bc0be"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a0250c52-87ef-418d-b625-515c3bc0a6bd"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a4fba5a1-0e66-41be-bc1a-a6c1049065cb"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("aa37189b-926e-4bb8-ae78-5e41e8a16964"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ad9c337a-bb6b-4949-b796-14620afd0f08"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("af1763bc-7bee-4d7d-aa72-d05ede7df398"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("bafc9d75-79bd-4608-abca-7e9931a0d7d4"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bcf2971d-119a-4874-a1e7-911c13bf5eb4"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c0104960-8451-40a9-8331-f0009fb50ee6"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c5408ed6-6101-4b04-8f5b-67d5d57ef7a1"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc898763-41d5-48f1-ac48-693d57837125"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cf3d6527-4bb9-4329-ba81-ee2ee488debc"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d4dd55be-9b27-4af1-8b55-4edb19be88a9"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("dcd50553-c31f-4d55-ae06-c6cfb8c98101"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e11eb642-3086-4b6f-9ef0-d10460968dd5"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e8cd88d7-cdd5-4dd5-8fdf-bc184450ec7b"), "UserRole" },
                    { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("fc4e8cc0-be4a-4540-b4d9-c84ddc307c99"), "UserRole" },
                    { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fe4d7e10-e60c-445a-8c6c-a00edc97e42f"), "UserRole" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("073f88cc-3f6d-48e6-bdca-4c3f972ffcfd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("0a365594-90f6-4e14-a2bb-6a267c62f1af") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("13643308-7f88-4caf-a83e-3c7ba53685a0") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f62e3ba-7b67-4bb5-9990-8ae88fe7412f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("1f99777e-749c-4608-a76b-5b8b07f4c855") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("21058f97-dbbf-479a-a7ce-864fc5121638") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("23c25cc5-d6b2-4208-bc8f-a7e153798bbf") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("24e0b413-4ccf-41be-ab27-7c18c7678d93") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("25b9a0d1-1b61-4597-b9b7-42ed331d6498") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("2e7c830c-aff0-4f7f-93a2-627b45f23371") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("30b3d356-fb3f-4957-ab96-bfb83153c289") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("3bb4080b-c5f2-41af-8111-05173653de3d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("46247145-edcd-46e8-b0e1-13574884ca6a") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("49b0e3de-468e-4e65-96b9-ef9f2b3a7a9d") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("523b214c-6eac-42f1-96b2-cc1fca0ad2ec") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("61385cbf-0859-4731-95bf-0bf1d95425e2") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("69dece1f-5a5d-43d5-b29b-a8948f9b1ca9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("6f622bb4-3174-4df3-83ad-4f6f0e012517") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("87badc17-7c6a-4caf-b58c-1713fb091128") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("8fe1fcfe-637f-4102-8d19-bba13343e367") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("94814fe8-b396-4bb5-9f64-e9d91407c831") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("9f1f22e3-c832-46cf-8313-b814475bc0be") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a0250c52-87ef-418d-b625-515c3bc0a6bd") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("a4fba5a1-0e66-41be-bc1a-a6c1049065cb") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("aa37189b-926e-4bb8-ae78-5e41e8a16964") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("ad9c337a-bb6b-4949-b796-14620afd0f08") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("af1763bc-7bee-4d7d-aa72-d05ede7df398") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("bafc9d75-79bd-4608-abca-7e9931a0d7d4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("bcf2971d-119a-4874-a1e7-911c13bf5eb4") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("c0104960-8451-40a9-8331-f0009fb50ee6") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("c5408ed6-6101-4b04-8f5b-67d5d57ef7a1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cc898763-41d5-48f1-ac48-693d57837125") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("cf3d6527-4bb9-4329-ba81-ee2ee488debc") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("d4dd55be-9b27-4af1-8b55-4edb19be88a9") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("dcd50553-c31f-4d55-ae06-c6cfb8c98101") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("e11eb642-3086-4b6f-9ef0-d10460968dd5") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("e8cd88d7-cdd5-4dd5-8fdf-bc184450ec7b") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("5fc71af5-0216-402b-a5cb-ba17701e2fa3"), new Guid("fc4e8cc0-be4a-4540-b4d9-c84ddc307c99") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8bbf66a4-da08-4b87-bdb2-1502e38562f3"), new Guid("fe4d7e10-e60c-445a-8c6c-a00edc97e42f") });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("073f88cc-3f6d-48e6-bdca-4c3f972ffcfd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0a365594-90f6-4e14-a2bb-6a267c62f1af"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("13643308-7f88-4caf-a83e-3c7ba53685a0"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1f62e3ba-7b67-4bb5-9990-8ae88fe7412f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1f99777e-749c-4608-a76b-5b8b07f4c855"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("21058f97-dbbf-479a-a7ce-864fc5121638"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23c25cc5-d6b2-4208-bc8f-a7e153798bbf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24e0b413-4ccf-41be-ab27-7c18c7678d93"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("25b9a0d1-1b61-4597-b9b7-42ed331d6498"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2e7c830c-aff0-4f7f-93a2-627b45f23371"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("30b3d356-fb3f-4957-ab96-bfb83153c289"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3bb4080b-c5f2-41af-8111-05173653de3d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("46247145-edcd-46e8-b0e1-13574884ca6a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("49b0e3de-468e-4e65-96b9-ef9f2b3a7a9d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("523b214c-6eac-42f1-96b2-cc1fca0ad2ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("61385cbf-0859-4731-95bf-0bf1d95425e2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("69dece1f-5a5d-43d5-b29b-a8948f9b1ca9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("6f622bb4-3174-4df3-83ad-4f6f0e012517"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("87badc17-7c6a-4caf-b58c-1713fb091128"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8fe1fcfe-637f-4102-8d19-bba13343e367"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("94814fe8-b396-4bb5-9f64-e9d91407c831"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9f1f22e3-c832-46cf-8313-b814475bc0be"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a0250c52-87ef-418d-b625-515c3bc0a6bd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a4fba5a1-0e66-41be-bc1a-a6c1049065cb"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("aa37189b-926e-4bb8-ae78-5e41e8a16964"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ad9c337a-bb6b-4949-b796-14620afd0f08"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("af1763bc-7bee-4d7d-aa72-d05ede7df398"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bafc9d75-79bd-4608-abca-7e9931a0d7d4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcf2971d-119a-4874-a1e7-911c13bf5eb4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c0104960-8451-40a9-8331-f0009fb50ee6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c5408ed6-6101-4b04-8f5b-67d5d57ef7a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cc898763-41d5-48f1-ac48-693d57837125"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf3d6527-4bb9-4329-ba81-ee2ee488debc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d4dd55be-9b27-4af1-8b55-4edb19be88a9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("dcd50553-c31f-4d55-ae06-c6cfb8c98101"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e11eb642-3086-4b6f-9ef0-d10460968dd5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e8cd88d7-cdd5-4dd5-8fdf-bc184450ec7b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc4e8cc0-be4a-4540-b4d9-c84ddc307c99"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("fe4d7e10-e60c-445a-8c6c-a00edc97e42f"));
        }
    }
}
