using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encoder
{
    public partial class Form1 : Form
    {
        /// <summary>テキストエンコーダ</summary>
        private Encoding _textEncoder;

        public Form1()
        {
            InitializeComponent();
            _textEncoder = Encoding.ASCII;
        }

        /// <summary>読み込みの「参照」ボタン</summary>
        private void btnReadReference_Click(object sender, EventArgs e)
        {
            string initPath = string.Empty;
            try
            {
                initPath = Path.GetDirectoryName(txtReadFilePath.Text);
            }
            catch
            {
            }

            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = initPath;
                ofd.Filter = "dsnファイル(*.dsn)|*.dsn|すべてのファイル(*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.Title = "開くファイルを選択してください";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtReadFilePath.Text = ofd.FileName;
                }
            }
        }

        /// <summary>書き込みの「参照」ボタン</summary>
        private void btnWriteReference_Click(object sender, EventArgs e)
        {
            string initPath = string.Empty;
            try
            {
                initPath = Path.GetDirectoryName(txtWriteFilePath.Text);
            }
            catch
            {
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.FileName = "新しいファイル.dsn";

                sfd.InitialDirectory = initPath;
                sfd.Filter = "dsnファイル(*.dsn)|*.dsn|すべてのファイル(*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.Title = "保存先のファイルを選択してください";
                sfd.RestoreDirectory = true;
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtWriteFilePath.Text = sfd.FileName;
                }
            }
        }

        /// <summary>「読み込み」ボタン</summary>
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtReadFilePath.Text) == false)
            {
                MessageBox.Show("ファイルが存在しません。", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (FileStream fs = new FileStream(txtReadFilePath.Text, FileMode.Open, FileAccess.Read))
                {
                    byte[] buf = new byte[fs.Length];
                    fs.Read(buf, 0, buf.Length);
                    buf = cbxRead.Checked == true ? Custom.CustomEncoder.Decode(buf) : buf;
                    txtEditor.Text = _textEncoder.GetString(buf);
                }
            }
            catch
            {
                MessageBox.Show("ファイルの読み込みに失敗しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("ファイルを読み込みました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>「書き込み」ボタン</summary>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                using (FileStream fs = new FileStream(txtWriteFilePath.Text, FileMode.Create, FileAccess.ReadWrite))
                {
                    byte[] b = _textEncoder.GetBytes(txtEditor.Text);
                    byte[] writeData = cbxWrite.Checked ? Custom.CustomEncoder.Encode(b) : _textEncoder.GetBytes(txtEditor.Text);
                    fs.Write(writeData, 0, writeData.Count());
                }
            }
            catch
            {
                MessageBox.Show("ファイルの書き込みに失敗しました。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("ファイルを書き込みました。", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>「表示クリア」ボタン</summary>
        private void btnTextClear_Click(object sender, EventArgs e)
        {
            txtEditor.Text = string.Empty;
        }

        #region ■チェックボックス
        private void cbxRead_CheckedChanged(object sender, EventArgs e)
        {
            cbxRead.Text = cbxRead.Checked == true ? "暗号化オン" : "暗号化オフ";
            cbxRead.BackColor = cbxRead.Checked == true ? Color.Plum : Color.PaleGreen;
        }

        private void cbxWrite_CheckedChanged(object sender, EventArgs e)
        {
            cbxWrite.Text = cbxWrite.Checked == true ? "暗号化オン" : "暗号化オフ";
            cbxWrite.BackColor = cbxWrite.Checked == true ? Color.Plum : Color.PaleGreen;
        }

        private void cbxEncode_CheckedChanged(object sender, EventArgs e)
        {
            cbxEncode.Text = cbxEncode.Checked == true ? "SHIFT-JIS" : "ASCII";
            cbxEncode.BackColor = cbxEncode.Checked == true ? Color.Plum : Color.PaleGreen;
            _textEncoder = cbxEncode.Checked == true ? Encoding.GetEncoding("shift_jis") : Encoding.ASCII;
        }
        #endregion
    }
}
