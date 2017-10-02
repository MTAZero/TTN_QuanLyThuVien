namespace QuanLyThuVien.GUI
{
    partial class FrmQuanLyMuonTra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMuonTra = new System.Windows.Forms.Panel();
            this.groupDocGia = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMuon = new System.Windows.Forms.DataGridView();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnMuon = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.IDMuonTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STTDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSachDangMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            this.panelMuonTra.SuspendLayout();
            this.groupDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).BeginInit();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupDocGia);
            this.panel1.Controls.Add(this.panelMuonTra);
            this.panel1.Controls.Add(this.panelTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 699);
            this.panel1.TabIndex = 0;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimKiem.Controls.Add(this.btnTimKiem);
            this.panelTimKiem.Controls.Add(this.txtTimKiem);
            this.panelTimKiem.Controls.Add(this.label1);
            this.panelTimKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimKiem.Location = new System.Drawing.Point(0, 0);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(1110, 65);
            this.panelTimKiem.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(436, 17);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(119, 24);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(113, 17);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(304, 24);
            this.txtTimKiem.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
            // 
            // panelMuonTra
            // 
            this.panelMuonTra.Controls.Add(this.panelChucNang);
            this.panelMuonTra.Controls.Add(this.panel2);
            this.panelMuonTra.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMuonTra.Location = new System.Drawing.Point(572, 65);
            this.panelMuonTra.Name = "panelMuonTra";
            this.panelMuonTra.Size = new System.Drawing.Size(538, 632);
            this.panelMuonTra.TabIndex = 1;
            // 
            // groupDocGia
            // 
            this.groupDocGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupDocGia.Controls.Add(this.dgvDocGia);
            this.groupDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDocGia.Location = new System.Drawing.Point(0, 65);
            this.groupDocGia.Name = "groupDocGia";
            this.groupDocGia.Size = new System.Drawing.Size(572, 632);
            this.groupDocGia.TabIndex = 3;
            this.groupDocGia.TabStop = false;
            this.groupDocGia.Text = "Danh sách độc giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToResizeColumns = false;
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDocGia.ColumnHeadersHeight = 30;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.STTDocGia,
            this.MaDocGia,
            this.HoTen,
            this.SoSachDangMuon});
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.EnableHeadersVisualStyles = false;
            this.dgvDocGia.GridColor = System.Drawing.Color.Black;
            this.dgvDocGia.Location = new System.Drawing.Point(3, 20);
            this.dgvDocGia.MultiSelect = false;
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.ReadOnly = true;
            this.dgvDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDocGia.RowHeadersWidth = 25;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDocGia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocGia.RowTemplate.Height = 30;
            this.dgvDocGia.RowTemplate.ReadOnly = true;
            this.dgvDocGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocGia.Size = new System.Drawing.Size(566, 609);
            this.dgvDocGia.TabIndex = 3;
            this.dgvDocGia.SelectionChanged += new System.EventHandler(this.dgvDocGia_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 373);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.dgvMuon);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 373);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đang mượn";
            // 
            // dgvMuon
            // 
            this.dgvMuon.AllowUserToResizeColumns = false;
            this.dgvMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvMuon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMuon.ColumnHeadersHeight = 30;
            this.dgvMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMuonTra,
            this.STT,
            this.NgayMuon,
            this.TenSach});
            this.dgvMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMuon.EnableHeadersVisualStyles = false;
            this.dgvMuon.GridColor = System.Drawing.Color.Black;
            this.dgvMuon.Location = new System.Drawing.Point(3, 20);
            this.dgvMuon.MultiSelect = false;
            this.dgvMuon.Name = "dgvMuon";
            this.dgvMuon.ReadOnly = true;
            this.dgvMuon.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMuon.RowHeadersWidth = 25;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMuon.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMuon.RowTemplate.Height = 30;
            this.dgvMuon.RowTemplate.ReadOnly = true;
            this.dgvMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuon.Size = new System.Drawing.Size(532, 350);
            this.dgvMuon.TabIndex = 3;
            // 
            // panelChucNang
            // 
            this.panelChucNang.Controls.Add(this.btnTra);
            this.panelChucNang.Controls.Add(this.btnMuon);
            this.panelChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChucNang.Location = new System.Drawing.Point(0, 373);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(538, 53);
            this.panelChucNang.TabIndex = 1;
            // 
            // btnMuon
            // 
            this.btnMuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuon.ForeColor = System.Drawing.Color.Black;
            this.btnMuon.Location = new System.Drawing.Point(6, 6);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(259, 39);
            this.btnMuon.TabIndex = 11;
            this.btnMuon.Text = "Mượn sách";
            this.btnMuon.UseVisualStyleBackColor = false;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // btnTra
            // 
            this.btnTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTra.ForeColor = System.Drawing.Color.Black;
            this.btnTra.Location = new System.Drawing.Point(280, 6);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(255, 39);
            this.btnTra.TabIndex = 12;
            this.btnTra.Text = "Trả sách";
            this.btnTra.UseVisualStyleBackColor = false;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // IDMuonTra
            // 
            this.IDMuonTra.DataPropertyName = "ID";
            this.IDMuonTra.HeaderText = "ID";
            this.IDMuonTra.Name = "IDMuonTra";
            this.IDMuonTra.ReadOnly = true;
            this.IDMuonTra.Visible = false;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.FillWeight = 5F;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.FillWeight = 15F;
            this.NgayMuon.HeaderText = "Ngày mượn";
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.ReadOnly = true;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.FillWeight = 25F;
            this.TenSach.HeaderText = "Đầu sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // STTDocGia
            // 
            this.STTDocGia.DataPropertyName = "STT";
            this.STTDocGia.FillWeight = 8F;
            this.STTDocGia.HeaderText = "STT";
            this.STTDocGia.Name = "STTDocGia";
            this.STTDocGia.ReadOnly = true;
            // 
            // MaDocGia
            // 
            this.MaDocGia.DataPropertyName = "MaDocGia";
            this.MaDocGia.FillWeight = 12F;
            this.MaDocGia.HeaderText = "Mã độc giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.FillWeight = 20F;
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // SoSachDangMuon
            // 
            this.SoSachDangMuon.DataPropertyName = "SoSachDangMuon";
            this.SoSachDangMuon.FillWeight = 18F;
            this.SoSachDangMuon.HeaderText = "Số sách đang mượn";
            this.SoSachDangMuon.Name = "SoSachDangMuon";
            this.SoSachDangMuon.ReadOnly = true;
            // 
            // FrmQuanLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 699);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQuanLyMuonTra";
            this.Text = "FrmQuanLyDocGia";
            this.Load += new System.EventHandler(this.FrmQuanLyMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panelTimKiem.ResumeLayout(false);
            this.panelTimKiem.PerformLayout();
            this.panelMuonTra.ResumeLayout(false);
            this.groupDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuon)).EndInit();
            this.panelChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupDocGia;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Panel panelMuonTra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMuon;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMuonTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn STTDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSachDangMuon;
    }
}