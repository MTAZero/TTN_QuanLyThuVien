namespace QuanLyThuVien.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLThuVienDbContext : DbContext
    {
        public QLThuVienDbContext()
            : base("name=QLThuVienDbContext")
        {
        }

        public virtual DbSet<DAUSACH> DAUSACHS { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAS { get; set; }
        public virtual DbSet<MUONTRA> MUONTRAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DOCGIA>()
                .Property(e => e.MADOCGIA)
                .IsUnicode(false);
        }
    }
}
