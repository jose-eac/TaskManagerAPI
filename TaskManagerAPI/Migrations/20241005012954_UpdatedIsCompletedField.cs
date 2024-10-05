using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIsCompletedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "TaskItems",
                newName: "IsComplete");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsComplete",
                table: "TaskItems",
                newName: "IsCompleted");
        }
    }
}
