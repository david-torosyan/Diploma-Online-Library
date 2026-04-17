using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class MassangerCommit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conversations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    IsGroup = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "text", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "timestamptz", nullable: false),
                    LastMessageAtUtc = table.Column<DateTime>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_conversations_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "chat_messages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConversationId = table.Column<Guid>(type: "uuid", nullable: false),
                    SenderUserId = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    SentAtUtc = table.Column<DateTime>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chat_messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chat_messages_AspNetUsers_SenderUserId",
                        column: x => x.SenderUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_chat_messages_conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "conversation_participants",
                columns: table => new
                {
                    ConversationId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "text", nullable: false),
                    JoinedAtUtc = table.Column<DateTime>(type: "timestamptz", nullable: false),
                    LastReadAtUtc = table.Column<DateTime>(type: "timestamptz", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conversation_participants", x => new { x.ConversationId, x.ApplicationUserId });
                    table.ForeignKey(
                        name: "FK_conversation_participants_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_conversation_participants_conversations_ConversationId",
                        column: x => x.ConversationId,
                        principalTable: "conversations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_chat_messages_ConversationId_SentAtUtc",
                table: "chat_messages",
                columns: new[] { "ConversationId", "SentAtUtc" });

            migrationBuilder.CreateIndex(
                name: "IX_chat_messages_SenderUserId",
                table: "chat_messages",
                column: "SenderUserId");

            migrationBuilder.CreateIndex(
                name: "IX_conversation_participants_ApplicationUserId",
                table: "conversation_participants",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_conversations_CreatedByUserId",
                table: "conversations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_conversations_LastMessageAtUtc",
                table: "conversations",
                column: "LastMessageAtUtc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chat_messages");

            migrationBuilder.DropTable(
                name: "conversation_participants");

            migrationBuilder.DropTable(
                name: "conversations");
        }
    }
}
