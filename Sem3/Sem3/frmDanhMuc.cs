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
    public partial class frmDanhMuc : Form
    {
        private Sem3DataContext db;
        int catId;
        public frmDanhMuc()
        {
            db = new Sem3DataContext();
            InitializeComponent();
            Load_DanhMuc();

        }
        private void Load_DanhMuc()
        {
            dgvDanhMuc.DataSource = from p in db.DanhMucs
                                    select new
                                    {
                                        id = p.id,
                                        name = p.name,
                                        status = p.status
                                    };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.name = txtName.Text;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên danh mục không được để trống!");
                return;

            }
            dm.status = cbStatus.Checked;
            db.DanhMucs.InsertOnSubmit(dm);
            db.SubmitChanges();
            Load_DanhMuc();
            resetForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var dm = db.DanhMucs.SingleOrDefault(x => x.id == catId);
            dm.name = txtName.Text;
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên danh mục");
                return;

            }
            dm.status = cbStatus.Checked;

            db.SubmitChanges();
            Load_DanhMuc();
            resetForm();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa danh mục!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var dm = db.DanhMucs.SingleOrDefault(x => x.id == catId);
                db.DanhMucs.DeleteOnSubmit(dm);
                db.SubmitChanges();
                Load_DanhMuc();
                resetForm();
            }
        }
        private void resetForm()
        {
            txtName.Text = "";
            cbStatus.Checked = true;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow != null)
            {
                var row = dgvDanhMuc.CurrentRow;
                catId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["catName"].Value.ToString();
                cbStatus.Checked = row.Cells["status"].Value.Equals(true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
