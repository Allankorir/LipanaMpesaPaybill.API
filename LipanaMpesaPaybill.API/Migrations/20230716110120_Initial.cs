using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LipanaMpesaPaybill.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TransTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransAmount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillRefNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgAccountBalance = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThirdPartyTransID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MSISDN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_TransID",
                table: "Transactions",
                column: "TransID",
                unique: true,
                filter: "[TransID] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
