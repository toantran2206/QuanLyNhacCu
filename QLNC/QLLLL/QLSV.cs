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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        private void QLSV_FormClosing(object sender, FormClosingEventArgs e)
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
        void LoadSV()
        {
            using (var sv = new QLNCEntities())
            {
                var sinhvien = from SinhVien in sv.SinhViens
                                orderby SinhVien.MaSV
                                select new
                                {
                                    ID = SinhVien.MaSV,
                                    Ten = SinhVien.TenSV,
                                    DienThoai = SinhVien.DienThoai,
                                    DiaChi = SinhVien.DiaChi,
                                    NgaySinh = SinhVien.NgaySinh
                                };
                dgvSV.DataSource = sinhvien.ToList();
            }
        }

        private void QLSV_Load(object sender, EventArgs e)
        {
            LoadSV();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaSV.Text = dgvSV.Rows[i].Cells[0].Value.ToString();
            txtTenSV.Text = dgvSV.Rows[i].Cells[1].Value.ToString();
            txtDT.Text = dgvSV.Rows[i].Cells[2].Value.ToString();
            txtDC.Text = dgvSV.Rows[i].Cells[3].Value.ToString();
            dtpNgaySinh.Text = dgvSV.Rows[i].Cells[4].Value.ToString();
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //txtMaSV.Text = dgvSV.Rows[i].Cells[0].ToString();
            //txtTenSV.Text = dgvSV.Rows[i].Cells[1];
            //txtDT.Text = dgvSV.Rows[i].Cells[2];
            //txtDC.Text = dgvSV.Rows[i].Cells[3];
            //txtNgaySinh.Text = dgvSV.Rows[i].Cells[4];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sv = new QLNCEntities())
                {
                    var sinhvien = new SinhVien()
                    {
                        MaSV = txtMaSV.Text,
                        TenSV = txtTenSV.Text,
                        DienThoai = txtDT.Text,
                        DiaChi = txtDC.Text,
                        NgaySinh= dtpNgaySinh.Value
                    };
                    sv.SinhViens.Add(sinhvien);
                    sv.SaveChanges();
                }
                LoadSV();
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
            string id = txtMaSV.Text.ToString();
            try
            {
                using (var sv = new QLNCEntities())
                {
                    SinhVien SVtoDel = sv.SinhViens.Find(id);
                    if (SVtoDel != null)
                    {
                        sv.SinhViens.Remove(SVtoDel);
                        sv.SaveChanges();
                    }

                }
                LoadSV();
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
                using (var sv = new QLNCEntities())
                {
                    string id = txtMaSV.Text.ToString();
                    SinhVien SVtoUpd = sv.SinhViens.Find(id);
                    if (SVtoUpd != null)
                    {
                        MessageBox.Show(sv.Entry(SVtoUpd).State.ToString());
                        SVtoUpd.TenSV = txtTenSV.Text;
                        SVtoUpd.DienThoai = txtDT.Text;
                        SVtoUpd.DiaChi = txtDC.Text;
                        SVtoUpd.NgaySinh = dtpNgaySinh.Value;
                        MessageBox.Show(sv.Entry(SVtoUpd).State.ToString());
                        sv.SaveChanges();
                    }
                }
                LoadSV();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
                //throw;
            }
        }
        //private static void Del(string id)
        //{
        //    using (var sv = new QLNCEntities())
        //    {
        //        SinhVien SVtoDel = new SinhVien() { MaSV = id };
        //        sv.Entry(SVtoDel).State = System.Data.Entity.EntityState.Deleted;

        //        try
        //        {
        //            sv.SaveChanges();
        //        }
        //        catch (SqlException ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //            //throw;
        //        }
                
        //    }

        }
    }

