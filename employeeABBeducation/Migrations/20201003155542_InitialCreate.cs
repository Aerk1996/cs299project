using Microsoft.EntityFrameworkCore.Migrations;

namespace employeeABBeducation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar50 = table.Column<string>(name: "nvarchar(50)", nullable: false),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EmployeeDaireBaskanligi = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    EmployeeJob = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
