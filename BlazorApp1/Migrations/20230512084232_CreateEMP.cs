using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations
{
    /// <inheritdoc />
    public partial class CreateEMP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    cust_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cust_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cust_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cust_postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cust_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cust_fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cust_email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.cust_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
