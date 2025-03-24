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
    public partial class fViewInfoGoods : Form
    {
        public fViewInfoGoods()
        {
            InitializeComponent();
        }

        private void fViewInfoGoods_Load(object sender, EventArgs e)
        {

        }

        public void tt (string masp, string tensp, string malsp, string soluong, string dongiaban, string dongianhap)
        {
            lbl_tt_MaSP.Text = masp;
            lbl_tt_TenSP.Text = tensp;
            lbl_tt_MaLSP.Text = malsp;
            lbl_tt_SoLuong.Text = soluong;
            lbl_tt_DonGiaBan.Text = dongiaban;
            lbl_tt_DonGiaNhap.Text = dongianhap;


        }
    }
}
