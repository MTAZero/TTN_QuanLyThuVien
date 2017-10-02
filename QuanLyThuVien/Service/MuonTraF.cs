using QuanLyThuVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Service
{
    class MuonTraF
    {
        private QLThuVienDbContext context;

        public MuonTraF()
        {
            context = new QLThuVienDbContext();
        }

        // Trả về toàn bộ dữ liệu
        public IQueryable<MUONTRA> MUONTRAS
        {
            get { return context.MUONTRAS; }
        }

        // Trả về một đối tượng  khi biết Khóa
        public MUONTRA FindEntity(int ID)
        {
            MUONTRA dbEntry = context.MUONTRAS.Find(ID);
            return dbEntry;
        }

        // Thêm một đối tượng
        public bool Insert(MUONTRA model)
        {
            MUONTRA dbEntry = context.MUONTRAS.Find(model.ID);

            if (dbEntry != null)
            {
                return false;
            }
            context.MUONTRAS.Add(model);
            context.SaveChanges();

            return true;
        }

        // Sửa một đối tượng
        public bool Update(MUONTRA model, int ID)
        {
            MUONTRA dbEntry = context.MUONTRAS.Find(ID);
            if (dbEntry == null)
            {
                return false;
            }

            dbEntry.NGAYMUON = model.NGAYMUON;
            dbEntry.DOCGIAID = model.DOCGIAID;
            dbEntry.DAUSACHID = model.DAUSACHID;
            dbEntry.NGAYTRA = model.NGAYTRA;
            dbEntry.TRANGTHAI = model.TRANGTHAI;

            context.SaveChanges();

            return true;
        }

        // Xóa một đối tượng
        public bool Delete(MUONTRA sp)
        {
            try
            {
                context.MUONTRAS.Remove(sp);
                context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool TRASACH(MUONTRA sp)
        {
            MUONTRA dbEntry = context.MUONTRAS.Find(sp.ID);
            if (dbEntry == null)
            {
                return false;
            }

            dbEntry.TRANGTHAI = 1;
            dbEntry.NGAYTRA = DateTime.Now;
            context.SaveChanges();

            return true;
        }
    }
}
