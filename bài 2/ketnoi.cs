using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Web_Qly_SV
{
    public class ketnoi
    {
        public SqlConnection kn = new SqlConnection();
        public void kn_csdl()
        {
            string chuoikn = @"Data Source=LEPHONG;Initial Catalog=Web_ĐA;Integrated Security=True";

            kn.ConnectionString = chuoikn;
            kn.Open();
        }
		//string chuoikn = @"Data Source=dataname;Initial Catalog=Name_CSDL;Intergrated Security=true";
		//string stringKN = @"Data Source=DataName;Inital Catalog=name_CSDL;Intergrated Security=true";
        public void dongketnoi()
        {
            if (kn.State == ConnectionState.Open)
            { kn.Close(); }
        }

        public string layIDSV(string ten, string matkhau)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LEPHONG;Initial Catalog=Web_ĐA;Integrated Security=True");
             
            string cau = "select Sinh_Vien.Ma_SV,PassWord,Ten_SV From  Login join  Sinh_Vien on Login.Ma_SV =  Sinh_Vien.Ma_SV where Login.Ma_SV= '" + ten + "' And PassWord='" + matkhau + "'";

            //string kq = "";
            //try
            //{
            //    kn_csdl();

            //    SqlCommand sqlComm = new SqlCommand(cau, kn);
            //    SqlDataReader r = sqlComm.ExecuteReader();
            //    if (r.Read())
            //    {
            //        kq = r["Ten_SV"].ToString();
            //    }
            //}
            //catch
            //{ }
            //return kq;
            string quyen = "";
            SqlCommand cmd = new SqlCommand(cau, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    quyen = dr["Ten_SV"].ToString();
                }

            }
            return quyen;
        }
        public string layID_admin(string ten, string matkhau)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LEPHONG;Initial Catalog=Web_ĐA;Integrated Security=True");

           

            string cau = "select * From  [Web_ĐA].[dbo].[Login_admin] where TenDangNhap= '" + ten + "' And PassWord='" + matkhau + "'";


            string quyen = "";
            SqlCommand cmd = new SqlCommand(cau, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    quyen = dr["Quyen"].ToString();
                }

            }
            return quyen;
        }
        public string lay_Ma_SV(string ten )
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LEPHONG;Initial Catalog=Web_ĐA;Integrated Security=True");



            string cau = "select Ma_SV From  [Web_ĐA].[dbo].[Sinh_Vien] where Ten_SV= N'" + ten  + "'";


            string Ma_SV = "";
            SqlCommand cmd = new SqlCommand(cau, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    Ma_SV = dr["Ma_SV"].ToString();
                }

            }
            return Ma_SV;
        }
        public string lay1giatri(string sql)
        {
            string kq = "";
            try
            {
                kn_csdl();

                SqlCommand sqlComm = new SqlCommand(sql, kn);
                SqlDataReader r = sqlComm.ExecuteReader();
                if (r.Read())
                {
                    kq = r["tong"].ToString();
                }
            }
            catch
            { }
            return kq;
        }
        public DataTable bangdulieu = new DataTable();
        public DataTable laybang(string caulenh)
        {
            try
            {
                kn_csdl();
                SqlDataAdapter Adapter = new SqlDataAdapter(caulenh, kn);
                DataSet ds = new DataSet();

                Adapter.Fill(bangdulieu);
            }
            catch (System.Exception)
            {
                bangdulieu = null;
            }
            finally
            {
                dongketnoi();
            }

            return bangdulieu;
        }

        public int xulydulieu(string caulenhsql)
        {
            int kq = 0;
            try
            {
                kn_csdl();
                SqlCommand lenh = new SqlCommand(caulenhsql, kn);
                
                kq = lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Thông báo lỗi ra!

                kq = 0;
            }
            finally
            {
                dongketnoi();
            }
            return kq;
        }

    }
}