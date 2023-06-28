using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorCRUDEFCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Imagen",
                table: "Books",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Books");
        }
    }
}
