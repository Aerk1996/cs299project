using Microsoft.EntityFrameworkCore.Migrations;

namespace employeeABBeducation.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(50)",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeSurname",
                table: "Employees",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeName",
                table: "Employees",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeSurname",
                table: "Employees",
                type: "nvarchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "nvarchar(50)",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");
        }
    }
}
