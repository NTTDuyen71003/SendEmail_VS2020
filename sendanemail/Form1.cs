using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace sendanemail
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        private string subject;

        private void llbDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        Modify modify = new Modify();

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btnGuiMaOTP_Click(object sender, EventArgs e)
        {            
            if (txtEmail.Text != "" && txtMatKhau.Text != "")
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
                    MessageBox.Show("OTP đã được gửi qua mail");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string MatKhau = txtMatKhau.Text;
            string mkdatabase = "Select * from TaiKhoan where MatKhau = '" + MatKhau + "'";
            if (Email.Trim() == "") 
            { 
                MessageBox.Show("Vui lòng nhập Email!"); 
                return; 
            }
            else if (!CheckEmail(Email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
                return;
            }
            else if (MatKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đúng Mật Khẩu!");
                return;
            }
            else if (txtMatKhau.Text != mkdatabase && modify.TaiKhoans(mkdatabase).Count == 0)
            {
                MessageBox.Show("Mật Khẩu không trùng khớp!");
                return;
            }
            else
            {
                string query = "Select * from  TaiKhoan where Email = '" + Email + "'";
                if (otp.ToString().Equals(txtOtp.Text) && modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtOtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
