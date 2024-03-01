﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AD_Manager.Models;

public partial class ADManagerContext : DbContext
{
    public ADManagerContext(DbContextOptions<ADManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<user_admin> user_admin { get; set; }

    public virtual DbSet<user_technician> user_technician { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<user_admin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("user-admin");

            entity.Property(e => e.user_name)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user-name");
            entity.Property(e => e.user_password)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user-password");
        });

        modelBuilder.Entity<user_technician>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("user-technician");

            entity.Property(e => e.ID)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.user_name)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user-name");
            entity.Property(e => e.user_password)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("user-password");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}