﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlmServer.Persistance.Migrations.CompanyDb
{
    /// <inheritdoc />
    public partial class mig002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "UniformChartOfAccount");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "UniformChartOfAccount",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
