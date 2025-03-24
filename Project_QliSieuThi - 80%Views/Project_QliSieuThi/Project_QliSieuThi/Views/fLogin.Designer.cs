namespace Project_QliSieuThi
{
    partial class fLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lg_ViewPass = new System.Windows.Forms.Button();
            this.btn_lg_Exit = new System.Windows.Forms.Button();
            this.btn_lg_Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_lg_MatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_lg_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_lg_ViewPass);
            this.panel1.Controls.Add(this.btn_lg_Exit);
            this.panel1.Controls.Add(this.btn_lg_Login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 169);
            this.panel1.TabIndex = 0;
            // 
            // btn_lg_ViewPass
            // 
            this.btn_lg_ViewPass.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_lg_ViewPass.Location = new System.Drawing.Point(7, 127);
            this.btn_lg_ViewPass.Name = "btn_lg_ViewPass";
            this.btn_lg_ViewPass.Size = new System.Drawing.Size(125, 31);
            this.btn_lg_ViewPass.TabIndex = 3;
            this.btn_lg_ViewPass.Text = "Hiện mật khẩu";
            this.btn_lg_ViewPass.UseVisualStyleBackColor = true;
            this.btn_lg_ViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // btn_lg_Exit
            // 
            this.btn_lg_Exit.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_lg_Exit.Location = new System.Drawing.Point(310, 127);
            this.btn_lg_Exit.Name = "btn_lg_Exit";
            this.btn_lg_Exit.Size = new System.Drawing.Size(101, 31);
            this.btn_lg_Exit.TabIndex = 5;
            this.btn_lg_Exit.Text = "Thoát";
            this.btn_lg_Exit.UseVisualStyleBackColor = true;
            this.btn_lg_Exit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn_lg_Login
            // 
            this.btn_lg_Login.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_lg_Login.Location = new System.Drawing.Point(203, 127);
            this.btn_lg_Login.Name = "btn_lg_Login";
            this.btn_lg_Login.Size = new System.Drawing.Size(101, 31);
            this.btn_lg_Login.TabIndex = 4;
            this.btn_lg_Login.Text = "Đăng nhập";
            this.btn_lg_Login.UseVisualStyleBackColor = true;
            this.btn_lg_Login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_lg_MatKhau);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 47);
            this.panel3.TabIndex = 2;
            // 
            // txt_lg_MatKhau
            // 
            this.txt_lg_MatKhau.Location = new System.Drawing.Point(117, 9);
            this.txt_lg_MatKhau.Name = "txt_lg_MatKhau";
            this.txt_lg_MatKhau.Size = new System.Drawing.Size(258, 22);
            this.txt_lg_MatKhau.TabIndex = 2;
            this.txt_lg_MatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(20, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_lg_TaiKhoan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 51);
            this.panel2.TabIndex = 1;
            // 
            // txt_lg_TaiKhoan
            // 
            this.txt_lg_TaiKhoan.Location = new System.Drawing.Point(117, 9);
            this.txt_lg_TaiKhoan.Name = "txt_lg_TaiKhoan";
            this.txt_lg_TaiKhoan.Size = new System.Drawing.Size(258, 22);
            this.txt_lg_TaiKhoan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản:";
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 197);
            this.Controls.Add(this.panel1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_lg_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_lg_MatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_lg_Exit;
        private System.Windows.Forms.Button btn_lg_Login;
        private System.Windows.Forms.Button btn_lg_ViewPass;
    }
}

