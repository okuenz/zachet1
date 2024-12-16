﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ivz_DE.Models
{
    public partial class CPROGRAMFILESMICROSOFTSQLSERVERMSSQL16SQLEXPRESSMSSQLDATAHOTEL_MANAGMENTMDFContext : DbContext
    {
        public CPROGRAMFILESMICROSOFTSQLSERVERMSSQL16SQLEXPRESSMSSQLDATAHOTEL_MANAGMENTMDFContext()
        {
        }

        public CPROGRAMFILESMICROSOFTSQLSERVERMSSQL16SQLEXPRESSMSSQLDATAHOTEL_MANAGMENTMDFContext(DbContextOptions<CPROGRAMFILESMICROSOFTSQLSERVERMSSQL16SQLEXPRESSMSSQLDATAHOTEL_MANAGMENTMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CleaningSchedule> CleaningSchedules { get; set; } = null!;
        public virtual DbSet<Guest> Guests { get; set; } = null!;
        public virtual DbSet<GuestService> GuestServices { get; set; } = null!;
        public virtual DbSet<Integration> Integrations { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<RoomAccess> RoomAccesses { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<StatisticHotel> StatisticHotels { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-OOKGFR3\\SQLEXPRESS;Database=C:\\PROGRAM FILES\\MICROSOFT SQL SERVER\\MSSQL16.SQLEXPRESS\\MSSQL\\DATA\\HOTEL_MANAGMENT.MDF;Encrypt=True;TrustServerCertificate=True; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CleaningSchedule>(entity =>
            {
                entity.ToTable("Cleaning_Schedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CleanerId).HasColumnName("cleaner_id");

                entity.Property(e => e.CleaningDate)
                    .HasColumnType("date")
                    .HasColumnName("cleaning_date");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.CleaningSchedules)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Cleaning_Schedule_Rooms");
            });

            modelBuilder.Entity<Guest>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CheckIn)
                    .HasColumnType("date")
                    .HasColumnName("check_in");

                entity.Property(e => e.CheckOut)
                    .HasColumnType("date")
                    .HasColumnName("check_out");

                entity.Property(e => e.DocumentNumber)
                    .HasMaxLength(255)
                    .HasColumnName("document_number");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(255)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<GuestService>(entity =>
            {
                entity.ToTable("Guest_Services");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.Property(e => e.ServiceId).HasColumnName("service_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.GuestServices)
                    .HasForeignKey(d => d.ServiceId)
                    .HasConstraintName("FK_Guest_Services_Services");
            });

            modelBuilder.Entity<Integration>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IntegrationDetails).HasColumnName("integration_details");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.PaymentDaate)
                    .HasColumnType("date")
                    .HasColumnName("payment_daate");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .HasColumnName("payment_method");

                entity.Property(e => e.ReservationId).HasColumnName("reservation_id");

                entity.HasOne(d => d.Reservation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.ReservationId)
                    .HasConstraintName("FK_Payments_Reservation");
            });

            modelBuilder.Entity<Reservation>(entity =>
            {
                entity.ToTable("Reservation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CheckInDate)
                    .HasColumnType("date")
                    .HasColumnName("check_in_date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnType("date")
                    .HasColumnName("check_out_date");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK_Reservation_Guests");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Reservations)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Reservation_Rooms");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasMaxLength(255)
                    .HasColumnName("category");

                entity.Property(e => e.Floor)
                    .HasMaxLength(255)
                    .HasColumnName("floor");

                entity.Property(e => e.Number).HasColumnName("number");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<RoomAccess>(entity =>
            {
                entity.ToTable("Room_Access");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AccessCardCode)
                    .HasMaxLength(50)
                    .HasColumnName("access_card_code");

                entity.Property(e => e.GuestId).HasColumnName("guest_id");

                entity.Property(e => e.RoomId).HasColumnName("room_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.RoomAccesses)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK_Room_Access_Guests");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.RoomAccesses)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Room_Access_Rooms");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");
            });

            modelBuilder.Entity<StatisticHotel>(entity =>
            {
                entity.ToTable("Statistic_hotel");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Adr)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("adr");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("date");

                entity.Property(e => e.OccupancyRate)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("occupancy_rate");

                entity.Property(e => e.Revenue)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("revenue");

                entity.Property(e => e.Revpar)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("revpar");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Firsrtname)
                    .HasMaxLength(255)
                    .HasColumnName("firsrtname");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .HasColumnName("phone");

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
