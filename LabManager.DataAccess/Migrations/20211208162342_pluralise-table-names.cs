using Microsoft.EntityFrameworkCore.Migrations;

namespace LabManager.DataAccess.Migrations
{
    public partial class pluralisetablenames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Client_ClientId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientClientCategory_Client_ClientsId",
                table: "ClientClientCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactNumber_ContactPerson_ContactPersonId",
                table: "ContactNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactNumber_ContactType_ContactTypeId",
                table: "ContactNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPerson_Address_AddressId",
                table: "ContactPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPerson_Email_EmailId",
                table: "ContactPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_UpdateType_UpdateTypeId",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactType",
                table: "ContactType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPerson",
                table: "ContactPerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactNumber",
                table: "ContactNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "Emails");

            migrationBuilder.RenameTable(
                name: "ContactType",
                newName: "ContactTypes");

            migrationBuilder.RenameTable(
                name: "ContactPerson",
                newName: "ContactPeople");

            migrationBuilder.RenameTable(
                name: "ContactNumber",
                newName: "ContactNumbers");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_Email_UpdateTypeId",
                table: "Emails",
                newName: "IX_Emails_UpdateTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactPerson_EmailId",
                table: "ContactPeople",
                newName: "IX_ContactPeople_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactPerson_AddressId",
                table: "ContactPeople",
                newName: "IX_ContactPeople_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNumber_ContactTypeId",
                table: "ContactNumbers",
                newName: "IX_ContactNumbers_ContactTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNumber_ContactPersonId",
                table: "ContactNumbers",
                newName: "IX_ContactNumbers_ContactPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_ClientId",
                table: "Addresses",
                newName: "IX_Addresses_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactTypes",
                table: "ContactTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPeople",
                table: "ContactPeople",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactNumbers",
                table: "ContactNumbers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Clients_ClientId",
                table: "Addresses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClientCategory_Clients_ClientsId",
                table: "ClientClientCategory",
                column: "ClientsId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNumbers_ContactPeople_ContactPersonId",
                table: "ContactNumbers",
                column: "ContactPersonId",
                principalTable: "ContactPeople",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNumbers_ContactTypes_ContactTypeId",
                table: "ContactNumbers",
                column: "ContactTypeId",
                principalTable: "ContactTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPeople_Addresses_AddressId",
                table: "ContactPeople",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPeople_Emails_EmailId",
                table: "ContactPeople",
                column: "EmailId",
                principalTable: "Emails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_UpdateType_UpdateTypeId",
                table: "Emails",
                column: "UpdateTypeId",
                principalTable: "UpdateType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Clients_ClientId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientClientCategory_Clients_ClientsId",
                table: "ClientClientCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactNumbers_ContactPeople_ContactPersonId",
                table: "ContactNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactNumbers_ContactTypes_ContactTypeId",
                table: "ContactNumbers");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPeople_Addresses_AddressId",
                table: "ContactPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPeople_Emails_EmailId",
                table: "ContactPeople");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_UpdateType_UpdateTypeId",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactTypes",
                table: "ContactTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPeople",
                table: "ContactPeople");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactNumbers",
                table: "ContactNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "Email");

            migrationBuilder.RenameTable(
                name: "ContactTypes",
                newName: "ContactType");

            migrationBuilder.RenameTable(
                name: "ContactPeople",
                newName: "ContactPerson");

            migrationBuilder.RenameTable(
                name: "ContactNumbers",
                newName: "ContactNumber");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_UpdateTypeId",
                table: "Email",
                newName: "IX_Email_UpdateTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactPeople_EmailId",
                table: "ContactPerson",
                newName: "IX_ContactPerson_EmailId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactPeople_AddressId",
                table: "ContactPerson",
                newName: "IX_ContactPerson_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNumbers_ContactTypeId",
                table: "ContactNumber",
                newName: "IX_ContactNumber_ContactTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactNumbers_ContactPersonId",
                table: "ContactNumber",
                newName: "IX_ContactNumber_ContactPersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_ClientId",
                table: "Address",
                newName: "IX_Address_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactType",
                table: "ContactType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPerson",
                table: "ContactPerson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactNumber",
                table: "ContactNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Client_ClientId",
                table: "Address",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientClientCategory_Client_ClientsId",
                table: "ClientClientCategory",
                column: "ClientsId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNumber_ContactPerson_ContactPersonId",
                table: "ContactNumber",
                column: "ContactPersonId",
                principalTable: "ContactPerson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactNumber_ContactType_ContactTypeId",
                table: "ContactNumber",
                column: "ContactTypeId",
                principalTable: "ContactType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPerson_Address_AddressId",
                table: "ContactPerson",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPerson_Email_EmailId",
                table: "ContactPerson",
                column: "EmailId",
                principalTable: "Email",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_UpdateType_UpdateTypeId",
                table: "Email",
                column: "UpdateTypeId",
                principalTable: "UpdateType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
