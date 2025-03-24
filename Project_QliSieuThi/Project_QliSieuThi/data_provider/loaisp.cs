using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class loaisp
    {
        private static loaisp instance;
        public static loaisp Instance
        {
            get
            {
                if (instance == null)
                    instance = new loaisp();

                return instance;
            }
            private set => instance = value;
        }
        public data_object.loaisanpham laytt(int malsp)
        {
            data_object.loaisanpham lsp;
            string query = "select * from loaisanpham where malsp = @malsp";

            List<object> parameters = new List<object>();

            parameters.Add(malsp);

            DataTable table = dataprovider.Instance.ketnoi(query, parameters);

            lsp = new data_object.loaisanpham(table.Rows[0]);

            return lsp;
        }

        public List<data_object.loaisanpham> layds()
        {
            List<data_object.loaisanpham> listLSP = new List<data_object.loaisanpham>();

            string query = "select * from loaisanpham";

            DataTable table = dataprovider.Instance.ketnoi(query, null);
            foreach (DataRow row in table.Rows)
            {
                data_object.loaisanpham lsp = new data_object.loaisanpham(row);
                listLSP.Add(lsp);
            }

            return listLSP;
        }

        public void them(string tenlsp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "insert into loaisanpham values (@tenlsp)";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tenlsp", tenlsp);

            cmd.ExecuteNonQuery();
        }

        public void xoa(int malsp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "delete from loaisanpham where malsp = @malsp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@malsp", malsp);

            cmd.ExecuteNonQuery();
        }

        public void sua(int malsp, string tenlsp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "update loaisanpham set tenlsp = @tenlsp where malsp = @malsp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@malsp", malsp);
            cmd.Parameters.AddWithValue("@tenlsp", tenlsp);
            
            cmd.ExecuteNonQuery();
        }

    }
}
