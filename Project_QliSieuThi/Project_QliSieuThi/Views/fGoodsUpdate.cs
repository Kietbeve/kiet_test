using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QliSieuThi.Views
{
    public partial class fGoodsUpdate : Form
    {
        public fGoodsUpdate()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_GioiTinh_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_DiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_NgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_MaCV_Click(object sender, EventArgs e)
        {

        }

        private void lbl_vinv_TenNhanVien_Click(object sender, EventArgs e)
        {

        }

        

        private void ptb__Click(object sender, EventArgs e)
        {

        }

        private void fGoodsUpdate_Load(object sender, EventArgs e)
        {

        }

        public void tt(string masp, string tensp, string malsp, string soluong, string dongiaban, string dongianhap)
        {
            txt_MaSP.Text = masp;
            txt_TenSP.Text = tensp;
            txt_MaLoai.Text = malsp;
            txt_SoLuong.Text = soluong;
            txt_DonGiaBan.Text = dongiaban;
            txt_DonGiaNhap.Text = dongianhap;


        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {

            fManager fManager = new fManager();
            int masp = Convert.ToInt32(txt_MaSP.Text);
            string tensp = txt_TenSP.Text;
            int malsp = Convert.ToInt32(txt_MaLoai.Text);
            int sl= Convert.ToInt32(txt_SoLuong.Text);
            int dongiaban = Convert.ToInt32(txt_DonGiaBan.Text);
            int dongianhap = Convert.ToInt32(txt_DonGiaNhap.Text);

            bll.qlsp qlsp = new bll.qlsp();
            int kt = qlsp.sua(masp, tensp, malsp, sl, dongiaban, dongianhap);
            if (kt == 1)
            {
                MessageBox.Show("thành công");
                this.Hide();
                fManager.hienthisp();
                fManager.ShowDialog();
            }
            else
            {
                MessageBox.Show(" ko thành công");
            }
            
            //this.Show();
            Close();
        }
    }
}
