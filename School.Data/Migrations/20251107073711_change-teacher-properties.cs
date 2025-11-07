using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeteacherproperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "teachers",
                newName: "LastName");

            migrationBuilder.AlterColumn<double>(
                name: "Hours",
                table: "teachers",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "teachers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "teachers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "teachers",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "Hours",
                table: "teachers",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
