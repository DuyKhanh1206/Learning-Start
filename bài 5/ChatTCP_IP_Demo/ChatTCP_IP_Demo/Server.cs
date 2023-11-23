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

namespace ChatTCP_IP_Demo
{
    public partial class Server : Form
    {
        private ServerListen _server;
        private bool _readFlag;
        public Server()
        {
            InitializeComponent();
            var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
            foreach (var items in btnControl)
            {
                items.Enabled = false;
            }
        }

        /// <summary> 待機ボタンがクライアントに接続します & 1秒ごとにデータを表示</summary>
        private void btConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Server started!");
            _server = new ServerListen(txtIp.Text, txtPort.Text);
            _server.Connection();
            _server.StartServerThread();
            btnConnect.Enabled = false;
            var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
            foreach (var items in btnControl)
            {
                items.Enabled = true;
            }
            _readFlag = true;            
            Action();
        }

        /// <summary>受信した文字列を表示する; ボタンの非表示と表示, クライアントが切断されたときにリッスンする  </summary>
        private void Action()
        { 
            Action act = new Action(() =>
            {
                try
                {
                    while (_readFlag)
                    {
                        while (_server.getmessage() != null)
                        {
                            if (_server.getmessage() != "DisConnected")             //Read getmessage, write to LsvDisplay
                            {
                                Action act1 = new Action(() =>
                                {
                                    lsvDisplay.Items.Add("Client: " + _server.getmessage());
                                });
                                if (InvokeRequired)
                                    Invoke(act1);
                                else
                                    act1.Invoke();                               
                            }
                            else        // Client DisConnected => server Listen()......
                            {
                                Action act1 = new Action(() =>
                                {
                                    lsvDisplay.Items.Add("Client: " + _server.getmessage()); 

                                });
                                if (InvokeRequired) 
                                {
                                    _server.Disconnect();
                                    _server.StopServerThread();
                                    Invoke(act1);
                                    _server.Connection();
                                    _server.StartServerThread();
                                    Invoke(act1);

                                }                                    
                                else
                                    act1.Invoke();
                            }
                            _server.ResetResMsg = null;
                        }                        
                    }
                }
                catch (Exception ex)
                {
                }
            });
                act.BeginInvoke(null, null);
                Thread.Sleep(1000);
        }

        /// <summary>切断ボタン</summary>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            _readFlag = false;
            _server.Disconnect();
            _server.StopServerThread();
            lsvDisplay.Items.Add("Server: DisConnected");
            btnConnect.Enabled = true;
            var btnControl = new Control[] { btnDisconnect, btnSend, txtDataSend };
            foreach (var items in btnControl)
            {
                items.Enabled = false;
            }
        }

        /// <summary>文字列送信ボタン </summary>
        private void btnSent_Click(object sender, EventArgs e)
        {
            if(txtDataSend.Text !=string.Empty)
            {
                string dataSend = txtDataSend.Text;
                _server.Sentence = dataSend;
                lsvDisplay.Items.Add("Server: "+txtDataSend.Text);
                txtDataSend.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter your transmission data!");
            }
        }
    }
}
