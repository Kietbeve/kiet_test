namespace Project_QliSieuThi.Views
{
    partial class fAddJobStaff
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
            this.btn_Ok = new System.Windows.Forms.Button();
            this.txt_LoaiMoi = new System.Windows.Forms.TextBox();
            this.lbl_vinv_MaNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ok.Location = new System.Drawing.Point(342, 75);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(124, 37);
            this.btn_Ok.TabIndex = 79;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // txt_LoaiMoi
            // 
            this.txt_LoaiMoi.Location = new System.Drawing.Point(83, 48);
            this.txt_LoaiMoi.Name = "txt_LoaiMoi";
            this.txt_LoaiMoi.Size = new System.Drawing.Size(182, 22);
            this.txt_LoaiMoi.TabIndex = 78;
            // 
            // lbl_vinv_MaNV
            // 
            this.lbl_vinv_MaNV.AutoSize = true;
            this.lbl_vinv_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_vinv_MaNV.Location = new System.Drawing.Point(80, 17);
            this.lbl_vinv_MaNV.Name = "lbl_vinv_MaNV";
            this.lbl_vinv_MaNV.Size = new System.Drawing.Size(147, 18);
            this.lbl_vinv_MaNV.TabIndex = 77;
            this.lbl_vinv_MaNV.Tag = "";
            this.lbl_vinv_MaNV.Text = "Nhập công việc mới: ";
            // 
            // fAddJobStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 128);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.txt_LoaiMoi);
            this.Controls.Add(this.lbl_vinv_MaNV);
            this.Name = "fAddJobStaff";
            this.Text = "Add Job Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.TextBox txt_LoaiMoi;
        private System.Windows.Forms.Label lbl_vinv_MaNV;
    }
}