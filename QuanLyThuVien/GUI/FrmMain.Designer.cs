namespace QuanLyThuVien.GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnHuongDanSuDung = new System.Windows.Forms.Button();
            this.btnQuanLyMuonTra = new System.Windows.Forms.Button();
            this.btnDocGia = new System.Windows.Forms.Button();
            this.btnDauSach = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelMain);
            this.panel1.Controls.Add(this.PanelMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 701);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1112, 699);
            this.panelMain.TabIndex = 1;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMenu.Controls.Add(this.btnDong);
            this.PanelMenu.Controls.Add(this.btnHuongDanSuDung);
            this.PanelMenu.Controls.Add(this.btnQuanLyMuonTra);
            this.PanelMenu.Controls.Add(this.btnDocGia);
            this.PanelMenu.Controls.Add(this.btnDauSach);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 699);
            this.PanelMenu.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.White;
            this.btnDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDong.FlatAppearance.BorderSize = 2;
            this.btnDong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDong.Location = new System.Drawing.Point(2, 427);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(213, 100);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "ĐÓNG";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnHuongDanSuDung
            // 
            this.btnHuongDanSuDung.BackColor = System.Drawing.Color.White;
            this.btnHuongDanSuDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHuongDanSuDung.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHuongDanSuDung.FlatAppearance.BorderSize = 2;
            this.btnHuongDanSuDung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHuongDanSuDung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHuongDanSuDung.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuongDanSuDung.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuongDanSuDung.ForeColor = System.Drawing.Color.Black;
            this.btnHuongDanSuDung.Image = ((System.Drawing.Image)(resources.GetObject("btnHuongDanSuDung.Image")));
            this.btnHuongDanSuDung.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHuongDanSuDung.Location = new System.Drawing.Point(2, 321);
            this.btnHuongDanSuDung.Name = "btnHuongDanSuDung";
            this.btnHuongDanSuDung.Size = new System.Drawing.Size(213, 100);
            this.btnHuongDanSuDung.TabIndex = 5;
            this.btnHuongDanSuDung.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.btnHuongDanSuDung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHuongDanSuDung.UseVisualStyleBackColor = false;
            this.btnHuongDanSuDung.Click += new System.EventHandler(this.btnHuongDanSuDung_Click);
            // 
            // btnQuanLyMuonTra
            // 
            this.btnQuanLyMuonTra.BackColor = System.Drawing.Color.White;
            this.btnQuanLyMuonTra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuanLyMuonTra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLyMuonTra.FlatAppearance.BorderSize = 2;
            this.btnQuanLyMuonTra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuanLyMuonTra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnQuanLyMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyMuonTra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyMuonTra.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyMuonTra.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanLyMuonTra.Image")));
            this.btnQuanLyMuonTra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuanLyMuonTra.Location = new System.Drawing.Point(2, 215);
            this.btnQuanLyMuonTra.Name = "btnQuanLyMuonTra";
            this.btnQuanLyMuonTra.Size = new System.Drawing.Size(213, 100);
            this.btnQuanLyMuonTra.TabIndex = 4;
            this.btnQuanLyMuonTra.Text = "QUẢN LÝ MƯỢN TRẢ";
            this.btnQuanLyMuonTra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuanLyMuonTra.UseVisualStyleBackColor = false;
            this.btnQuanLyMuonTra.Click += new System.EventHandler(this.btnQuanLyMuonTra_Click);
            // 
            // btnDocGia
            // 
            this.btnDocGia.BackColor = System.Drawing.Color.White;
            this.btnDocGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDocGia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDocGia.FlatAppearance.BorderSize = 2;
            this.btnDocGia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDocGia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDocGia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocGia.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocGia.ForeColor = System.Drawing.Color.Black;
            this.btnDocGia.Image = ((System.Drawing.Image)(resources.GetObject("btnDocGia.Image")));
            this.btnDocGia.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDocGia.Location = new System.Drawing.Point(2, 109);
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.Size = new System.Drawing.Size(213, 100);
            this.btnDocGia.TabIndex = 3;
            this.btnDocGia.Text = "QUẢN LÝ ĐỘC GIẢ";
            this.btnDocGia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocGia.UseVisualStyleBackColor = false;
            this.btnDocGia.Click += new System.EventHandler(this.btnDocGia_Click);
            // 
            // btnDauSach
            // 
            this.btnDauSach.BackColor = System.Drawing.Color.White;
            this.btnDauSach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDauSach.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDauSach.FlatAppearance.BorderSize = 2;
            this.btnDauSach.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDauSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDauSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDauSach.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDauSach.ForeColor = System.Drawing.Color.Black;
            this.btnDauSach.Image = ((System.Drawing.Image)(resources.GetObject("btnDauSach.Image")));
            this.btnDauSach.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDauSach.Location = new System.Drawing.Point(2, 3);
            this.btnDauSach.Name = "btnDauSach";
            this.btnDauSach.Size = new System.Drawing.Size(213, 100);
            this.btnDauSach.TabIndex = 2;
            this.btnDauSach.Text = "QUẢN LÝ ĐẦU SÁCH";
            this.btnDauSach.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDauSach.UseVisualStyleBackColor = false;
            this.btnDauSach.Click += new System.EventHandler(this.btnDauSach_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.panel1.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnDauSach;
        private System.Windows.Forms.Button btnQuanLyMuonTra;
        private System.Windows.Forms.Button btnDocGia;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuongDanSuDung;
    }
}