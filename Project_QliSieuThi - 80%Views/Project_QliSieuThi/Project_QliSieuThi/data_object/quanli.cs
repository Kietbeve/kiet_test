using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_object
{
    internal class quanli
    {
        private int maql;
        private string tenql;
        private string tentk;
        private string mk;
        private DateTime ngaysinh;
        private string sdt;

        public int Maql { get => maql; set => maql = value; }
        public string Tenql { get => tenql; set => tenql = value; }
        public string Tentk { get => tentk; set => tentk = value; }
        public string Mk { get => mk; set => mk = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }


        public quanli(DataRow row)
        {
            this.maql = Int32.Parse(row["maql"].ToString());
            this.tenql = row["tenql"].ToString();
            this.tentk = row["tentk"].ToString();
            this.mk = row["mk"].ToString();
            this.ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
            this.sdt = row["sdt"].ToString();
        }

    }
}
