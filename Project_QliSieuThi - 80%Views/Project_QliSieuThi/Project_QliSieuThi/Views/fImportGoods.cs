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
    public partial class fImportGoods : Form
    {
        public fImportGoods()
        {
            InitializeComponent();
            hienthisp();
            foreach (DataGridViewRow row in dgv_nhaphang_qlsp.Rows)
            {
                // Kiểm tra để tránh thêm hàng trống
                if (row.Cells["malsp"].Value != null)
                {
                    cbb_mal.Items.Add((row.Cells["malsp"].Value.ToString()));
                }
            }
            // Đăng ký sự kiện SelectionChanged
            this.dgv_nhaphang_dshoadon.CellClick += new DataGridViewCellEventHandler(this.dgv_nhaphang_dshoadon_CellContentClick);
           
        }
        private int sl_bandau = 0;
        public void hienthisp()
        {
            List<data_object.sanpham> listSP = data_provider.qlsanpham.Instance.layds();
            dgv_nhaphang_qlsp.DataSource = listSP;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (txt_nhaphang_tenspthem.Text != "" && cbb_mal.Text != "" && num_soluong.Text != "" && txt_dongiaban.Text != "" && txt_dongianhap.Text != "")
            {
                string tensp = txt_nhaphang_tenspthem.Text;
                int malsp = Convert.ToInt32(cbb_mal.Text);
                int soluong = Convert.ToInt32(num_soluong.Text);
                int dongiaban = Convert.ToInt32(txt_dongiaban.Text);
                int dongianhap = Convert.ToInt32(txt_dongianhap.Text);
                bll.qlsp qlsp = new bll.qlsp();
                int kt = qlsp.them(tensp, malsp, soluong, dongiaban, dongianhap);
                if (kt == 1)
                {
                    MessageBox.Show("Thêm thành công");
                    hienthisp();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tensp = txt_nhaphang_tensp.Text;
            if (tensp != "")
            {
                bll.qlsp qlsp = new bll.qlsp();
                int kt = qlsp.layttbangten(tensp);
                if (kt == 1)
                {
                    //MessageBox.Show("tc");
                    List<data_object.sanpham> sp = data_provider.qlsanpham.Instance.laydsbangtensp(tensp);
                    dgv_nhaphang_qlsp.DataSource = sp;
                }
                else
                    MessageBox.Show("Lỗi");
            }
            MessageBox.Show("Chưa nhập tên sp cần tìm");
        }

        private void fImportGoods_Load(object sender, EventArgs e)
        {

        }

        private void btn_nhaphang_them_Click(object sender, EventArgs e)
        {
            //dgv_nhaphang_dshoadon.Rows.Clear();
            if (dgv_nhaphang_qlsp.SelectedRows.Count > 0)
            {
                if (dgv_nhaphang_dshoadon.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn column in dgv_nhaphang_qlsp.Columns)
                    {
                        dgv_nhaphang_dshoadon.Columns.Add(column.Name, column.HeaderText);
                    }
                }

                // Duyệt qua các hàng được chọn trong DataGridView nguồn
                foreach (DataGridViewRow row in dgv_nhaphang_qlsp.SelectedRows)
                {
                    // Kiểm tra nếu dòng không phải là dòng mới (dòng trống)
                    if (!row.IsNewRow)
                    {
                        int rowIndex = dgv_nhaphang_dshoadon.Rows.Add(); // Thêm một dòng mới vào DataGridView đích
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            dgv_nhaphang_dshoadon.Rows[rowIndex].Cells[i].Value = row.Cells[i].Value; // Sao chép giá trị từ ô nguồn sang ô đích
                        }
                    }
                }

            }
            else
                MessageBox.Show("Vui lòng chọn hàng");


        }



        private void dgv_nhaphang_dshoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_nhaphang_dshoadon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn hàng");
            }
            else
            {
                DataGridViewRow row = dgv_nhaphang_dshoadon.SelectedRows[0];
                txt_nhaphang_tendssp.Text = row.Cells["tensp"].Value.ToString();
                txt_ds_sl.Text = row.Cells["soluong"].Value.ToString();
                sl_bandau = Convert.ToInt32(row.Cells["soluong"].Value);
            }


            //MessageBox.Show(row.Cells["tensp"].Value.ToString());
        }


        private int sum = 0;
        private int temp = 0;
        
        private void btn_nhaphang_suasl_Click(object sender, EventArgs e)
        {
            if(temp  == 0)
            {
                temp = sl_bandau;
            }
            if (dgv_nhaphang_dshoadon.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv_nhaphang_dshoadon.SelectedRows[0];
                row.Cells["tensp"].Value = txt_nhaphang_tendssp.Text;
                row.Cells["soluong"].Value = txt_ds_sl.Text;
                
                //int sl_bandau = Convert.ToInt32(row.Cells["soluong"].Value);
                int sl_nhapvao = Convert.ToInt32(txt_ds_sl.Text) - temp;
                //MessageBox.Show(sl_nhapvao.ToString());
                
                sum += Convert.ToInt32(sl_nhapvao) * Convert.ToInt32(row.Cells["dongianhap"].Value);
                temp = Convert.ToInt32(row.Cells["soluong"].Value);
                txt_tonghd.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Chọn hàng cần nhập hàng");
            }

           

        }

        private void btn_nhaphang_dathang_Click(object sender, EventArgs e)
        {
            int masp, malsp, sl, dongiaban, dongianhap;
            string tensp;
            //DataGridViewRow row = dgv_nhaphang_dshoadon.SelectedRows[0];
            foreach(DataGridViewRow row in dgv_nhaphang_dshoadon.Rows) {
                masp = Convert.ToInt32(row.Cells["masp"].Value);              
                sl = Convert.ToInt32(row.Cells["soluong"].Value);
                data_provider.qlsanpham.Instance.suasl(masp, sl);
            }

            hienthisp();


        }

        private void btn_nhaphang_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_nhaphang_dshoadon.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn hàng cần xóa");
            }
            else
            {
                DataGridViewRow row = dgv_nhaphang_dshoadon.SelectedRows[0];
                dgv_nhaphang_dshoadon.Rows.Remove(row);
            }
        }

        private void dgv_nhaphang_qlsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
