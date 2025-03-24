using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_object
{
    internal class loaisanpham
    {
        private int malsp;
        private string tenlsp;

        public int Malsp { get => malsp; set => malsp = value; }
        public string Tenlsp { get => tenlsp; set => tenlsp = value; }

        public loaisanpham (DataRow row)
        {
            this.malsp = Int32.Parse(row["malsp"].ToString());
            this.tenlsp = row["tenlsp"].ToString();

        }
    }
}
