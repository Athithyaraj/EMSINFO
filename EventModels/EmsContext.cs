using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EMSINFO.EventModels;

public partial class EMSContext : DbContext
{
    public EMSContext()
    {
    }

    public EMSContext(DbContextOptions<EMSContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Eventmaster> eventmasters { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Eventmaster>(entity =>
        {
            entity.HasKey(e => e.id).HasName("eventmaster_pkey");

            entity.ToTable("eventmaster");

            entity.Property(e => e.event_name).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
