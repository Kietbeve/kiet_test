namespace Project_QliSieuThi.Views
{
    partial class fJobStaff
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
            this.btn_XoaCV = new System.Windows.Forms.Button();
            this.btn_SuaCV = new System.Windows.Forms.Button();
            this.btn_ThemCV = new System.Windows.Forms.Button();
            this.dgv_LoaiCongViec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaCV
            // 
            this.btn_XoaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_XoaCV.Location = new System.Drawing.Point(404, 220);
            this.btn_XoaCV.Name = "btn_XoaCV";
            this.btn_XoaCV.Size = new System.Drawing.Size(124, 37);
            this.btn_XoaCV.TabIndex = 16;
            this.btn_XoaCV.Text = "Xóa CV";
            this.btn_XoaCV.UseVisualStyleBackColor = true;
            // 
            // btn_SuaCV
            // 
            this.btn_SuaCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SuaCV.Location = new System.Drawing.Point(404, 115);
            this.btn_SuaCV.Name = "btn_SuaCV";
            this.btn_SuaCV.Size = new System.Drawing.Size(124, 37);
            this.btn_SuaCV.TabIndex = 15;
            this.btn_SuaCV.Text = "Sửa CV";
            this.btn_SuaCV.UseVisualStyleBackColor = true;
            this.btn_SuaCV.Click += new System.EventHandler(this.btn_SuaCV_Click);
            // 
            // btn_ThemCV
            // 
            this.btn_ThemCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ThemCV.Location = new System.Drawing.Point(404, 12);
            this.btn_ThemCV.Name = "btn_ThemCV";
            this.btn_ThemCV.Size = new System.Drawing.Size(124, 37);
            this.btn_ThemCV.TabIndex = 14;
            this.btn_ThemCV.Text = "Thêm CV";
            this.btn_ThemCV.UseVisualStyleBackColor = true;
            this.btn_ThemCV.Click += new System.EventHandler(this.btn_ThemCV_Click);
            // 
            // dgv_LoaiCongViec
            // 
            this.dgv_LoaiCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiCongViec.Location = new System.Drawing.Point(30, 15);
            this.dgv_LoaiCongViec.Name = "dgv_LoaiCongViec";
            this.dgv_LoaiCongViec.RowHeadersWidth = 51;
            this.dgv_LoaiCongViec.RowTemplate.Height = 24;
            this.dgv_LoaiCongViec.Size = new System.Drawing.Size(326, 481);
            this.dgv_LoaiCongViec.TabIndex = 13;
            // 
            // fJobStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 509);
            this.Controls.Add(this.btn_XoaCV);
            this.Controls.Add(this.btn_SuaCV);
            this.Controls.Add(this.btn_ThemCV);
            this.Controls.Add(this.dgv_LoaiCongViec);
            this.Name = "fJobStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_XoaCV;
        private System.Windows.Forms.Button btn_SuaCV;
        private System.Windows.Forms.Button btn_ThemCV;
        private System.Windows.Forms.DataGridView dgv_LoaiCongViec;
    }
}