using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QliSieuThi.bll
{
    internal class loginn
    {
        public string checklogin(string tentk, string mk)
        {
            try
            {
                data_object.quanli ql = data_provider.quanli_pro.Instance.laytt(tentk, mk);
                //data_object.quanli nv = data_provider.quanli_pro.Instance.laytt(tentk, mk);//dùng hàm laytt để lấy thông tin trong db
                return "tồn tại";

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
    }
}
