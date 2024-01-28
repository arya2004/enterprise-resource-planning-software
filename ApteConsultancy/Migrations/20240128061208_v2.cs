using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associate_Fees_AssociateUser_AssociateId",
                table: "Associate_Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_AssociateWorkerOrders_AssociateUser_AssociateUserId",
                table: "AssociateWorkerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Drawings_EmployeeUser_EmployeeId",
                table: "Drawings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTimeSheets_EmployeeUser_EmployeeId",
                table: "EmployeeTimeSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnCarLocalAndOutStations_EmployeeUser_EmployeeId",
                table: "OwnCarLocalAndOutStations");

            migrationBuilder.DropTable(
                name: "AssociateUser");

            migrationBuilder.DropTable(
                name: "EmployeeUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Associate_Fees_AspNetUsers_AssociateId",
                table: "Associate_Fees",
                column: "AssociateId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssociateWorkerOrders_AspNetUsers_AssociateUserId",
                table: "AssociateWorkerOrders",
                column: "AssociateUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawings_AspNetUsers_EmployeeId",
                table: "Drawings",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTimeSheets_AspNetUsers_EmployeeId",
                table: "EmployeeTimeSheets",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnCarLocalAndOutStations_AspNetUsers_EmployeeId",
                table: "OwnCarLocalAndOutStations",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associate_Fees_AspNetUsers_AssociateId",
                table: "Associate_Fees");

            migrationBuilder.DropForeignKey(
                name: "FK_AssociateWorkerOrders_AspNetUsers_AssociateUserId",
                table: "AssociateWorkerOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Drawings_AspNetUsers_EmployeeId",
                table: "Drawings");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTimeSheets_AspNetUsers_EmployeeId",
                table: "EmployeeTimeSheets");

            migrationBuilder.DropForeignKey(
                name: "FK_OwnCarLocalAndOutStations_AspNetUsers_EmployeeId",
                table: "OwnCarLocalAndOutStations");

            migrationBuilder.CreateTable(
                name: "AssociateUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISFCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFreeLancer = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociateUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anniversary = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchNam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpBeforeJoiningM = table.Column<int>(type: "int", nullable: false),
                    ExpBeforeJoiningY = table.Column<int>(type: "int", nullable: false),
                    ISFCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    MonthlySalary = table.Column<int>(type: "int", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Relation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUser", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Associate_Fees_AssociateUser_AssociateId",
                table: "Associate_Fees",
                column: "AssociateId",
                principalTable: "AssociateUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AssociateWorkerOrders_AssociateUser_AssociateUserId",
                table: "AssociateWorkerOrders",
                column: "AssociateUserId",
                principalTable: "AssociateUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Drawings_EmployeeUser_EmployeeId",
                table: "Drawings",
                column: "EmployeeId",
                principalTable: "EmployeeUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTimeSheets_EmployeeUser_EmployeeId",
                table: "EmployeeTimeSheets",
                column: "EmployeeId",
                principalTable: "EmployeeUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OwnCarLocalAndOutStations_EmployeeUser_EmployeeId",
                table: "OwnCarLocalAndOutStations",
                column: "EmployeeId",
                principalTable: "EmployeeUser",
                principalColumn: "Id");
        }
    }
}
