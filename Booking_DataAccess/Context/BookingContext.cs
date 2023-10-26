using System;
using System.Collections.Generic;
using Booking_DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking_DataAccess.Context;

public partial class BookingContext : DbContext
{
    public BookingContext(DbContextOptions<BookingContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Structures> Structures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Structures>(entity =>
        {
            entity.HasKey(e => e.idStructure);

            entity.Property(e => e.idStructure).HasDefaultValueSql("(newid())");
            entity.Property(e => e.adresseStructure).HasMaxLength(255);
            entity.Property(e => e.codePostalStructure).HasMaxLength(15);
            entity.Property(e => e.complementAdresseStructure).HasMaxLength(255);
            entity.Property(e => e.emailStructure).HasMaxLength(255);
            entity.Property(e => e.nomStructure).HasMaxLength(255);
            entity.Property(e => e.telephoneStructure).HasMaxLength(255);
            entity.Property(e => e.villeStructure).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
