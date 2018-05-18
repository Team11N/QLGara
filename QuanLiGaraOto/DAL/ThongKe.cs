using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiGaraOto.DAL
{
    public class ThongKe:SqlConnect
    {
        public DataTable LayDanhSachHoaDonTheoNgay(DateTime checkIn, DateTime checkOut)
        {
            return ThucThiQuery("exec LayDanhSachHoaDonTheoNgay @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable XoaThongKe(string ma)
        {
            return ThucThiQuery("exec XoaHoaDon @ma", new object[] { ma });
        }
        public DataTable BieuDo()
        {
            return ThucThiQuery("exec bieudo");
        }

    }
}
