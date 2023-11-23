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
    public partial class Form1 : Form
    {
        private ClsSQLite _sqlite;
        IReadOnlyList<PhoneBookEntity> _a;


        public Form1()
            {
                InitializeComponent();
                _sqlite = new ClsSQLite(@"Data Source=S:\装置開発部\■共有\91_個人\湯浅\900_勉強結果\02_電話帳\DB\DDD.db;Version=3");
                dgvPhoneBook.DataSource = _a;
            }

        private void bntload_Click(object sender, EventArgs e)
            {
                string sql = "select phoneid, phonenumber,phones.userid,users.username from phones left join users on phones.userid = users.userid";

                Func<SQLiteDataReader, PhoneBookEntity> funcDataChange = delegate_method;

                _a = _sqlite.ExecuteReader<PhoneBookEntity>(sql, funcDataChange);
                dgvPhoneBook.DataSource = _a;
            }
        private PhoneBookEntity delegate_method(SQLiteDataReader reader)
            {
                return new PhoneBookEntity(
                    Convert.ToInt32(reader["UserId"]),
                    Convert.ToString(reader["UserName"]),
                    Convert.ToInt32(reader["PhoneID"]),
                    Convert.ToString(reader["PhoneNumber"])
                    );
            }
  //      Func<SQLiteDataReader, PhoneBookEntity> funcDataChange =(reader) => 
  //              new PhoneBookEntity(
  //                  Convert.ToInt32(reader["UserId"]),
  //                  Convert.ToString(reader["UserName"]),
  //                  Convert.ToInt32(reader["PhoneID"]),
  //                  Convert.ToString(reader["PhoneNumber"]));

        private void bntcancel_Click(object sender, EventArgs e)
            {
                //string sql = "select phoneid, phonenumber,phones.userid,users.username from phones left join users on phones.userid = users.userid";
                //DataTable dt = _sqlite.GetDataTable(sql);
                //dgvPhoneBook.DataSource = dt;  
                this.Close();           

            }   

        private void bntaddnumber_Click(object sender, EventArgs e)
            {
                frmAddPhoneNumber frmPhoneNum = new frmAddPhoneNumber();
                frmPhoneNum.ShowDialog();
            }

        private void bntadduser_Click(object sender, EventArgs e)
            {
                frmAddUsers frmUser = new frmAddUsers();
                frmUser.ShowDialog();
            }

    }
}