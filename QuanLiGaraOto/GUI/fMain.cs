using QuanLiGaraOto.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGaraOto
{
    public partial class fMain : Form
    {
       
        public fMain()
        {
            InitializeComponent();
            
              LoadXe();
             LoadComboBox();
            AddXuong();
             LoadNhanvien();
            LoadPhutung();
            LoadKhachHang();


        }

    

        void LoadNhanvien()
        {  
            string query = "select * from NHANVIEN ";
            SqlConnect connect = new SqlConnect();
            dataGridView1.DataSource = connect.ExecuteQuery(query);
           
        
        }
        void LoadXe()
        {
            string query = "select * from THONGTINXE";
            SqlConnect connect = new SqlConnect();
            dataGridView2.DataSource = connect.ExecuteQuery(query);

        }

        void LoadPhutung()
        {
            string query = "select MAPHIEUVATTU AS ' MaPhuTung',MaPhieuKhaoSat,TenVatLieu,NhaCungCap,SoLuong,SoTien  from PHIEUVATTU ";
            SqlConnect connect = new SqlConnect();
            dataGridView4.DataSource = connect.ExecuteQuery(query);
        }
        void LoadKhachHang()
        {
            string query = "select * from KHACHHANG ";
            SqlConnect connect = new SqlConnect();
            dataGridView5.DataSource = connect.ExecuteQuery(query);
        }
            public void LoadComboBox()
        {
                string query ="Select * From XUONG,NHANVIEN WHERE NHANVIEN.TENXUONG = XUONG.TENXUONG ";

                SqlConnect connect = new SqlConnect();
                comboBox1.DataSource =connect.ExecuteQuery(query) ;
                comboBox1.DisplayMember = "TenXuong";
                comboBox1.ValueMember = "TenXuong";
            
        }

        private void fMain_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
         
        }
        
        public void AddXuong()
        {
            textBox9.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "DiaChi"));
            textBox10.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Email"));
            textBox11.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "Website"));
            textBox12.DataBindings.Add(new Binding("Text", comboBox1.DataSource, "MaNguoiPhuTrach"));
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlINSERT = "insert into THONGTINXE values (@BienSoXe, @HangXe, @DoiXe,@SoKhung,@SoMay,@SoKM)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlINSERT, connection);
            cmd.Parameters.AddWithValue("BienSoXe", textBox3.Text);
            cmd.Parameters.AddWithValue("HangXe", textBox6.Text);
            cmd.Parameters.AddWithValue("DoiXe", textBox4.Text);
            cmd.Parameters.AddWithValue("SoKhung", textBox5.Text);
            cmd.Parameters.AddWithValue("SoMay", textBox8.Text);
            cmd.Parameters.AddWithValue("SoKM", textBox7.Text);
            cmd.ExecuteNonQuery();
            LoadXe();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlEDIT = "update  THONGTINXE set  HangXe = @HangXe, DoiXe = @DoiXe , SoKhung = @SoKhung, SoMay = @SoMay, SoKM = @SoKM where BienSoXe = @BienSoXe";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlEDIT, connection);
            cmd.Parameters.AddWithValue("BienSoXe", textBox3.Text);
            cmd.Parameters.AddWithValue("HangXe", textBox6.Text);
            cmd.Parameters.AddWithValue("DoiXe", textBox4.Text);
            cmd.Parameters.AddWithValue("SoKhung", textBox5.Text);
            cmd.Parameters.AddWithValue("SoMay", textBox8.Text);
            cmd.Parameters.AddWithValue("SoKM", textBox7.Text);
            cmd.ExecuteNonQuery();
            LoadXe();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlDELETE = "delete from ThongTinXe where BienSoXe = @BienSoXe";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlDELETE, connection);
            cmd.Parameters.AddWithValue("BienSoXe", textBox3.Text);
            cmd.Parameters.AddWithValue("HangXe", textBox6.Text);
            cmd.Parameters.AddWithValue("DoiXe", textBox4.Text);
            cmd.Parameters.AddWithValue("SoKhung", textBox5.Text);
            cmd.Parameters.AddWithValue("SoMay", textBox8.Text);
            cmd.Parameters.AddWithValue("SoKM", textBox7.Text);
            cmd.ExecuteNonQuery();
            LoadXe();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlSEARCH = "select* from ThongTinXe where BienSoXe = @BienSoXe";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlSEARCH, connection);
            cmd.Parameters.AddWithValue("BienSoXe", textBox2.Text);
            cmd.Parameters.AddWithValue("HangXe", textBox6.Text);
            cmd.Parameters.AddWithValue("DoiXe", textBox4.Text);
            cmd.Parameters.AddWithValue("SoKhung", textBox5.Text);
            cmd.Parameters.AddWithValue("SoMay", textBox8.Text);
            cmd.Parameters.AddWithValue("SoKM", textBox7.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlINSERT = "insert into NHANVIEN values (@MaNV, @HoTen, @SDT,@NgaySinh,@GioiTinh,@DiaChi,@TenXuong)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlINSERT, connection);
            cmd.Parameters.AddWithValue("MaNV", textBox13.Text);
            cmd.Parameters.AddWithValue("HoTen", textBox14.Text);
            cmd.Parameters.AddWithValue("SDT", textBox15.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBox16.Text);
            cmd.Parameters.AddWithValue("GioiTinh", textBox17.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBox18.Text);
            cmd.Parameters.AddWithValue("TenXuong", textBox19.Text);
            cmd.ExecuteNonQuery();
            LoadNhanvien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlEDIT1 = "update  NHANVIEN set HoTen = @HoTen,SDT = @SDT,NgaySinh = @NgaySinh, GioiTinh =@GioiTinh , DiaChi = @DiaChi,TenXuong = @TenXuong where MaNV = @MaNV";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlEDIT1, connection);
            cmd.Parameters.AddWithValue("MaNV", textBox13.Text);
            cmd.Parameters.AddWithValue("HoTen", textBox14.Text);
            cmd.Parameters.AddWithValue("SDT", textBox15.Text);
            cmd.Parameters.AddWithValue("NgaySinh", textBox16.Text);
            cmd.Parameters.AddWithValue("GioiTinh", textBox17.Text);
            cmd.Parameters.AddWithValue("DiaChi", textBox18.Text);
            cmd.Parameters.AddWithValue("TenXuong", textBox19.Text);
            cmd.ExecuteNonQuery();
            LoadNhanvien();
        }

       
    

    private void btnXoa_Click(object sender, EventArgs e)
    {

        string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionSTR);
        string sqlDELETE = "delete from NHANVIEN where MaNV = @MaNV";
        connection.Open();
        SqlCommand cmd = new SqlCommand(sqlDELETE, connection);
        cmd.Parameters.AddWithValue("MaNV", textBox13.Text);
        cmd.Parameters.AddWithValue("HoTen", textBox14.Text);
        cmd.Parameters.AddWithValue("SDT", textBox15.Text);
        cmd.Parameters.AddWithValue("NgaySinh", textBox16.Text);
        cmd.Parameters.AddWithValue("GioiTinh", textBox17.Text);
        cmd.Parameters.AddWithValue("DiaChi", textBox18.Text);
        cmd.Parameters.AddWithValue("TenXuong", textBox19.Text);
        cmd.ExecuteNonQuery();
        LoadNhanvien();
    }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlSEARCH = "select* from NHANVIEN where MaNV = @MaNV";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlSEARCH, connection);
            cmd.Parameters.AddWithValue("MaNV", textBox1.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlINSERT = "insert into PHIEUVATTU values (@MaPhieuVatTu, @MaPhieuKhaoSat, @TenVatLieu,@NhaCungCap,@SoLuong,@SoTien)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlINSERT, connection);
            cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);
            cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);
            cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);
            cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);
            cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);
            cmd.Parameters.AddWithValue("SoTien", textBox26.Text);
            cmd.ExecuteNonQuery();
            LoadPhutung();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlEDIT1 = "update  PHIEUVATTU set MaPhieuVatTu  = @MaPhieuVatTu,MaPhieuKhaoSat = @MaPhieuKhaoSat,TenVatLieu = @TenVatLieu, NhaCungCap =@NhaCungCap , SoLuong = @SoLuong,SoTien = @SoTien where MaPhieuVatTu = @MaPhieuVatTu";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlEDIT1, connection);
            cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);
            cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);
            cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);
            cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);
            cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);
            cmd.Parameters.AddWithValue("SoTien", textBox26.Text);
            cmd.ExecuteNonQuery();
            LoadPhutung();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlDELETE = "delete from PHIEUVATTU where MaPhieuVatTu = @MaPhieuVatTu";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlDELETE, connection);
            cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox21.Text);
            cmd.Parameters.AddWithValue("MaPhieuKhaoSat", textBox22.Text);
            cmd.Parameters.AddWithValue("TenVatLieu", textBox23.Text);
            cmd.Parameters.AddWithValue("NhaCungCap", textBox24.Text);
            cmd.Parameters.AddWithValue("SoLuong", textBox25.Text);
            cmd.Parameters.AddWithValue("SoTien", textBox26.Text);
            cmd.ExecuteNonQuery();
            LoadPhutung();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.label28.ForeColor = Color.Red;
            this.label29.ForeColor = Color.Red;
            this.label30.ForeColor = Color.Red;
            this.label31.ForeColor = Color.Red;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.label28.ForeColor = Color.Green;
            this.label29.ForeColor = Color.Green;
            this.label30.ForeColor = Color.Green;
            this.label31.ForeColor = Color.Green;
        }
            private void timer3_Tick(object sender, EventArgs e)
        {
            this.label28.ForeColor = Color.Violet;
            this.label29.ForeColor = Color.Violet;
            this.label30.ForeColor = Color.Violet;
            this.label31.ForeColor = Color.Violet;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);
            string sqlSEARCH = "select* from PHIEUVATTU where MaPhieuVatTu = @MaPhieuVatTu";
            connection.Open();
            SqlCommand cmd = new SqlCommand(sqlSEARCH, connection);
            cmd.Parameters.AddWithValue("MaPhieuVatTu", textBox20.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView4.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadPhutung();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

