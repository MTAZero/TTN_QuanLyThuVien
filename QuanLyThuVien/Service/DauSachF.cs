using QuanLyThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Service
{
    class DauSachF
    {
        private QLThuVienDbContext context;

        public DauSachF()
        {
            context = new QLThuVienDbContext();
        }

        // Trả về toàn bộ dữ liệu
        public IQueryable<DAUSACH> DauSachS
        {
            get { return context.DAUSACHS; }
        }

        // Trả về một đối tượng  khi biết Khóa
        public DAUSACH FindEntity(int ID)
        {
            DAUSACH dbEntry = context.DAUSACHS.Find(ID);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(DAUSACH model)
        {
            DAUSACH dbEntry = context.DAUSACHS.Find(model.ID);

            if (dbEntry != null)
            {
                return false;
            }
            context.DAUSACHS.Add(model);
            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(DAUSACH model, int ID)
        {
            DAUSACH dbEntry = context.DAUSACHS.Find(ID);
            if (dbEntry == null)
            {
                return false;
            }

            dbEntry.TACGIA = model.TACGIA;
            dbEntry.TEN = model.TEN;

            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(DAUSACH sp)
        {
            try
            {
                context.DAUSACHS.Remove(sp);
                context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
