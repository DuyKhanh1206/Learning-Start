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
    //参考：https://csharp.keicode.com/basic/events-basic.php
    //　　：https://csharp.keicode.com/basic/delegates-basic.php

    internal class Timer : IthreadKiller
    {
        #region ■メンバ変数■
        /// <summary>タイマ文字</summary>
        public string TimerStr;
        /// <summary>ストップウォッチ</summary>
        private Stopwatch _stopWatch;

        /// <summary>スレッドのフラグ</summary>
        private bool _bThreadFlag;
        /// <summary>スレッド</summary>
        private Thread _threadMain;
        #endregion

        /// <summary>コンストラクタ</summary>
        public Timer()
        {
            TimerStr = "00:00.000";
            _stopWatch = new Stopwatch();
        }

        #region ■スレッド■
        /// <summary>スレッドの開始</summary>
        public bool StartThread()
        {
            if (true == _bThreadFlag)
                return false;
            _threadMain = new Thread(ThreadMain);
            _threadMain.Name = nameof(Timer) + "Thread";
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

                TimerStr = string.Format("{0:00}:{1:00}.{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
                
                Thread.Sleep(5);
            }
            _stopWatch.Stop();
        }

        public bool ThreadKill()
        {
            return StopThread();
        }

        public void ThreadAbort()
        {
            _threadMain?.Abort();
        }
        #endregion

    }
}
