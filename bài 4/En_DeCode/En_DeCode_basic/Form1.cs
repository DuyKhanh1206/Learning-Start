using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace En_DeCode_basic
{
    public partial class Form1 : Form
    {
        private Encryption2 _encrytion;
        /// <summary>文字コード</summary>
        private Encoding _encode;
        /// <summary>入力○○</summary>

        public Form1()
        {
            InitializeComponent();
            _encrytion = new Encryption2();
            _encode = Encoding.ASCII;
        }

        /// <summary>「ファイルを開く」ボタン</summary>
        private void bntOpen1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog _open = new OpenFileDialog())
            {
                if (_open.ShowDialog() == DialogResult.OK)
                {
                    tbLinkOpen.Text = _open.FileName;
                }
            }
        }

        /// <summary>「ファイルを開く」ボタン</summary>
        private void bntOpen2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog _save = new SaveFileDialog())
            {
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    tbLinkWrite.Text = _save.FileName;
                }
            }              
        }

        /// <summary>「表示クリア」ボタン</summary>
        private void bntClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = string.Empty;
        }

        /// <summary>「暗号化オン」& 「暗号化オフ」ボタン/ có mã hóa, giải mã hay không</summary>
        private void cbChange1_CheckedChanged(object sender, EventArgs e)
        {
            cbChange1.Text = cbChange1.Checked ==true ? "暗号化オン" : "暗号化オフ";
            cbChange1.BackColor = cbChange1.Checked == true ? Color.SpringGreen : Color.Violet;
            cbChange1.CheckAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>「暗号化オン」& 「暗号化オフ」ボタン/ có mã hóa, giải mã hay không</summary>
        private void cbChange2_CheckedChanged(object sender, EventArgs e)
        {
            cbChange2.Text = cbChange2.Checked == true ? "暗号化オン" : "暗号化オフ";
            cbChange2.BackColor = cbChange2.Checked == true ? Color.SpringGreen : Color.Violet;
            cbChange2.TextAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>「ASCII」と「SHIFT-JIS」　ボタン/ nút kiểu dữ liệu dùng để đọc và ghi</summary>
        private void cbASC__JIS_CheckedChanged(object sender, EventArgs e)
        {
            cbASC__JIS.Text = cbASC__JIS.Checked == true ? "ASCII" :  "SHIFT -JIS";
            _encode = cbASC__JIS.Checked == true ? Encoding.ASCII : Encoding.GetEncoding("Shift_JIS");
            cbASC__JIS.BackColor = cbASC__JIS.Checked == true ? Color.SpringGreen : Color.Violet ;
            cbASC__JIS.TextAlign = ContentAlignment.MiddleCenter;
        }

        /// <summary>「読み込み」ボタン/ nút đọc dữ liệu</summary>
        private void bntRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(tbLinkOpen.Text, FileMode.Open, FileAccess.Read))
                {
                    if (tbLinkOpen.Text != string.Empty)
                    {

                        byte[] _value = new byte[fs.Length];
                        fs.Read(_value, 0, _value.Length);
                        _value = cbChange1.Checked == true ? En_DeCode_basic.Encryption2.Decoding(_value) : _value;
                        tbDisplay.Text = _encode.GetString(_value);
                        MessageBox.Show("ファイルを読み込ました。");
                    }

                    else
                    {
                        MessageBox.Show("暗号化するファイルを入力してください!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("パスが正しくありません。");
                
            }           
        }

        /// <summary>「書き込み」ボタン / nút ghi dữ liệu</summary>
        private void bntWrite_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(tbLinkWrite.Text, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    if (tbLinkWrite.Text != string.Empty)
                    {

                        string _inputwrite = tbDisplay.Text;
                        byte[] bytes = _encode.GetBytes(_inputwrite);
                        bytes = cbChange2.Checked == true ? En_DeCode_basic.Encryption2.Encoding(bytes) : bytes;
                        fs.Write(bytes, 0, bytes.Length);
                        MessageBox.Show("ファイルを書き込みました。");
                    }
                    else
                    {
                        MessageBox.Show("暗号化された保存ファイルを選択してください!");
                    }
                }          
            }
            catch(Exception ex)
            {
                MessageBox.Show("パスが正しくありません。");
                throw;
            }
        }
    }
}
