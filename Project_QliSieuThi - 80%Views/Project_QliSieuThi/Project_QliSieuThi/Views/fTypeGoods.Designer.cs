namespace Project_QliSieuThi.Views
{
    partial class fTypeGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_LoaiSanPham = new System.Windows.Forms.DataGridView();
            this.btn_SuaLoai = new System.Windows.Forms.Button();
            this.btn_XoaLoai = new System.Windows.Forms.Button();
            this.btn_ThemLoai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiSanPham
            // 
            this.dgv_LoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiSanPham.Location = new System.Drawing.Point(14, 20);
            this.dgv_LoaiSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_LoaiSanPham.Name = "dgv_LoaiSanPham";
            this.dgv_LoaiSanPham.RowHeadersWidth = 51;
            this.dgv_LoaiSanPham.RowTemplate.Height = 24;
            this.dgv_LoaiSanPham.Size = new System.Drawing.Size(367, 601);
            this.dgv_LoaiSanPham.TabIndex = 0;
            // 
            // btn_SuaLoai
            // 
            this.btn_SuaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaLoai.Location = new System.Drawing.Point(434, 145);
            this.btn_SuaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SuaLoai.Name = "btn_SuaLoai";
            this.btn_SuaLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_SuaLoai.TabIndex = 11;
            this.btn_SuaLoai.Text = "Sửa loại";
            this.btn_SuaLoai.UseVisualStyleBackColor = true;
            this.btn_SuaLoai.Click += new System.EventHandler(this.btn_SuaLoai_Click);
            // 
            // btn_XoaLoai
            // 
            this.btn_XoaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaLoai.Location = new System.Drawing.Point(434, 276);
            this.btn_XoaLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaLoai.Name = "btn_XoaLoai";
            this.btn_XoaLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_XoaLoai.TabIndex = 12;
            this.btn_XoaLoai.Text = "Xóa loại";
            this.btn_XoaLoai.UseVisualStyleBackColor = true;
            this.btn_XoaLoai.Click += new System.EventHandler(this.btn_XoaLoai_Click);
            // 
            // btn_ThemLoai
            // 
            this.btn_ThemLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemLoai.Location = new System.Drawing.Point(434, 20);
            this.btn_ThemLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemLoai.Name = "btn_ThemLoai";
            this.btn_ThemLoai.Size = new System.Drawing.Size(140, 46);
            this.btn_ThemLoai.TabIndex = 13;
            this.btn_ThemLoai.Text = "Thêm loại";
            this.btn_ThemLoai.UseVisualStyleBackColor = true;
            this.btn_ThemLoai.Click += new System.EventHandler(this.btn_ThemLoai_Click);
            // 
            // fTypeGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 636);
            this.Controls.Add(this.btn_ThemLoai);
            this.Controls.Add(this.btn_XoaLoai);
            this.Controls.Add(this.btn_SuaLoai);
            this.Controls.Add(this.dgv_LoaiSanPham);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fTypeGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Type Goods";
            this.Load += new System.EventHandler(this.fTypeGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiSanPham;
        private System.Windows.Forms.Button btn_SuaLoai;
        private System.Windows.Forms.Button btn_XoaLoai;
        private System.Windows.Forms.Button btn_ThemLoai;
    }
}