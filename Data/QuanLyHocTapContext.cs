using DoAn.Models;
using Microsoft.EntityFrameworkCore;

namespace DoAn.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<BaiTap> BaiTaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=QuanLyHocTap;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

//Nếu cần thêm cột-bảng: Add-Migration ThemCotGhiChu và Update-Database