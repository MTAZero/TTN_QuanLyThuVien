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
    public partial class FrmMain : Form
    {
        #region constructor
        public FrmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region sự kiện
        private void btnDauSach_Click(object sender, EventArgs e)
        {
            FrmQuanLyDauSach tg = new FrmQuanLyDauSach();
            panelMain.Controls.Clear();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Add(tg);
            tg.Show();
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            FrmQuanLyDocGia tg = new FrmQuanLyDocGia();
            panelMain.Controls.Clear();
            tg.TopLevel = false;
            tg.Dock = DockStyle.Fill;
            panelMain.Controls.Add(tg);
            tg.Show();
        }



    }
}
