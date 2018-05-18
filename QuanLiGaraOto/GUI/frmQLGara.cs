﻿using QuanLiGaraOto.DAL; using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Data.SqlClient; using System.Drawing; using System.Linq; using System.Text; using System.Threading; using System.Threading.Tasks; using System.Windows.Forms; using Excel = Microsoft.Office.Interop.Excel; using xlapp = Microsoft.Office.Interop.Excel.Application; using xlworksheet = Microsoft.Office.Interop.Excel.Worksheet; using xlworkbook = Microsoft.Office.Interop.Excel.Workbook;  namespace QuanLiGaraOto {     public partial class frmQLGara : Form     {         public string checkGara;// = false;          public frmQLGara()         {             InitializeComponent();         }          #region Method          /// <summary>         /// nhân viên         /// </summary>         void LoadNhanvien()         {             string query = "select * from NHANVIEN ";             SqlConnect connect = new SqlConnect();             dgvNhanVien.DataSource = connect.ExecuteQuery(query);         }          public void LoadCmbNhanVien()         {             string query = "Select * From XUONG,NHANVIEN WHERE NHANVIEN.TENXUONG = XUONG.TENXUONG ";              SqlConnect connect = new SqlConnect();             cmbXuong.DataSource = connect.ExecuteQuery(query);             cmbXuong.DisplayMember = "TenXuong";             cmbXuong.ValueMember = "TenXuong";         }          public void AddXuong()         {             textBox9.DataBindings.Add(new Binding("Text", cmbXuong.DataSource, "DiaChi"));             textBox10.DataBindings.Add(new Binding("Text", cmbXuong.DataSource, "Email"));             textBox11.DataBindings.Add(new Binding("Text", cmbXuong.DataSource, "Website"));             textBox12.DataBindings.Add(new Binding("Text", cmbXuong.DataSource, "MaNguoiPhuTrach"));         }          /// <summary>         /// phụ tùng         /// </summary>         void LoadPhutung()         {             string query = "select MAPHIEUVATTU AS ' MaPhuTung',MaPhieuKhaoSat,TenVatLieu,NhaCungCap,SoLuong,SoTien  from PHIEUVATTU ";             SqlConnect connect = new SqlConnect();             dataGridView4.DataSource = connect.ExecuteQuery(query);         }          /// <summary>         /// gara         /// </summary>         void LoadXe()         {             string query = "select * from THONGTINXE";             SqlConnect connect = new SqlConnect();             dgvGara.DataSource = connect.ExecuteQuery(query);         }          /// <summary>         /// disEnable textbox is tbGara         /// </summary>         public void lockTxtGara()         {             txtBS.Enabled = false;             txtHangXe.Enabled = false;             txtDX.Enabled = false;             txtSoKhung.Enabled = false;             txtSoMay.Enabled = false;             txtSoKM.Enabled = false;         }         /// <summary>         /// Enable textbox is tbGara         /// </summary>         public void unlockTxtGara()         {             txtBS.Enabled = true;             txtHangXe.Enabled = true;             txtDX.Enabled = true;             txtSoKhung.Enabled = true;             txtSoMay.Enabled = true;             txtSoKM.Enabled = true;         }         /// <summary>         /// reset textbox is tbGara         /// </summary>         public void resetTxtGara()         {             txtBS.Text = "";             txtHangXe.Text = "";             txtDX.Text = "";             txtSoKhung.Text = "";             txtSoMay.Text = "";             txtSoKM.Text = "";         }         /// <summary>         /// check insert, update in tbGara         /// </summary>         /// <returns></returns>         public bool CheckIn_Up()         {             if (txtBS.Text == "" || txtHangXe.Text == "" || txtDX.Text == "" || txtSoKhung.Text == "" || txtSoMay.Text == "" || txtSoKM.Text == "")             {                 return false;             }             return true;         }         //check delete         public bool CheckDel()         {             if (txtBS.Text == "")             {                 return false;             }             return true;         }          public void showEnableBtn(string name)         {             if (name.Equals("insert"))             {                 btnDelGara.Enabled = false;                 btnEditGara.Enabled = false;                 btnSaveGara.Enabled = true;                 btnExitGara.Enabled = true;             }             if (name.Equals("update"))             {                 btnDelGara.Enabled = false;                 btnInsertGara.Enabled = false;                 btnSaveGara.Enabled = true;                 btnExitGara.Enabled = true;             }         }          public void resetEnableBtn(string name)         {             if (name.Equals("done"))             {                 btnInsertGara.Enabled = true;                 btnDelGara.Enabled = true;                 btnEditGara.Enabled = true;                 btnSaveGara.Enabled = false;                 btnExitGara.Enabled = false;             }          }          /// <summary>         /// pls, select show hangXe         /// </summary>         public void LoadCmbGara()         {             string query = "SELECT DISTINCT HangXe FROM dbo.THONGTINXE";             SqlConnect connect = new SqlConnect();             cmbShowGara.DataSource = connect.ExecuteQuery(query);             cmbShowGara.DisplayMember = "HangXe";             cmbShowGara.ValueMember = "HangXe";         }         /// <summary>         /// Search Car to Gara         /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>         public void searchGara(string bsx, string hangXe)         {             string query;             SqlConnect connect = new SqlConnect();              if (bsx == "")             {                 query = "select * from THONGTINXE where HangXe = '" + hangXe + "'";                 dgvGara.DataSource = connect.ExecuteQuery(query);             }             else             {                 query = "select * from THONGTINXE where HangXe = '" + hangXe + "' and BienSoXe like '" + bsx + "%'";                 dgvGara.DataSource = connect.ExecuteQuery(query);             }          }         //          /// <summary>         /// doanh thu         /// </summary>         ThongKe thongKe = new ThongKe();         void LoadData()         {             dgvThongKe.DataSource = thongKe.LayDanhSachHoaDonTheoNgay(dtpkFrom.Value, dtpkTo.Value);         }          void LoadBieuDo()         {             chart1.DataSource = thongKe.BieuDo();         }          void DataBinding()         {             txthoadon.DataBindings.Clear();             txthoadon.DataBindings.Add("Text", dgvThongKe.DataSource, "Hóa Đơn");             txtxuong.DataBindings.Clear();             txtxuong.DataBindings.Add("Text", dgvThongKe.DataSource, "Xưởng");             dtpkngayvao.DataBindings.Clear();             dtpkngayvao.DataBindings.Add("Text", dgvThongKe.DataSource, "Ngày vào");             dtpkngayra.DataBindings.Clear();             dtpkngayra.DataBindings.Add("Text", dgvThongKe.DataSource, "Ngày ra");             txttongtien.DataBindings.Clear();             txttongtien.DataBindings.Add("Text", dgvThongKe.DataSource, "Tổng Tiền");         }          void LoadDateTimePickerHoaDon()         {             DateTime today = DateTime.Now;             dtpkFrom.Value = new DateTime(today.Year, today.Month, 1);             dtpkTo.Value = dtpkFrom.Value.AddMonths(1).AddDays(-1);         }          private void exportExcel(DataGridView g, string duongDan, string tenTep)         {             xlapp excel = new xlapp();             excel.Application.Workbooks.Add(Type.Missing);             excel.Columns.ColumnWidth = 25;             for (int i = 1; i < g.Columns.Count + 1; i++)             {                 excel.Cells[1, i] = g.Columns[i - 1].HeaderText;             }             for (int i = 0; i < g.Rows.Count; i++)             {                 for (int j = 0; j < g.Columns.Count; j++)                 {                     if (g.Rows[i].Cells[j].Value != null)                     {                         excel.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();                     }                 }             }             excel.ActiveWorkbook.SaveCopyAs(duongDan + tenTep + ".xlsx");             excel.ActiveWorkbook.Saved = true;          }          #endregion          #region tbNhanVien          private void btnNhaphang_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlINSERT = "insert into NHANVIEN values (@MaNV, @HoTen, @SDT,@NgaySinh,@GioiTinh,@DiaChi,@TenXuong)";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlINSERT, connection);             cmd.Parameters.AddWithValue("MaNV", txtMSV.Text);             cmd.Parameters.AddWithValue("HoTen", txtNameNV.Text);             cmd.Parameters.AddWithValue("SDT", txtContact.Text);             cmd.Parameters.AddWithValue("NgaySinh", txtBirthDay.Text);             cmd.Parameters.AddWithValue("GioiTinh", txtGender.Text);             cmd.Parameters.AddWithValue("DiaChi", txtAddress.Text);             cmd.Parameters.AddWithValue("TenXuong", txtNameXuong.Text);             cmd.ExecuteNonQuery();             LoadNhanvien();         }          private void btnSua_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlEDIT1 = "update  NHANVIEN set HoTen = @HoTen,SDT = @SDT,NgaySinh = @NgaySinh, GioiTinh =@GioiTinh , DiaChi = @DiaChi,TenXuong = @TenXuong where MaNV = @MaNV";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlEDIT1, connection);             cmd.Parameters.AddWithValue("MaNV", txtMSV.Text);             cmd.Parameters.AddWithValue("HoTen", txtNameNV.Text);             cmd.Parameters.AddWithValue("SDT", txtContact.Text);             cmd.Parameters.AddWithValue("NgaySinh", txtBirthDay.Text);             cmd.Parameters.AddWithValue("GioiTinh", txtGender.Text);             cmd.Parameters.AddWithValue("DiaChi", txtAddress.Text);             cmd.Parameters.AddWithValue("TenXuong", txtNameXuong.Text);             cmd.ExecuteNonQuery();             LoadNhanvien();         }          private void btnXoa_Click(object sender, EventArgs e)         {              string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlDELETE = "delete from NHANVIEN where MaNV = @MaNV";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlDELETE, connection);             cmd.Parameters.AddWithValue("MaNV", txtMSV.Text);             cmd.Parameters.AddWithValue("HoTen", txtNameNV.Text);             cmd.Parameters.AddWithValue("SDT", txtContact.Text);             cmd.Parameters.AddWithValue("NgaySinh", txtBirthDay.Text);             cmd.Parameters.AddWithValue("GioiTinh", txtGender.Text);             cmd.Parameters.AddWithValue("DiaChi", txtAddress.Text);             cmd.Parameters.AddWithValue("TenXuong", txtNameXuong.Text);             cmd.ExecuteNonQuery();             LoadNhanvien();         }          private void btnSearchNV_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlSEARCH = "select* from NHANVIEN where MaNV = @MaNV";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlSEARCH, connection);             cmd.Parameters.AddWithValue("MaNV", txtSearchNV.Text);             cmd.ExecuteNonQuery();             SqlDataReader dr = cmd.ExecuteReader();             DataTable dt = new DataTable();             dt.Load(dr);             dgvNhanVien.DataSource = dt;         }          private void cmbXuong_SelectedIndexChanged(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlSelect = "select * from NHANVIEN where TenXuong = @TenXuong";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlSelect, connection);             cmd.Parameters.AddWithValue("TenXuong", cmbXuong.Text);             cmd.ExecuteNonQuery();             SqlDataReader dr = cmd.ExecuteReader();             DataTable dt = new DataTable();             dt.Load(dr);             dgvNhanVien.DataSource = dt;         }          #endregion          #region tbPhuTung         private void btnReload_Click(object sender, EventArgs e)         {             LoadPhutung();         }          private void btnDelPhuTung_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlDELETE = "delete from PHIEUVATTU where MaPhieuVatTu = @MaPhieuVatTu";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlDELETE, connection);             cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);             cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);             cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);             cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);             cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);             cmd.Parameters.AddWithValue("SoTien", textBox26.Text);             cmd.ExecuteNonQuery();             LoadPhutung();         }          private void btnEditPhuTung_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlEDIT1 = "update  PHIEUVATTU set MaPhieuVatTu  = @MaPhieuVatTu,MaPhieuKhaoSat = @MaPhieuKhaoSat,TenVatLieu = @TenVatLieu, NhaCungCap =@NhaCungCap , SoLuong = @SoLuong,SoTien = @SoTien where MaPhieuVatTu = @MaPhieuVatTu";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlEDIT1, connection);             cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);             cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);             cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);             cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);             cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);             cmd.Parameters.AddWithValue("SoTien", textBox26.Text);             cmd.ExecuteNonQuery();             LoadPhutung();         }          private void btnInsertPhuTung_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlINSERT = "insert into PHIEUVATTU values (@MaPhieuVatTu, @MaPhieuKhaoSat, @TenVatLieu,@NhaCungCap,@SoLuong,@SoTien)";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlINSERT, connection);             cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);             cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);             cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);             cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);             cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);             cmd.Parameters.AddWithValue("SoTien", textBox26.Text);             cmd.ExecuteNonQuery();             LoadPhutung();         }          private void btnSearchPhuTung_Click(object sender, EventArgs e)         {             string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";             SqlConnection connection = new SqlConnection(connectionSTR);             string sqlSEARCH = "select* from PHIEUVATTU where MaPhieuVatTu = @MaPhieuVatTu";             connection.Open();             SqlCommand cmd = new SqlCommand(sqlSEARCH, connection);             cmd.Parameters.AddWithValue("MaPhieuVatTu", txtSearchPhuTung.Text);             cmd.ExecuteNonQuery();             SqlDataReader dr = cmd.ExecuteReader();             DataTable dt = new DataTable();             dt.Load(dr);             dataGridView4.DataSource = dt;         }          #endregion          #region tbGara          //private void btnSearchGara_Click(object sender, EventArgs e)         //{         //    string sqlSEARCH = "select* from ThongTinXe where BienSoXe = @BienSoXe";         //    SqlConnect connection = new SqlConnect();         //    connection.OpenConnect();         //    SqlCommand cmd = new SqlCommand(sqlSEARCH, connection.Conn);         //    cmd.Parameters.AddWithValue("BienSoXe", txtBS.Text);         //    cmd.Parameters.AddWithValue("HangXe", txtHangXe.Text);         //    cmd.Parameters.AddWithValue("DoiXe", txtDX.Text);         //    cmd.Parameters.AddWithValue("SoKhung", txtSoKhung.Text);         //    cmd.Parameters.AddWithValue("SoMay", txtSoMay.Text);         //    cmd.Parameters.AddWithValue("SoKM", txtSoKM.Text);         //    cmd.ExecuteNonQuery();         //    SqlDataReader dr = cmd.ExecuteReader();         //    DataTable dt = new DataTable();         //    dt.Load(dr);         //    dgvGara.DataSource = dt;         //}          /// <summary>         /// reload dgvGara in DB         /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>         private void btnReloadGara_Click(object sender, EventArgs e)         {             txtSearchGara.Text = "";             LoadXe();             cmbShowGara.Enabled = false;         }          // update info gara         private void btnEditGara_Click(object sender, EventArgs e)         {             unlockTxtGara();             txtHangXe.Enabled = false;             txtBS.Enabled = false;             showEnableBtn("update");             checkGara = "u";

            //string sqlEDIT = "UPDATE THONGTINXE set  HangXe = '" + txtHangXe.Text + "', DoiXe = '" + txtDX.Text + "' , SoKhung = '" + txtSoKhung.Text
            //                + "', SoMay = '" + txtSoMay.Text + "', SoKM = '" + txtSoKM.Text + "' where BienSoXe = '" + txtBS.Text + "'";

            //SqlConnect connect = new SqlConnect();
            //connect.OpenConnect();
            //SqlCommand cmd = new SqlCommand(sqlEDIT, connect.Conn);
            //cmd.ExecuteNonQuery();
            //LoadXe();
            //connect.CloseConnect();
            //lockTxtGara();
        }

        //delete gara
        private void btnDelGara_Click(object sender, EventArgs e)         {              if (CheckDel())             {                 if (MessageBox.Show("Bạn muốn xóa xe mang biển số " + txtBS.Text, "Quession", MessageBoxButtons.YesNo) != DialogResult.No)                 {                     string sqlDel = "delete from ThongTinXe where BienSoXe = '" + txtBS.Text + "'";                     SqlConnect connect = new SqlConnect();                     connect.OpenConnect();                     SqlCommand cmd = new SqlCommand(sqlDel, connect.Conn);                     cmd.ExecuteNonQuery();                     LoadXe();                     connect.CloseConnect();                     resetTxtGara();                 }             }             else             {                 MessageBox.Show("Bạn cần chọn xe muốn xóa trước!");             }          }          //insert to gara         private void btnInsertGara_Click(object sender, EventArgs e)         {             unlockTxtGara();             resetTxtGara();             showEnableBtn("insert");             checkGara = "i";

            //try
            //{

            //    string sqlINSERT = "INSERT INTO dbo.THONGTINXE( BienSoXe , HangXe ,DoiXe ,SoKhung , SoMay , SoKM) VALUES  ( '"
            //                    + txtBS.Text + "' ,N'" + txtHangXe.Text + "' ,N'" + txtDX.Text + "' ,N'" + txtSoKhung.Text + "' , N'"
            //                    + txtSoMay.Text + "' , N'" + txtSoKM.Text + "'  )";

            //    SqlConnect connect = new SqlConnect();
            //    connect.OpenConnect();
            //    SqlCommand cmd = new SqlCommand(sqlINSERT, connect.Conn);
            //    cmd.ExecuteNonQuery();
            //    LoadXe();
            //    connect.CloseConnect();
            //    lockTxtGara();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}

        }

        //Exit to gara
        private void btnExitGara_Click(object sender, EventArgs e)         {             lockTxtGara();             resetTxtGara();             resetEnableBtn("done");         }          //Save to gara         private void btnSaveGara_Click(object sender, EventArgs e)         {             if (checkGara == "i")             {                 if (CheckIn_Up())                 {                     string sqlINSERT = "INSERT INTO dbo.THONGTINXE( BienSoXe , HangXe ,DoiXe ,SoKhung , SoMay , SoKM) VALUES  ( '"                                 + txtBS.Text + "' ,N'" + txtHangXe.Text + "' ,N'" + txtDX.Text + "' ,N'" + txtSoKhung.Text + "' , N'"                                 + txtSoMay.Text + "' , N'" + txtSoKM.Text + "'  )";                      SqlConnect connect = new SqlConnect();                     connect.OpenConnect();                     SqlCommand cmd = new SqlCommand(sqlINSERT, connect.Conn);                     cmd.ExecuteNonQuery();                     LoadXe();                     connect.CloseConnect();                     lockTxtGara();                 }                 else                 {                     MessageBox.Show("Vui lòng điền đầy đủ thông tin!");                     resetEnableBtn("done");                     lockTxtGara();                 }             }             if (checkGara=="u")             {                 if (CheckIn_Up())                 {                     string sqlEDIT = "UPDATE THONGTINXE set DoiXe = '" + txtDX.Text + "' , SoKhung = '" + txtSoKhung.Text                                 + "', SoMay = '" + txtSoMay.Text + "', SoKM = '" + txtSoKM.Text + "' where HangXe = '" + txtHangXe.Text + "' AND BienSoXe = '" + txtBS.Text + "'";                      SqlConnect connect = new SqlConnect();                     connect.OpenConnect();                     SqlCommand cmd = new SqlCommand(sqlEDIT, connect.Conn);                     cmd.ExecuteNonQuery();                     LoadXe();                     connect.CloseConnect();                     lockTxtGara();                 }                 else                 {                     MessageBox.Show("Vui lòng chọn xe cần sửa!");                     resetTxtGara();
                    resetEnableBtn("done");                 }             }                      }           /// <summary>         /// bingding dataGridview to textbox is tbGara         /// </summary>         /// <param name="sender"></param>         /// <param name="e"></param>         private void dgvGara_CellClick(object sender, DataGridViewCellEventArgs e)         {             if (e.RowIndex >= 0)             {                 DataGridViewRow row = this.dgvGara.Rows[e.RowIndex];                 txtBS.Text = row.Cells[0].Value.ToString();                 txtHangXe.Text = row.Cells[1].Value.ToString();                 txtDX.Text = row.Cells[2].Value.ToString();                 txtSoKhung.Text = row.Cells[3].Value.ToString();                 txtSoMay.Text = row.Cells[4].Value.ToString();                 txtSoKM.Text = row.Cells[5].Value.ToString();             }          }          private void txtSearchGara_TextChanged(object sender, EventArgs e)         {             cmbShowGara.Enabled = true;             searchGara(txtSearchGara.Text, cmbShowGara.Text);         }          private void cmbShowGara_SelectedIndexChanged(object sender, EventArgs e)         {             searchGara(txtSearchGara.Text, cmbShowGara.Text);         }           #endregion          #region tbDoangThu          private void btnThongKe_Click(object sender, EventArgs e)         {             LoadData();             DataBinding();         }          private void btnxoaDT_Click_1(object sender, EventArgs e)         {             dgvThongKe.DataSource = thongKe.XoaThongKe(txthoadon.Text);             LoadData();             DataBinding();         }          private void btnxuatEL_Click_1(object sender, EventArgs e)         {             exportExcel(dgvThongKe, @"C:\Users\Vlit\Desktop\ttn", "doanhthu");         }          private void chart1_Click(object sender, EventArgs e)         {             LoadBieuDo();         }          #endregion          private void frmQLGara_Load(object sender, EventArgs e)         {             LoadXe();             LoadCmbNhanVien();             AddXuong();             LoadNhanvien();             LoadPhutung();             lockTxtGara();             LoadCmbGara();             LoadBieuDo();              cmbShowGara.Enabled = false;             //this.cmbShowGara.DropDownStyle = ComboBoxStyle.DropDownList;             btnExitGara.Enabled = false;             btnSaveGara.Enabled = false;          }               } }  