using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace kicksharing.Models;

public partial class KicksharingDbContext : DbContext
{
    public KicksharingDbContext()
    {
    }

    public KicksharingDbContext(DbContextOptions<KicksharingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Scooter> Scooters { get; set; }

    public virtual DbSet<ScooterModel> ScooterModels { get; set; }

    public virtual DbSet<ScooterStatus> ScooterStatuses { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    public virtual DbSet<TripStatus> TripStatuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=kicksharing_db;Username=postgres;Password=1111");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_payment_statuses_id");

            entity.ToTable("payment_statuses");

            entity.HasIndex(e => e.StatusName, "un_status_name_payment_statuses").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_roles_id");

            entity.ToTable("roles");

            entity.HasIndex(e => e.RoleName, "un_role_name_roles").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Scooter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_scooters_id");

            entity.ToTable("scooters");

            entity.HasIndex(e => e.SerialNumber, "un_serial_number_scooters").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BuyDate).HasColumnName("buy_date");
            entity.Property(e => e.CurrentBattery).HasColumnName("current_battery");
            entity.Property(e => e.CurrentLocation).HasColumnName("current_location");
            entity.Property(e => e.CurrentMileage).HasColumnName("current_mileage");
            entity.Property(e => e.IdModel).HasColumnName("id_model");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.SerialNumber).HasColumnName("serial_number");

            entity.HasOne(d => d.IdModelNavigation).WithMany(p => p.Scooters)
                .HasForeignKey(d => d.IdModel)
                .HasConstraintName("fk_scooters_to_scooter_models");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Scooters)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("fk_scooters_to_scooter_statuses");
        });

        modelBuilder.Entity<ScooterModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_scooter_models_id");

            entity.ToTable("scooter_models");

            entity.HasIndex(e => e.ModelName, "un_model_name_scooter_models").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MaxSpeed).HasColumnName("max_speed");
            entity.Property(e => e.ModelName).HasColumnName("model_name");
            entity.Property(e => e.PowerWatt).HasColumnName("power_watt");
            entity.Property(e => e.PricePerMinute).HasColumnName("price_per_minute");
            entity.Property(e => e.RangeKm).HasColumnName("range_km");
            entity.Property(e => e.WeightKg).HasColumnName("weight_kg");
        });

        modelBuilder.Entity<ScooterStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_scooter_statuses_id");

            entity.ToTable("scooter_statuses");

            entity.HasIndex(e => e.StatusName, "un_status_name_scooter_statuses").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_trips_id");

            entity.ToTable("trips");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.DistanceMeters).HasColumnName("distance_meters");
            entity.Property(e => e.DurationMinutes).HasColumnName("duration_minutes");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EndTime).HasColumnName("end_time");
            entity.Property(e => e.IdPaymentStatus).HasColumnName("id_payment_status");
            entity.Property(e => e.IdScooters).HasColumnName("id_scooters");
            entity.Property(e => e.IdTripStatus).HasColumnName("id_trip_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StartTime).HasColumnName("start_time");

            entity.HasOne(d => d.IdPaymentStatusNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.IdPaymentStatus)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_trips_to_payment_statuses");

            entity.HasOne(d => d.IdScootersNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.IdScooters)
                .HasConstraintName("fk_trips_to_scooters");

            entity.HasOne(d => d.IdTripStatusNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.IdTripStatus)
                .HasConstraintName("fk_trips_to_trip_statuses");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("trips_id_user_fkey");
        });

        modelBuilder.Entity<TripStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_trip_statuses_id");

            entity.ToTable("trip_statuses");

            entity.HasIndex(e => e.StatusName, "un_status_name_trip_statuses").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_users_id");

            entity.ToTable("users");

            entity.HasIndex(e => e.Email, "un_email_users").IsUnique();

            entity.HasIndex(e => e.Phone, "un_phone_users").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.FullName).HasColumnName("full_name");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Pass).HasColumnName("pass");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.RegistrationDate).HasColumnName("registration_date");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("fk_users_to_roles");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
