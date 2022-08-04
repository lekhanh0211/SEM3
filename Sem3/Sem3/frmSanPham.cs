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
    public partial class frmSanPham : Form
    {
        private Sem3DataContext db;
        int proId;
        public frmSanPham()
        {
            db = new Sem3DataContext();
            InitializeComponent();
            Load_SanPham();
            Load_CboDanhMuc();
        }

        private void Load_SanPham()
        {
            dgvSanPham.DataSource = from p in db.SanPhams
                                    join c in db.DanhMucs on p.catId equals c.id
                                    select new
                                    {
                                        id = p.id,
                                        name = p.name,
                                        catId = c.id,
                                        catName = c.name,
                                        quantity = p.quantity,
                                        price = p.price,
                                        description = p.description,
                                        status = (bool)p.status ? "Còn hàng" : "Hết hàng"

                                    };
        }
        private void Load_CboDanhMuc()
        {
            cboCat.DataSource = db.DanhMucs;
            cboCat.ValueMember = "id";
            cboCat.DisplayMember = "name";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SanPham p = new SanPham();
            p.name = txtName.Text;
            p.description = txtDesc.Text;
            p.price = Convert.ToDouble(txtPrice.Text);
            p.quantity = Convert.ToInt32(txtQuantity.Text);
            p.status = cbStatus.Checked;
            p.catId = Convert.ToInt32(cboCat.SelectedValue);

            db.SanPhams.InsertOnSubmit(p);
            db.SubmitChanges();
            Load_SanPham();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var p = db.SanPhams.SingleOrDefault(x => x.id == proId);
            p.name = txtName.Text;
            p.description = txtDesc.Text;
            p.price = Convert.ToDouble(txtPrice.Text);
            p.quantity = Convert.ToInt32(txtQuantity.Text);
            p.status = cbStatus.Checked;
            p.catId = Convert.ToInt32(cboCat.SelectedValue);
            db.SubmitChanges();
            Load_SanPham();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xóa sản phẩm!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var p = db.SanPhams.SingleOrDefault(x => x.id == proId);
                db.SanPhams.DeleteOnSubmit(p);
                db.SubmitChanges();
                Load_SanPham();
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "";
            txtDesc.Text = "";
            txtQuantity.Text = "";
            cbStatus.Checked = true;
            cboCat.SelectedIndex = 0;

        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                var row = dgvSanPham.CurrentRow;
                proId = Convert.ToInt32(row.Cells["id"].Value);
                txtName.Text = row.Cells["proName"].Value.ToString();
                txtPrice.Text = row.Cells["price"].Value.ToString();
                txtDesc.Text = row.Cells["desc"].Value.ToString();
                txtQuantity.Text = row.Cells["quantity"].Value.ToString();
                cbStatus.Checked = row.Cells["status"].Value.Equals("Còn hàng");
                cboCat.SelectedValue = Convert.ToInt32(row.Cells["catId"].Value);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = from p in db.SanPhams
                                    join c in db.DanhMucs on p.catId equals c.id
                                    where p.name.ToLower().Contains(txtSearch.Text.ToLower()) ||
                                    c.name.ToLower().Contains(txtSearch.Text.ToLower())
                                    select new
                                    {
                                        id = p.id,
                                        name = p.name,
                                        catId = c.id,
                                        catName = c.name,
                                        quantity = p.quantity,
                                        price = p.price,
                                        description = p.description,
                                        status = (bool)p.status ? "Còn hàng" : "Hết hàng"

                                    };
        }
    }
}
