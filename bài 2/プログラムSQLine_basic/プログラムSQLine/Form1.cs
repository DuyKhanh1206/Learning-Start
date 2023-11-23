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
        DataTable dt = new DataTable();
       

        public Form1()
        {
            InitializeComponent();
            _sqlite = new ClsSQLite(@"Data Source=S:\装置開発部\■共有\91_個人\湯浅\900_勉強結果\02_電話帳\DB\DDD.db;Version=3");

 
            dgvPhoneBook.DataSource = dt;

        }

        private void bntload_Click(object sender, EventArgs e)
        {
            string sql = "select phoneid, phonenumber,phones.userid,users.username from phones left join users on phones.userid = users.userid";
            DataTable dt = _sqlite.GetDataTable(sql);
            dgvPhoneBook.DataSource = dt;
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