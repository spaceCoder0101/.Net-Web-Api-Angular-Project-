﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentsDetail",
                columns: table => new
                {
                    PaymentDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardOwner = table.Column<string>(type: "nvarchar(16)", nullable: true),
                    ExpirationDate = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    SecurityCode = table.Column<string>(type: "nvarchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentsDetail", x => x.PaymentDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentsDetail");
        }
    }
}
