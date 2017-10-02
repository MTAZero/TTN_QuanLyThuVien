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

        #region sự kiện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ClearControl();
            LoadDgvDauSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {

                btnThem.Text = "Lưu";
                btnSua.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvDauSach.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;

                ClearControl();

                return;
            }

            if (btnThem.Text == "Lưu")
            {
                if (Check())
                {

                    btnThem.Text = "Thêm";
                    btnSua.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvDauSach.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    DAUSACH tg = getItemByForm();
                    bool ok = DauSach_Service.Insert(tg);

                    if (ok)
                    {
                        MessageBox.Show("Thêm đầu sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm đầu sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvDauSach();
                }

                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DAUSACH tg = getItemById();
            if (tg.ID == 0)
            {
                MessageBox.Show("Chưa có đầu sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnThem.Enabled = false;
                btnXoa.Text = "Hủy";

                groupThongTin.Enabled = true;
                dgvDauSach.Enabled = false;

                btnTimKiem.Enabled = false;
                txtTimKiem.Enabled = false;
                return;
            }

            if (btnSua.Text == "Lưu")
            {
                if (Check())
                {
                    btnSua.Text = "Sửa";
                    btnThem.Enabled = true;
                    btnXoa.Text = "Xóa";

                    groupThongTin.Enabled = false;
                    dgvDauSach.Enabled = true;

                    btnTimKiem.Enabled = true;
                    txtTimKiem.Enabled = true;

                    DAUSACH tgs = getItemByForm();
                    bool ok = DauSach_Service.Update(tgs, tg.ID);

                    if (ok)
                    {
                        MessageBox.Show("Sửa thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    LoadDgvDauSach();
                }

                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnXoa.Text == "Xóa")
            {
                DAUSACH tg = getItemById();
                if (tg.ID == 0)
                {
                    MessageBox.Show("Chưa có đầu sách nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa đầu sách này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Cancel) return;

                bool xoa = DauSach_Service.Delete(tg);
                if (xoa)
                {
                    MessageBox.Show("Xóa đầu sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa đầu sách thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadDgvDauSach();

                return;
            }

            if (btnXoa.Text == "Hủy")
            {
                btnXoa.Text = "Xóa";
                btnThem.Text = "Thêm";
                btnSua.Text = "Sửa";

                btnThem.Enabled = true;
                btnSua.Enabled = true;

                groupThongTin.Enabled = false;
                dgvDauSach.Enabled = true;

                btnTimKiem.Enabled = true;
                txtTimKiem.Enabled = true;

                UpdateDetail();

                return;
            }
        }
        #endregion

    }
}
