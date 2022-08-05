using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace NeighbodFood2.Migrations
{
    public partial class ApplicationFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrador",
                columns: table => new
                {
                    PK_CedulaADM = table.Column<long>(type: "bigint", nullable: false),
                    ADM_Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ADM_Apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ADM_Genero = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    ADM_Correo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    ADM_Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ADM_Telefono = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Administ__44F7DAE67B72BC22", x => x.PK_CedulaADM);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    PK_CedulaADM = table.Column<long>(type: "bigint", nullable: false),
                    CLI_Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLI_Apellido = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLI_Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLI_FechaREgistro = table.Column<DateTime>(type: "datetime", nullable: false),
                    CLI_Telefono = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CLI_Ciudad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CLI_Correo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    CLI_Genero = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    CLI_Puntos = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Cliente__9200A6922394EEF5", x => x.PK_CedulaADM);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    PK_MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Menu__41A0E50B17EF897B", x => x.PK_MenuID);
                });

            migrationBuilder.CreateTable(
                name: "Plato",
                columns: table => new
                {
                    PK_PlatoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PLA_Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PLA_Precio = table.Column<double>(type: "float", nullable: false),
                    PLA_Descripcion = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    PLA_Ingredientes = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Plato__2CE00A9EFEECC494", x => x.PK_PlatoID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurante",
                columns: table => new
                {
                    PK_RestauranteID = table.Column<long>(type: "bigint", nullable: false),
                    RESTA_Nombre = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    RESTA_Correo = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Restaura__BBC7FC2CCB25598F", x => x.PK_RestauranteID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotografia",
                columns: table => new
                {
                    PK_FotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FOT_Ruta = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FK_PlatoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fotograf__3AF7D80EC3BE3248", x => x.PK_FotoID);
                    table.ForeignKey(
                        name: "FK_Fotografia_Plato",
                        column: x => x.FK_PlatoID,
                        principalTable: "Plato",
                        principalColumn: "PK_PlatoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Plato",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    PlatoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Menu_Pla__5D3533FA04FD50C7", x => new { x.MenuID, x.PlatoID });
                    table.ForeignKey(
                        name: "FK__Menu_Plat__MenuI__49C3F6B7",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "PK_MenuID");
                    table.ForeignKey(
                        name: "FK__Menu_Plat__Plato__4AB81AF0",
                        column: x => x.PlatoID,
                        principalTable: "Plato",
                        principalColumn: "PK_PlatoID");
                });

            migrationBuilder.CreateTable(
                name: "Preferencia",
                columns: table => new
                {
                    PK_PreferenciaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_PlatoID = table.Column<int>(type: "int", nullable: true),
                    FK_ClienteID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Preferen__60A33EBA7722E325", x => x.PK_PreferenciaID);
                    table.ForeignKey(
                        name: "FK_Preferencia_Cliente",
                        column: x => x.FK_ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "PK_CedulaADM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preferencia_Plato",
                        column: x => x.FK_PlatoID,
                        principalTable: "Plato",
                        principalColumn: "PK_PlatoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promocione",
                columns: table => new
                {
                    PK_PromoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRO_Descuento = table.Column<int>(type: "int", nullable: false),
                    PRO_PuntosCanje = table.Column<int>(type: "int", nullable: false),
                    FK_RestauranteID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Promocio__95EEDD9011AC160D", x => x.PK_PromoID);
                    table.ForeignKey(
                        name: "FK_Promociones_Restaurante",
                        column: x => x.FK_RestauranteID,
                        principalTable: "Restaurante",
                        principalColumn: "PK_RestauranteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reseña",
                columns: table => new
                {
                    PK_ReseñaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RES_Contenido = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    RES_Calificacion = table.Column<double>(type: "float", nullable: false),
                    RES_FechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    FK_RestauranteID = table.Column<long>(type: "bigint", nullable: true),
                    FK_ClienteID = table.Column<long>(type: "bigint", nullable: true),
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reseña__900F8BEC0F6BEF4F", x => x.PK_ReseñaID);
                    table.ForeignKey(
                        name: "FK_Reseña_Cliente",
                        column: x => x.FK_ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "PK_CedulaADM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reseña_Restaurante",
                        column: x => x.FK_RestauranteID,
                        principalTable: "Restaurante",
                        principalColumn: "PK_RestauranteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurante_Administrador",
                columns: table => new
                {
                    RestauranteID = table.Column<long>(type: "bigint", nullable: false),
                    AdministradorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Restaura__D834E68EEBD68DF8", x => new { x.RestauranteID, x.AdministradorID });
                    table.ForeignKey(
                        name: "FK__Restauran__Admin__52593CB8",
                        column: x => x.AdministradorID,
                        principalTable: "Administrador",
                        principalColumn: "PK_CedulaADM");
                    table.ForeignKey(
                        name: "FK__Restauran__Resta__5165187F",
                        column: x => x.RestauranteID,
                        principalTable: "Restaurante",
                        principalColumn: "PK_RestauranteID");
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    PK_SedeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SED_Direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SED_Telefono = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    FK_RestauranteID = table.Column<long>(type: "bigint", nullable: true),
                    Ubicacion = table.Column<Point>(type: "geography", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sede__A073E828D5412115", x => x.PK_SedeID);
                    table.ForeignKey(
                        name: "FK_Sede_Restaurante",
                        column: x => x.FK_RestauranteID,
                        principalTable: "Restaurante",
                        principalColumn: "PK_RestauranteID");
                });

            migrationBuilder.CreateTable(
                name: "Sede_Menu",
                columns: table => new
                {
                    SedeID = table.Column<int>(type: "int", nullable: false),
                    Menu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Sede_Men__BC55831341201CA5", x => new { x.SedeID, x.Menu });
                    table.ForeignKey(
                        name: "FK__Sede_Menu__Menu__4E88ABD4",
                        column: x => x.Menu,
                        principalTable: "Menu",
                        principalColumn: "PK_MenuID");
                    table.ForeignKey(
                        name: "FK__Sede_Menu__SedeI__4D94879B",
                        column: x => x.SedeID,
                        principalTable: "Sede",
                        principalColumn: "PK_SedeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Fotografia_FK_PlatoID",
                table: "Fotografia",
                column: "FK_PlatoID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Plato_PlatoID",
                table: "Menu_Plato",
                column: "PlatoID");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencia_FK_ClienteID",
                table: "Preferencia",
                column: "FK_ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Preferencia_FK_PlatoID",
                table: "Preferencia",
                column: "FK_PlatoID");

            migrationBuilder.CreateIndex(
                name: "IX_Promocione_FK_RestauranteID",
                table: "Promocione",
                column: "FK_RestauranteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_FK_ClienteID",
                table: "Reseña",
                column: "FK_ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_FK_RestauranteID",
                table: "Reseña",
                column: "FK_RestauranteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reseña_UsuarioId",
                table: "Reseña",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurante_Administrador_AdministradorID",
                table: "Restaurante_Administrador",
                column: "AdministradorID");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_FK_RestauranteID",
                table: "Sede",
                column: "FK_RestauranteID");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Menu_Menu",
                table: "Sede_Menu",
                column: "Menu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Fotografia");

            migrationBuilder.DropTable(
                name: "Menu_Plato");

            migrationBuilder.DropTable(
                name: "Preferencia");

            migrationBuilder.DropTable(
                name: "Promocione");

            migrationBuilder.DropTable(
                name: "Reseña");

            migrationBuilder.DropTable(
                name: "Restaurante_Administrador");

            migrationBuilder.DropTable(
                name: "Sede_Menu");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Plato");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Administrador");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Restaurante");
        }
    }
}
