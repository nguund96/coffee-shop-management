using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Program.NhanVienDangDangNhap.Quyen.Value == false)
            {
                TSMI_NhanSu.Visible = false;
                TSB_DiemDanh.Visible = false;
                TSMI_DMPhieuChi.Visible = false;
                TSB_PhieuChi.Visible = false;
            }
            TSL_Welcome_Click(new ToolStripLabel(), new EventArgs());

            this.Text = "Quản lý quán coffee -- " + Program.NhanVienDangDangNhap.MaNV + " -- " + Program.NhanVienDangDangNhap.HoTen + " -- " + "[" + (Program.NhanVienDangDangNhap.Quyen == true ? "Admin" : "Nhân viên") + "]";
        }
        #region ToolStripLable Welcome
        private void TSL_Welcome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            // Load form welcome
            frmWelcome frm = new frmWelcome();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Parent = panel1;
            frm.Show();
            panel1.Controls.Add(frm);
        }
        private void TSL_Welcome_MouseMove(object sender, MouseEventArgs e)
        {
            TSL_Welcome.ForeColor = Color.Blue;
        }
        private void TSL_Welcome_MouseLeave(object sender, EventArgs e)
        {
            TSL_Welcome.ForeColor = Color.Black;
        }
        #endregion
        
        
    }
}
