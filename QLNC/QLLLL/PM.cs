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
    public partial class PM : Form
    {
        public PM()
        {
            InitializeComponent();
        }

        private void PM_FormClosing(object sender, FormClosingEventArgs e)
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
        void LoadPM()
        {
            using (var pm = new QLNCEntities())
            {
                var phieumuon = from PhieuMuon in pm.PhieuMuons
                                orderby PhieuMuon.MaNC
                                select new
                                {

                                    IDsv = PhieuMuon.MaSV,
                                    IDnc = PhieuMuon.MaNC,
                                    NM = PhieuMuon.NgayMuon,
                                    NT = PhieuMuon.NgayTra,
                                    TT = PhieuMuon.ThanhTien

                                };
                dgvPM.DataSource = phieumuon.ToList();
            }
        }

        private void PM_Load(object sender, EventArgs e)
        {
            LoadPM();
        }

        private void dgvPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMaSV.Text = dgvPM.Rows[i].Cells[0].Value.ToString();
            txtMaNC.Text = dgvPM.Rows[i].Cells[1].Value.ToString();
            dtpNM.Text = dgvPM.Rows[i].Cells[2].Value.ToString();
            dtpNT.Text = dgvPM.Rows[i].Cells[3].Value.ToString();
            txtThanhTien.Text = dgvPM.Rows[i].Cells[4].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var pm = new QLNCEntities())
                {
                    var phieumuon = new PhieuMuon()
                    {
                       MaSV = txtMaSV.Text,
                       MaNC = txtMaNC.Text,
                       NgayMuon = dtpNM.Value,
                       NgayTra = dtpNT.Value,
                       ThanhTien = double.Parse(txtThanhTien.Text)
                    };
                    pm.PhieuMuons.Add(phieumuon);
                    pm.SaveChanges();
                }
                LoadPM();
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
                using (var pm = new QLNCEntities())
                {
                    PhieuMuon PMtoDel = pm.PhieuMuons.Find(id);
                    if (PMtoDel != null)
                    {
                        pm.PhieuMuons.Remove(PMtoDel);
                        pm.SaveChanges();
                    }

                }
                LoadPM();
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
                using (var pm = new QLNCEntities())
                {
                    string id = txtMaNC.Text.ToString();
                    PhieuMuon PMtoUpd = pm.PhieuMuons.Find(id) ;
                    if (PMtoUpd != null)
                    {
                        MessageBox.Show(pm.Entry(PMtoUpd).State.ToString());
                        PMtoUpd.NgayMuon = dtpNM.Value;
                        PMtoUpd.NgayTra = dtpNT.Value;
                        PMtoUpd.ThanhTien = double.Parse(txtThanhTien.Text);
                        MessageBox.Show(pm.Entry(PMtoUpd).State.ToString());
                        pm.SaveChanges();
                    }
                }
                LoadPM();
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
