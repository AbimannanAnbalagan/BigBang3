using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tourism.Models;

public partial class TourismContext : DbContext
{
    public TourismContext()
    {
    }

    public TourismContext(DbContextOptions<TourismContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<ContactU> ContactUs { get; set; }

    public virtual DbSet<Feedback> Feedbacks { get; set; }

    public virtual DbSet<Gallery> Galleries { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Package> Packages { get; set; }

    public virtual DbSet<TravelAgent> TravelAgents { get; set; }

    public virtual DbSet<Traveler> Travelers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = Tourism; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__73951AED795131C1");

            entity.Property(e => e.TotalAmount).HasColumnType("money");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Agent).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.AgentId)
                .HasConstraintName("BookingsAgentId");

            entity.HasOne(d => d.Package).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("BookingsPackageId");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("BookingsUserId");
        });

        modelBuilder.Entity<ContactU>(entity =>
        {
            entity.HasKey(e => e.ContactUsId).HasName("PK__ContactU__E10B7AC815832C23");
        });

        modelBuilder.Entity<Feedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Feedback__6A4BEDD66EF07780");

            entity.ToTable("Feedback");

            entity.Property(e => e.Feedback1).HasColumnName("Feedback");

            entity.HasOne(d => d.Booking).WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FeedbackBookingId");
        });

        modelBuilder.Entity<Gallery>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__Gallery__7516F70C7559369E");

            entity.ToTable("Gallery");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotels__46023BDF37E88A23");

            entity.HasOne(d => d.Package).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.PackageId)
                .HasConstraintName("HotelsPackageId");
        });

        modelBuilder.Entity<Package>(entity =>
        {
            entity.HasKey(e => e.PackageId).HasName("PK__Package__322035CC2C0FB153");

            entity.ToTable("Package");

            entity.Property(e => e.Price).HasColumnType("money");
        });

        modelBuilder.Entity<TravelAgent>(entity =>
        {
            entity.HasKey(e => e.AgentId).HasName("PK__TravelAg__9AC3BFF17C277C90");

            entity.ToTable("TravelAgent");

            entity.Property(e => e.Gender).HasMaxLength(9);

            entity.HasOne(d => d.User).WithMany(p => p.TravelAgents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("TravelAgentUserId");
        });

        modelBuilder.Entity<Traveler>(entity =>
        {
            entity.HasKey(e => e.TravelerId).HasName("PK__Traveler__66FD3CD89A48C233");

            entity.ToTable("Traveler");

            entity.Property(e => e.Gender).HasMaxLength(9);

            entity.HasOne(d => d.User).WithMany(p => p.Travelers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("TravelerUserId");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__User__1788CC4CCA81B923");

            entity.ToTable("User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
