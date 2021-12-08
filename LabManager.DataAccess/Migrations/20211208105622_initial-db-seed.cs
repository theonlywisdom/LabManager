using Microsoft.EntityFrameworkCore.Migrations;

namespace LabManager.DataAccess.Migrations
{
    public partial class initialdbseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UpdateType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpdateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Line_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientClientCategory",
                columns: table => new
                {
                    ClientCategoriesId = table.Column<int>(type: "int", nullable: false),
                    ClientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientClientCategory", x => new { x.ClientCategoriesId, x.ClientsId });
                    table.ForeignKey(
                        name: "FK_ClientClientCategory_Client_ClientsId",
                        column: x => x.ClientsId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientClientCategory_ClientCategory_ClientCategoriesId",
                        column: x => x.ClientCategoriesId,
                        principalTable: "ClientCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Email_UpdateType_UpdateTypeId",
                        column: x => x.UpdateTypeId,
                        principalTable: "UpdateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    EmailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactPerson_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactPerson_Email_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Email",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContactNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonId = table.Column<int>(type: "int", nullable: false),
                    ContactTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactNumber_ContactPerson_ContactPersonId",
                        column: x => x.ContactPersonId,
                        principalTable: "ContactPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContactNumber_ContactType_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "ContactType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Client",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "MHVAP", "Mowi Consumer Products UK Limited" },
                    { 2, "GDC", "Grahams Dairy" },
                    { 3, "LAKE01", "The Lakes Free Range Egg  Company" }
                });

            migrationBuilder.InsertData(
                table: "ClientCategory",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "RSA" },
                    { 2, "CSPO" }
                });

            migrationBuilder.InsertData(
                table: "ContactType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Mobile" },
                    { 2, "Telephone" }
                });

            migrationBuilder.InsertData(
                table: "Email",
                columns: new[] { "Id", "ContactEmail", "UpdateTypeId" },
                values: new object[,]
                {
                    { 1, "Sandy.fong@mowi.com", null },
                    { 2, "bryan.donald@mowi.com", null },
                    { 3, "lucyt@lakesfreerange.co.uk", null }
                });

            migrationBuilder.InsertData(
                table: "UpdateType",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Test Reports" },
                    { 2, "Flagged Reports" },
                    { 3, "Excel Updates" },
                    { 4, "Gateway Updates" },
                    { 5, "Invoices" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AddressType", "ClientId", "Line_1", "Line_2", "Line_3", "PostCode" },
                values: new object[,]
                {
                    { 1, "Main", 1, "Admirality Park", "Admirality Road", "Rosyth", "KY11 2YW" },
                    { 3, "Main", 3, "Meg Bank", "Stainton,Penrith", "Cumbria", "CA11 0EE" }
                });

            migrationBuilder.InsertData(
                table: "ClientClientCategory",
                columns: new[] { "ClientCategoriesId", "ClientsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "ContactPerson",
                columns: new[] { "Id", "AddressId", "EmailId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 1, 1, 1, "Sandy", "Micro and Taste Panel Technician", "Fong" });

            migrationBuilder.InsertData(
                table: "ContactPerson",
                columns: new[] { "Id", "AddressId", "EmailId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 2, 1, 2, "Bryan", "Food Safety Manager", "Donald" });

            migrationBuilder.InsertData(
                table: "ContactPerson",
                columns: new[] { "Id", "AddressId", "EmailId", "FirstName", "JobTitle", "LastName" },
                values: new object[] { 3, 3, 3, "Lucy", "N/A", "Templeton" });

            migrationBuilder.InsertData(
                table: "ContactNumber",
                columns: new[] { "Id", "ContactPersonId", "ContactTypeId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, "07788925371" },
                    { 2, 2, 1, "07929181960" },
                    { 3, 2, 2, "01383221194" },
                    { 4, 3, 1, "07984590402" },
                    { 5, 3, 2, "01768890460" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Address_ClientId",
                table: "Address",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientClientCategory_ClientsId",
                table: "ClientClientCategory",
                column: "ClientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactNumber_ContactPersonId",
                table: "ContactNumber",
                column: "ContactPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactNumber_ContactTypeId",
                table: "ContactNumber",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_AddressId",
                table: "ContactPerson",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPerson_EmailId",
                table: "ContactPerson",
                column: "EmailId");

            migrationBuilder.CreateIndex(
                name: "IX_Email_UpdateTypeId",
                table: "Email",
                column: "UpdateTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientClientCategory");

            migrationBuilder.DropTable(
                name: "ContactNumber");

            migrationBuilder.DropTable(
                name: "ClientCategory");

            migrationBuilder.DropTable(
                name: "ContactPerson");

            migrationBuilder.DropTable(
                name: "ContactType");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "UpdateType");
        }
    }
}
