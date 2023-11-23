using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadStudy
{
    internal class ThreadKiller
    {
        /// <summary>スレッド本体</summary>
        private IthreadKiller[] _threadKills;

        /// <summary>スレッド数</summary>
        private int _threadCounter;

        /// <summary>コンストラクタ</summary>
        public ThreadKiller(IthreadKiller[] ThreadKillClass)
        {
            _threadKills = ThreadKillClass;
            _threadCounter = 0;
        }

        /// <summary>スレッド終了処理</summary>
        public void ThreadClose(bool IsAbort = false)
        {
            //各スレッドに対し、非同期で「ThreadKill」を実行。              thực hiện thread không đồng bộ cho mỗi luồng
            foreach (var th in _threadKills)
            {
                Func<bool> func = () =>
                {
                    return th.ThreadKill();
                };
                //BeginInvoke（非同期）で実行し、CallBack待機。           Thực thi với BeginInvoke (không đồng bộ) và đợi CallBack
                func.BeginInvoke(CallBackMethod, func);
            }

            Stopwatch sw = Stopwatch.StartNew();
            do
            {
                Thread.Sleep(50);
                if (_threadCounter >= _threadKills.Count())
                    break;

            } while (sw.ElapsedMilliseconds < 5000);//完了するまでの待ち時間。これをまっても終わらなければ強制終了  nếu chờ quá lâu thì buộc thoát

            _threadCounter = 0;                                                                                       // k dùng cũng được

            //強制終了
            if(IsAbort == true)
            {
                foreach (var th in _threadKills)
                {
                    th.ThreadAbort();
                }
            }
        }

        /// <summary>非同期コールバック</summary>
        private void CallBackMethod(IAsyncResult ar)
        {
            try
            {
                Func<bool> func = (Func<bool>)ar.AsyncState;
                bool bRet = func.EndInvoke(ar);
                if (bRet == true)
                    _threadCounter++;//成功ならカウントアップ
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

    }
}
