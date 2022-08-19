﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NeighbodFood2.Models;
using NetTopologySuite.Geometries;

#nullable disable

namespace NeighbodFood2.Migrations
{
    [DbContext(typeof(NEIGHBORFOODContext))]
    partial class NEIGHBORFOODContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MenuPlato", b =>
                {
                    b.Property<int>("MenuId")
                        .HasColumnType("int")
                        .HasColumnName("MenuID");

                    b.Property<int>("PlatoId")
                        .HasColumnType("int")
                        .HasColumnName("PlatoID");

                    b.HasKey("MenuId", "PlatoId")
                        .HasName("PK__Menu_Pla__5D3533FA04FD50C7");

                    b.HasIndex(new[] { "PlatoId" }, "IX_Menu_Plato_PlatoID");

                    b.ToTable("Menu_Plato", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Administrador", b =>
                {
                    b.Property<long>("PK_CedulaADM")
                        .HasColumnType("bigint")
                        .HasColumnName("PK_CedulaADM");

                    b.Property<string>("ADM_Apellido")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ADM_Apellido");

                    b.Property<string>("ADM_Correo")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("ADM_Correo");

                    b.Property<string>("ADM_Genero")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ADM_Genero");

                    b.Property<string>("ADM_Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ADM_Nombre");

                    b.Property<string>("ADM_Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("ADM_Password");

                    b.Property<string>("ADM_Telefono")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("ADM_Telefono");

                    b.HasKey("PK_CedulaADM")
                        .HasName("PK__Administ__44F7DAE67B72BC22");

                    b.ToTable("Administrador", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Categoria", b =>
                {
                    b.Property<int>("PK_CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_CategoriaID"), 1L, 1);

                    b.Property<string>("CategoriaImagen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoriaNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Cliente", b =>
                {
                    b.Property<long>("PK_Cedula")
                        .HasColumnType("bigint")
                        .HasColumnName("PK_CedulaADM");

                    b.Property<string>("CLI_Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CLI_Apellido");

                    b.Property<string>("CLI_Ciudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CLI_Ciudad");

                    b.Property<string>("CLI_Correo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("CLI_Correo");

                    b.Property<DateTime>("CLI_FechaRegistro")
                        .HasColumnType("datetime")
                        .HasColumnName("CLI_FechaREgistro");

                    b.Property<string>("CLI_Genero")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("CLI_Genero");

                    b.Property<string>("CLI_Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CLI_Nombre");

                    b.Property<string>("CLI_Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("CLI_Password");

                    b.Property<int?>("CLI_Puntos")
                        .HasColumnType("int")
                        .HasColumnName("CLI_Puntos");

                    b.Property<string>("CLI_Telefono")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("CLI_Telefono");

                    b.HasKey("PK_Cedula")
                        .HasName("PK__Cliente__9200A6922394EEF5");

                    b.ToTable("Cliente", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Fotografia", b =>
                {
                    b.Property<int>("PK_FotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_FotoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_FotoID"), 1L, 1);

                    b.Property<int?>("FK_PlatoID")
                        .HasColumnType("int")
                        .HasColumnName("FK_PlatoID");

                    b.Property<string>("FOT_Ruta")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("FOT_Ruta");

                    b.HasKey("PK_FotoID")
                        .HasName("PK__Fotograf__3AF7D80EC3BE3248");

                    b.HasIndex(new[] { "FK_PlatoID" }, "IX_Fotografia_FK_PlatoID");

                    b.ToTable("Fotografia");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Menu", b =>
                {
                    b.Property<int>("PK_MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_MenuID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_MenuID"), 1L, 1);

                    b.HasKey("PK_MenuID")
                        .HasName("PK__Menu__41A0E50B17EF897B");

                    b.ToTable("Menu", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Plato", b =>
                {
                    b.Property<int>("PK_PlatoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_PlatoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_PlatoID"), 1L, 1);

                    b.Property<int?>("CategoriaPK_CategoriaID")
                        .HasColumnType("int");

                    b.Property<int>("PLA_Categoria")
                        .HasColumnType("int");

                    b.Property<string>("PLA_Descripcion")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("PLA_Descripcion");

                    b.Property<string>("PLA_Ingredientes")
                        .HasMaxLength(1)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1)")
                        .HasColumnName("PLA_Ingredientes");

                    b.Property<string>("PLA_Nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("PLA_Nombre");

                    b.Property<double>("PLA_Precio")
                        .HasColumnType("float")
                        .HasColumnName("PLA_Precio");

                    b.HasKey("PK_PlatoID")
                        .HasName("PK__Plato__2CE00A9EFEECC494");

                    b.HasIndex("CategoriaPK_CategoriaID");

                    b.ToTable("Plato", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Preferencia", b =>
                {
                    b.Property<int>("PK_PreferenciaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_PreferenciaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_PreferenciaID"), 1L, 1);

                    b.Property<long?>("FK_ClienteID")
                        .HasColumnType("bigint")
                        .HasColumnName("FK_ClienteID");

                    b.Property<int?>("FK_PlatoID")
                        .HasColumnType("int")
                        .HasColumnName("FK_PlatoID");

                    b.HasKey("PK_PreferenciaID")
                        .HasName("PK__Preferen__60A33EBA7722E325");

                    b.HasIndex(new[] { "FK_ClienteID" }, "IX_Preferencia_FK_ClienteID");

                    b.HasIndex(new[] { "FK_PlatoID" }, "IX_Preferencia_FK_PlatoID");

                    b.ToTable("Preferencia");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Promocion", b =>
                {
                    b.Property<int>("PK_PromoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_PromoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_PromoID"), 1L, 1);

                    b.Property<long?>("FK_RestauranteID")
                        .HasColumnType("bigint")
                        .HasColumnName("FK_RestauranteID");

                    b.Property<int>("PRO_Descuento")
                        .HasColumnType("int")
                        .HasColumnName("PRO_Descuento");

                    b.Property<int>("PRO_PuntosCanje")
                        .HasColumnType("int")
                        .HasColumnName("PRO_PuntosCanje");

                    b.HasKey("PK_PromoID")
                        .HasName("PK__Promocio__95EEDD9011AC160D");

                    b.HasIndex(new[] { "FK_RestauranteID" }, "IX_Promocione_FK_RestauranteID");

                    b.ToTable("Promocione", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Reseña", b =>
                {
                    b.Property<int>("PK_ReseñaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_ReseñaID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_ReseñaID"), 1L, 1);

                    b.Property<long?>("FK_ClienteID")
                        .HasColumnType("bigint")
                        .HasColumnName("FK_ClienteID");

                    b.Property<long?>("FK_RestauranteID")
                        .HasColumnType("bigint")
                        .HasColumnName("FK_RestauranteID");

                    b.Property<double>("RES_Calificacion")
                        .HasColumnType("float")
                        .HasColumnName("RES_Calificacion");

                    b.Property<string>("RES_Contenido")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("RES_Contenido");

                    b.Property<DateTime>("RES_FechaCreacion")
                        .HasColumnType("datetime")
                        .HasColumnName("RES_FechaCreacion");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PK_ReseñaID")
                        .HasName("PK__Reseña__900F8BEC0F6BEF4F");

                    b.HasIndex(new[] { "FK_ClienteID" }, "IX_Reseña_FK_ClienteID");

                    b.HasIndex(new[] { "FK_RestauranteID" }, "IX_Reseña_FK_RestauranteID");

                    b.HasIndex(new[] { "UsuarioId" }, "IX_Reseña_UsuarioId");

                    b.ToTable("Reseña", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Restaurante", b =>
                {
                    b.Property<long>("PK_RestauranteID")
                        .HasColumnType("bigint")
                        .HasColumnName("PK_RestauranteID");

                    b.Property<string>("RESTA_Correo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESTA_Correo");

                    b.Property<string>("RESTA_Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RESTA_Nombre")
                        .HasMaxLength(60)
                        .IsUnicode(false)
                        .HasColumnType("varchar(60)")
                        .HasColumnName("RESTA_Nombre");

                    b.HasKey("PK_RestauranteID")
                        .HasName("PK__Restaura__BBC7FC2CCB25598F");

                    b.ToTable("Restaurante", (string)null);
                });

            modelBuilder.Entity("NeighbodFood2.Models.Sede", b =>
                {
                    b.Property<int>("PK_SedeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK_SedeID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PK_SedeID"), 1L, 1);

                    b.Property<long?>("FK_RestauranteID")
                        .HasColumnType("bigint")
                        .HasColumnName("FK_RestauranteID");

                    b.Property<string>("SED_Direccion")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("SED_Direccion");

                    b.Property<string>("SED_Telefono")
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("SED_Telefono");

                    b.Property<Point>("Ubicacion")
                        .HasColumnType("geography");

                    b.HasKey("PK_SedeID")
                        .HasName("PK__Sede__A073E828D5412115");

                    b.HasIndex(new[] { "FK_RestauranteID" }, "IX_Sede_FK_RestauranteID");

                    b.ToTable("Sede", (string)null);
                });

            modelBuilder.Entity("RestauranteAdministrador", b =>
                {
                    b.Property<long>("RestauranteId")
                        .HasColumnType("bigint")
                        .HasColumnName("RestauranteID");

                    b.Property<long>("AdministradorId")
                        .HasColumnType("bigint")
                        .HasColumnName("AdministradorID");

                    b.HasKey("RestauranteId", "AdministradorId")
                        .HasName("PK__Restaura__D834E68EEBD68DF8");

                    b.HasIndex(new[] { "AdministradorId" }, "IX_Restaurante_Administrador_AdministradorID");

                    b.ToTable("Restaurante_Administrador", (string)null);
                });

            modelBuilder.Entity("SedeMenu", b =>
                {
                    b.Property<int>("SedeId")
                        .HasColumnType("int")
                        .HasColumnName("SedeID");

                    b.Property<int>("Menu")
                        .HasColumnType("int");

                    b.HasKey("SedeId", "Menu")
                        .HasName("PK__Sede_Men__BC55831341201CA5");

                    b.HasIndex(new[] { "Menu" }, "IX_Sede_Menu_Menu");

                    b.ToTable("Sede_Menu", (string)null);
                });

            modelBuilder.Entity("MenuPlato", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .IsRequired()
                        .HasConstraintName("FK__Menu_Plat__MenuI__49C3F6B7");

                    b.HasOne("NeighbodFood2.Models.Plato", null)
                        .WithMany()
                        .HasForeignKey("PlatoId")
                        .IsRequired()
                        .HasConstraintName("FK__Menu_Plat__Plato__4AB81AF0");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NeighbodFood2.Models.Fotografia", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Plato", "Plato")
                        .WithMany("Fotografias")
                        .HasForeignKey("FK_PlatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Fotografia_Plato");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Plato", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Categoria", null)
                        .WithMany("Platos")
                        .HasForeignKey("CategoriaPK_CategoriaID");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Preferencia", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Cliente", "Cliente")
                        .WithMany("Preferencias")
                        .HasForeignKey("FK_ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Preferencia_Cliente");

                    b.HasOne("NeighbodFood2.Models.Plato", "Plato")
                        .WithMany("Preferencia")
                        .HasForeignKey("FK_PlatoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Preferencia_Plato");

                    b.Navigation("Cliente");

                    b.Navigation("Plato");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Promocion", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Restaurante", "Restaurante")
                        .WithMany("Promociones")
                        .HasForeignKey("FK_RestauranteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Promociones_Restaurante");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Reseña", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Cliente", "Cliente")
                        .WithMany("Reseñas")
                        .HasForeignKey("FK_ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Reseña_Cliente");

                    b.HasOne("NeighbodFood2.Models.Restaurante", "Restaurante")
                        .WithMany("Reseñas")
                        .HasForeignKey("FK_RestauranteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Reseña_Restaurante");

                    b.Navigation("Cliente");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Sede", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Restaurante", "Restaurante")
                        .WithMany("Sedes")
                        .HasForeignKey("FK_RestauranteID")
                        .HasConstraintName("FK_Sede_Restaurante");

                    b.Navigation("Restaurante");
                });

            modelBuilder.Entity("RestauranteAdministrador", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Administrador", null)
                        .WithMany()
                        .HasForeignKey("AdministradorId")
                        .IsRequired()
                        .HasConstraintName("FK__Restauran__Admin__52593CB8");

                    b.HasOne("NeighbodFood2.Models.Restaurante", null)
                        .WithMany()
                        .HasForeignKey("RestauranteId")
                        .IsRequired()
                        .HasConstraintName("FK__Restauran__Resta__5165187F");
                });

            modelBuilder.Entity("SedeMenu", b =>
                {
                    b.HasOne("NeighbodFood2.Models.Menu", null)
                        .WithMany()
                        .HasForeignKey("Menu")
                        .IsRequired()
                        .HasConstraintName("FK__Sede_Menu__Menu__4E88ABD4");

                    b.HasOne("NeighbodFood2.Models.Sede", null)
                        .WithMany()
                        .HasForeignKey("SedeId")
                        .IsRequired()
                        .HasConstraintName("FK__Sede_Menu__SedeI__4D94879B");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Categoria", b =>
                {
                    b.Navigation("Platos");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Cliente", b =>
                {
                    b.Navigation("Preferencias");

                    b.Navigation("Reseñas");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Plato", b =>
                {
                    b.Navigation("Fotografias");

                    b.Navigation("Preferencia");
                });

            modelBuilder.Entity("NeighbodFood2.Models.Restaurante", b =>
                {
                    b.Navigation("Promociones");

                    b.Navigation("Reseñas");

                    b.Navigation("Sedes");
                });
#pragma warning restore 612, 618
        }
    }
}
