using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace プログラムSQLine
{
    public partial class frmAddUsers : Form
    {
        private string strSqrlite;
        private string sqliteConn;
        private ClsSQLite _sqlite;
        public frmAddUsers()
            {
                InitializeComponent();
                sqliteConn = @"Data Source=S:\装置開発部\■共有\91_個人\湯浅\900_勉強結果\02_電話帳\DB\DDD.db;Version=3";
                _sqlite = new ClsSQLite(sqliteConn);
            }
        private void bntRegister_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text =="" )
                {
                    MessageBox.Show("ユーザID、ユーザ名を入力してください");
                    return;
                }
            string sql = string.Format("select* from users where userid = {0}", numUserID.Value);
            DataTable dt = _sqlite.GetDataTable(sql);
            if(dt.Rows.Count == 0)
                {
                    strSqrlite = "insert into users values(" + numUserID.Value + ",'" + txtUsername.Text + "')";
                    _sqlite.ExecuteNoneQuery(strSqrlite);
                    MessageBox.Show("登録しました");
                }
            else
                {
                    MessageBox.Show("アカウントはすでに存在しています ");
                }

        }

        private void bntCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }
    }
}
