using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NeighbodFood2.Models
{
    public partial class NEIGHBORFOODContext : IdentityDbContext
    {
        public NEIGHBORFOODContext()
        {
        }

        public NEIGHBORFOODContext(DbContextOptions<NEIGHBORFOODContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administrador { get; set; } = null!;
        public virtual DbSet<Cliente> Cliente { get; set; } = null!;
        public virtual DbSet<Fotografia> Fotografia { get; set; } = null!;
        public virtual DbSet<Menu> Menu { get; set; } = null!;
        public virtual DbSet<Plato> Plato { get; set; } = null!;
        public virtual DbSet<Preferencia> Preferencia { get; set; } = null!;
        public virtual DbSet<Promocion> Promociones { get; set; } = null!;
        public virtual DbSet<Reseña> Reseña { get; set; } = null!;
        public virtual DbSet<Restaurante> Restaurante { get; set; } = null!;
        public virtual DbSet<Sede> Sede { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.PK_CedulaADM)
                    .HasName("PK__Administ__44F7DAE67B72BC22");

                entity.ToTable("Administrador");

                entity.Property(e => e.PK_CedulaADM)
                    .ValueGeneratedNever()
                    .HasColumnName("PK_CedulaADM");

                entity.Property(e => e.ADM_Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Apellido");

                entity.Property(e => e.ADM_Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Correo");

                entity.Property(e => e.ADM_Genero)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Genero");

                entity.Property(e => e.ADM_Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Nombre");

                entity.Property(e => e.ADM_Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Password");

                entity.Property(e => e.ADM_Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("ADM_Telefono");
            });


            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.PK_Cedula)
                    .HasName("PK__Cliente__9200A6922394EEF5");

                entity.ToTable("Cliente");

                entity.Property(e => e.PK_Cedula)
                    .ValueGeneratedNever()
                    .HasColumnName("PK_CedulaADM");

                entity.Property(e => e.CLI_Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Apellido");

                entity.Property(e => e.CLI_Ciudad)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Ciudad");

                entity.Property(e => e.CLI_Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Correo");

                entity.Property(e => e.CLI_FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("CLI_FechaREgistro");

                entity.Property(e => e.CLI_Genero)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Genero");

                entity.Property(e => e.CLI_Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Nombre");

                entity.Property(e => e.CLI_Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Password");

                entity.Property(e => e.CLI_Puntos).HasColumnName("CLI_Puntos");

                entity.Property(e => e.CLI_Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CLI_Telefono");
            });

            modelBuilder.Entity<Fotografia>(entity =>
            {
                entity.HasKey(e => e.PK_FotoID)
                    .HasName("PK__Fotograf__3AF7D80EC3BE3248");

                entity.HasIndex(e => e.FK_PlatoID, "IX_Fotografia_FK_PlatoID");

                entity.Property(e => e.PK_FotoID).HasColumnName("PK_FotoID");

                entity.Property(e => e.FK_PlatoID).HasColumnName("FK_PlatoID");

                entity.Property(e => e.FOT_Ruta)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FOT_Ruta");

                entity.HasOne(d => d.Plato)
                    .WithMany(p => p.Fotografias)
                    .HasForeignKey(d => d.FK_PlatoID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Fotografia_Plato");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.HasKey(e => e.PK_MenuID)
                    .HasName("PK__Menu__41A0E50B17EF897B");

                entity.ToTable("Menu");

                entity.Property(e => e.PK_MenuID).HasColumnName("PK_MenuID");

                entity.HasMany(d => d.Platos)
                    .WithMany(p => p.Menus)
                    .UsingEntity<Dictionary<string, object>>(
                        "MenuPlato",
                        l => l.HasOne<Plato>().WithMany().HasForeignKey("PlatoId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Menu_Plat__Plato__4AB81AF0"),
                        r => r.HasOne<Menu>().WithMany().HasForeignKey("MenuId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Menu_Plat__MenuI__49C3F6B7"),
                        j =>
                        {
                            j.HasKey("MenuId", "PlatoId").HasName("PK__Menu_Pla__5D3533FA04FD50C7");

                            j.ToTable("Menu_Plato");

                            j.HasIndex(new[] { "PlatoId" }, "IX_Menu_Plato_PlatoID");

                            j.IndexerProperty<int>("MenuId").HasColumnName("MenuID");

                            j.IndexerProperty<int>("PlatoId").HasColumnName("PlatoID");
                        });
            });

            modelBuilder.Entity<Plato>(entity =>
            {
                entity.HasKey(e => e.PK_PlatoID)
                    .HasName("PK__Plato__2CE00A9EFEECC494");

                entity.ToTable("Plato");

                entity.Property(e => e.PK_PlatoID).HasColumnName("PK_PlatoID");

                entity.Property(e => e.PLA_Descripcion)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLA_Descripcion");

                entity.Property(e => e.PLA_Ingredientes)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PLA_Ingredientes");

                entity.Property(e => e.PLA_Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PLA_Nombre");

                entity.Property(e => e.PLA_Precio).HasColumnName("PLA_Precio");
            });

            modelBuilder.Entity<Preferencia>(entity =>
            {
                entity.HasKey(e => e.PK_PreferenciaID)
                    .HasName("PK__Preferen__60A33EBA7722E325");

                entity.HasIndex(e => e.FK_ClienteID, "IX_Preferencia_FK_ClienteID");

                entity.HasIndex(e => e.FK_PlatoID, "IX_Preferencia_FK_PlatoID");

                entity.Property(e => e.PK_PreferenciaID).HasColumnName("PK_PreferenciaID");

                entity.Property(e => e.FK_ClienteID).HasColumnName("FK_ClienteID");

                entity.Property(e => e.FK_PlatoID).HasColumnName("FK_PlatoID");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Preferencias)
                    .HasForeignKey(d => d.FK_ClienteID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preferencia_Cliente");

                entity.HasOne(d => d.Plato)
                    .WithMany(p => p.Preferencia)
                    .HasForeignKey(d => d.FK_PlatoID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preferencia_Plato");
            });

            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.HasKey(e => e.PK_PromoID)
                    .HasName("PK__Promocio__95EEDD9011AC160D");

                entity.ToTable("Promocione");

                entity.HasIndex(e => e.FK_RestauranteID, "IX_Promocione_FK_RestauranteID");

                entity.Property(e => e.PK_PromoID).HasColumnName("PK_PromoID");

                entity.Property(e => e.FK_RestauranteID).HasColumnName("FK_RestauranteID");

                entity.Property(e => e.PRO_Descuento).HasColumnName("PRO_Descuento");

                entity.Property(e => e.PRO_PuntosCanje).HasColumnName("PRO_PuntosCanje");

                entity.HasOne(d => d.Restaurante)
                    .WithMany(p => p.Promociones)
                    .HasForeignKey(d => d.FK_RestauranteID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Promociones_Restaurante");
            });

            modelBuilder.Entity<Reseña>(entity =>
            {
                entity.HasKey(e => e.PK_ReseñaID)
                    .HasName("PK__Reseña__900F8BEC0F6BEF4F");

                entity.ToTable("Reseña");

                entity.HasIndex(e => e.FK_ClienteID, "IX_Reseña_FK_ClienteID");

                entity.HasIndex(e => e.FK_RestauranteID, "IX_Reseña_FK_RestauranteID");

                entity.HasIndex(e => e.UsuarioId, "IX_Reseña_UsuarioId");

                entity.Property(e => e.PK_ReseñaID).HasColumnName("PK_ReseñaID");

                entity.Property(e => e.FK_ClienteID).HasColumnName("FK_ClienteID");

                entity.Property(e => e.FK_RestauranteID).HasColumnName("FK_RestauranteID");

                entity.Property(e => e.RES_Calificacion).HasColumnName("RES_Calificacion");

                entity.Property(e => e.RES_Contenido)
                    .IsUnicode(false)
                    .HasColumnName("RES_Contenido");

                entity.Property(e => e.RES_FechaCreacion)
                    .HasColumnType("datetime")
                    .HasColumnName("RES_FechaCreacion");

                entity.HasOne(d => d.Cliente)
                    .WithMany(p => p.Reseñas)
                    .HasForeignKey(d => d.FK_ClienteID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Reseña_Cliente");

                entity.HasOne(d => d.Restaurante)
                    .WithMany(p => p.Reseñas)
                    .HasForeignKey(d => d.FK_RestauranteID)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Reseña_Restaurante");

                
            });

            modelBuilder.Entity<Restaurante>(entity =>
            {
                entity.HasKey(e => e.PK_RestauranteID)
                    .HasName("PK__Restaura__BBC7FC2CCB25598F");

                entity.ToTable("Restaurante");

                entity.Property(e => e.PK_RestauranteID)
                    .ValueGeneratedNever()
                    .HasColumnName("PK_RestauranteID");

                entity.Property(e => e.RESTA_Correo)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESTA_Correo");

                entity.Property(e => e.RESTA_Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("RESTA_Nombre");

                entity.HasMany(d => d.Administradores)
                    .WithMany(p => p.Restaurantes)
                    .UsingEntity<Dictionary<string, object>>(
                        "RestauranteAdministrador",
                        l => l.HasOne<Administrador>().WithMany().HasForeignKey("AdministradorId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Restauran__Admin__52593CB8"),
                        r => r.HasOne<Restaurante>().WithMany().HasForeignKey("RestauranteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Restauran__Resta__5165187F"),
                        j =>
                        {
                            j.HasKey("RestauranteId", "AdministradorId").HasName("PK__Restaura__D834E68EEBD68DF8");

                            j.ToTable("Restaurante_Administrador");

                            j.HasIndex(new[] { "AdministradorId" }, "IX_Restaurante_Administrador_AdministradorID");

                            j.IndexerProperty<long>("RestauranteId").HasColumnName("RestauranteID");

                            j.IndexerProperty<long>("AdministradorId").HasColumnName("AdministradorID");
                        });
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.PK_SedeID)
                    .HasName("PK__Sede__A073E828D5412115");

                entity.ToTable("Sede");

                entity.HasIndex(e => e.FK_RestauranteID, "IX_Sede_FK_RestauranteID");

                entity.Property(e => e.PK_SedeID).HasColumnName("PK_SedeID");

                entity.Property(e => e.FK_RestauranteID).HasColumnName("FK_RestauranteID");

                entity.Property(e => e.SED_Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SED_Direccion");

                entity.Property(e => e.SED_Telefono)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("SED_Telefono");

                entity.HasOne(d => d.Restaurante)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.FK_RestauranteID)
                    .HasConstraintName("FK_Sede_Restaurante");

                entity.HasMany(d => d.Menu)
                    .WithMany(p => p.Sedes)
                    .UsingEntity<Dictionary<string, object>>(
                        "SedeMenu",
                        l => l.HasOne<Menu>().WithMany().HasForeignKey("Menu").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Sede_Menu__Menu__4E88ABD4"),
                        r => r.HasOne<Sede>().WithMany().HasForeignKey("SedeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__Sede_Menu__SedeI__4D94879B"),
                        j =>
                        {
                            j.HasKey("SedeId", "Menu").HasName("PK__Sede_Men__BC55831341201CA5");

                            j.ToTable("Sede_Menu");

                            j.HasIndex(new[] { "Menu" }, "IX_Sede_Menu_Menu");

                            j.IndexerProperty<int>("SedeId").HasColumnName("SedeID");
                        });
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
