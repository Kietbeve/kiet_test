using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Project_QliSieuThi.Views
{
    public partial class fAddTypeGoods : Form
    {
        public fAddTypeGoods()
        {
            InitializeComponent();
        }

        public void tt(int tensp)
        {
            txt_LoaiMoi.Text = tensp.ToString();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            fTypeGoods fTypeGoods = new fTypeGoods();
            string tenlsp = txt_LoaiMoi.Text;
            if (tenlsp == "")
            {
                MessageBox.Show("Nhap lai");
            }
            else
            {
                bll.loaisp loaisp = new bll.loaisp();
                int kt = loaisp.them(tenlsp);
                if (kt == 1)
                {
                    MessageBox.Show("thêm thành công");
                    this.Hide();
                    fTypeGoods.hienthilsp();
                    fTypeGoods.ShowDialog();
                    Close();
                }

                else
                    MessageBox.Show("thêm thất bại");

            }
            this.Show();
        }

        private void fAddTypeGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
