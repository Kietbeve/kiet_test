using Project_QliSieuThi.bll;
using Project_QliSieuThi.Views;
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
    public partial class fManager : Form
    {
        public fManager()
        {
            InitializeComponent();
            fTypeGoods fTypeGoods = new fTypeGoods();
            hienthisp();
            foreach (DataGridViewRow row in dataView_qlsp.Rows)
            {
                // Kiểm tra để tránh thêm hàng trống
                if (row.Cells["malsp"].Value != null)
                {
                    cbb_qlsp_LoaiNhanVien.Items.Add((row.Cells["malsp"].Value.ToString()));
                }
            }
            
        }

        public void hienthisp()
        {
            List<data_object.sanpham> listSP = data_provider.qlsanpham.Instance.layds();
            dataView_qlsp.DataSource = listSP;

        }

        private void btn_qlnv_XemChiTiet_Click(object sender, EventArgs e)
        {

            fViewInfoNhanVien fViewInfoNhanVien = new fViewInfoNhanVien();           
            fViewInfoNhanVien.ShowDialog();
        }

        private void btn_qlsp_XemChiTiet_Click(object sender, EventArgs e)
        {
            fViewInfoGoods fViewInfoSanPham = new fViewInfoGoods();
            if (dataView_qlsp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataView_qlsp.SelectedRows[0];
                string masp = selectedRow.Cells["masp"].Value.ToString();
                string tensp = selectedRow.Cells["tensp"].Value.ToString();
                string malsp = selectedRow.Cells["malsp"].Value.ToString();
                string soluong = selectedRow.Cells["soluong"].Value.ToString();
                string dongiaban = selectedRow.Cells["dongiaban"].Value.ToString();
                string dongianhap = selectedRow.Cells["dongianhap"].Value.ToString();

                fViewInfoSanPham.tt(masp, tensp, malsp, soluong, dongiaban, dongianhap);

                fViewInfoSanPham.ShowDialog();
            }
            else
                MessageBox.Show("Chưa chọn hàng cần xem");
            
        }

        private void btn_qlsp_NhapHang_Click(object sender, EventArgs e)
        {
            fImportGoods fImportGoods = new fImportGoods();
            this.Hide();
            fImportGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlsp_SuaSanPham_Click(object sender, EventArgs e)
        {

            fGoodsUpdate fGoodsUpdate = new fGoodsUpdate();
            if (dataView_qlsp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataView_qlsp.SelectedRows[0];
                string masp = selectedRow.Cells["masp"].Value.ToString();
                string tensp = selectedRow.Cells["tensp"].Value.ToString();
                string malsp = selectedRow.Cells["malsp"].Value.ToString();
                string soluong = selectedRow.Cells["soluong"].Value.ToString();
                string dongiaban = selectedRow.Cells["dongiaban"].Value.ToString();
                string dongianhap = selectedRow.Cells["dongianhap"].Value.ToString();

                fGoodsUpdate.tt(masp, tensp, malsp, soluong, dongiaban, dongianhap);

                fGoodsUpdate.ShowDialog();

                Close();
            }
            else
                MessageBox.Show("Chưa chọn sản phẩm cần sửa");

        }

        private void btn_qlnv_SuaNhanVien_Click(object sender, EventArgs e)
        {
            fStaffUpdate fStaffUpdate = new fStaffUpdate();
            fStaffUpdate.ShowDialog();
        }

        private void btn_qlsp_LoaiSanPham_Click(object sender, EventArgs e)
        {

            fTypeGoods fTypeGoods = new fTypeGoods();
            this.Hide();
            fTypeGoods.ShowDialog();
            this.Show();
        }

        private void btn_qlnv_LoaiNhanVien_Click(object sender, EventArgs e)
        {

            fJobStaff fJobStaff = new fJobStaff();
            this.Hide();
            fJobStaff.ShowDialog();
            this.Show();
        }

        private void btn_qlnv_ThemNhanVien_Click(object sender, EventArgs e)
        {
            fAddStaff fAddStaff = new fAddStaff();
            fAddStaff.ShowDialog();
        }

        private void btn_qlsp_XoaHang_Click(object sender, EventArgs e)
        {
            if (dataView_qlsp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataView_qlsp.SelectedRows[0];

                bll.qlsp qlsp = new bll.qlsp();
                var masp = selectedRow.Cells["masp"].Value;
                //MessageBox.Show(selectedRow.Cells["masp"].Value.ToString());
                int kt = qlsp.dlt((int)(masp));
                if (kt == 1)
                {
                    MessageBox.Show("thành công");
                }
                else
                {
                    MessageBox.Show(" ko thành công");
                }
                hienthisp();
            }
            else
                MessageBox.Show("Chưa chọn mặt hàng!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btn_qlnv_XoaNhanVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa chọn nhân viên!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataView_qlsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void btn_qlsp_TimKiem_Click(object sender, EventArgs e)
        {
            if (rdb_qlsp_TenSanPham.Checked){
                string tensp = txt_qlsp_TenSanPham.Text;
                if (tensp != "")
                {
                    bll.qlsp qlsp = new bll.qlsp();
                    int kt = qlsp.layttbangten(tensp);
                    if (kt == 1)
                    {
                        //MessageBox.Show("tc");
                        List<data_object.sanpham> sp = data_provider.qlsanpham.Instance.laydsbangtensp(tensp);
                        dataView_qlsp.DataSource = sp;
                    }
                    else
                        MessageBox.Show("Lỗi ");
                }
                else
                    MessageBox.Show("Chưa nhập tên sản phẩm");
            }
            else if (rdb_qlsp_TatCa.Checked)
            {
                hienthisp();
            }
            else if(rdb_qlsp_LoaiSanPham.Checked)
            {
                
                if (cbb_qlsp_LoaiNhanVien.Text != "")
                {
                    int malsp = Convert.ToInt32(cbb_qlsp_LoaiNhanVien.Text);
                    bll.qlsp qlsp = new bll.qlsp();
                    int kt = qlsp.layttbangloai(malsp);
                    if (kt == 1)
                    {
                        MessageBox.Show("tc");
                        List<data_object.sanpham> sp = data_provider.qlsanpham.Instance.laydsbanglsp(malsp);
                        dataView_qlsp.DataSource = sp;
                    }
                    else
                        MessageBox.Show("....");
                }
                else
                    MessageBox.Show("Chưa nhập mã loại sản phẩm");
            }
        }

        private void cbb_qlsp_LoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {                
                    
                
        }
    }
}
