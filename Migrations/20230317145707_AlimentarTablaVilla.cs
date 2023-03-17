using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_Api.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenida", "Detalle", "FechaActualizacion", "FechaCreacion", "ImageUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2023, 3, 17, 9, 57, 7, 13, DateTimeKind.Local).AddTicks(6498), new DateTime(2023, 3, 17, 9, 57, 7, 13, DateTimeKind.Local).AddTicks(6485), "", 50, "Villa real", 5, 200100.0 },
                    { 2, "", "Detalle de la villa", new DateTime(2023, 3, 17, 9, 57, 7, 13, DateTimeKind.Local).AddTicks(6501), new DateTime(2023, 3, 17, 9, 57, 7, 13, DateTimeKind.Local).AddTicks(6501), "", 60, "Villa premiun vista a la playa", 4, 500000.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
