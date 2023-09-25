using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.WebRequestMethods;
using System.Net.Mail;
using System.Net;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace sendanemail
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        Random random = new Random();
        int otp;
        private string subject;

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }


        Modify modify = new Modify();

        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
            }
            else
            {
                try
                {
                    otp = random.Next(100000, 1000000);
                    var fromAddress = new MailAddress("nhutran211820@gmail.com");
                    var toAddress = new MailAddress(txtEmail.ToString());
                    const string frompass = "fmsbjbtnvwrxcfiz"; // xac thuc 2 buoc de nhan ma
                    string body = otp.ToString();

                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body,
                    })
                    {
                        smtp.Send(message);
                    }
                    MessageBox.Show("OTP đã được gửi qua Email.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            string HoTen = txtHoten.Text;
            string SDT = txtSDT.Text;
            string Email = txtEmail.Text;
            string MatKhau = txtMatKhau.Text;
            string XacNhanMatKhau = txtXacNhanMatKhau.Text;
            string MaXN = txtMaXN.Text;

            if (txtHoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Họ Tên!");
                return;
            }
            else if (txtSDT.Text == "" || txtSDT.TextLength < 10 || txtSDT.TextLength > 10)
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại gồm 10 chữ số!");
                return;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return;
            }
            else if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
                return;
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu!");
                return;
            }
            else if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng xác nhận đúng Mật Khẩu đã đăng ký!");
                return;
            }
            else if (!txtMatKhau.Text.Equals(txtXacNhanMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }
            else if (txtMaXN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập OTP!");
                return;
            }
            else if (modify.TaiKhoans("Select * from TaiKhoan where Email = '" + Email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được sử dụng! Vui lòng sử dụng Email khác. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    if (otp.ToString().Equals(txtMaXN.Text))
                    {
                        MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string query = "Insert into TaiKhoan values ('" + HoTen + "','" + SDT + "', '" + MatKhau + "', '" + Email + "')";
                        modify.Command(query);
                    }
                    else
                    {
                        MessageBox.Show("OTP không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Tài khoản Email này đã được đăng ký! Vui lòng đăng ký tài khoản Email khác.");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ngăn người dùng nhập chữ vào khung số điện thoại
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar)) 
            { 
                e.Handled = true;
            }
        }

        private void txtHoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMaXN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
