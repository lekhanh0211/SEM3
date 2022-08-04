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
    public partial class frmNhanVien : Form
    {
        private Sem3DataContext db;
        int empId;

        public frmNhanVien()
        {
            db = new Sem3DataContext();
            InitializeComponent();
            Load_NhanVien();
        }
        private void Load_NhanVien()
        {
            dgvNhanVien.DataSource = from e in db.NhanViens
                                     select new
                                     {
                                         id = e.id,
                                         name = e.name,
                                         user = e.username,
                                         pass = e.password,
                                         birthday = e.birthday,
                                         phone = e.phone,
                                         address = e.address
                                     };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.name = txtName.Text;
            nv.username = txtUser.Text;
            nv.password = txtPass.Text;
            nv.phone = txtPhone.Text;
            nv.address = txtAddress.Text;
            nv.birthday = txtBirthday.Value;
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            Load_NhanVien();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var nv = db.NhanViens.SingleOrDefault(x => x.id == empId);
            nv.name = txtName.Text;
            nv.username = txtUser.Text;
            nv.password = txtPass.Text;
            nv.phone = txtPhone.Text;
            nv.address = txtAddress.Text;
            nv.birthday = txtBirthday.Value;
            db.SubmitChanges();
            Load_NhanVien();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa nhân viên!",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var nv = db.NhanViens.SingleOrDefault(x => x.id == empId);
                db.NhanViens.DeleteOnSubmit(nv);
                db.SubmitChanges();
                Load_NhanVien();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUser.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtBirthday.Value = DateTime.Now;
            txtPass.Text = "";
            txtRePass.Text = "";

        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                var row = dgvNhanVien.CurrentRow;
                empId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["fullname"].Value.ToString();
                txtAddress.Text = row.Cells["address"].Value.ToString();
                txtUser.Text = row.Cells["username"].Value.ToString();
                txtBirthday.Value = (DateTime)row.Cells["birthday"].Value;
                txtPhone.Text = row.Cells["phone"].Value.ToString();
            }
        }

       
    }
}
