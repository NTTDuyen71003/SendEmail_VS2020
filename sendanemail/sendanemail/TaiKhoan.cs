using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sendanemail
{
    internal class TaiKhoan
    {
        private string HoTen;
        private string SDT;
        private string MatKhau;
        public TaiKhoan()
        {
        }
        public TaiKhoan(string HoTen, string SDT, string MatKhau)
        {
            this.HoTen = HoTen;
            this.SDT = SDT;
            this.MatKhau = MatKhau;
        }
        public String Hoten { get => HoTen; set => HoTen = value; }
        public String sdt { get => SDT; set => SDT = value; }
        public String matkhau { get => MatKhau; set => MatKhau = value; }
    }

}
