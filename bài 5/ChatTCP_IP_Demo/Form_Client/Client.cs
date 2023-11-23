using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Client
{
    public partial class Client : Form
    {
        private ClientConnect _client;
        private bool _readFlag;
        public Client()
        {
            InitializeComponent();
            var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
            foreach (var items in btnControl)
            {
                items.Enabled = false;
            }
        }
        /// <summary>接続し、一定時間後にデータを読み取り、表示します </summary>
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                _client = new ClientConnect(txtIp.Text, txtPort.Text);
                _client.Connect();
                _client.StartServerThread();
                _readFlag = true;
                btnConnect.Enabled = false;
                var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
                foreach (var items in btnControl)
                {
                    items.Enabled = true;
                }
                Action();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The server has not started yet");
            }
        }
        /// <summary>受信した文字列を表示する; ボタンの非表示と表示, サーバーが切断されたときに処理する </summary>
        private void Action()
        {
            Action act = new Action(() =>
            {
                try
                {
                    while (_readFlag)
                    {
                        while (_client.getmessage() != null)
                        {
                            if (_client.getmessage() != "DisConnected")     //Read getmessage, write to LsvDisplay
                            {
                                Action act1 = new Action(() =>
                                {
                                    lsvDisplay.Items.Add("Server: " + _client.getmessage());
                                });
                                if (InvokeRequired)
                                    Invoke(act1);
                                else
                                    act1.Invoke();
                            }
                            else                        // if Server is DisConnected => Client も DisConected
                            {
                                Action act1 = new Action(() =>
                                {
                                    lsvDisplay.Items.Add("Server: " + _client.getmessage());

                                    btnConnect.Enabled = true;
                                    var controlButon = new Control[] { btnDisconnect, btnSend, txtDataSend };
                                    foreach (var items in controlButon)
                                    {
                                        items.Enabled = false;
                                    }
                                });
                                if (InvokeRequired)
                                {
                                    _client.DisConnect();
                                    _client.StopServerThread();
                                    Invoke(act1);
                                }                                   
                                else
                                    act1.Invoke();
                            }
                            _client.ResetResMsg = null;
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            });
            act.BeginInvoke(null, null);
        }
        /// <summary>切断ボタン</summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            _readFlag = false;
            _client.DisConnect();
            _client.StopServerThread();
            lsvDisplay.Items.Add("Client: DisConnected");         
            btnConnect.Enabled = true;
            var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
            foreach (var items in btnControl)
            {
                items.Enabled = false;
                
            }
        }

        /// <summary>文字列送信ボタン </summary>
        private void bntSent_Click(object sender, EventArgs e)
        {
            if (txtDataSend.Text != string.Empty)
            {
                _client.Sentence = txtDataSend.Text;     
                lsvDisplay.Items.Add("Client: "+txtDataSend.Text);
                txtDataSend.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please enter your transmission data!");
            }
        }


    }
}
