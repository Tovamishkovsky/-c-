using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lesson9.models;

public partial class DBManager : DbContext
{
    static DBManager db;
    public DBManager()
    {
    }
    public static DBManager GetInstance()
    {
        if (db == null)
        {
            db = new DBManager();
        }
        return db;
    }

    public DBManager(DbContextOptions<DBManager> options)
        : base(options)
    {
    }

    public virtual DbSet<Apartment> Apartments { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<InterestTable> InterestTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\c#\\lesson8\\database\\MyDb.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Apartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC0785B1B326");

            entity.ToTable("apartment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Adress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("adress");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Size).HasColumnName("size");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3214EC079B491BFC");

            entity.ToTable("customer");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("full_name");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<InterestTable>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Interest__3214EC0730798E5D");

            entity.ToTable("Interest_table");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.IdApartment).HasColumnName("id_apartment");
            entity.Property(e => e.IdCustomer).HasColumnName("id_customer");

            entity.HasOne(d => d.IdApartmentNavigation).WithMany(p => p.InterestTables)
                .HasForeignKey(d => d.IdApartment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interest_table_ToTable_1");

            entity.HasOne(d => d.IdCustomerNavigation).WithMany(p => p.InterestTables)
                .HasForeignKey(d => d.IdCustomer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Interest_table_ToTable");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
