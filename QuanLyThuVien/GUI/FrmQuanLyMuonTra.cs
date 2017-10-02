using QuanLyThuVien.Data;
using QuanLyThuVien.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class FrmQuanLyMuonTra : Form
    {
        private int indexDocGia = 0, indexDocGia1 = 0;
        #region Hàm khởi tạo
        public FrmQuanLyMuonTra()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadForm

        private void LoadDgvMuonTra()
        {

            try
            {
                MuonTraF muonTraService = new MuonTraF();
                int i = 0;
                int id = (int)dgvDocGia.SelectedRows[0].Cells["ID"].Value;

                var listMuonTra = muonTraService.MUONTRAS.Where(p => p.DOCGIAID == id && p.TRANGTHAI == 0)
                                  .ToList()
                                  .Select(p => new
                                  {
                                      ID = p.ID,
                                      STT = ++i,
                                      NgayMuon = ((DateTime)p.NGAYMUON).ToString("dd/MM/yyyy"),
                                      TenSach = new DauSachF().DauSachS.Where(z => z.ID == p.DAUSACHID).FirstOrDefault().TEN
                                  })
                    //.Where()
                                  .ToList();

                dgvMuon.DataSource = listMuonTra;
            }
            catch { }
        }
        private void LoadDgvDocGia()
        {
            try
            {
                DocGiaF docGiaService = new DocGiaF();
                int i = 0;
                var listDocGia = docGiaService.DOCGIAS.ToList()
                                 .Select(p => new
                                 {
                                     ID = p.ID,
                                     STT = ++i,
                                     MaDocGia = p.MADOCGIA,
                                     HoTen = p.HOTEN,
                                     SoSachDangMuon = new MuonTraF().MUONTRAS.Where(z => z.DOCGIAID == p.ID && z.TRANGTHAI == 0).ToList().Count
                                 })
                                 .Where(p => p.MaDocGia.Contains(txtTimKiem.Text) || p.HoTen.Contains(txtTimKiem.Text))
                                 .ToList();

                dgvDocGia.DataSource = listDocGia;

                indexDocGia = indexDocGia1;
                dgvDocGia.Rows[indexDocGia].Cells["STTDocGia"].Selected = true;
                dgvDocGia.Select();

                LoadDgvMuonTra();
            }
            catch
            {

            }

        }
        private void FrmQuanLyMuonTra_Load(object sender, EventArgs e)
        {
            LoadDgvDocGia();
        }
        #endregion

        #region Sự kiện ngầm
        private void dgvDocGia_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                indexDocGia1 = indexDocGia;
                indexDocGia = dgvDocGia.SelectedRows[0].Index;
            }
            catch
            {

            }
            LoadDgvMuonTra();
        }
        #endregion


    }
}
