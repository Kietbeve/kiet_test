using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QliSieuThi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            txt_lg_MatKhau.UseSystemPasswordChar = !txt_lg_MatKhau.UseSystemPasswordChar;
            if (txt_lg_MatKhau.UseSystemPasswordChar)
            {
                btn_lg_ViewPass.Text = "Hiện mật khẩu";
            }
            else
            {
                btn_lg_ViewPass.Text = "Ẩn mật khẩu";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát chương trình? ","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)!=System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            fManager fManager = new fManager();
            //string tentk = txt_lg_TaiKhoan.Text;
            //string mk = txt_lg_MatKhau.Text;

            //if(tentk == "" && mk == "")
            //{
            //    MessageBox.Show("Nhap lai");
            //}
            //else
            //{
            //    bll.loginn loginn = new bll.loginn();
            //    string kt = loginn.checklogin(tentk, mk);
            //    if (kt == "tồn tại")
            //    {
            //        MessageBox.Show("đăng nhập thành công");
            //        this.Hide();
            //        fManager.ShowDialog();
            //    }

            //    else
            //        MessageBox.Show("đăng nhập thất bại");

            //}
            this.Hide();
            fManager.ShowDialog();
            this.Show();
        }
    }
}
