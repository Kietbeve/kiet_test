using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_QliSieuThi.Views
{
    public partial class fTypeGoods : Form
    {
        public fTypeGoods()
        {
            InitializeComponent();
            hienthilsp();
        }

        public void hienthilsp()
        {
            List<data_object.loaisanpham> listLSP = data_provider.loaisp.Instance.layds();
            dgv_LoaiSanPham.DataSource = listLSP;
        }

       

        private void btn_SuaLoai_Click(object sender, EventArgs e)
        {
            fUpdateTypeGoods fUpdateTypeGoods = new fUpdateTypeGoods();
            if (dgv_LoaiSanPham.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_LoaiSanPham.SelectedRows[0];
                //foreach (DataGridViewRow row in dgv_LoaiSanPham.Rows)
                //{
                //    // Kiểm tra để tránh thêm hàng trống
                //    if (row.Cells["tenlsp"].Value != null)
                //    {
                //        fUpdateTypeGoods.tt((row.Cells["tenlsp"].Value.ToString()));
                //    }
                //}
                string malsp = row.Cells["malsp"].Value.ToString();
                string tenlsp = row.Cells["tenlsp"].Value.ToString();
                fUpdateTypeGoods.tt(malsp, tenlsp);
                fUpdateTypeGoods.ShowDialog();

                Close();
            }
            else
                MessageBox.Show("Chưa chọn hàng cần sửa");
        }

        private void fTypeGoods_Load(object sender, EventArgs e)
        {

        }

        private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btn_ThemLoai_Click(object sender, EventArgs e)
        {
            
            fAddTypeGoods fAddTypeGoods = new fAddTypeGoods();       
            
            fAddTypeGoods.ShowDialog();

            Close();
        }

        private void btn_XoaLoai_Click(object sender, EventArgs e)
        {
            if (dgv_LoaiSanPham.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa nhập hàng cần xóa");
            }
            else
            {
                DataGridViewRow row = dgv_LoaiSanPham.SelectedRows[0];
                int malsp = Convert.ToInt32(row.Cells["malsp"].Value.ToString());
                bll.loaisp loaisp = new bll.loaisp();
                int kt = loaisp.xoa(malsp);
                if (kt == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    hienthilsp();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }
    }
}
