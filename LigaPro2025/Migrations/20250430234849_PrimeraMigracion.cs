using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LigaPro2025.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PartidosJugados = table.Column<int>(type: "int", nullable: false),
                    PartidosGanados = table.Column<int>(type: "int", nullable: false),
                    PartidosEmpatados = table.Column<int>(type: "int", nullable: false),
                    PartidosPerdidos = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: false),
                    NumeroCamiseta = table.Column<int>(type: "int", nullable: false),
                    Goles = table.Column<int>(type: "int", nullable: false),
                    Asistencias = table.Column<int>(type: "int", nullable: false),
                    Sueldo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    EsTitular = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Equipos_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Equipos",
                columns: new[] { "Id", "Logo", "Nombre", "PartidosEmpatados", "PartidosGanados", "PartidosJugados", "PartidosPerdidos", "Puntos" },
                values: new object[,]
                {
                    { 1, "aucas.png", "Aucas", 0, 0, 0, 0, 0 },
                    { 2, "bsc.png", "Barcelona SC", 0, 0, 0, 0, 0 },
                    { 3, "cato.png", "Catolica", 0, 0, 0, 0, 0 },
                    { 4, "delfin.png", "Delfín", 0, 0, 0, 0, 0 },
                    { 5, "cuenca.png", "Deportivo Cuenca", 0, 0, 0, 0, 0 },
                    { 6, "nacional.png", "El Nacional", 0, 0, 0, 0, 0 },
                    { 7, "emelec.png", "Emelec", 0, 0, 0, 0, 0 },
                    { 8, "manta.png", "Manta", 0, 0, 0, 0, 0 },
                    { 9, "idv.png", "Independiente del Valle", 0, 0, 0, 0, 0 },
                    { 10, "liga.png", "LDU Quito", 0, 0, 0, 0, 0 },
                    { 11, "macara.png", "Macará", 0, 0, 0, 0, 0 },
                    { 12, "runa.png", "Mushuc Runa", 0, 0, 0, 0, 0 },
                    { 13, "orense.png", "Orense SC", 0, 0, 0, 0, 0 },
                    { 14, "venecos.png", "Vinotinto", 0, 0, 0, 0, 0 },
                    { 15, "tecnico.png", "Técnico Universitario", 0, 0, 0, 0, 0 },
                    { 16, "liberdad.png", "Libertad", 0, 0, 0, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Jugadores",
                columns: new[] { "Id", "Asistencias", "Edad", "EquipoId", "EsTitular", "Goles", "Nombre", "Numero", "NumeroCamiseta", "Posicion", "Sueldo" },
                values: new object[,]
                {
                    { 101, 0, null, 1, true, 0, "Jugador 1 - Equipo 1", 0, 1, "Delantero", 1000m },
                    { 102, 0, null, 1, true, 0, "Jugador 2 - Equipo 1", 0, 2, "Delantero", 1000m },
                    { 103, 0, null, 1, true, 0, "Jugador 3 - Equipo 1", 0, 3, "Delantero", 1000m },
                    { 104, 0, null, 1, true, 0, "Jugador 4 - Equipo 1", 0, 4, "Delantero", 1000m },
                    { 105, 0, null, 1, true, 0, "Jugador 5 - Equipo 1", 0, 5, "Delantero", 1000m },
                    { 106, 0, null, 1, true, 0, "Jugador 6 - Equipo 1", 0, 6, "Delantero", 1000m },
                    { 107, 0, null, 1, true, 0, "Jugador 7 - Equipo 1", 0, 7, "Delantero", 1000m },
                    { 108, 0, null, 1, true, 0, "Jugador 8 - Equipo 1", 0, 8, "Delantero", 1000m },
                    { 109, 0, null, 1, true, 0, "Jugador 9 - Equipo 1", 0, 9, "Delantero", 1000m },
                    { 110, 0, null, 1, true, 0, "Jugador 10 - Equipo 1", 0, 10, "Delantero", 1000m },
                    { 111, 0, null, 1, true, 0, "Jugador 11 - Equipo 1", 0, 11, "Delantero", 1000m },
                    { 201, 0, null, 2, true, 0, "Jugador 1 - Equipo 2", 0, 1, "Delantero", 1000m },
                    { 202, 0, null, 2, true, 0, "Jugador 2 - Equipo 2", 0, 2, "Delantero", 1000m },
                    { 203, 0, null, 2, true, 0, "Jugador 3 - Equipo 2", 0, 3, "Delantero", 1000m },
                    { 204, 0, null, 2, true, 0, "Jugador 4 - Equipo 2", 0, 4, "Delantero", 1000m },
                    { 205, 0, null, 2, true, 0, "Jugador 5 - Equipo 2", 0, 5, "Delantero", 1000m },
                    { 206, 0, null, 2, true, 0, "Jugador 6 - Equipo 2", 0, 6, "Delantero", 1000m },
                    { 207, 0, null, 2, true, 0, "Jugador 7 - Equipo 2", 0, 7, "Delantero", 1000m },
                    { 208, 0, null, 2, true, 0, "Jugador 8 - Equipo 2", 0, 8, "Delantero", 1000m },
                    { 209, 0, null, 2, true, 0, "Jugador 9 - Equipo 2", 0, 9, "Delantero", 1000m },
                    { 210, 0, null, 2, true, 0, "Jugador 10 - Equipo 2", 0, 10, "Delantero", 1000m },
                    { 211, 0, null, 2, true, 0, "Jugador 11 - Equipo 2", 0, 11, "Delantero", 1000m },
                    { 301, 0, null, 3, true, 0, "Jugador 1 - Equipo 3", 0, 1, "Delantero", 1000m },
                    { 302, 0, null, 3, true, 0, "Jugador 2 - Equipo 3", 0, 2, "Delantero", 1000m },
                    { 303, 0, null, 3, true, 0, "Jugador 3 - Equipo 3", 0, 3, "Delantero", 1000m },
                    { 304, 0, null, 3, true, 0, "Jugador 4 - Equipo 3", 0, 4, "Delantero", 1000m },
                    { 305, 0, null, 3, true, 0, "Jugador 5 - Equipo 3", 0, 5, "Delantero", 1000m },
                    { 306, 0, null, 3, true, 0, "Jugador 6 - Equipo 3", 0, 6, "Delantero", 1000m },
                    { 307, 0, null, 3, true, 0, "Jugador 7 - Equipo 3", 0, 7, "Delantero", 1000m },
                    { 308, 0, null, 3, true, 0, "Jugador 8 - Equipo 3", 0, 8, "Delantero", 1000m },
                    { 309, 0, null, 3, true, 0, "Jugador 9 - Equipo 3", 0, 9, "Delantero", 1000m },
                    { 310, 0, null, 3, true, 0, "Jugador 10 - Equipo 3", 0, 10, "Delantero", 1000m },
                    { 311, 0, null, 3, true, 0, "Jugador 11 - Equipo 3", 0, 11, "Delantero", 1000m },
                    { 401, 0, null, 4, true, 0, "Jugador 1 - Equipo 4", 0, 1, "Delantero", 1000m },
                    { 402, 0, null, 4, true, 0, "Jugador 2 - Equipo 4", 0, 2, "Delantero", 1000m },
                    { 403, 0, null, 4, true, 0, "Jugador 3 - Equipo 4", 0, 3, "Delantero", 1000m },
                    { 404, 0, null, 4, true, 0, "Jugador 4 - Equipo 4", 0, 4, "Delantero", 1000m },
                    { 405, 0, null, 4, true, 0, "Jugador 5 - Equipo 4", 0, 5, "Delantero", 1000m },
                    { 406, 0, null, 4, true, 0, "Jugador 6 - Equipo 4", 0, 6, "Delantero", 1000m },
                    { 407, 0, null, 4, true, 0, "Jugador 7 - Equipo 4", 0, 7, "Delantero", 1000m },
                    { 408, 0, null, 4, true, 0, "Jugador 8 - Equipo 4", 0, 8, "Delantero", 1000m },
                    { 409, 0, null, 4, true, 0, "Jugador 9 - Equipo 4", 0, 9, "Delantero", 1000m },
                    { 410, 0, null, 4, true, 0, "Jugador 10 - Equipo 4", 0, 10, "Delantero", 1000m },
                    { 411, 0, null, 4, true, 0, "Jugador 11 - Equipo 4", 0, 11, "Delantero", 1000m },
                    { 501, 0, null, 5, true, 0, "Jugador 1 - Equipo 5", 0, 1, "Delantero", 1000m },
                    { 502, 0, null, 5, true, 0, "Jugador 2 - Equipo 5", 0, 2, "Delantero", 1000m },
                    { 503, 0, null, 5, true, 0, "Jugador 3 - Equipo 5", 0, 3, "Delantero", 1000m },
                    { 504, 0, null, 5, true, 0, "Jugador 4 - Equipo 5", 0, 4, "Delantero", 1000m },
                    { 505, 0, null, 5, true, 0, "Jugador 5 - Equipo 5", 0, 5, "Delantero", 1000m },
                    { 506, 0, null, 5, true, 0, "Jugador 6 - Equipo 5", 0, 6, "Delantero", 1000m },
                    { 507, 0, null, 5, true, 0, "Jugador 7 - Equipo 5", 0, 7, "Delantero", 1000m },
                    { 508, 0, null, 5, true, 0, "Jugador 8 - Equipo 5", 0, 8, "Delantero", 1000m },
                    { 509, 0, null, 5, true, 0, "Jugador 9 - Equipo 5", 0, 9, "Delantero", 1000m },
                    { 510, 0, null, 5, true, 0, "Jugador 10 - Equipo 5", 0, 10, "Delantero", 1000m },
                    { 511, 0, null, 5, true, 0, "Jugador 11 - Equipo 5", 0, 11, "Delantero", 1000m },
                    { 601, 0, null, 6, true, 0, "Jugador 1 - Equipo 6", 0, 1, "Delantero", 1000m },
                    { 602, 0, null, 6, true, 0, "Jugador 2 - Equipo 6", 0, 2, "Delantero", 1000m },
                    { 603, 0, null, 6, true, 0, "Jugador 3 - Equipo 6", 0, 3, "Delantero", 1000m },
                    { 604, 0, null, 6, true, 0, "Jugador 4 - Equipo 6", 0, 4, "Delantero", 1000m },
                    { 605, 0, null, 6, true, 0, "Jugador 5 - Equipo 6", 0, 5, "Delantero", 1000m },
                    { 606, 0, null, 6, true, 0, "Jugador 6 - Equipo 6", 0, 6, "Delantero", 1000m },
                    { 607, 0, null, 6, true, 0, "Jugador 7 - Equipo 6", 0, 7, "Delantero", 1000m },
                    { 608, 0, null, 6, true, 0, "Jugador 8 - Equipo 6", 0, 8, "Delantero", 1000m },
                    { 609, 0, null, 6, true, 0, "Jugador 9 - Equipo 6", 0, 9, "Delantero", 1000m },
                    { 610, 0, null, 6, true, 0, "Jugador 10 - Equipo 6", 0, 10, "Delantero", 1000m },
                    { 611, 0, null, 6, true, 0, "Jugador 11 - Equipo 6", 0, 11, "Delantero", 1000m },
                    { 701, 0, null, 7, true, 0, "Jugador 1 - Equipo 7", 0, 1, "Delantero", 1000m },
                    { 702, 0, null, 7, true, 0, "Jugador 2 - Equipo 7", 0, 2, "Delantero", 1000m },
                    { 703, 0, null, 7, true, 0, "Jugador 3 - Equipo 7", 0, 3, "Delantero", 1000m },
                    { 704, 0, null, 7, true, 0, "Jugador 4 - Equipo 7", 0, 4, "Delantero", 1000m },
                    { 705, 0, null, 7, true, 0, "Jugador 5 - Equipo 7", 0, 5, "Delantero", 1000m },
                    { 706, 0, null, 7, true, 0, "Jugador 6 - Equipo 7", 0, 6, "Delantero", 1000m },
                    { 707, 0, null, 7, true, 0, "Jugador 7 - Equipo 7", 0, 7, "Delantero", 1000m },
                    { 708, 0, null, 7, true, 0, "Jugador 8 - Equipo 7", 0, 8, "Delantero", 1000m },
                    { 709, 0, null, 7, true, 0, "Jugador 9 - Equipo 7", 0, 9, "Delantero", 1000m },
                    { 710, 0, null, 7, true, 0, "Jugador 10 - Equipo 7", 0, 10, "Delantero", 1000m },
                    { 711, 0, null, 7, true, 0, "Jugador 11 - Equipo 7", 0, 11, "Delantero", 1000m },
                    { 801, 0, null, 8, true, 0, "Jugador 1 - Equipo 8", 0, 1, "Delantero", 1000m },
                    { 802, 0, null, 8, true, 0, "Jugador 2 - Equipo 8", 0, 2, "Delantero", 1000m },
                    { 803, 0, null, 8, true, 0, "Jugador 3 - Equipo 8", 0, 3, "Delantero", 1000m },
                    { 804, 0, null, 8, true, 0, "Jugador 4 - Equipo 8", 0, 4, "Delantero", 1000m },
                    { 805, 0, null, 8, true, 0, "Jugador 5 - Equipo 8", 0, 5, "Delantero", 1000m },
                    { 806, 0, null, 8, true, 0, "Jugador 6 - Equipo 8", 0, 6, "Delantero", 1000m },
                    { 807, 0, null, 8, true, 0, "Jugador 7 - Equipo 8", 0, 7, "Delantero", 1000m },
                    { 808, 0, null, 8, true, 0, "Jugador 8 - Equipo 8", 0, 8, "Delantero", 1000m },
                    { 809, 0, null, 8, true, 0, "Jugador 9 - Equipo 8", 0, 9, "Delantero", 1000m },
                    { 810, 0, null, 8, true, 0, "Jugador 10 - Equipo 8", 0, 10, "Delantero", 1000m },
                    { 811, 0, null, 8, true, 0, "Jugador 11 - Equipo 8", 0, 11, "Delantero", 1000m },
                    { 901, 0, null, 9, true, 0, "Jugador 1 - Equipo 9", 0, 1, "Delantero", 1000m },
                    { 902, 0, null, 9, true, 0, "Jugador 2 - Equipo 9", 0, 2, "Delantero", 1000m },
                    { 903, 0, null, 9, true, 0, "Jugador 3 - Equipo 9", 0, 3, "Delantero", 1000m },
                    { 904, 0, null, 9, true, 0, "Jugador 4 - Equipo 9", 0, 4, "Delantero", 1000m },
                    { 905, 0, null, 9, true, 0, "Jugador 5 - Equipo 9", 0, 5, "Delantero", 1000m },
                    { 906, 0, null, 9, true, 0, "Jugador 6 - Equipo 9", 0, 6, "Delantero", 1000m },
                    { 907, 0, null, 9, true, 0, "Jugador 7 - Equipo 9", 0, 7, "Delantero", 1000m },
                    { 908, 0, null, 9, true, 0, "Jugador 8 - Equipo 9", 0, 8, "Delantero", 1000m },
                    { 909, 0, null, 9, true, 0, "Jugador 9 - Equipo 9", 0, 9, "Delantero", 1000m },
                    { 910, 0, null, 9, true, 0, "Jugador 10 - Equipo 9", 0, 10, "Delantero", 1000m },
                    { 911, 0, null, 9, true, 0, "Jugador 11 - Equipo 9", 0, 11, "Delantero", 1000m },
                    { 1001, 0, null, 10, true, 0, "Jugador 1 - Equipo 10", 0, 1, "Delantero", 1000m },
                    { 1002, 0, null, 10, true, 0, "Jugador 2 - Equipo 10", 0, 2, "Delantero", 1000m },
                    { 1003, 0, null, 10, true, 0, "Jugador 3 - Equipo 10", 0, 3, "Delantero", 1000m },
                    { 1004, 0, null, 10, true, 0, "Jugador 4 - Equipo 10", 0, 4, "Delantero", 1000m },
                    { 1005, 0, null, 10, true, 0, "Jugador 5 - Equipo 10", 0, 5, "Delantero", 1000m },
                    { 1006, 0, null, 10, true, 0, "Jugador 6 - Equipo 10", 0, 6, "Delantero", 1000m },
                    { 1007, 0, null, 10, true, 0, "Jugador 7 - Equipo 10", 0, 7, "Delantero", 1000m },
                    { 1008, 0, null, 10, true, 0, "Jugador 8 - Equipo 10", 0, 8, "Delantero", 1000m },
                    { 1009, 0, null, 10, true, 0, "Jugador 9 - Equipo 10", 0, 9, "Delantero", 1000m },
                    { 1010, 0, null, 10, true, 0, "Jugador 10 - Equipo 10", 0, 10, "Delantero", 1000m },
                    { 1011, 0, null, 10, true, 0, "Jugador 11 - Equipo 10", 0, 11, "Delantero", 1000m },
                    { 1101, 0, null, 11, true, 0, "Jugador 1 - Equipo 11", 0, 1, "Delantero", 1000m },
                    { 1102, 0, null, 11, true, 0, "Jugador 2 - Equipo 11", 0, 2, "Delantero", 1000m },
                    { 1103, 0, null, 11, true, 0, "Jugador 3 - Equipo 11", 0, 3, "Delantero", 1000m },
                    { 1104, 0, null, 11, true, 0, "Jugador 4 - Equipo 11", 0, 4, "Delantero", 1000m },
                    { 1105, 0, null, 11, true, 0, "Jugador 5 - Equipo 11", 0, 5, "Delantero", 1000m },
                    { 1106, 0, null, 11, true, 0, "Jugador 6 - Equipo 11", 0, 6, "Delantero", 1000m },
                    { 1107, 0, null, 11, true, 0, "Jugador 7 - Equipo 11", 0, 7, "Delantero", 1000m },
                    { 1108, 0, null, 11, true, 0, "Jugador 8 - Equipo 11", 0, 8, "Delantero", 1000m },
                    { 1109, 0, null, 11, true, 0, "Jugador 9 - Equipo 11", 0, 9, "Delantero", 1000m },
                    { 1110, 0, null, 11, true, 0, "Jugador 10 - Equipo 11", 0, 10, "Delantero", 1000m },
                    { 1111, 0, null, 11, true, 0, "Jugador 11 - Equipo 11", 0, 11, "Delantero", 1000m },
                    { 1201, 0, null, 12, true, 0, "Jugador 1 - Equipo 12", 0, 1, "Delantero", 1000m },
                    { 1202, 0, null, 12, true, 0, "Jugador 2 - Equipo 12", 0, 2, "Delantero", 1000m },
                    { 1203, 0, null, 12, true, 0, "Jugador 3 - Equipo 12", 0, 3, "Delantero", 1000m },
                    { 1204, 0, null, 12, true, 0, "Jugador 4 - Equipo 12", 0, 4, "Delantero", 1000m },
                    { 1205, 0, null, 12, true, 0, "Jugador 5 - Equipo 12", 0, 5, "Delantero", 1000m },
                    { 1206, 0, null, 12, true, 0, "Jugador 6 - Equipo 12", 0, 6, "Delantero", 1000m },
                    { 1207, 0, null, 12, true, 0, "Jugador 7 - Equipo 12", 0, 7, "Delantero", 1000m },
                    { 1208, 0, null, 12, true, 0, "Jugador 8 - Equipo 12", 0, 8, "Delantero", 1000m },
                    { 1209, 0, null, 12, true, 0, "Jugador 9 - Equipo 12", 0, 9, "Delantero", 1000m },
                    { 1210, 0, null, 12, true, 0, "Jugador 10 - Equipo 12", 0, 10, "Delantero", 1000m },
                    { 1211, 0, null, 12, true, 0, "Jugador 11 - Equipo 12", 0, 11, "Delantero", 1000m },
                    { 1301, 0, null, 13, true, 0, "Jugador 1 - Equipo 13", 0, 1, "Delantero", 1000m },
                    { 1302, 0, null, 13, true, 0, "Jugador 2 - Equipo 13", 0, 2, "Delantero", 1000m },
                    { 1303, 0, null, 13, true, 0, "Jugador 3 - Equipo 13", 0, 3, "Delantero", 1000m },
                    { 1304, 0, null, 13, true, 0, "Jugador 4 - Equipo 13", 0, 4, "Delantero", 1000m },
                    { 1305, 0, null, 13, true, 0, "Jugador 5 - Equipo 13", 0, 5, "Delantero", 1000m },
                    { 1306, 0, null, 13, true, 0, "Jugador 6 - Equipo 13", 0, 6, "Delantero", 1000m },
                    { 1307, 0, null, 13, true, 0, "Jugador 7 - Equipo 13", 0, 7, "Delantero", 1000m },
                    { 1308, 0, null, 13, true, 0, "Jugador 8 - Equipo 13", 0, 8, "Delantero", 1000m },
                    { 1309, 0, null, 13, true, 0, "Jugador 9 - Equipo 13", 0, 9, "Delantero", 1000m },
                    { 1310, 0, null, 13, true, 0, "Jugador 10 - Equipo 13", 0, 10, "Delantero", 1000m },
                    { 1311, 0, null, 13, true, 0, "Jugador 11 - Equipo 13", 0, 11, "Delantero", 1000m },
                    { 1401, 0, null, 14, true, 0, "Jugador 1 - Equipo 14", 0, 1, "Delantero", 1000m },
                    { 1402, 0, null, 14, true, 0, "Jugador 2 - Equipo 14", 0, 2, "Delantero", 1000m },
                    { 1403, 0, null, 14, true, 0, "Jugador 3 - Equipo 14", 0, 3, "Delantero", 1000m },
                    { 1404, 0, null, 14, true, 0, "Jugador 4 - Equipo 14", 0, 4, "Delantero", 1000m },
                    { 1405, 0, null, 14, true, 0, "Jugador 5 - Equipo 14", 0, 5, "Delantero", 1000m },
                    { 1406, 0, null, 14, true, 0, "Jugador 6 - Equipo 14", 0, 6, "Delantero", 1000m },
                    { 1407, 0, null, 14, true, 0, "Jugador 7 - Equipo 14", 0, 7, "Delantero", 1000m },
                    { 1408, 0, null, 14, true, 0, "Jugador 8 - Equipo 14", 0, 8, "Delantero", 1000m },
                    { 1409, 0, null, 14, true, 0, "Jugador 9 - Equipo 14", 0, 9, "Delantero", 1000m },
                    { 1410, 0, null, 14, true, 0, "Jugador 10 - Equipo 14", 0, 10, "Delantero", 1000m },
                    { 1411, 0, null, 14, true, 0, "Jugador 11 - Equipo 14", 0, 11, "Delantero", 1000m },
                    { 1501, 0, null, 15, true, 0, "Jugador 1 - Equipo 15", 0, 1, "Delantero", 1000m },
                    { 1502, 0, null, 15, true, 0, "Jugador 2 - Equipo 15", 0, 2, "Delantero", 1000m },
                    { 1503, 0, null, 15, true, 0, "Jugador 3 - Equipo 15", 0, 3, "Delantero", 1000m },
                    { 1504, 0, null, 15, true, 0, "Jugador 4 - Equipo 15", 0, 4, "Delantero", 1000m },
                    { 1505, 0, null, 15, true, 0, "Jugador 5 - Equipo 15", 0, 5, "Delantero", 1000m },
                    { 1506, 0, null, 15, true, 0, "Jugador 6 - Equipo 15", 0, 6, "Delantero", 1000m },
                    { 1507, 0, null, 15, true, 0, "Jugador 7 - Equipo 15", 0, 7, "Delantero", 1000m },
                    { 1508, 0, null, 15, true, 0, "Jugador 8 - Equipo 15", 0, 8, "Delantero", 1000m },
                    { 1509, 0, null, 15, true, 0, "Jugador 9 - Equipo 15", 0, 9, "Delantero", 1000m },
                    { 1510, 0, null, 15, true, 0, "Jugador 10 - Equipo 15", 0, 10, "Delantero", 1000m },
                    { 1511, 0, null, 15, true, 0, "Jugador 11 - Equipo 15", 0, 11, "Delantero", 1000m },
                    { 1601, 0, null, 16, true, 0, "Jugador 1 - Equipo 16", 0, 1, "Delantero", 1000m },
                    { 1602, 0, null, 16, true, 0, "Jugador 2 - Equipo 16", 0, 2, "Delantero", 1000m },
                    { 1603, 0, null, 16, true, 0, "Jugador 3 - Equipo 16", 0, 3, "Delantero", 1000m },
                    { 1604, 0, null, 16, true, 0, "Jugador 4 - Equipo 16", 0, 4, "Delantero", 1000m },
                    { 1605, 0, null, 16, true, 0, "Jugador 5 - Equipo 16", 0, 5, "Delantero", 1000m },
                    { 1606, 0, null, 16, true, 0, "Jugador 6 - Equipo 16", 0, 6, "Delantero", 1000m },
                    { 1607, 0, null, 16, true, 0, "Jugador 7 - Equipo 16", 0, 7, "Delantero", 1000m },
                    { 1608, 0, null, 16, true, 0, "Jugador 8 - Equipo 16", 0, 8, "Delantero", 1000m },
                    { 1609, 0, null, 16, true, 0, "Jugador 9 - Equipo 16", 0, 9, "Delantero", 1000m },
                    { 1610, 0, null, 16, true, 0, "Jugador 10 - Equipo 16", 0, 10, "Delantero", 1000m },
                    { 1611, 0, null, 16, true, 0, "Jugador 11 - Equipo 16", 0, 11, "Delantero", 1000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_EquipoId",
                table: "Jugadores",
                column: "EquipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Equipos");
        }
    }
}
