using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiGaraOto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            WaterMark();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=QLGara;Integrated Security=True");
            try
            {
                connection.Open();
                string tk = tbTaikhoan.Text;
                string mk = tbMatkhau.Text;
                string sql = "select * from TaiKhoan where TaiKhoan = '" + tk + "' and MatKhau = '" + mk + "' ";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader sqlData = command.ExecuteReader();
                if(sqlData.Read() == true)
                {
                    frmQLGara f = new frmQLGara();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    
                }
                else
                {

                    MessageBox.Show("Tài khoản mật khẩu không chính xác!!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("lỗi !!!",ex.ToString());
            }
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void tbTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMatkhau_TextChanged(object sender, EventArgs e)
        {

        }
        public void WaterMark()
        {
            tbTaikhoan.ForeColor = Color.LightGray;
            tbTaikhoan.Text = "User name";
            this.tbTaikhoan.Leave += new System.EventHandler(this.tbTaikhoan_Leave);
            this.tbTaikhoan.Enter += new System.EventHandler(this.tbTaikhoan_Enter);

            tbMatkhau.ForeColor = Color.LightGray;
            tbMatkhau.Text = "Password";
            this.tbMatkhau.Leave += new System.EventHandler(this.tbMatkhau_Leave);
            this.tbMatkhau.Enter += new System.EventHandler(this.tbMatkhau_Enter);
        }
        private void tbTaikhoan_Leave(object sender, EventArgs e)
        {
            if (tbTaikhoan.Text=="")
            {
                tbTaikhoan.Text = "User name";
                tbTaikhoan.ForeColor = Color.Gray;
            }
        }

        private void tbTaikhoan_Enter(object sender, EventArgs e)
        {
            if (tbTaikhoan.Text != "")
            {
                tbTaikhoan.Text = "";
                tbTaikhoan.ForeColor = Color.Black;
            }
        }

        private void tbMatkhau_Leave(object sender, EventArgs e)
        {
            if (tbMatkhau.Text == "")
            {
                tbMatkhau.Text = "Password";
                tbMatkhau.ForeColor = Color.Gray;
            }
        }

        private void tbMatkhau_Enter(object sender, EventArgs e)
        {
            if (tbMatkhau.Text != "")
            {
                tbMatkhau.Text = "";
                tbMatkhau.ForeColor = Color.Black;
            }
        }
    }
}
