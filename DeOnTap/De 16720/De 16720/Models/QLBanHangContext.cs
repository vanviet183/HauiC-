using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace De_16720.Models
{
    public partial class QLBanHangContext : DbContext
    {
        public QLBanHangContext()
        {
        }

        public QLBanHangContext(DbContextOptions<QLBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DanhMucHang> DanhMucHangs { get; set; } = null!;
        public virtual DbSet<Hang> Hangs { get; set; } = null!;
        public virtual DbSet<Hangsx> Hangsxes { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<Nhap> Nhaps { get; set; } = null!;
        public virtual DbSet<Pnhap> Pnhaps { get; set; } = null!;
        public virtual DbSet<Pxuat> Pxuats { get; set; } = null!;
        public virtual DbSet<Sanpham> Sanphams { get; set; } = null!;
        public virtual DbSet<Xuat> Xuats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-6GE5AST\\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DanhMucHang>(entity =>
            {
                entity.HasKey(e => e.MaDm)
                    .HasName("PK__DanhMucH__2725866ED545DA2A");

                entity.ToTable("DanhMucHang");

                entity.Property(e => e.MaDm)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaDM")
                    .IsFixedLength();

                entity.Property(e => e.TenDm)
                    .HasMaxLength(50)
                    .HasColumnName("TenDM");
            });

            modelBuilder.Entity<Hang>(entity =>
            {
                entity.HasKey(e => e.MaHang)
                    .HasName("PK__Hang__19C0DB1D2C23B218");

                entity.ToTable("Hang");

                entity.Property(e => e.MaHang)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaDm)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaDM")
                    .IsFixedLength();

                entity.Property(e => e.TenHang).HasMaxLength(30);

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.Hangs)
                    .HasForeignKey(d => d.MaDm)
                    .HasConstraintName("FK__Hang__MaDM__04E4BC85");
            });

            modelBuilder.Entity<Hangsx>(entity =>
            {
                entity.HasKey(e => e.Mahangsx)
                    .HasName("PK__hangsx__E875248F5D2CFEDE");

                entity.ToTable("hangsx");

                entity.Property(e => e.Mahangsx)
                    .HasMaxLength(10)
                    .HasColumnName("mahangsx")
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasMaxLength(30)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Sodt)
                    .HasMaxLength(20)
                    .HasColumnName("sodt");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(20)
                    .HasColumnName("tenhang");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__nhanvien__7A21B37DF6BB5677");

                entity.ToTable("nhanvien");

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .HasColumnName("manv")
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasMaxLength(30)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .HasColumnName("email");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(10)
                    .HasColumnName("gioitinh")
                    .IsFixedLength();

                entity.Property(e => e.Sodt)
                    .HasMaxLength(20)
                    .HasColumnName("sodt");

                entity.Property(e => e.Tennv)
                    .HasMaxLength(20)
                    .HasColumnName("tennv");

                entity.Property(e => e.Tenphong)
                    .HasMaxLength(30)
                    .HasColumnName("tenphong");
            });

            modelBuilder.Entity<Nhap>(entity =>
            {
                entity.HasKey(e => e.Sohdn)
                    .HasName("pk_nhap");

                entity.ToTable("nhap");

                entity.Property(e => e.Sohdn)
                    .HasMaxLength(10)
                    .HasColumnName("sohdn")
                    .IsFixedLength();

                entity.Property(e => e.Dongian)
                    .HasColumnType("money")
                    .HasColumnName("dongian");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .HasColumnName("masp")
                    .IsFixedLength();

                entity.Property(e => e.Soluongn).HasColumnName("soluongn");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Nhaps)
                    .HasForeignKey(d => d.Masp)
                    .HasConstraintName("fk_nhap_sp");

                entity.HasOne(d => d.SohdnNavigation)
                    .WithOne(p => p.Nhap)
                    .HasForeignKey<Nhap>(d => d.Sohdn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nhap_pnhap");
            });

            modelBuilder.Entity<Pnhap>(entity =>
            {
                entity.HasKey(e => e.Sohdn)
                    .HasName("PK__pnhap__1F36848B34281776");

                entity.ToTable("pnhap");

                entity.Property(e => e.Sohdn)
                    .HasMaxLength(10)
                    .HasColumnName("sohdn")
                    .IsFixedLength();

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .HasColumnName("manv")
                    .IsFixedLength();

                entity.Property(e => e.Ngaynhap)
                    .HasColumnType("date")
                    .HasColumnName("ngaynhap");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Pnhaps)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("fk_pnhap_nv");
            });

            modelBuilder.Entity<Pxuat>(entity =>
            {
                entity.HasKey(e => e.Sohdx)
                    .HasName("PK__pxuat__1F3684F592C957F9");

                entity.ToTable("pxuat");

                entity.Property(e => e.Sohdx)
                    .HasMaxLength(10)
                    .HasColumnName("sohdx")
                    .IsFixedLength();

                entity.Property(e => e.Manv)
                    .HasMaxLength(10)
                    .HasColumnName("manv")
                    .IsFixedLength();

                entity.Property(e => e.Ngayxuat)
                    .HasColumnType("date")
                    .HasColumnName("ngayxuat");

                entity.HasOne(d => d.ManvNavigation)
                    .WithMany(p => p.Pxuats)
                    .HasForeignKey(d => d.Manv)
                    .HasConstraintName("fk_pxuat_nv");
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp)
                    .HasName("PK__sanpham__7A2176725B7E59E8");

                entity.ToTable("sanpham");

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .HasColumnName("masp")
                    .IsFixedLength();

                entity.Property(e => e.Donvitinh)
                    .HasMaxLength(10)
                    .HasColumnName("donvitinh")
                    .IsFixedLength();

                entity.Property(e => e.Giaban)
                    .HasColumnType("money")
                    .HasColumnName("giaban");

                entity.Property(e => e.Mahangsx)
                    .HasMaxLength(10)
                    .HasColumnName("mahangsx")
                    .IsFixedLength();

                entity.Property(e => e.Mausac)
                    .HasMaxLength(20)
                    .HasColumnName("mausac");

                entity.Property(e => e.Mota).HasColumnName("mota");

                entity.Property(e => e.Soluong).HasColumnName("soluong");

                entity.Property(e => e.Tensp)
                    .HasMaxLength(20)
                    .HasColumnName("tensp");

                entity.HasOne(d => d.MahangsxNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Mahangsx)
                    .HasConstraintName("fk_sp_hãn");
            });

            modelBuilder.Entity<Xuat>(entity =>
            {
                entity.HasKey(e => e.Sohdx)
                    .HasName("pk_xuat");

                entity.ToTable("xuat");

                entity.Property(e => e.Sohdx)
                    .HasMaxLength(10)
                    .HasColumnName("sohdx")
                    .IsFixedLength();

                entity.Property(e => e.Masp)
                    .HasMaxLength(10)
                    .HasColumnName("masp")
                    .IsFixedLength();

                entity.Property(e => e.Soluongx).HasColumnName("soluongx");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Xuats)
                    .HasForeignKey(d => d.Masp)
                    .HasConstraintName("fk_xuat_sp");

                entity.HasOne(d => d.SohdxNavigation)
                    .WithOne(p => p.Xuat)
                    .HasForeignKey<Xuat>(d => d.Sohdx)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_xuat_pxuat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
