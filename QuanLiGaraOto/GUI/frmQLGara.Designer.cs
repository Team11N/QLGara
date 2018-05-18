using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiGaraOto
{
    partial class frmQLGara
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbPhuTung = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.txtSearchPhuTung = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnDelPhuTung = new System.Windows.Forms.Button();
            this.btnEditPhuTung = new System.Windows.Forms.Button();
            this.btnInsertPhuTung = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tbGara = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchGara = new System.Windows.Forms.TextBox();
            this.cmbShowGara = new System.Windows.Forms.ComboBox();
            this.btnReloadGara = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveGara = new System.Windows.Forms.Button();
            this.btnExitGara = new System.Windows.Forms.Button();
            this.txtSoMay = new System.Windows.Forms.TextBox();
            this.txtSoKM = new System.Windows.Forms.TextBox();
            this.btnDelGara = new System.Windows.Forms.Button();
            this.btnEditGara = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInsertGara = new System.Windows.Forms.Button();
            this.txtHangXe = new System.Windows.Forms.TextBox();
            this.txtSoKhung = new System.Windows.Forms.TextBox();
            this.txtDX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGara = new System.Windows.Forms.DataGridView();
            this.tbNhanVien = new System.Windows.Forms.TabPage();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtNameNV = new System.Windows.Forms.TextBox();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtBirthDay = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNameXuong = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchNV = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSearchNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbXuong = new System.Windows.Forms.ComboBox();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tbDoanhThu = new System.Windows.Forms.TabPage();
            this.btnxuatEL = new System.Windows.Forms.Button();
            this.btnxoaDT = new System.Windows.Forms.Button();
            this.dtpkngayra = new System.Windows.Forms.DateTimePicker();
            this.dtpkngayvao = new System.Windows.Forms.DateTimePicker();
            this.txtxuong = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txthoadon = new System.Windows.Forms.TextBox();
            this.Hoas = new System.Windows.Forms.Label();
            this.lbdoanhthu = new System.Windows.Forms.Label();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbPhuTung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tbGara.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGara)).BeginInit();
            this.tbNhanVien.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tbDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPhuTung
            // 
            this.tbPhuTung.Controls.Add(this.button12);
            this.tbPhuTung.Controls.Add(this.textBox26);
            this.tbPhuTung.Controls.Add(this.textBox25);
            this.tbPhuTung.Controls.Add(this.textBox24);
            this.tbPhuTung.Controls.Add(this.textBox23);
            this.tbPhuTung.Controls.Add(this.textBox22);
            this.tbPhuTung.Controls.Add(this.textBox21);
            this.tbPhuTung.Controls.Add(this.txtSearchPhuTung);
            this.tbPhuTung.Controls.Add(this.label26);
            this.tbPhuTung.Controls.Add(this.label25);
            this.tbPhuTung.Controls.Add(this.label24);
            this.tbPhuTung.Controls.Add(this.label23);
            this.tbPhuTung.Controls.Add(this.label22);
            this.tbPhuTung.Controls.Add(this.label21);
            this.tbPhuTung.Controls.Add(this.btnDelPhuTung);
            this.tbPhuTung.Controls.Add(this.btnEditPhuTung);
            this.tbPhuTung.Controls.Add(this.btnInsertPhuTung);
            this.tbPhuTung.Controls.Add(this.button8);
            this.tbPhuTung.Controls.Add(this.dataGridView4);
            this.tbPhuTung.Location = new System.Drawing.Point(4, 22);
            this.tbPhuTung.Name = "tbPhuTung";
            this.tbPhuTung.Padding = new System.Windows.Forms.Padding(3);
            this.tbPhuTung.Size = new System.Drawing.Size(972, 422);
            this.tbPhuTung.TabIndex = 3;
            this.tbPhuTung.Text = "Phụ tùng xe";
            this.tbPhuTung.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(900, 260);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(52, 22);
            this.button12.TabIndex = 11;
            this.button12.Text = "Reload";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(785, 216);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(167, 20);
            this.textBox26.TabIndex = 7;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(785, 190);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(167, 20);
            this.textBox25.TabIndex = 6;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(785, 164);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(167, 20);
            this.textBox24.TabIndex = 5;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(785, 138);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(167, 20);
            this.textBox23.TabIndex = 4;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(785, 107);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(167, 20);
            this.textBox22.TabIndex = 3;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(785, 81);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(167, 20);
            this.textBox21.TabIndex = 2;
            // 
            // txtSearchPhuTung
            // 
            this.txtSearchPhuTung.Location = new System.Drawing.Point(252, 16);
            this.txtSearchPhuTung.Name = "txtSearchPhuTung";
            this.txtSearchPhuTung.Size = new System.Drawing.Size(175, 20);
            this.txtSearchPhuTung.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(670, 223);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Số tiền";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(670, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 11;
            this.label25.Text = "Số lượng";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(670, 171);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "Nhà cung cấp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(670, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "Tên vật liệu";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(670, 114);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(95, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Mã phiếu khảo sát";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(670, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 7;
            this.label21.Text = "Mã phụ tùng";
            // 
            // btnDelPhuTung
            // 
            this.btnDelPhuTung.Location = new System.Drawing.Point(826, 260);
            this.btnDelPhuTung.Name = "btnDelPhuTung";
            this.btnDelPhuTung.Size = new System.Drawing.Size(52, 22);
            this.btnDelPhuTung.TabIndex = 10;
            this.btnDelPhuTung.Text = "Xóa";
            this.btnDelPhuTung.UseVisualStyleBackColor = true;
            this.btnDelPhuTung.Click += new System.EventHandler(this.btnDelPhuTung_Click);
            // 
            // btnEditPhuTung
            // 
            this.btnEditPhuTung.Location = new System.Drawing.Point(752, 260);
            this.btnEditPhuTung.Name = "btnEditPhuTung";
            this.btnEditPhuTung.Size = new System.Drawing.Size(52, 22);
            this.btnEditPhuTung.TabIndex = 9;
            this.btnEditPhuTung.Text = "Sửa";
            this.btnEditPhuTung.UseVisualStyleBackColor = true;
            this.btnEditPhuTung.Click += new System.EventHandler(this.btnEditPhuTung_Click);
            // 
            // btnInsertPhuTung
            // 
            this.btnInsertPhuTung.Location = new System.Drawing.Point(682, 260);
            this.btnInsertPhuTung.Name = "btnInsertPhuTung";
            this.btnInsertPhuTung.Size = new System.Drawing.Size(51, 22);
            this.btnInsertPhuTung.TabIndex = 8;
            this.btnInsertPhuTung.Text = "Thêm";
            this.btnInsertPhuTung.UseVisualStyleBackColor = true;
            this.btnInsertPhuTung.Click += new System.EventHandler(this.btnInsertPhuTung_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(114, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "Tìm kiếm";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnSearchPhuTung_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(7, 56);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(645, 357);
            this.dataGridView4.TabIndex = 0;
            // 
            // tbGara
            // 
            this.tbGara.Controls.Add(this.label12);
            this.tbGara.Controls.Add(this.txtSearchGara);
            this.tbGara.Controls.Add(this.cmbShowGara);
            this.tbGara.Controls.Add(this.btnReloadGara);
            this.tbGara.Controls.Add(this.panel4);
            this.tbGara.Controls.Add(this.dgvGara);
            this.tbGara.Location = new System.Drawing.Point(4, 22);
            this.tbGara.Name = "tbGara";
            this.tbGara.Padding = new System.Windows.Forms.Padding(3);
            this.tbGara.Size = new System.Drawing.Size(972, 422);
            this.tbGara.TabIndex = 1;
            this.tbGara.Text = "Gara";
            this.tbGara.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Mời nhập vào biển số xe cần tìm kiếm";
            // 
            // txtSearchGara
            // 
            this.txtSearchGara.Location = new System.Drawing.Point(254, 11);
            this.txtSearchGara.Name = "txtSearchGara";
            this.txtSearchGara.Size = new System.Drawing.Size(152, 20);
            this.txtSearchGara.TabIndex = 11;
            this.txtSearchGara.TextChanged += new System.EventHandler(this.txtSearchGara_TextChanged);
            // 
            // cmbShowGara
            // 
            this.cmbShowGara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowGara.FormattingEnabled = true;
            this.cmbShowGara.Items.AddRange(new object[] {
            "plz, select show hangXe"});
            this.cmbShowGara.Location = new System.Drawing.Point(412, 11);
            this.cmbShowGara.Name = "cmbShowGara";
            this.cmbShowGara.Size = new System.Drawing.Size(147, 21);
            this.cmbShowGara.TabIndex = 10;
            this.cmbShowGara.SelectedIndexChanged += new System.EventHandler(this.cmbShowGara_SelectedIndexChanged);
            // 
            // btnReloadGara
            // 
            this.btnReloadGara.Location = new System.Drawing.Point(565, 10);
            this.btnReloadGara.Name = "btnReloadGara";
            this.btnReloadGara.Size = new System.Drawing.Size(46, 21);
            this.btnReloadGara.TabIndex = 8;
            this.btnReloadGara.Text = "reload";
            this.btnReloadGara.UseVisualStyleBackColor = true;
            this.btnReloadGara.Click += new System.EventHandler(this.btnReloadGara_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveGara);
            this.panel4.Controls.Add(this.btnExitGara);
            this.panel4.Controls.Add(this.txtSoMay);
            this.panel4.Controls.Add(this.txtSoKM);
            this.panel4.Controls.Add(this.btnDelGara);
            this.panel4.Controls.Add(this.btnEditGara);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btnInsertGara);
            this.panel4.Controls.Add(this.txtHangXe);
            this.panel4.Controls.Add(this.txtSoKhung);
            this.panel4.Controls.Add(this.txtDX);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtBS);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(700, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 378);
            this.panel4.TabIndex = 9;
            // 
            // btnSaveGara
            // 
            this.btnSaveGara.Location = new System.Drawing.Point(143, 288);
            this.btnSaveGara.Name = "btnSaveGara";
            this.btnSaveGara.Size = new System.Drawing.Size(46, 22);
            this.btnSaveGara.TabIndex = 32;
            this.btnSaveGara.Text = "Save";
            this.btnSaveGara.UseVisualStyleBackColor = true;
            this.btnSaveGara.Click += new System.EventHandler(this.btnSaveGara_Click);
            // 
            // btnExitGara
            // 
            this.btnExitGara.Location = new System.Drawing.Point(62, 288);
            this.btnExitGara.Name = "btnExitGara";
            this.btnExitGara.Size = new System.Drawing.Size(44, 22);
            this.btnExitGara.TabIndex = 31;
            this.btnExitGara.Text = "Exit";
            this.btnExitGara.UseVisualStyleBackColor = true;
            this.btnExitGara.Click += new System.EventHandler(this.btnExitGara_Click);
            // 
            // txtSoMay
            // 
            this.txtSoMay.Location = new System.Drawing.Point(94, 172);
            this.txtSoMay.Name = "txtSoMay";
            this.txtSoMay.Size = new System.Drawing.Size(152, 20);
            this.txtSoMay.TabIndex = 4;
            // 
            // txtSoKM
            // 
            this.txtSoKM.Location = new System.Drawing.Point(94, 198);
            this.txtSoKM.Name = "txtSoKM";
            this.txtSoKM.Size = new System.Drawing.Size(152, 20);
            this.txtSoKM.TabIndex = 5;
            // 
            // btnDelGara
            // 
            this.btnDelGara.Location = new System.Drawing.Point(186, 239);
            this.btnDelGara.Name = "btnDelGara";
            this.btnDelGara.Size = new System.Drawing.Size(47, 22);
            this.btnDelGara.TabIndex = 8;
            this.btnDelGara.Text = "Xóa";
            this.btnDelGara.UseVisualStyleBackColor = true;
            this.btnDelGara.Click += new System.EventHandler(this.btnDelGara_Click);
            // 
            // btnEditGara
            // 
            this.btnEditGara.Location = new System.Drawing.Point(97, 239);
            this.btnEditGara.Name = "btnEditGara";
            this.btnEditGara.Size = new System.Drawing.Size(46, 22);
            this.btnEditGara.TabIndex = 7;
            this.btnEditGara.Text = "Sửa";
            this.btnEditGara.UseVisualStyleBackColor = true;
            this.btnEditGara.Click += new System.EventHandler(this.btnEditGara_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Số máy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Số KM";
            // 
            // btnInsertGara
            // 
            this.btnInsertGara.Location = new System.Drawing.Point(16, 239);
            this.btnInsertGara.Name = "btnInsertGara";
            this.btnInsertGara.Size = new System.Drawing.Size(44, 22);
            this.btnInsertGara.TabIndex = 6;
            this.btnInsertGara.Text = "Thêm";
            this.btnInsertGara.UseVisualStyleBackColor = true;
            this.btnInsertGara.Click += new System.EventHandler(this.btnInsertGara_Click);
            // 
            // txtHangXe
            // 
            this.txtHangXe.Location = new System.Drawing.Point(94, 94);
            this.txtHangXe.Name = "txtHangXe";
            this.txtHangXe.Size = new System.Drawing.Size(152, 20);
            this.txtHangXe.TabIndex = 1;
            // 
            // txtSoKhung
            // 
            this.txtSoKhung.Location = new System.Drawing.Point(94, 146);
            this.txtSoKhung.Name = "txtSoKhung";
            this.txtSoKhung.Size = new System.Drawing.Size(152, 20);
            this.txtSoKhung.TabIndex = 3;
            // 
            // txtDX
            // 
            this.txtDX.Location = new System.Drawing.Point(94, 120);
            this.txtDX.Name = "txtDX";
            this.txtDX.Size = new System.Drawing.Size(152, 20);
            this.txtDX.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hãng xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Đời xe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Số khung";
            // 
            // txtBS
            // 
            this.txtBS.Location = new System.Drawing.Point(94, 68);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(152, 20);
            this.txtBS.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Biển số";
            // 
            // dgvGara
            // 
            this.dgvGara.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGara.Location = new System.Drawing.Point(3, 36);
            this.dgvGara.Name = "dgvGara";
            this.dgvGara.Size = new System.Drawing.Size(691, 378);
            this.dgvGara.TabIndex = 2;
            this.dgvGara.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGara_CellClick);
            // 
            // tbNhanVien
            // 
            this.tbNhanVien.Controls.Add(this.txtContact);
            this.tbNhanVien.Controls.Add(this.txtNameNV);
            this.tbNhanVien.Controls.Add(this.txtMSV);
            this.tbNhanVien.Controls.Add(this.txtBirthDay);
            this.tbNhanVien.Controls.Add(this.txtGender);
            this.tbNhanVien.Controls.Add(this.txtAddress);
            this.tbNhanVien.Controls.Add(this.txtNameXuong);
            this.tbNhanVien.Controls.Add(this.label14);
            this.tbNhanVien.Controls.Add(this.label13);
            this.tbNhanVien.Controls.Add(this.label15);
            this.tbNhanVien.Controls.Add(this.label17);
            this.tbNhanVien.Controls.Add(this.label16);
            this.tbNhanVien.Controls.Add(this.label18);
            this.tbNhanVien.Controls.Add(this.label19);
            this.tbNhanVien.Controls.Add(this.panel7);
            this.tbNhanVien.Controls.Add(this.btnXoa);
            this.tbNhanVien.Controls.Add(this.panel3);
            this.tbNhanVien.Controls.Add(this.panel1);
            this.tbNhanVien.Controls.Add(this.btnNhaphang);
            this.tbNhanVien.Controls.Add(this.btnSua);
            this.tbNhanVien.Location = new System.Drawing.Point(4, 22);
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tbNhanVien.Size = new System.Drawing.Size(972, 422);
            this.tbNhanVien.TabIndex = 0;
            this.tbNhanVien.Text = "Nhân Viên";
            this.tbNhanVien.UseVisualStyleBackColor = true;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(737, 116);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(195, 20);
            this.txtContact.TabIndex = 2;
            // 
            // txtNameNV
            // 
            this.txtNameNV.Location = new System.Drawing.Point(737, 90);
            this.txtNameNV.Name = "txtNameNV";
            this.txtNameNV.Size = new System.Drawing.Size(195, 20);
            this.txtNameNV.TabIndex = 1;
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(737, 64);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(195, 20);
            this.txtMSV.TabIndex = 0;
            // 
            // txtBirthDay
            // 
            this.txtBirthDay.Location = new System.Drawing.Point(737, 142);
            this.txtBirthDay.Name = "txtBirthDay";
            this.txtBirthDay.Size = new System.Drawing.Size(195, 20);
            this.txtBirthDay.TabIndex = 3;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(737, 168);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(195, 20);
            this.txtGender.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(737, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(195, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtNameXuong
            // 
            this.txtNameXuong.Location = new System.Drawing.Point(737, 221);
            this.txtNameXuong.Name = "txtNameXuong";
            this.txtNameXuong.Size = new System.Drawing.Size(195, 20);
            this.txtNameXuong.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(657, 93);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Họ Tên ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(657, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Mã NV";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(657, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "SĐT";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(657, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Giới tính";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(657, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Ngày Sinh";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(657, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Địa Chỉ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(657, 221);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Tên Xưởng";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox12);
            this.panel7.Controls.Add(this.textBox11);
            this.panel7.Controls.Add(this.textBox10);
            this.panel7.Controls.Add(this.textBox9);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(639, 286);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 113);
            this.panel7.TabIndex = 5;
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(153, 87);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(153, 20);
            this.textBox12.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(153, 61);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(153, 20);
            this.textBox11.TabIndex = 6;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(153, 32);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(153, 20);
            this.textBox10.TabIndex = 5;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(153, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 20);
            this.textBox9.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhân viên quản lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Website";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa chỉ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(862, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(50, 21);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvNhanVien);
            this.panel3.Location = new System.Drawing.Point(3, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 357);
            this.panel3.TabIndex = 4;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(628, 357);
            this.dgvNhanVien.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearchNV);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.txtSearchNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbXuong);
            this.panel1.Location = new System.Drawing.Point(74, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 43);
            this.panel1.TabIndex = 3;
            // 
            // btnSearchNV
            // 
            this.btnSearchNV.Location = new System.Drawing.Point(209, 10);
            this.btnSearchNV.Name = "btnSearchNV";
            this.btnSearchNV.Size = new System.Drawing.Size(59, 23);
            this.btnSearchNV.TabIndex = 1;
            this.btnSearchNV.Text = "Tìm kiếm";
            this.btnSearchNV.UseVisualStyleBackColor = true;
            this.btnSearchNV.Click += new System.EventHandler(this.btnSearchNV_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(84, 129);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtSearchNV
            // 
            this.txtSearchNV.Location = new System.Drawing.Point(283, 10);
            this.txtSearchNV.Name = "txtSearchNV";
            this.txtSearchNV.Size = new System.Drawing.Size(140, 20);
            this.txtSearchNV.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Xưởng";
            // 
            // cmbXuong
            // 
            this.cmbXuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXuong.FormattingEnabled = true;
            this.cmbXuong.Location = new System.Drawing.Point(75, 10);
            this.cmbXuong.Name = "cmbXuong";
            this.cmbXuong.Size = new System.Drawing.Size(115, 21);
            this.cmbXuong.TabIndex = 3;
            this.cmbXuong.SelectedIndexChanged += new System.EventHandler(this.cmbXuong_SelectedIndexChanged);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.Location = new System.Drawing.Point(697, 253);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(46, 23);
            this.btnNhaphang.TabIndex = 7;
            this.btnNhaphang.Text = "Thêm";
            this.btnNhaphang.UseVisualStyleBackColor = true;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(776, 253);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(47, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tbNhanVien);
            this.tabControl.Controls.Add(this.tbGara);
            this.tabControl.Controls.Add(this.tbDoanhThu);
            this.tabControl.Controls.Add(this.tbPhuTung);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(980, 448);
            this.tabControl.TabIndex = 0;
            // 
            // tbDoanhThu
            // 
            this.tbDoanhThu.Controls.Add(this.chart1);
            this.tbDoanhThu.Controls.Add(this.btnxuatEL);
            this.tbDoanhThu.Controls.Add(this.btnxoaDT);
            this.tbDoanhThu.Controls.Add(this.dtpkngayra);
            this.tbDoanhThu.Controls.Add(this.dtpkngayvao);
            this.tbDoanhThu.Controls.Add(this.txtxuong);
            this.tbDoanhThu.Controls.Add(this.txttongtien);
            this.tbDoanhThu.Controls.Add(this.label30);
            this.tbDoanhThu.Controls.Add(this.label29);
            this.tbDoanhThu.Controls.Add(this.label28);
            this.tbDoanhThu.Controls.Add(this.label27);
            this.tbDoanhThu.Controls.Add(this.txthoadon);
            this.tbDoanhThu.Controls.Add(this.Hoas);
            this.tbDoanhThu.Controls.Add(this.lbdoanhthu);
            this.tbDoanhThu.Controls.Add(this.dtpkFrom);
            this.tbDoanhThu.Controls.Add(this.btnThongKe);
            this.tbDoanhThu.Controls.Add(this.dtpkTo);
            this.tbDoanhThu.Controls.Add(this.dgvThongKe);
            this.tbDoanhThu.Location = new System.Drawing.Point(4, 22);
            this.tbDoanhThu.Name = "tbDoanhThu";
            this.tbDoanhThu.Padding = new System.Windows.Forms.Padding(3);
            this.tbDoanhThu.Size = new System.Drawing.Size(972, 422);
            this.tbDoanhThu.TabIndex = 2;
            this.tbDoanhThu.Text = "Doanh thu";
            this.tbDoanhThu.UseVisualStyleBackColor = true;
            // 
            // btnxuatEL
            // 
            this.btnxuatEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxuatEL.Location = new System.Drawing.Point(319, 385);
            this.btnxuatEL.Name = "btnxuatEL";
            this.btnxuatEL.Size = new System.Drawing.Size(93, 29);
            this.btnxuatEL.TabIndex = 35;
            this.btnxuatEL.Text = "Xuất Excel";
            this.btnxuatEL.UseVisualStyleBackColor = true;
            this.btnxuatEL.Click += new System.EventHandler(this.btnxuatEL_Click_1);
            // 
            // btnxoaDT
            // 
            this.btnxoaDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoaDT.Location = new System.Drawing.Point(180, 385);
            this.btnxoaDT.Name = "btnxoaDT";
            this.btnxoaDT.Size = new System.Drawing.Size(96, 29);
            this.btnxoaDT.TabIndex = 34;
            this.btnxoaDT.Text = "Xóa";
            this.btnxoaDT.UseVisualStyleBackColor = true;
            this.btnxoaDT.Click += new System.EventHandler(this.btnxoaDT_Click_1);
            // 
            // dtpkngayra
            // 
            this.dtpkngayra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkngayra.Location = new System.Drawing.Point(292, 354);
            this.dtpkngayra.Name = "dtpkngayra";
            this.dtpkngayra.Size = new System.Drawing.Size(94, 20);
            this.dtpkngayra.TabIndex = 33;
            // 
            // dtpkngayvao
            // 
            this.dtpkngayvao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkngayvao.Location = new System.Drawing.Point(293, 321);
            this.dtpkngayvao.Name = "dtpkngayvao";
            this.dtpkngayvao.Size = new System.Drawing.Size(93, 20);
            this.dtpkngayvao.TabIndex = 32;
            // 
            // txtxuong
            // 
            this.txtxuong.Location = new System.Drawing.Point(96, 354);
            this.txtxuong.Name = "txtxuong";
            this.txtxuong.Size = new System.Drawing.Size(100, 20);
            this.txtxuong.TabIndex = 31;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(490, 321);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(100, 20);
            this.txttongtien.TabIndex = 30;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(21, 354);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 13);
            this.label30.TabIndex = 29;
            this.label30.Text = "Xưởng";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(223, 324);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 13);
            this.label29.TabIndex = 28;
            this.label29.Text = "Ngày vào";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(223, 354);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 27;
            this.label28.Text = "Ngày ra";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(428, 324);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "Tổng Tiền";
            // 
            // txthoadon
            // 
            this.txthoadon.Location = new System.Drawing.Point(96, 321);
            this.txthoadon.Name = "txthoadon";
            this.txthoadon.Size = new System.Drawing.Size(100, 20);
            this.txthoadon.TabIndex = 25;
            // 
            // Hoas
            // 
            this.Hoas.AutoSize = true;
            this.Hoas.Location = new System.Drawing.Point(21, 324);
            this.Hoas.Name = "Hoas";
            this.Hoas.Size = new System.Drawing.Size(49, 13);
            this.Hoas.TabIndex = 24;
            this.Hoas.Text = "Hóa đơn";
            // 
            // lbdoanhthu
            // 
            this.lbdoanhthu.AutoSize = true;
            this.lbdoanhthu.Location = new System.Drawing.Point(682, 393);
            this.lbdoanhthu.Name = "lbdoanhthu";
            this.lbdoanhthu.Size = new System.Drawing.Size(190, 13);
            this.lbdoanhthu.TabIndex = 23;
            this.lbdoanhthu.Text = "Biểu đồ thể hiện doanh thu theo tháng";
            this.lbdoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkFrom.Location = new System.Drawing.Point(4, 12);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(97, 20);
            this.dtpkFrom.TabIndex = 19;
            // 
            // btnThongKe
            // 
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Location = new System.Drawing.Point(244, 4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(123, 35);
            this.btnThongKe.TabIndex = 21;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtpkTo
            // 
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkTo.Location = new System.Drawing.Point(493, 12);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(97, 20);
            this.dtpkTo.TabIndex = 20;
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(1, 54);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.Size = new System.Drawing.Size(589, 254);
            this.dgvThongKe.TabIndex = 22;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea4.AxisX.Title = "Tháng";
            chartArea4.AxisY.Title = "Doanh Thu (VND)";
            chartArea4.Name = "Tháng";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(635, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "Tháng";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Doanh Thu";
            series4.XValueMember = "Tháng";
            series4.YValueMembers = "Tổng Tiền";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(337, 369);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // frmQLGara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 448);
            this.Controls.Add(this.tabControl);
            this.Name = "frmQLGara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Gara Ôtô";
            this.Load += new System.EventHandler(this.frmQLGara_Load);
            this.tbPhuTung.ResumeLayout(false);
            this.tbPhuTung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tbGara.ResumeLayout(false);
            this.tbGara.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGara)).EndInit();
            this.tbNhanVien.ResumeLayout(false);
            this.tbNhanVien.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tbDoanhThu.ResumeLayout(false);
            this.tbDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }



        #endregion
        private System.Windows.Forms.TabPage tbPhuTung;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox txtSearchPhuTung;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnDelPhuTung;
        private System.Windows.Forms.Button btnEditPhuTung;
        private System.Windows.Forms.Button btnInsertPhuTung;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TabPage tbGara;
        private System.Windows.Forms.Button btnReloadGara;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSoMay;
        private System.Windows.Forms.TextBox txtSoKM;
        private System.Windows.Forms.Button btnDelGara;
        private System.Windows.Forms.Button btnEditGara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInsertGara;
        private System.Windows.Forms.TextBox txtHangXe;
        private System.Windows.Forms.TextBox txtSoKhung;
        private System.Windows.Forms.TextBox txtDX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGara;
        private System.Windows.Forms.TabPage tbNhanVien;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtNameNV;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNameXuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchNV;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSearchNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbXuong;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ComboBox cmbShowGara;
        private System.Windows.Forms.TextBox txtBirthDay;
        private System.Windows.Forms.TextBox txtSearchGara;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSaveGara;
        private System.Windows.Forms.Button btnExitGara;
        private System.Windows.Forms.TabPage tbDoanhThu;
        private System.Windows.Forms.Button btnxuatEL;
        private System.Windows.Forms.Button btnxoaDT;
        private System.Windows.Forms.DateTimePicker dtpkngayra;
        private System.Windows.Forms.DateTimePicker dtpkngayvao;
        private System.Windows.Forms.TextBox txtxuong;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txthoadon;
        private System.Windows.Forms.Label Hoas;
        private System.Windows.Forms.Label lbdoanhthu;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}