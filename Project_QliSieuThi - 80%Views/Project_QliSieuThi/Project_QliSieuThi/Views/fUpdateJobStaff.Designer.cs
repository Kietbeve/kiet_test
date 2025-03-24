namespace Project_QliSieuThi.Views
{
    partial class fUpdateJobStaff
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
            this.cbb_DsCongViec = new System.Windows.Forms.ComboBox();
            this.txt_ChinhSua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.lbl_vinv_MaNV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbb_DsCongViec
            // 
            this.cbb_DsCongViec.FormattingEnabled = true;
            this.cbb_DsCongViec.Location = new System.Drawing.Point(66, 53);
            this.cbb_DsCongViec.Name = "cbb_DsCongViec";
            this.cbb_DsCongViec.Size = new System.Drawing.Size(182, 24);
            this.cbb_DsCongViec.TabIndex = 87;
            // 
            // txt_ChinhSua
            // 
            this.txt_ChinhSua.Location = new System.Drawing.Point(66, 118);
            this.txt_ChinhSua.Name = "txt_ChinhSua";
            this.txt_ChinhSua.Size = new System.Drawing.Size(182, 22);
            this.txt_ChinhSua.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(63, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 85;
            this.label1.Tag = "";
            this.label1.Text = "Chỉnh sửa:";
            // 
            // btn_Ok
            // 
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Ok.Location = new System.Drawing.Point(359, 144);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(124, 37);
            this.btn_Ok.TabIndex = 84;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            // 
            // lbl_vinv_MaNV
            // 
            this.lbl_vinv_MaNV.AutoSize = true;
            this.lbl_vinv_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl_vinv_MaNV.Location = new System.Drawing.Point(63, 21);
            this.lbl_vinv_MaNV.Name = "lbl_vinv_MaNV";
            this.lbl_vinv_MaNV.Size = new System.Drawing.Size(171, 18);
            this.lbl_vinv_MaNV.TabIndex = 83;
            this.lbl_vinv_MaNV.Tag = "";
            this.lbl_vinv_MaNV.Text = "Chọn công việc cần sửa:";
            // 
            // fUpdateJobStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 202);
            this.Controls.Add(this.cbb_DsCongViec);
            this.Controls.Add(this.txt_ChinhSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.lbl_vinv_MaNV);
            this.Name = "fUpdateJobStaff";
            this.Text = "Update Job Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_DsCongViec;
        private System.Windows.Forms.TextBox txt_ChinhSua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label lbl_vinv_MaNV;
    }
}