using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static ThreadStudy.Timer;

namespace ThreadStudy
{
    public partial class Form1 : Form
    {
        /// <summary>タイマークラス</summary>
        private Timer _timer;
        /// <summary>タイプライタークラス</summary>
        private TypeWriter _typeWriter;

        /// <summary>コンストラクタ</summary>
        public Form1()
        {
            InitializeComponent();
            this.ControlBox = !this.ControlBox;//コントロールボックス非表示

            _timer = new Timer();
            _typeWriter = new TypeWriter("ăn no tức bụng\r\nTrăm nghe không bằng một thấy\r\ncưỡi ngựa ngắm hoa\r\nuống nước nhớ nguồn\r\n'Góp gió thành bão'");
        }

        #region ■ボタン
        private void btnThread1Start_Click(object sender, EventArgs e)
        {
            _timer.Act += TimeDisplay;
            _timer.StartThread();
        }

        private void btnThread1Stop_Click(object sender, EventArgs e)
        {
            _timer.StopThread();
            _timer.Act -= TimeDisplay;
        }

        private void btnThread2Start_Click_Click(object sender, EventArgs e)
        {
            _typeWriter.Act += TypeWriterDisplay;
            _typeWriter.StartThread();
        }

        private void btnThread2Stop_Click(object sender, EventArgs e)
        {
            _typeWriter.StopThread();
            _typeWriter.Act -= TypeWriterDisplay;
        }
        #endregion

        /// <summary>終了ボタン押下</summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            _timer.StopThread();
            _typeWriter.StopThread();
            _timer.Act -= TimeDisplay;
            _typeWriter.Act -= TypeWriterDisplay;

            this.Close();
        }

        /// <summary>時間表示メソッド</summary>
        private void TimeDisplay(string msg)
        {
            Action act = new Action(() =>
            {
                lblTimer.Text = msg;
            });

            if (InvokeRequired)
                Invoke(act);
            else
                act.Invoke();
        }
        /// <summary>タイプライター表示メソッド</summary>
        private void TypeWriterDisplay(string msg)
        {
            Action act = new Action(() =>
            {
                txtTypeWriter.Text = msg;
            });

            if (InvokeRequired)
                Invoke(act);
            else
                act.Invoke();
        }

    }
}
