using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialNetworkSignalR_3_22_10.Migrations
{
    /// <inheritdoc />
    public partial class IsFriendAndRequestPending : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasRequestPending",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsFriend",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasRequestPending",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsFriend",
                table: "AspNetUsers");
        }
    }
}
