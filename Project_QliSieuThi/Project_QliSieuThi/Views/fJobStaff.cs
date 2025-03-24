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
    public partial class fJobStaff : Form
    {
        public fJobStaff()
        {
            InitializeComponent();
        }

        private void btn_ThemCV_Click(object sender, EventArgs e)
        {
            fAddJobStaff fAddJobStaff = new fAddJobStaff();
            fAddJobStaff.Show();
        }

        private void btn_SuaCV_Click(object sender, EventArgs e)
        {
            fUpdateJobStaff fUpdateJobStaff = new fUpdateJobStaff();
            fUpdateJobStaff.Show();
        }
    }
}
