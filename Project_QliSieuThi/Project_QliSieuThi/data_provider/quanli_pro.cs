using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class quanli_pro
    {
        private static quanli_pro instance;

        public static quanli_pro Instance
        {
            get
            {
                if (instance == null)
                    instance = new quanli_pro();

                return instance;
            }
            private set => instance = value;
        }
        public data_object.quanli laytt(string tentk, string mk)
        {
            data_object.quanli ql;
            string query = "select * from quanli where tentk = @tentk and mk = @mk ";

            List<object> parameters = new List<object>();

            parameters.Add(tentk);
            parameters.Add(mk);

            DataTable table = dataprovider.Instance.ketnoi(query, parameters);

            ql = new data_object.quanli(table.Rows[0]);

            return ql;
        }

        public List<data_object.quanli> layds()
        {
            List<data_object.quanli> listNV = new List<data_object.quanli>();
            string query = "select * from quanli";

            DataTable table = dataprovider.Instance.ketnoi(query);
            foreach (DataRow row in table.Rows)
            {
                data_object.quanli nv = new data_object.quanli(row);
                listNV.Add(nv);
            }

            return listNV;
        }
    }
}
