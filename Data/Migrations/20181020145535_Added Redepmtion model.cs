using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ExxonRedeemtion.Data.Migrations
{
    public partial class AddedRedepmtionmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RedemptionId",
                table: "Coupons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Redemptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    CouponPrice = table.Column<int>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    RetrieveDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redemptions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_RedemptionId",
                table: "Coupons",
                column: "RedemptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Redemptions_RedemptionId",
                table: "Coupons",
                column: "RedemptionId",
                principalTable: "Redemptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coupons_Redemptions_RedemptionId",
                table: "Coupons");

            migrationBuilder.DropTable(
                name: "Redemptions");

            migrationBuilder.DropIndex(
                name: "IX_Coupons_RedemptionId",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "RedemptionId",
                table: "Coupons");
        }
    }
}
