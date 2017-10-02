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


    }
}
