using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStudy
{
    internal class TypeWriter : IthreadKiller
    {
        #region ■メンバ変数■

        /// <summary>タイプライター文字</summary>
        public string TypeWriterStr;
        /// <summary>全表示文字</summary>
        private string _allCharacters;
        /// <summary>カウンタ</summary>
        private int _counter;

        /// <summary>スレッドのフラグ</summary>
        private bool _bThreadFlag;
        /// <summary>スレッド</summary>
        private Thread _threadMain;
        #endregion

        /// <summary>コンストラクタ</summary>
        public TypeWriter(string displayCharacters)
        {
            TypeWriterStr = string.Empty;
            _allCharacters = displayCharacters;
            _counter = 0;
        }

        #region ■スレッド■
        /// <summary>スレッドの開始</summary>
        public bool StartThread()
        {
            if (true == _bThreadFlag)
                return false;
            _threadMain = new Thread(ThreadMain);
            _threadMain.Name = nameof(TypeWriter) + "Thread";
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
                _counter = _counter == _allCharacters.Count() ? 0 : _counter;
                string disp = _allCharacters.Substring(0, ++_counter);

                TypeWriterStr = disp;

                if (disp[disp.Length -1] != '\r' && disp[disp.Length - 1] != '\n')
                    Thread.Sleep(50);
            }
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