using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class qlsanpham
    {
        private static qlsanpham instance;

        public static qlsanpham Instance
        {
            get
            {
                if (instance == null)
                    instance = new qlsanpham();

                return instance;
            }
            private set => instance = value;
        }
        public data_object.sanpham laytt(int masp)
        {
            data_object.sanpham sp;
            string query = "select * from sanpham where masp = @masp";

            List<object> parameters = new List<object>();

            parameters.Add(masp);

            DataTable table = dataprovider.Instance.ketnoi(query, parameters);

            sp = new data_object.sanpham(table.Rows[0]);

            return sp;
        }

        public List<data_object.sanpham> layds()
        {
            List<data_object.sanpham> listSP = new List<data_object.sanpham>();

            string query = "select * from sanpham";

            DataTable table = dataprovider.Instance.ketnoi(query, null);
            foreach (DataRow row in table.Rows)
            {
                data_object.sanpham sp = new data_object.sanpham(row);
                listSP.Add(sp);
            }

            return listSP;
        }

        public List<data_object.sanpham> laydsbangtensp(string tensp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<data_object.sanpham> listSP = new List<data_object.sanpham>();
            List<object> parameters = new List<object>();
            string query = "select * from sanpham where tensp = @tensp ";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            parameters.Add(tensp);        
            DataTable table = dataprovider.Instance.ketnoi(query, parameters);
            foreach (DataRow row in table.Rows)
            {
                data_object.sanpham sp = new data_object.sanpham(row);
                listSP.Add(sp);
            }

            return listSP;          
        }

        public List<data_object.sanpham> laydsbanglsp(int malsp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<data_object.sanpham> listSP = new List<data_object.sanpham>();
            List<object> parameters = new List<object>();
            string query = "select * from sanpham  where malsp = @malsp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@malsp", malsp);
            parameters.Add(malsp);
            DataTable table = dataprovider.Instance.ketnoi(query, parameters);
            foreach (DataRow row in table.Rows)
            {
                data_object.sanpham sp = new data_object.sanpham(row);
                listSP.Add(sp);
            }

            return listSP;
        }

        public void xoa(int masp)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "delete from sanpham where masp = @masp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@masp", masp);



            //parameters.Add(masp);

            cmd.ExecuteNonQuery();
        }

        public void sua(int masp, string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "update sanpham set tensp = @tensp, malsp = @malsp, soluong = @soluong, dongiaban = @dongiaban, dongianhap = @dongianhap where masp = @masp";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@malsp", malsp);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongiaban", dongiaban);
            cmd.Parameters.AddWithValue("@dongianhap", dongianhap);

            cmd.ExecuteNonQuery();
        }

        public void them(string tensp, int malsp, int soluong, int dongiaban, int dongianhap)
        {
            string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            List<object> parameters = new List<object>();
            string query = "insert into sanpham (tensp, malsp, soluong, dongiaban, dongianhap) values (@tensp, @malsp, @soluong, @dongiaban, @dongianhap)";
            SqlCommand cmd = new SqlCommand(query, connection);
            //cmd.Parameters.AddWithValue("@masp", masp);
            cmd.Parameters.AddWithValue("@tensp", tensp);
            cmd.Parameters.AddWithValue("@malsp", malsp);
            cmd.Parameters.AddWithValue("@soluong", soluong);
            cmd.Parameters.AddWithValue("@dongiaban", dongiaban);
            cmd.Parameters.AddWithValue("@dongianhap", dongianhap);

            cmd.ExecuteNonQuery();
        }



    }
}
