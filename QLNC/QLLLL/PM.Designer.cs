namespace QLLLL
{
    partial class PM
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
            this.dgvPM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaNC = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.dtpNM = new System.Windows.Forms.DateTimePicker();
            this.dtpNT = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPM
            // 
            this.dgvPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPM.Location = new System.Drawing.Point(52, 326);
            this.dgvPM.Name = "dgvPM";
            this.dgvPM.Size = new System.Drawing.Size(630, 150);
            this.dgvPM.TabIndex = 0;
            this.dgvPM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPM_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma NC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngay Muon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thanh Tien";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(437, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ngay Tra";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(190, 51);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 2;
            // 
            // txtMaNC
            // 
            this.txtMaNC.Location = new System.Drawing.Point(190, 97);
            this.txtMaNC.Name = "txtMaNC";
            this.txtMaNC.Size = new System.Drawing.Size(100, 20);
            this.txtMaNC.TabIndex = 2;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(523, 97);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(100, 20);
            this.txtThanhTien.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(144, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(287, 213);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Xoa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(397, 213);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 3;
            this.btnUpd.Text = "Sua";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // dtpNM
            // 
            this.dtpNM.Location = new System.Drawing.Point(190, 144);
            this.dtpNM.Name = "dtpNM";
            this.dtpNM.Size = new System.Drawing.Size(200, 20);
            this.dtpNM.TabIndex = 4;
            // 
            // dtpNT
            // 
            this.dtpNT.Location = new System.Drawing.Point(523, 51);
            this.dtpNT.Name = "dtpNT";
            this.dtpNT.Size = new System.Drawing.Size(200, 20);
            this.dtpNT.TabIndex = 5;
            // 
            // PM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 488);
            this.Controls.Add(this.dtpNT);
            this.Controls.Add(this.dtpNM);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtMaNC);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPM);
            this.Name = "PM";
            this.Text = "PM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PM_FormClosing);
            this.Load += new System.EventHandler(this.PM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaNC;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.DateTimePicker dtpNM;
        private System.Windows.Forms.DateTimePicker dtpNT;
    }
}