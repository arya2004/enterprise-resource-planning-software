using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.Migrations
{
    /// <inheritdoc />
    public partial class qwerty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Architects",
                columns: table => new
                {
                    ArchitectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Architects", x => x.ArchitectId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsAssociate = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpBeforeJoiningY = table.Column<int>(type: "int", nullable: false),
                    ExpBeforeJoiningM = table.Column<int>(type: "int", nullable: false),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Anniversary = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlySalary = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsFreeLancer = table.Column<bool>(type: "bit", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    ISFCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssociateUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    ISFCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    IsFreeLancer = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociateUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GstNUmber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DirectorEmployeeCode = table.Column<int>(type: "int", nullable: false),
                    DirectorMobile = table.Column<int>(type: "int", nullable: false),
                    LandLine = table.Column<int>(type: "int", nullable: false),
                    DirectorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    PanNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    ContactPerson1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber1 = table.Column<int>(type: "int", nullable: false),
                    ContactPerson2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber2 = table.Column<int>(type: "int", nullable: false),
                    ExpBeforeJoiningY = table.Column<int>(type: "int", nullable: false),
                    ExpBeforeJoiningM = table.Column<int>(type: "int", nullable: false),
                    Pan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Anniversary = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchNam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountNumber = table.Column<int>(type: "int", nullable: false),
                    ISFCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MonthlySalary = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Associate_Fees",
                columns: table => new
                {
                    Associate_FeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssociateId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Project_Fee = table.Column<double>(type: "float", nullable: false),
                    Transaction_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Transaction_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TDSAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associate_Fees", x => x.Associate_FeeId);
                    table.ForeignKey(
                        name: "FK_Associate_Fees_AssociateUser_AssociateId",
                        column: x => x.AssociateId,
                        principalTable: "AssociateUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ArchitectId = table.Column<int>(type: "int", nullable: true),
                    ProjectCode = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientWoNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjecLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalFees = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FeesReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FeesBalance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Expenses = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ProfitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Projects_Architects_ArchitectId",
                        column: x => x.ArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchitectId");
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Projects_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "Employee_Attendances",
                columns: table => new
                {
                    Employee_AttendanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Attendance_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Attendances", x => x.Employee_AttendanceId);
                    table.ForeignKey(
                        name: "FK_Employee_Attendances_EmployeeUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserProject",
                columns: table => new
                {
                    ApplicationUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectsProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserProject", x => new { x.ApplicationUsersId, x.ProjectsProjectId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_AspNetUsers_ApplicationUsersId",
                        column: x => x.ApplicationUsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserProject_Projects_ProjectsProjectId",
                        column: x => x.ProjectsProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssociateWorkerOrders",
                columns: table => new
                {
                    AssociateWorkerOrdersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    AssociateUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WorkOrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WoAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WoDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WoStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssociateWorkerOrders", x => x.AssociateWorkerOrdersId);
                    table.ForeignKey(
                        name: "FK_AssociateWorkerOrders_AssociateUser_AssociateUserId",
                        column: x => x.AssociateUserId,
                        principalTable: "AssociateUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssociateWorkerOrders_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "Drawings",
                columns: table => new
                {
                    DrawingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    ArchitectId = table.Column<int>(type: "int", nullable: true),
                    DrawingNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drawings", x => x.DrawingId);
                    table.ForeignKey(
                        name: "FK_Drawings_Architects_ArchitectId",
                        column: x => x.ArchitectId,
                        principalTable: "Architects",
                        principalColumn: "ArchitectId");
                    table.ForeignKey(
                        name: "FK_Drawings_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientId");
                    table.ForeignKey(
                        name: "FK_Drawings_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_Drawings_EmployeeUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Drawings_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTimeSheets",
                columns: table => new
                {
                    EmployeeTimeSheetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoursSpent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RatePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTimeSheets", x => x.EmployeeTimeSheetId);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeSheets_EmployeeUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_EmployeeTimeSheets_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "GSTInvoices",
                columns: table => new
                {
                    GSTInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GSTInvoices", x => x.GSTInvoiceId);
                    table.ForeignKey(
                        name: "FK_GSTInvoices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OwnCarLocalAndOutStations",
                columns: table => new
                {
                    OwnCarLocalAndOutStationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PetrolRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarAvgKMPL = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DistanceTravelled = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostOfTravel = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PublicTransport = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    DrawingPrints = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Courier = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Toll = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnCarLocalAndOutStations", x => x.OwnCarLocalAndOutStationId);
                    table.ForeignKey(
                        name: "FK_OwnCarLocalAndOutStations_EmployeeUser_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeUser",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OwnCarLocalAndOutStations_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "ProformaInvoices",
                columns: table => new
                {
                    ProformaInvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    GST_Invoice_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GST_Invoice_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GST_Invoice_Number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProformaInvoices", x => x.ProformaInvoiceId);
                    table.ForeignKey(
                        name: "FK_ProformaInvoices_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectFees",
                columns: table => new
                {
                    ProjectFeesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    TRXDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TRXno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TDSAmount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectFees", x => x.ProjectFeesId);
                    table.ForeignKey(
                        name: "FK_ProjectFees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectId");
                });

            migrationBuilder.CreateTable(
                name: "DrawingRevisions",
                columns: table => new
                {
                    DrawingRevisionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RevisionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DrawingId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawingRevisions", x => x.DrawingRevisionId);
                    table.ForeignKey(
                        name: "FK_DrawingRevisions_Drawings_DrawingId",
                        column: x => x.DrawingId,
                        principalTable: "Drawings",
                        principalColumn: "DrawingId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserProject_ProjectsProjectId",
                table: "ApplicationUserProject",
                column: "ProjectsProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Associate_Fees_AssociateId",
                table: "Associate_Fees",
                column: "AssociateId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociateWorkerOrders_AssociateUserId",
                table: "AssociateWorkerOrders",
                column: "AssociateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AssociateWorkerOrders_ProjectId",
                table: "AssociateWorkerOrders",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_DrawingRevisions_DrawingId",
                table: "DrawingRevisions",
                column: "DrawingId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ArchitectId",
                table: "Drawings",
                column: "ArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ClientId",
                table: "Drawings",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_CompanyId",
                table: "Drawings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_EmployeeId",
                table: "Drawings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Drawings_ProjectId",
                table: "Drawings",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Attendances_EmployeeId",
                table: "Employee_Attendances",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeSheets_EmployeeId",
                table: "EmployeeTimeSheets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeSheets_ProjectId",
                table: "EmployeeTimeSheets",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_GSTInvoices_ProjectId",
                table: "GSTInvoices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnCarLocalAndOutStations_EmployeeId",
                table: "OwnCarLocalAndOutStations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_OwnCarLocalAndOutStations_ProjectId",
                table: "OwnCarLocalAndOutStations",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProformaInvoices_ProjectId",
                table: "ProformaInvoices",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectFees_ProjectId",
                table: "ProjectFees",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ArchitectId",
                table: "Projects",
                column: "ArchitectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CompanyId",
                table: "Projects",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserProject");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Associate_Fees");

            migrationBuilder.DropTable(
                name: "AssociateWorkerOrders");

            migrationBuilder.DropTable(
                name: "DrawingRevisions");

            migrationBuilder.DropTable(
                name: "Employee_Attendances");

            migrationBuilder.DropTable(
                name: "EmployeeTimeSheets");

            migrationBuilder.DropTable(
                name: "GSTInvoices");

            migrationBuilder.DropTable(
                name: "OwnCarLocalAndOutStations");

            migrationBuilder.DropTable(
                name: "ProformaInvoices");

            migrationBuilder.DropTable(
                name: "ProjectFees");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AssociateUser");

            migrationBuilder.DropTable(
                name: "Drawings");

            migrationBuilder.DropTable(
                name: "EmployeeUser");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Architects");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
