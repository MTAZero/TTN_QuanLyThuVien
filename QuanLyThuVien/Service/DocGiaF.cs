using QuanLyThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Service
{
    class DocGiaF
    {
        private QLThuVienDbContext context;

        public DocGiaF()
        {
            context = new QLThuVienDbContext();
        }

        // Trả về toàn bộ dữ liệu
        public IQueryable<DOCGIA> DOCGIAS
        {
            get { return context.DOCGIAS; }
        }

        // Trả về một đối tượng  khi biết Khóa
        public DOCGIA FindEntity(int ID)
        {
            DOCGIA dbEntry = context.DOCGIAS.Find(ID);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(DOCGIA model)
        {
            DOCGIA dbEntry = context.DOCGIAS.Find(model.ID);

            if (dbEntry != null)
            {
                return false;
            }
            context.DOCGIAS.Add(model);
            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(DOCGIA model, int ID)
        {
            DOCGIA dbEntry = context.DOCGIAS.Find(ID);
            if (dbEntry == null)
            {
                return false;
            }

            dbEntry.MADOCGIA = model.MADOCGIA;
            dbEntry.HOTEN = model.HOTEN;
            dbEntry.NGAYSINH = model.NGAYSINH;
            dbEntry.GIOITINH = model.GIOITINH;
            dbEntry.DIACHI = model.DIACHI;

            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(DOCGIA sp)
        {
            try
            {
                context.DOCGIAS.Remove(sp);
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
