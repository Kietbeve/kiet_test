using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.data_provider
{
    internal class dataprovider
    {
        private static dataprovider instance;// hàm dung để truy vấn dữ liệu 

        public static dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new dataprovider();//tạo vùng nhớ để có thể truy vấn 

                return instance;

            }
            private set => instance = value;
        }

        private static string connectionStr = "Data Source=LAPTOP-LKVH2QD8\\SQLEXPRESS;Initial Catalog=QliSieuThi_db;Integrated Security=True;";
        public DataTable ketnoi(string query, List<object> parameters = null)//List<object> có thể chứa các đối tượng từ bất kỳ lớp hoặc kiểu dữ liệu nào trong C#.
        {
            DataTable table = new DataTable();//tạo vùng nhớ dưới dạng bảng

            SqlConnection connection = new SqlConnection(connectionStr);

            connection.Open();

            //query = "select * from quanli where tentk = @tentk and mk = @mk";

            SqlCommand cmd = new SqlCommand(query, connection);

            if (parameters != null)
            {
                string[] lam = query.Split(' ');//Split: được sử dụng để tách một chuỗi thành các phần tử con,
                int i = 0;
                foreach (string s in lam)// vòng lặp qua mảng "lam"
                {
                    if (s.Contains("@"))// contains: kt giá trị có chứa (...)
                    {
                        cmd.Parameters.AddWithValue(s, parameters[i]);// thêm mảng s vào list 
                        i++;
                    }
                }

            }

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);// cầu nối giữa db và code (datatable
            adapter.Fill(table);

            connection.Close();

            return table;
        }

        public object truyvan(string query, List<object> parameters = null)
        {
            object result = null;
            return result;
        }

        public int capnhat(string query, List<object> parameters = null)
        {
            int i = 0;
            return i;
        }

      
    }
}

