using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api_rest_run.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Slot> Slots { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost;database=TestDB;user=SA;password=VeryStr0ngP@ssw0rd;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Inventory_PK");

            entity.ToTable("Inventory");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.VehicleId).HasName("reservations_pk");

            entity.ToTable("reservations");

            entity.Property(e => e.VehicleId)
                .ValueGeneratedNever()
                .HasColumnName("vehicle_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DateTimeEnd)
                .HasColumnType("datetime")
                .HasColumnName("date_time_end");
            entity.Property(e => e.DateTimeStart)
                .HasColumnType("datetime")
                .HasColumnName("date_time_start");
            entity.Property(e => e.DurationInMinutes)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("duration_in_minutes");
            entity.Property(e => e.IsPaid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("is_paid");
            entity.Property(e => e.SlotId).HasColumnName("slot_id");
            entity.Property(e => e.TotalCost)
                .HasColumnType("decimal(38, 0)")
                .HasColumnName("total_cost");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Slot>(entity =>
        {
            entity.HasKey(e => e.SlotNumber).HasName("slots_pk");

            entity.ToTable("slots");

            entity.Property(e => e.SlotNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("slot_number");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Floor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("floor");
            entity.Property(e => e.Free)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("free");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Plate).HasName("vehicles_pk");

            entity.ToTable("vehicles");

            entity.Property(e => e.Plate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plate");
            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("brand");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.TypeCar)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("type_car");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.Year)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("year");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
