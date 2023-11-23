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
        List<PhoneBookEntity> _a;

        public Form1()
        {
            InitializeComponent();
            _sqlite = new ClsSQLite(@"Data Source=S:\装置開発部\■共有\91_個人\湯浅\900_勉強結果\02_電話帳\DB\DDD.db;Version=3");

            dgvPhoneBook.DataSource = _a;

        }

        private void bntload_Click(object sender, EventArgs e)
        {

            string sql = "select phoneid, phonenumber,phones.userid,users.username from phones left join users on phones.userid = users.userid";

            Func<SQLiteDataReader, PhoneBookEntity> funcDataChange = (reader) =>
            {
            PhoneBookEntity pb = new PhoneBookEntity(
                Convert.ToInt32(reader["UserId"]),
                Convert.ToString(reader["UserName"]),
                Convert.ToInt32(reader["PhoneID"]),
                Convert.ToString(reader["PhoneNumber"]));
            return pb;
                ;
            };

            Func<SQLiteDataReader, PhoneBookEntity> funcDataChange2 = aaaa;


            _a = _sqlite.ExecuteReader<PhoneBookEntity>(sql, funcDataChange2);
            dgvPhoneBook.DataSource = _a;

        }
        private PhoneBookEntity aaaa(SQLiteDataReader sqlreader)
        {
            //phonebookentity rt = new phonebookentity();
            //rt.userid = convert.toint32(sqlreader["userid"]);
            //rt.username = convert.tostring(sqlreader["username"]);
            //rt.phoneid = convert.toint32(sqlreader["phoneid"]);
            //rt.phonenumber = convert.tostring(sqlreader["phonenumber"]);

            //convert.toint32(sqlreader["userid"]),
            //        convert.tostring(sqlreader["username"]),
            //        convert.toint32(sqlreader["phoneid"]),
            //        convert.tostring(sqlreader["phonenumber"]));
            //return rt;

            return new PhoneBookEntity(1,"",2,"");
        }


        private void bntcancel_Click(object sender, EventArgs e)
            {
            string sql = "select phoneid, phonenumber,phones.userid,users.username from phones left join users on phones.userid = users.userid";
            DataTable dt = _sqlite.GetDataTable(sql);
            dgvPhoneBook.DataSource = dt;
             

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