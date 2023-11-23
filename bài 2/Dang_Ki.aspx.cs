using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Web_Qly_SV
{
    public partial class Dang_Ki : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtpassword1.Text == txtpassword2.Text)
                {
                    ketnoi kn = new ketnoi();
                    string sql = "select * from Sinh_Vien Where Ma_SV =N'"+txtUsername.Text+"'";
                    int kq1 = kn.xulydulieu(sql);
                    if (kq1 != 0)
                    {

                        int kq = kn.xulydulieu("insert into Login(Ma_SV,PassWord,Quyen)values ('" + txtUsername.Text + "','" + txtpassword1.Text + "','student')");
                        if (kq > 0)
                        {
                            Lb_thongbao.Text = "Bạn đã đang kí  thành công";
                            txtUsername.Text = "";
                            txtpassword1.Text = "";
                            txtpassword2.Text = "";

                        }
                    }
                    else
                    {
                        Lb_thongbao.Text = "đăng kí không thành công, vui lòng kiểm tra lại!";
                    }
                   
                }
                else
                {
                    Lb_thongbao.Text = "Mật khẩu không khớp";
                }
            }
            catch (Exception ex)
            {
                Lb_thongbao.Text = "Lỗi kết nối";
            }
        }

       
    }
}