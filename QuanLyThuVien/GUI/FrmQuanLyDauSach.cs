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
    public partial class FrmQuanLyDauSach : Form
    {

        private DauSachF DauSach_Service = new DauSachF();
        private int index = 0, index1 = 0;

        #region constructor
        public FrmQuanLyDauSach()
        {
            InitializeComponent();
            Data.Data.Reload();
        }

        #endregion

        #region LoadFrom

        private void LoadDgvDauSach()
        {
            string key = txtTimKiem.Text;
            int i = 0;
            dgvDauSach.DataSource = DauSach_Service.DauSachS.ToList()
                                    .Where(p => p.TEN.ToUpper().Contains(key.ToUpper()) || p.TACGIA.ToUpper().Contains(key.ToUpper()))
                                    .Select(p => new
                                    {
                                        ID = p.ID,
                                        STT = ++i,
                                        TenSach = p.TEN,
                                        TacGia = p.TACGIA
                                    })
                                    .ToList();

            // cập nhật lại index
            try
            {
                index = index1;
                dgvDauSach.Rows[index].Cells["STT"].Selected = true;
                dgvDauSach.Select();
            }
            catch { }
        }
        private void FrmQuanLyDauSach_Load(object sender, EventArgs e)
        {
            LoadDgvDauSach();
            groupThongTin.Enabled = false;
        }
        #endregion
        #region Hàm chức năng
        private bool Check()
        {
            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Tên sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTacGia.Text == "")
            {
                MessageBox.Show("Tên tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void ClearControl()
        {
            txtTacGia.Text = "";
            txtTenSach.Text = "";
        }
        private void UpdateDetail()
        {
            DAUSACH tg = getItemById();
            if (tg.ID == 0) return;
            txtTacGia.Text = tg.TACGIA;
            txtTenSach.Text = tg.TEN;
        }
        private DAUSACH getItemById()
        {
            try
            {
                int id = (int)dgvDauSach.SelectedRows[0].Cells["ID"].Value;
                return DauSach_Service.FindEntity(id);
            }
            catch
            {
                // k có dòng nào đang được chọn
            }
            return new DAUSACH();
        }

        private DAUSACH getItemByForm()
        {
            DAUSACH ans = new DAUSACH();
            ans.TEN = txtTenSach.Text;
            ans.TACGIA = txtTacGia.Text;
            return ans;
        }

        #endregion

        #region Sự kiện ngầm
        private void dgvDauSach_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index1 = index;
                index = dgvDauSach.SelectedRows[0].Index;
                UpdateDetail();
            }
            catch { }
        }
        #endregion

    }
}
