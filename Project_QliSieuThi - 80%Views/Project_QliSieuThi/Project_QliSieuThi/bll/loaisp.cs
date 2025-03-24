using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.bll
{
    internal class loaisp
    {
        public int them(string tenlsp)
        {
            data_provider.loaisp.Instance.them(tenlsp);
            return 1;
        }

        public int sua(int malsp, string tenlsp)
        {
            data_provider.loaisp.Instance.sua(malsp, tenlsp);
            return 1;
        }

        public int xoa (int malsp)
        {
            data_provider.loaisp.Instance.xoa(malsp);
            return 1;
        }
    }
}
