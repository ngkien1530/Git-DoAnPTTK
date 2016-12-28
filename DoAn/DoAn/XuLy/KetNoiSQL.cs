using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn.XuLy
{
    class KetNoiSQL
    {
        private KetNoiSQL()
        {
            try
            {
                string str = "server=LUSKY-PC;database=QuanLyChiTieu";
                string query = "select * from NguoiDung";
                SqlConnection con = new SqlConnection(str);
                SqlCommand com = new SqlCommand(query, con);
                con.Open();

            }
        }
    }
}
