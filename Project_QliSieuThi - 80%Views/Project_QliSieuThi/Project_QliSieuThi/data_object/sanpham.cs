using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_object
{
    internal class sanpham
    {
        private string anh;
        private int masp;
        private string tensp;
        private int malsp;
        private int soluong;
        private int dongiaban;
        private int dongianhap;

        public string Anh { get => anh; set => anh = value; }
        public int Masp { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }
        public int Malsp { get => malsp; set => malsp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Dongiaban { get => dongiaban; set => dongiaban = value; }
        public int Dongianhap { get => dongianhap; set => dongianhap = value; }

        public sanpham(DataRow row)
        {
            this.anh = row["anh"].ToString();
            this.masp = Int32.Parse(row["masp"].ToString());
            this.tensp = row["tensp"].ToString();
            this.malsp = Int32.Parse(row["malsp"].ToString());
            this.soluong = Int32.Parse(row["soluong"].ToString());
            this.dongiaban = Int32.Parse(row["dongiaban"].ToString());
            this.dongianhap = Int32.Parse(row["dongianhap"].ToString());
        }
    }
}
