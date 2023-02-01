using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Qinchili.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddDeleteTimestampToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTimeStamp",
                table: "Products",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTimeStamp",
                table: "Products");
        }
    }
}
