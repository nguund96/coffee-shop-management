namespace CoffeeShopManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.TSL_Welcome = new System.Windows.Forms.ToolStripLabel();
            this.TSB_PhieuChi = new System.Windows.Forms.ToolStripButton();
            this.TSB_NhapHangVaoKho = new System.Windows.Forms.ToolStripButton();
            this.TSB_HoaDon = new System.Windows.Forms.ToolStripButton();
            this.TSB_QuanLyBanHang = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_DiemDanh = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TSMI_ThongTinPhanMem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ThongTinQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DiemDanh = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CaLamViec = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DanhMucNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_NhanSu = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMPhieuChi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.hoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_QuanLyBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_NhapHangVaoKho = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ThongKeDoanhThuThang = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ThongKeDoanhThuNgay = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ThongKeMon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_LichSuHoatDong = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMMon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMLoaiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMBan = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_DMKhuVuc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSL_Welcome
            // 
            this.TSL_Welcome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_Welcome.ForeColor = System.Drawing.Color.Black;
            this.TSL_Welcome.Image = ((System.Drawing.Image)(resources.GetObject("TSL_Welcome.Image")));
            this.TSL_Welcome.Name = "TSL_Welcome";
            this.TSL_Welcome.Size = new System.Drawing.Size(138, 49);
            this.TSL_Welcome.Text = "Coffee Store Manager";
            this.TSL_Welcome.Click += new System.EventHandler(this.TSL_Welcome_Click);
            this.TSL_Welcome.MouseLeave += new System.EventHandler(this.TSL_Welcome_MouseLeave);
            this.TSL_Welcome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TSL_Welcome_MouseMove);
            // 
            // TSB_PhieuChi
            // 
            this.TSB_PhieuChi.Image = global::CoffeeShopManager.Properties.Resources.register;
            this.TSB_PhieuChi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_PhieuChi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_PhieuChi.Name = "TSB_PhieuChi";
            this.TSB_PhieuChi.Size = new System.Drawing.Size(85, 49);
            this.TSB_PhieuChi.Text = "Phiếu chi";
            // 
            // TSB_NhapHangVaoKho
            // 
            this.TSB_NhapHangVaoKho.Image = global::CoffeeShopManager.Properties.Resources.export;
            this.TSB_NhapHangVaoKho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_NhapHangVaoKho.Name = "TSB_NhapHangVaoKho";
            this.TSB_NhapHangVaoKho.Size = new System.Drawing.Size(86, 49);
            this.TSB_NhapHangVaoKho.Text = "Nhập hàng";
            // 
            // TSB_HoaDon
            // 
            this.TSB_HoaDon.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSB_HoaDon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_HoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_HoaDon.Name = "TSB_HoaDon";
            this.TSB_HoaDon.Size = new System.Drawing.Size(82, 49);
            this.TSB_HoaDon.Text = "Hóa đơn";
            // 
            // TSB_QuanLyBanHang
            // 
            this.TSB_QuanLyBanHang.Image = global::CoffeeShopManager.Properties.Resources.edit;
            this.TSB_QuanLyBanHang.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_QuanLyBanHang.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_QuanLyBanHang.Name = "TSB_QuanLyBanHang";
            this.TSB_QuanLyBanHang.Size = new System.Drawing.Size(130, 49);
            this.TSB_QuanLyBanHang.Text = "Quản lý bán hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_QuanLyBanHang,
            this.TSB_HoaDon,
            this.TSB_NhapHangVaoKho,
            this.TSB_PhieuChi,
            this.TSB_DiemDanh,
            this.TSL_Welcome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 52);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSB_DiemDanh
            // 
            this.TSB_DiemDanh.Image = global::CoffeeShopManager.Properties.Resources.diemdanh;
            this.TSB_DiemDanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_DiemDanh.Name = "TSB_DiemDanh";
            this.TSB_DiemDanh.Size = new System.Drawing.Size(85, 49);
            this.TSB_DiemDanh.Text = "Điểm danh";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 522);
            this.panel1.TabIndex = 5;
            // 
            // TSMI_ThongTinPhanMem
            // 
            this.TSMI_ThongTinPhanMem.Image = global::CoffeeShopManager.Properties.Resources.info_circle_outline_512;
            this.TSMI_ThongTinPhanMem.Name = "TSMI_ThongTinPhanMem";
            this.TSMI_ThongTinPhanMem.Size = new System.Drawing.Size(187, 22);
            this.TSMI_ThongTinPhanMem.Text = "Thông tin phần mềm";
            // 
            // TSMI_ThongTinQuan
            // 
            this.TSMI_ThongTinQuan.Image = global::CoffeeShopManager.Properties.Resources.info_alt_128;
            this.TSMI_ThongTinQuan.Name = "TSMI_ThongTinQuan";
            this.TSMI_ThongTinQuan.Size = new System.Drawing.Size(187, 22);
            this.TSMI_ThongTinQuan.Text = "Thông tin quán";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_ThongTinQuan,
            this.TSMI_ThongTinPhanMem});
            this.trợGiúpToolStripMenuItem.Image = global::CoffeeShopManager.Properties.Resources.register;
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.trợGiúpToolStripMenuItem.Text = "Khác";
            // 
            // TSMI_TinhLuong
            // 
            this.TSMI_TinhLuong.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_TinhLuong.Name = "TSMI_TinhLuong";
            this.TSMI_TinhLuong.Size = new System.Drawing.Size(184, 22);
            this.TSMI_TinhLuong.Text = "Tính lương";
            // 
            // TSMI_DiemDanh
            // 
            this.TSMI_DiemDanh.Image = global::CoffeeShopManager.Properties.Resources.diemdanh;
            this.TSMI_DiemDanh.Name = "TSMI_DiemDanh";
            this.TSMI_DiemDanh.Size = new System.Drawing.Size(184, 22);
            this.TSMI_DiemDanh.Text = "Điểm danh";
            // 
            // TSMI_CaLamViec
            // 
            this.TSMI_CaLamViec.Image = global::CoffeeShopManager.Properties.Resources.Calamviec;
            this.TSMI_CaLamViec.Name = "TSMI_CaLamViec";
            this.TSMI_CaLamViec.Size = new System.Drawing.Size(184, 22);
            this.TSMI_CaLamViec.Text = "Ca làm việc";
            // 
            // TSMI_DanhMucNhanVien
            // 
            this.TSMI_DanhMucNhanVien.Image = global::CoffeeShopManager.Properties.Resources.Trainer;
            this.TSMI_DanhMucNhanVien.Name = "TSMI_DanhMucNhanVien";
            this.TSMI_DanhMucNhanVien.Size = new System.Drawing.Size(184, 22);
            this.TSMI_DanhMucNhanVien.Text = "Danh mục nhân viên";
            // 
            // TSMI_NhanSu
            // 
            this.TSMI_NhanSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DanhMucNhanVien,
            this.TSMI_CaLamViec,
            this.TSMI_DiemDanh,
            this.TSMI_TinhLuong});
            this.TSMI_NhanSu.Image = global::CoffeeShopManager.Properties.Resources.group;
            this.TSMI_NhanSu.Name = "TSMI_NhanSu";
            this.TSMI_NhanSu.Size = new System.Drawing.Size(79, 20);
            this.TSMI_NhanSu.Text = "Nhân sự";
            // 
            // TSMI_DMHoaDon
            // 
            this.TSMI_DMHoaDon.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMHoaDon.Name = "TSMI_DMHoaDon";
            this.TSMI_DMHoaDon.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMHoaDon.Text = "Hóa đơn";
            // 
            // TSMI_DMPhieuChi
            // 
            this.TSMI_DMPhieuChi.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMPhieuChi.Name = "TSMI_DMPhieuChi";
            this.TSMI_DMPhieuChi.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMPhieuChi.Text = "Phiếu chi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.hoạtĐộngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.TSMI_NhanSu,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(970, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DoiMatKhau,
            this.TSMI_DangXuat});
            this.hệThốngToolStripMenuItem.Image = global::CoffeeShopManager.Properties.Resources.settings;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // TSMI_DoiMatKhau
            // 
            this.TSMI_DoiMatKhau.Image = global::CoffeeShopManager.Properties.Resources.edit;
            this.TSMI_DoiMatKhau.Name = "TSMI_DoiMatKhau";
            this.TSMI_DoiMatKhau.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // TSMI_DangXuat
            // 
            this.TSMI_DangXuat.Image = global::CoffeeShopManager.Properties.Resources.logout;
            this.TSMI_DangXuat.Name = "TSMI_DangXuat";
            this.TSMI_DangXuat.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DangXuat.Text = "Đăng xuất";
            // 
            // hoạtĐộngToolStripMenuItem
            // 
            this.hoạtĐộngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_QuanLyBanHang,
            this.TSMI_NhapHangVaoKho,
            this.TSMI_ThongKeDoanhThuThang,
            this.TSMI_ThongKeDoanhThuNgay,
            this.TSMI_ThongKeMon,
            this.TSMI_LichSuHoatDong});
            this.hoạtĐộngToolStripMenuItem.Image = global::CoffeeShopManager.Properties.Resources.attendance;
            this.hoạtĐộngToolStripMenuItem.Name = "hoạtĐộngToolStripMenuItem";
            this.hoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.hoạtĐộngToolStripMenuItem.Text = "Hoạt động";
            // 
            // TSMI_QuanLyBanHang
            // 
            this.TSMI_QuanLyBanHang.Image = global::CoffeeShopManager.Properties.Resources.edit;
            this.TSMI_QuanLyBanHang.Name = "TSMI_QuanLyBanHang";
            this.TSMI_QuanLyBanHang.Size = new System.Drawing.Size(216, 22);
            this.TSMI_QuanLyBanHang.Text = "Quản lý bán hàng";
            // 
            // TSMI_NhapHangVaoKho
            // 
            this.TSMI_NhapHangVaoKho.Image = global::CoffeeShopManager.Properties.Resources.export;
            this.TSMI_NhapHangVaoKho.Name = "TSMI_NhapHangVaoKho";
            this.TSMI_NhapHangVaoKho.Size = new System.Drawing.Size(216, 22);
            this.TSMI_NhapHangVaoKho.Text = "Nhập hàng vào kho";
            // 
            // TSMI_ThongKeDoanhThuThang
            // 
            this.TSMI_ThongKeDoanhThuThang.Image = global::CoffeeShopManager.Properties.Resources.level;
            this.TSMI_ThongKeDoanhThuThang.Name = "TSMI_ThongKeDoanhThuThang";
            this.TSMI_ThongKeDoanhThuThang.Size = new System.Drawing.Size(216, 22);
            this.TSMI_ThongKeDoanhThuThang.Text = "Thống kê doanh thu tháng";
            // 
            // TSMI_ThongKeDoanhThuNgay
            // 
            this.TSMI_ThongKeDoanhThuNgay.Image = global::CoffeeShopManager.Properties.Resources.level;
            this.TSMI_ThongKeDoanhThuNgay.Name = "TSMI_ThongKeDoanhThuNgay";
            this.TSMI_ThongKeDoanhThuNgay.Size = new System.Drawing.Size(216, 22);
            this.TSMI_ThongKeDoanhThuNgay.Text = "Thống kê doanh thu ngày";
            // 
            // TSMI_ThongKeMon
            // 
            this.TSMI_ThongKeMon.Image = global::CoffeeShopManager.Properties.Resources.level;
            this.TSMI_ThongKeMon.Name = "TSMI_ThongKeMon";
            this.TSMI_ThongKeMon.Size = new System.Drawing.Size(216, 22);
            this.TSMI_ThongKeMon.Text = "Thống kê món";
            // 
            // TSMI_LichSuHoatDong
            // 
            this.TSMI_LichSuHoatDong.Image = global::CoffeeShopManager.Properties.Resources.overtime;
            this.TSMI_LichSuHoatDong.Name = "TSMI_LichSuHoatDong";
            this.TSMI_LichSuHoatDong.Size = new System.Drawing.Size(216, 22);
            this.TSMI_LichSuHoatDong.Text = "Lịch sử hoạt động";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_DMMon,
            this.TSMI_DMLoaiMon,
            this.TSMI_DMBan,
            this.TSMI_DMKhuVuc,
            this.TSMI_DMPhieuChi,
            this.TSMI_DMHoaDon});
            this.danhMụcToolStripMenuItem.Image = global::CoffeeShopManager.Properties.Resources.course;
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // TSMI_DMMon
            // 
            this.TSMI_DMMon.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMMon.Name = "TSMI_DMMon";
            this.TSMI_DMMon.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMMon.Text = "Món";
            // 
            // TSMI_DMLoaiMon
            // 
            this.TSMI_DMLoaiMon.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMLoaiMon.Name = "TSMI_DMLoaiMon";
            this.TSMI_DMLoaiMon.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMLoaiMon.Text = "Loại món";
            // 
            // TSMI_DMBan
            // 
            this.TSMI_DMBan.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMBan.Name = "TSMI_DMBan";
            this.TSMI_DMBan.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMBan.Text = "Bàn";
            // 
            // TSMI_DMKhuVuc
            // 
            this.TSMI_DMKhuVuc.Image = global::CoffeeShopManager.Properties.Resources.transcrpit;
            this.TSMI_DMKhuVuc.Name = "TSMI_DMKhuVuc";
            this.TSMI_DMKhuVuc.Size = new System.Drawing.Size(152, 22);
            this.TSMI_DMKhuVuc.Text = "Khu vực";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 601);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel TSL_Welcome;
        private System.Windows.Forms.ToolStripButton TSB_PhieuChi;
        private System.Windows.Forms.ToolStripButton TSB_NhapHangVaoKho;
        private System.Windows.Forms.ToolStripButton TSB_HoaDon;
        private System.Windows.Forms.ToolStripButton TSB_QuanLyBanHang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSB_DiemDanh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongTinPhanMem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongTinQuan;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TinhLuong;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DiemDanh;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CaLamViec;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DanhMucNhanVien;
        private System.Windows.Forms.ToolStripMenuItem TSMI_NhanSu;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMHoaDon;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMPhieuChi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem hoạtĐộngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_QuanLyBanHang;
        private System.Windows.Forms.ToolStripMenuItem TSMI_NhapHangVaoKho;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongKeDoanhThuThang;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongKeDoanhThuNgay;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ThongKeMon;
        private System.Windows.Forms.ToolStripMenuItem TSMI_LichSuHoatDong;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMMon;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMLoaiMon;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMBan;
        private System.Windows.Forms.ToolStripMenuItem TSMI_DMKhuVuc;
    }
}