using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLLLL
{
    public partial class QLNC : Form
    {
        public QLNC()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void QLNC_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ans = MessageBox.Show("Bạn có muốn thoát không ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ans == DialogResult.OK)
            {
                e.Cancel = false;
            }
            if (ans == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        void LoadNC()
        {
            using (var nc = new QLNCEntities())
            {
                var nhaccu = from NhacCu in nc.NhacCus
                               orderby NhacCu.MaNC
                               select new
                               {
                                   ID = NhacCu.MaNC,
                                   Ten = NhacCu.TenNC,
                                   NhanHieu = NhacCu.NhanHieu,
                                   NamSX = NhacCu.NamSanXuat,
                                   DonGia = NhacCu.DonGia,
                                   MaLoai = NhacCu.MaLoaiNC
                               };
                dgvNC.DataSource = nhaccu.ToList();
            }
        }

        private void QLNC_Load(object sender, EventArgs e)
        {
            LoadNC();
        }

        private void dgvNC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaNC.Text = dgvNC.Rows[i].Cells[0].Value.ToString();
            txtTenNC.Text = dgvNC.Rows[i].Cells[1].Value.ToString();
            txtNH.Text = dgvNC.Rows[i].Cells[2].Value.ToString();
            txtNSX.Text = dgvNC.Rows[i].Cells[3].Value.ToString();
            txtDG.Text = dgvNC.Rows[i].Cells[4].Value.ToString();
            txtMaLoaiNC.Text = dgvNC.Rows[i].Cells[5].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var nc = new QLNCEntities())
                {
                    var nhaccu = new NhacCu()
                    {
                        MaNC = txtMaNC.Text,
                        TenNC = txtTenNC.Text,
                        NhanHieu = txtNH.Text,
                        NamSanXuat = txtNSX.Text,
                        DonGia = double.Parse(txtDG.Text),
                        MaLoaiNC = txtMaLoaiNC.Text
                    };
                    nc.NhacCus.Add(nhaccu);
                    nc.SaveChanges();
                }
                LoadNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
                //throw;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string id = txtMaNC.Text.ToString();
            try
            {
                using (var nc = new QLNCEntities())
                {
                    NhacCu NCtoDel = nc.NhacCus.Find(id);
                    if (NCtoDel != null)
                    {
                        nc.NhacCus.Remove(NCtoDel);
                        nc.SaveChanges();
                    }

                }
                LoadNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
                //throw;
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var nc = new QLNCEntities())
                {
                    string id = txtMaNC.Text.ToString();
                    NhacCu NCtoUpd = nc.NhacCus.Find(id);
                    if (NCtoUpd != null)
                    {
                        MessageBox.Show(nc.Entry(NCtoUpd).State.ToString());
                        NCtoUpd.TenNC = txtTenNC.Text;
                        NCtoUpd.NhanHieu = txtNH.Text;
                        NCtoUpd.NamSanXuat = txtNSX.Text;
                        NCtoUpd.DonGia = double.Parse(txtDG.Text);
                        NCtoUpd.MaLoaiNC = txtMaLoaiNC.Text;
                        MessageBox.Show(nc.Entry(NCtoUpd).State.ToString());
                        nc.SaveChanges();
                    }
                }
                LoadNC();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
                //throw;
            }
        }
    }
}
