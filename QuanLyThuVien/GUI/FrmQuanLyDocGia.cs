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
    public partial class FrmQuanLyDocGia : Form
    {
        private DocGiaF DOCGIA_Service = new DocGiaF();
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyDocGia()
        {
            InitializeComponent();
            Data.Data.Reload();
        }

        #endregion

        #region LoadFrom

        private void LoadDgvDOCGIA()
        {
            try
            {
                string key = txtTimKiem.Text;
                int i = 0;
                dgvDOCGIA.DataSource = DOCGIA_Service.DOCGIAS.ToList()
                                        .Where(p => p.HOTEN.ToUpper().Contains(key.ToUpper()) || p.MADOCGIA.ToUpper().Contains(key.ToUpper()))
                                        .Select(p => new
                                        {
                                            ID = p.ID,
                                            STT = ++i,
                                            MaDocGia = p.MADOCGIA,
                                            HoTen = p.HOTEN,
                                            GioiTinh = (p.GIOITINH == 0) ? "Nữ" : "Nam",
                                            NgaySinh = ((DateTime)p.NGAYSINH).ToString("dd/MM/yyyy")

                                        })
                                        .ToList();

                // cập nhật lại index
                try
                {
                    index = index1;
                    dgvDOCGIA.Rows[index].Cells["STT"].Selected = true;
                    dgvDOCGIA.Select();
                }
                catch { }
            }
            catch
            {

            }
        }
        private void FrmQuanLyDOCGIA_Load(object sender, EventArgs e)
        {
            LoadDgvDOCGIA();
            groupThongTin.Enabled = false;
            cbxGioiTinh.SelectedIndex = 0;
            dateNgaySinh.Value = DateTime.Now;
        }
        #endregion

        #region Hàm chức năng
        private bool Check()
        {
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Mã độc giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DOCGIA a = getItemById();
            int cnt = DOCGIA_Service.DOCGIAS.Where(p => p.MADOCGIA == txtMaDocGia.Text && p.ID != a.ID).ToList().Count;
            if (cnt > 0)
            {
                MessageBox.Show("Mã độc giả đã được sử dụng",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên độc giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ của độc giả không được để trống",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ClearControl()
        {
            txtHoTen.Text = "";
            txtMaDocGia.Text = "";
            txtDiaChi.Text = "";
            dateNgaySinh.Value = DateTime.Now;
            cbxGioiTinh.SelectedIndex = 0;
        }
        private void UpdateDetail()
        {
            try
            {
                DOCGIA tg = getItemById();
                if (tg.ID == 0) return;
                txtHoTen.Text = tg.HOTEN;
                txtMaDocGia.Text = tg.MADOCGIA;
                dateNgaySinh.Value = ((DateTime)tg.NGAYSINH);
                txtDiaChi.Text = tg.DIACHI;
                cbxGioiTinh.SelectedIndex = (int)tg.GIOITINH;
            }
            catch { }
        }
        private DOCGIA getItemById()
        {
            try
            {
                int id = (int)dgvDOCGIA.SelectedRows[0].Cells["ID"].Value;
                return DOCGIA_Service.FindEntity(id);
            }
            catch
            {
                // k có dòng nào đang được chọn
            }
            return new DOCGIA();
        }

        private DOCGIA getItemByForm()
        {
            DOCGIA ans = new DOCGIA();
            ans.HOTEN = txtHoTen.Text;
            ans.MADOCGIA = txtMaDocGia.Text;
            ans.GIOITINH = cbxGioiTinh.SelectedIndex;
            ans.NGAYSINH = dateNgaySinh.Value;
            ans.DIACHI = txtDiaChi.Text;

            return ans;
        }

        #endregion

        #region Sự kiện ngầm
        private void dgvDOCGIA_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index1 = index;
                index = dgvDOCGIA.SelectedRows[0].Index;
                UpdateDetail();
            }
            catch { }
        }
        #endregion

 
    }
}
