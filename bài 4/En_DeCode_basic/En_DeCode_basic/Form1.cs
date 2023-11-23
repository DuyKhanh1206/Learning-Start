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
        private Encryption _encrytion;
        private OpenFileDialog open;
        private byte[] _value;
        private string _inputwrite;
        private Encoding _encode;
        public Form1()
        {
            InitializeComponent();
            open = new OpenFileDialog();
            _encrytion = new Encryption();
        }       

        private void bntChange1_Click(object sender, EventArgs e)
        {
            bntChange1.Text = bntChange1.Text == "暗号化オン" ? "暗号化オフ" : "暗号化オン";
            bntChange1.BackColor = bntChange1.BackColor == Color.SpringGreen ? Color.Violet : Color.SpringGreen;

        }
        private void bntChange2_Click(object sender, EventArgs e)
        {
            bntChange2.Text = bntChange2.Text == "暗号化オン" ? "暗号化オフ" : "暗号化オン";
            bntChange2.BackColor = bntChange2.BackColor == Color.SpringGreen ? Color.Violet : Color.SpringGreen;
        }
        private void bntASC__JIS_Click(object sender, EventArgs e)
        {
            bntASC__JIS.Text = bntASC__JIS.Text == "ASCII" ? "SHIFT-JIS" : "ASCII";
            bntASC__JIS.BackColor = bntASC__JIS.BackColor == Color.SpringGreen ? Color.Violet : Color.SpringGreen;
        }

        private void bntOpen1_Click(object sender, EventArgs e)
        {
            if(open.ShowDialog()== DialogResult.OK)
            {
                tbLinkOpen.Text = open.FileName;
            }

        }

        private void bntOpen2_Click(object sender, EventArgs e)
        {  
                     
            if (open.ShowDialog() == DialogResult.OK)
            {
                tbLinkWrite.Text = open.FileName;
            }

        }

        private void bntClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = null;
        }

        private void bntRead_Click(object sender, EventArgs e)
        {

            try
            {
                using (FileStream fs = new FileStream(tbLinkOpen.Text, FileMode.Open, FileAccess.Read))
                {
                    Encoding encoder = check(bntASC__JIS.Text);
                    _value = new byte[fs.Length];
                    fs.Read(_value, 0, _value.Length);

                    switch (bntChange1.Text)
                    {
                        case ("暗号化オン"):
                            {
                                 _encrytion.style( _value);
                                 _encrytion.Encoding();
                                 byte[] resoul = _encrytion.GetValue();
                                 tbDisplay.Text = encoder.GetString(resoul);
                                MessageBox.Show("ファイルを読み込ました。");
                                break;
                            }
                        case ("暗号化オフ"):
                            {
                                tbDisplay.Text = encoder.GetString(_value);
                                MessageBox.Show("ファイルを読み込ました。");
                                break;                            
                            }
                    }                   
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("パスが正しくありません。");
                
            }           
        }
        private void bntWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbLinkWrite.Text != null)
                {
                    using (FileStream fs = new FileStream(tbLinkWrite.Text, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        Encoding encoder = check(bntASC__JIS.Text);
                        _inputwrite = tbDisplay.Text;
                        byte[] bytes = encoder.GetBytes(_inputwrite);
                        switch (bntChange2.Text)
                        {

                            case ("暗号化オン"):
                                {                                  
                                    _encrytion.style( bytes);
                                    _encrytion.Encoding();
                                    fs.Write(_encrytion.GetValue(), 0, _encrytion.GetValue().Length);
                                    MessageBox.Show("ファイルを書き込みました。");
                                    break;
                                }
                            case ("暗号化オフ"):
                                {
                                    fs.Write(bytes, 0, bytes.Length);
                                    MessageBox.Show("ファイルを書き込みました。");
                                    break;
                                }
                        }

                    }                    
                                          
                }               

            }
            catch(Exception ex)
            {
                MessageBox.Show("パスが正しくありません。");
                throw;
            }
        }

        private Encoding check(string ckeckvalue)
        {
            switch (ckeckvalue)
            {
                case "ASCII":
                    {
                        _encode = Encoding.ASCII;
                        break;
                    }
                case "SHIFT-JIS":
                    {
                        _encode = Encoding.GetEncoding("Shift_JIS"); break;
                    }
            }
            return _encode;
        }
    }
}
