using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace プログラムSQLine
{
    public partial class frmAddPhoneNumber : Form
    {
        
        private string strSqrlite;
        private string sqliteConn;
        private ClsSQLite _sqlite;
        public frmAddPhoneNumber()
            {
                InitializeComponent();
            sqliteConn = @"Data Source=S:\装置開発部\■共有\91_個人\湯浅\900_勉強結果\02_電話帳\DB\DDD.db;Version=3";
            _sqlite = new ClsSQLite(sqliteConn);

        }
        

        private void bntRegister_Click(object sender, EventArgs e)
            {
            if(txtUserID.Text == ""|| txtPhoneNumber.Text =="")
                {
                    MessageBox.Show("ユーザID、電話番号を入力してください");
                    return;
                }

            string sql = string.Format("select phoneid from phones where phoneid ={0} OR userid= {1}",NumPhoneID.Value,txtUserID.Text);
            DataTable dt = _sqlite.GetDataTable(sql);
            if( dt.Rows.Count == 0)
                {
                    strSqrlite = string.Format("insert into phones values({0},{1},{2})",  NumPhoneID.Value, txtUserID.Text , txtPhoneNumber.Text);
                    _sqlite.ExecuteNoneQuery(strSqrlite);
                    MessageBox.Show("登録しました");
                }
            else
                {
                    MessageBox.Show("アカウントはすでに存在しています ");
                }          
            
            }
     }
}
