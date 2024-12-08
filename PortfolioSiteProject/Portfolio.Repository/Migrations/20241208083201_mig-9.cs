using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Repository.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "UserInfos");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "SocialLinks");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ImageData",
                table: "HeroSections");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "UserInfos",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "SocialLinks",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "Skills",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "Projects",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ImageMimeType",
                table: "HeroSections",
                newName: "ImageUrl");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Experiences",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Experiences");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "UserInfos",
                newName: "ImageMimeType");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "SocialLinks",
                newName: "ImageMimeType");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Skills",
                newName: "ImageMimeType");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Projects",
                newName: "ImageMimeType");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "HeroSections",
                newName: "ImageMimeType");

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "UserInfos",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "SocialLinks",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Skills",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "Projects",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ImageData",
                table: "HeroSections",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
