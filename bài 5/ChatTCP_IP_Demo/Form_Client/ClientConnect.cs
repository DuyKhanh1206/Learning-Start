using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Form_Client
{
    class ClientConnect
    {
        /// <summary>メンバー変数 </summary>
        private string _ip;
        private int _port;
        private string _sentence;
        private string _resMsg;
        /// <summary>スレッドのフラグ</summary>
        private bool _bThreadFlag;
        /// <summary>スレッド</summary>
        private Thread _threadServerMain;
        TcpClient clientConnect;
        Encoding encode = Encoding.UTF8;

        /// <summary>クライアントから受け取った文字列を返します </summary>
        public string getmessage()
        {
            return _resMsg;
        }

        /// <summary> 画面に書き込むと「」にリセットされます。</summary>
        public string ResetResMsg
        {
            get { return _resMsg; }
            set
            {
                _resMsg = value;
            }
        }

        /// <summary>送信値の設定 </summary>
        public string Sentence
            {
            get { return _sentence; }
            set{ _sentence = value; }
            }

        /// <summary>IPアドレスと Port </summary>
        public ClientConnect(string ip, string port)
        {
            _ip = ip;
            int.TryParse(port, out _port);
            _sentence = "";
        }

        /// <summary> connect client to server</summary>
        public void Connect()
        {
            clientConnect = new TcpClient(_ip, _port);
            _resMsg = "Connected";
        }

        /// <summary>クライアントが切断する </summary>
        public void DisConnect()
        {
            _resMsg = "DisConnected";
            clientConnect.Close();
           
        }

        public bool ConnectCheck()
        {
            try
            {
                NetworkStream ns = clientConnect.GetStream();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>スレッドの開始</summary>
        public bool StartServerThread()
        {
            if (true == _bThreadFlag)
                return false;
            _threadServerMain = new Thread(ThreadServerMain);
            _threadServerMain.Name = nameof(ClientConnect) + "Thread";
            _bThreadFlag = true;
            _threadServerMain.IsBackground = true;             // アプリケーションを突然閉じるとスレッドも停止します.
            _threadServerMain.Start();
            return true;
        }

        /// <summary>スレッドの終了</summary>
        public bool StopServerThread()
        {
            if (_threadServerMain == null)
                return true;
            _bThreadFlag = false;
            do
            {
                _threadServerMain.Join(100);
            } while (_threadServerMain.IsAlive);
            return true;
        }

        //summary>スレッド本体</summary>
        private void ThreadServerMain()
        {
            NetworkStream ns = clientConnect.GetStream();
            while (_bThreadFlag)
            {
                if (_sentence != "")     // 文字列を送信する
                {
                    try
                    {
                        byte[] sendBytes = encode.GetBytes(_sentence + '\n');
                        ns.Write(sendBytes, 0, sendBytes.Length);
                        _sentence = "";

                    }catch
                    {

                    }                   
                }
                else       // 送信クライアントから文字列を読み取ります
                {
                    try
                    {
                        ns.ReadTimeout = 100;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            byte[] resBytes = new byte[1024];
                            int resSize = 0;
                            do
                            {
                                resSize = ns.Read(resBytes, 0, resBytes.Length);
                                while (resSize == 0)
                                {
                                    break;
                                }
                                ms.Write(resBytes, 0, resSize);
                            } while (ns.DataAvailable || resBytes[resSize - 1] != '\n');

                            _resMsg = encode.GetString(ms.GetBuffer(), 0, (int)ms.Length);
                            }
                    
                    }catch(Exception ex)
                    {
                        //var a = ex.InnerException as SocketException;
                        var a = (SocketException)ex.InnerException;
                        if (a!= null)
                        {
                            if (a.ErrorCode == 10060)
                            {
                                Console.WriteLine("TimeOut Client");
                                //OK Tyoe Error
                            }                                                      
                            else
                            {

                            }
                        }
                        else if(ex.HResult == -2146233080)
                        {
                            Console.WriteLine("Server DisConnected");
                            _resMsg = "DisConnected";
                            //Server DisConnected
                        }                        
                        else
                        {
                            //NG Tyoe Error
                        }                        
                        Thread.Sleep(500);
                    }
                }
            }       
        }
    }
}
