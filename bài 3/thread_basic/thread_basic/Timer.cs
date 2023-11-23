using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thread_basic
{
    internal class Timer
    {
        #region ■メンバ変数■
        /// <summary>名前</summary>
        //private string _name;
        /// <summary>間隔（ミリ秒）</summary>
        private int _intervalMilliSec;

        /// <summary>ストップウォッチ</summary>
        private Stopwatch _stopWatch;

        /// <summary>スレッドのフラグ</summary>
        private bool _bThreadFlag;
        /// <summary>スレッド</summary>
        private Thread _threadMain;
        #endregion
        private int _min, _second, _minisecon;
        public string TimeConv;
        /// <summary>コンストラクタ</summary>
        public Timer( int interval)
            {
                _intervalMilliSec = interval;
                _stopWatch = new Stopwatch();
            }
        public decimal GetMin()
            {
                return _min;
            }
        public decimal GetSecond()
            {
                return _second;
            }
        public decimal GetMiniSecon()
            {
                return _minisecon;
            }
        public string Format(decimal timer)
            {
                if(timer<10)
                {
                    TimeConv = "0" + timer.ToString();
                }
                else
                {
                    TimeConv = timer.ToString();
                }
                return TimeConv;
            }

        #region ■スレッド■
        /// <summary>スレッドの開始</summary>
        public bool StartThread()
            {
                if (true == _bThreadFlag)
                    return false;
                _threadMain = new Thread(ThreadMain);
                _bThreadFlag = true;
                _threadMain.Start();
            
                return true;
            }

        /// <summary>スレッドの終了</summary>
        public bool StopThread()
            {
                if (_threadMain == null)
                    return true;
                _bThreadFlag = false;
                do
                {
                    _threadMain.Join(100);
                } while (_threadMain.IsAlive);
                _threadMain.Abort();
                return true;
            }
        /// <summary>スレッド本体</summary>
        private void ThreadMain()
            {
                while (_bThreadFlag)
                {
                    TimeSpan ts = _stopWatch.Elapsed; // lệnh lấy thời gian từ khi bắt đầu đến khi kết thúc
                    _stopWatch.Start();
                    _min = ts.Minutes;
                    _second = ts.Seconds;
                    _minisecon = ts.Milliseconds;   
                }
                _stopWatch.Stop();
            }

        #endregion

    }
}
