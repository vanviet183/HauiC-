using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace De_1.Models
{
    public partial class De1Context : DbContext
    {
        public De1Context()
        {
        }

        public De1Context(DbContextOptions<De1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        public virtual DbSet<PhongBan> PhongBans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6GE5AST\\SQLEXPRESS;Initial Catalog=De1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NhanVien__2724CB02C9283C92");

                entity.ToTable("NhanVien");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Mapb)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.MapbNavigation)
                    .WithMany(p => p.NhanViens)
                    .HasForeignKey(d => d.Mapb)
                    .HasConstraintName("FK_NhanVien_PhongBan");
            });

            modelBuilder.Entity<PhongBan>(entity =>
            {
                entity.HasKey(e => e.Mapb)
                    .HasName("PK__PhongBan__2724DBBCBBE6867B");

                entity.ToTable("PhongBan");

                entity.Property(e => e.Mapb)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Tenphong).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
