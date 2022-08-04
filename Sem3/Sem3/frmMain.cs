using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form CurrentForm;
        private void childForm(Form childForm)
        {
            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            CurrentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDM_Click(object sender, EventArgs e)
        {
            childForm(new frmDanhMuc());
            txtTitle.Text = btnDM.Text;
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            childForm(new frmSanPham());
            txtTitle.Text = btnSP.Text;
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            childForm(new frmHoaDon());
            txtTitle.Text = btnHD.Text;
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            childForm(new frmNhanVien());
            txtTitle.Text = btnNV.Text;
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            childForm(new frmThongKe());
            txtTitle.Text = btnTk.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (CurrentForm != null)
            {
                CurrentForm.Close();
            }
            txtTitle.Text = "Trang chủ";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
