using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReservationBus.Infrastructure.Models;

namespace ReservationBus.Infrastructure.Contexts;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AffectBusToDestination> AffectBusToDestinations { get; set; }

    public virtual DbSet<AffectationRole> AffectationRoles { get; set; }

    public virtual DbSet<Bus> Buses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<Monney> Monneys { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Society> Societies { get; set; }

    public virtual DbSet<TypeReservation> TypeReservations { get; set; }

    public virtual DbSet<TypeUser> TypeUsers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Wallet> Wallets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ReservationBus;User Id=sa;Password='$uP3RC0mpl3Xp@$$w0rD';TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AffectBusToDestination>(entity =>
        {
            entity.ToTable("AffectBusToDestination");

            entity.Property(e => e.LibAffectation)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Periode)
                .HasColumnType("datetime")
                .HasColumnName("periode");
        });

        modelBuilder.Entity<AffectationRole>(entity =>
        {
            entity.ToTable("AffectationRole");

            entity.Property(e => e.Idrole)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idrole");
            entity.Property(e => e.Iduser)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("iduser");
        });

        modelBuilder.Entity<Bus>(entity =>
        {
            entity.ToTable("Bus");

            entity.Property(e => e.IdCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idCategory");
            entity.Property(e => e.IdDestionation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idDestionation");
            entity.Property(e => e.IdSociety)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idSociety");
            entity.Property(e => e.LibBus)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.Property(e => e.IdCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LibCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.Property(e => e.IdDestination)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idDestination");
            entity.Property(e => e.LibDestination)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Monney>(entity =>
        {
            entity.ToTable("Monney");

            entity.Property(e => e.IdMonney)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LibMonney)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.Property(e => e.IdBus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idBus");
            entity.Property(e => e.LibPlace)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.Property(e => e.DateDepart).HasColumnType("datetime");
            entity.Property(e => e.IdTypeReservation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idTypeReservation");
            entity.Property(e => e.IdUser)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Monney)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.ToTable("Rol");

            entity.Property(e => e.IdRole)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Society>(entity =>
        {
            entity.ToTable("Society");

            entity.Property(e => e.IdSociety)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idSociety");
            entity.Property(e => e.LibSociety)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TypeReservation>(entity =>
        {
            entity.ToTable("TypeReservation");

            entity.Property(e => e.IdTypeReservation)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idTypeReservation");
            entity.Property(e => e.LibTypeReservation)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TypeUser>(entity =>
        {
            entity.ToTable("TypeUser");

            entity.Property(e => e.IdTypeUser).IsUnicode(false);
            entity.Property(e => e.LibTypeUser).IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Email)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Firstname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.IdTypeUser)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wallet>(entity =>
        {
            entity.ToTable("Wallet");

            entity.Property(e => e.IdWallet)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("idWallet");
            entity.Property(e => e.LibWallet)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
