using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.bll
{
    internal class qlsp
    {
        public int dlt(int masp)
        {
            //data_object.sanpham sp = data_provider.qlsanpham.Instance.laytt(masp);
            data_provider.qlsanpham.Instance.xoa(masp);
            return 1;
        }

        public int sua(int masp, string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {
            data_provider.qlsanpham.Instance.sua(masp, tensp, malsp, soluong, dongiaban, dongianhap);
            return 1;
        }

        public int them( string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {
            data_provider.qlsanpham.Instance.them( tensp, malsp, soluong, dongiaban, dongianhap);
            return 1;
        }

        public int layttbangten(string tensp)
        {
                data_provider.qlsanpham.Instance.laydsbangtensp(tensp);
                return 1;           
        }

        public int layttbangloai(int malsp)
        {
            data_provider.qlsanpham.Instance.laydsbanglsp(malsp);   
            return 1;
        }

    }
}
