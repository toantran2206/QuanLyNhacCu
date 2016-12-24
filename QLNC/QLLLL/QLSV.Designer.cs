namespace QLLLL
{
    partial class QLSV
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Them";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.Location = new System.Drawing.Point(235, 212);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(75, 23);
            this.btnUpd.TabIndex = 0;
            this.btnUpd.Text = "Sua";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(370, 212);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Xoa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(512, 212);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Dong";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dien Thoai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngay Sinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(157, 38);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(100, 20);
            this.txtMaSV.TabIndex = 2;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(157, 76);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(100, 20);
            this.txtTenSV.TabIndex = 2;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(157, 117);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(100, 20);
            this.txtDT.TabIndex = 2;
            // 
            // txtDC
            // 
            this.txtDC.Location = new System.Drawing.Point(487, 42);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(100, 20);
            this.txtDC.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Dia Chi";
            // 
            // dgvSV
            // 
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(71, 267);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.Size = new System.Drawing.Size(560, 226);
            this.dgvSV.TabIndex = 3;
            this.dgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellClick);
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(487, 83);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 505);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.txtDC);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtTenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpd);
            this.Controls.Add(this.btnAdd);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLSV_FormClosing);
            this.Load += new System.EventHandler(this.QLSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}