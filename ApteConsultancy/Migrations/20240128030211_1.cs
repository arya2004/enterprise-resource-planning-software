using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApteConsultancy.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Attendances_EmployeeUser_EmployeeId",
                table: "Employee_Attendances");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Employee_Attendances",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Attendances_AspNetUsers_EmployeeId",
                table: "Employee_Attendances",
                column: "EmployeeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Attendances_AspNetUsers_EmployeeId",
                table: "Employee_Attendances");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Employee_Attendances",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Attendances_EmployeeUser_EmployeeId",
                table: "Employee_Attendances",
                column: "EmployeeId",
                principalTable: "EmployeeUser",
                principalColumn: "Id");
        }
    }
}
