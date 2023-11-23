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
        private ClsSQLite _sqlite;
        private string strSqrlite;

        public frmAddPhoneNumber()
            {
                InitializeComponent();
            }
        

        private void bntRegister_Click(object sender, EventArgs e)
            {
                strSqrlite = "insert into phones values(" + NumPhoneID.Value + "," + txtUserID.Text + "," + txtPhoneNumber.Text + ")";
                MessageBox.Show(strSqrlite);
                string[] str = new string[] {};
                _sqlite.ExecuteNoneQueryWithTransaction(str);

            }
    }
}
