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
    public partial class fUpdateTypeGoods : Form
    {
        public fUpdateTypeGoods()
        {
            InitializeComponent();
        }

        public void tt(string malsp, string tenlsp)
        {
            //cbb_DsLoai.Items.Add(tenlsp);
            txt_malsp.Text = malsp;
            txt_tenlsp.Text = tenlsp;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            //txt_ChinhSua.Text = cbb_DsLoai.Text;
            int malsp = Convert.ToInt32(txt_malsp.Text);
            string tenlsp = txt_tenlsp.Text;

            bll.loaisp loaisp = new bll.loaisp();
            int kt = loaisp.sua(malsp,tenlsp);
            if(kt == 1)
            {
                fTypeGoods fTypeGoods = new fTypeGoods();
                MessageBox.Show("Sửa thành công");
                fTypeGoods.hienthilsp();
                fTypeGoods.ShowDialog();
                Close();
            }
            else
                MessageBox.Show("Sửa thất bại");

            Close();
        }

        private void cbb_DsLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fUpdateTypeGoods_Load(object sender, EventArgs e)
        {

        }
    }
}
