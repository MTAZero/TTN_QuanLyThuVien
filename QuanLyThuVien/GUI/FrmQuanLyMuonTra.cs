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

        #region Sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDgvDocGia();
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvDocGia.SelectedRows[0].Cells["ID"].Value;
                DOCGIA docgia = new DocGiaF().FindEntity(id);
                FrmMuonSach tg = new FrmMuonSach(docgia);
                tg.ShowDialog();
                LoadDgvDocGia();
            }
            catch
            {
                MessageBox.Show("Chưa có độc giả nào được chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvMuon.SelectedRows[0].Cells["IDMuonTra"].Value;

                MUONTRA z = new MuonTraF().FindEntity(id);
                DOCGIA docgia = new DocGiaF().FindEntity((int)z.DOCGIAID);
                DAUSACH dausach = new DauSachF().FindEntity((int)z.DAUSACHID);

                DialogResult rs = MessageBox.Show("Xác nhận trả sách\nĐộc giả : " + docgia.HOTEN + "\nĐầu sách : " + dausach.TEN,
                                                  "Thông báo",
                                                  MessageBoxButtons.OKCancel,
                                                  MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;

                bool ok = new MuonTraF().TRASACH(z);
                if (ok)
                {
                    MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDgvDocGia();
                }
                else
                {
                    MessageBox.Show("Trả sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Chưa có thông tin mượn trả nào được lựa chọn",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
