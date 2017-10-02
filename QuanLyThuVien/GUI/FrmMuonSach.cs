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
    public partial class FrmMuonSach : Form
    {

        private DOCGIA docgia = new DOCGIA();

        #region Hàm khởi tạo
        public FrmMuonSach(DOCGIA a)
        {
            InitializeComponent();
            docgia = a;
        }

        #endregion

        #region LoadForm
        private void FrmMuonSach_Load(object sender, EventArgs e)
        {
            cbxDauSach.DataSource = new DauSachF().DauSachS.ToList();
            cbxDauSach.DisplayMember = "TEN";
            cbxDauSach.ValueMember = "ID";
        }
        #endregion

        #region Sự kiện
        private void btnMuon_Click(object sender, EventArgs e)
        {
            MUONTRA tg = new MUONTRA();
            tg.DAUSACHID = (int)cbxDauSach.SelectedValue;
            tg.NGAYMUON = dateNgayMuon.Value;
            tg.DOCGIAID = docgia.ID;
            tg.TRANGTHAI = 0;
            tg.NGAYTRA = (DateTime.Now);

            bool ok = new MuonTraF().Insert(tg);
            if (ok)
            {
                MessageBox.Show("Thêm phiếu mượn thành công",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phiếu mượn thất bại",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}
