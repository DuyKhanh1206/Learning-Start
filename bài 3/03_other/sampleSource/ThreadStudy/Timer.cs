using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadStudy
{
    internal class Timer
    {
        #region ■メンバ変数■
        /// <summary>名前</summary>
        private string _name;
        /// <summary>間隔（ミリ秒）</summary>
        private int _intervalMilliSec;

        /// <summary>ストップウォッチ</summary>
        private Stopwatch _stopWatch;

        /// <summary>スレッドのフラグ</summary>
        private bool _bThreadFlag;
        /// <summary>スレッド</summary>
        private Thread _threadMain;
        #endregion

        /// <summary>コンストラクタ</summary>
        public Timer(string name, int interval)
        {
            _name = name;
            _intervalMilliSec = interval;
            _stopWatch = new Stopwatch();
        }

        #region ■スレッド■
        /// <summary>スレッドの開始</summary>
        public bool StartThread()
        {
            if (true == _bThreadFlag)
                return false;
            _threadMain = new Thread(ThreadMain);
            //_threadMain.Name = _name + "Thread";
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
            return true;
        }

        /// <summary>スレッド本体</summary>
        private void ThreadMain()
        {
            while (_bThreadFlag)
            {
                _stopWatch.Stop();
                TimeSpan ts = _stopWatch.Elapsed;
                _stopWatch.Start();

                Console.WriteLine(_name + string.Format(":{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds));
                
                Thread.Sleep(_intervalMilliSec);
            }
            _stopWatch.Stop();
        }
        #endregion

    }
}
