using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _7keyz.Migrations
{
    /// <inheritdoc />
    public partial class AddingReference : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatsUsers_Chats_ChatsId",
                table: "ChatsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatsUsers_Users_UsersId",
                table: "ChatsUsers");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "ChatsUsers",
                newName: "usersId");

            migrationBuilder.RenameColumn(
                name: "ChatsId",
                table: "ChatsUsers",
                newName: "chatsId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatsUsers_UsersId",
                table: "ChatsUsers",
                newName: "IX_ChatsUsers_usersId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatsUsers_ChatsId",
                table: "ChatsUsers",
                newName: "IX_ChatsUsers_chatsId");

            migrationBuilder.AlterColumn<int>(
                name: "usersId",
                table: "ChatsUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "chatsId",
                table: "ChatsUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatsUsers_Chats_chatsId",
                table: "ChatsUsers",
                column: "chatsId",
                principalTable: "Chats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChatsUsers_Users_usersId",
                table: "ChatsUsers",
                column: "usersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatsUsers_Chats_chatsId",
                table: "ChatsUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ChatsUsers_Users_usersId",
                table: "ChatsUsers");

            migrationBuilder.RenameColumn(
                name: "usersId",
                table: "ChatsUsers",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "chatsId",
                table: "ChatsUsers",
                newName: "ChatsId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatsUsers_usersId",
                table: "ChatsUsers",
                newName: "IX_ChatsUsers_UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_ChatsUsers_chatsId",
                table: "ChatsUsers",
                newName: "IX_ChatsUsers_ChatsId");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "ChatsUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ChatsId",
                table: "ChatsUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatsUsers_Chats_ChatsId",
                table: "ChatsUsers",
                column: "ChatsId",
                principalTable: "Chats",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatsUsers_Users_UsersId",
                table: "ChatsUsers",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
