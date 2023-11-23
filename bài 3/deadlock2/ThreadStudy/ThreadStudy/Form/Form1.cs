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
            _timer.StartThread();
        }

        private void btnThread1Stop_Click(object sender, EventArgs e)
        {
            ThreadKiller sc = new ThreadKiller(new IthreadKiller[] { _timer });
            sc.ThreadClose();
        }

        private void btnThread2Start_Click_Click(object sender, EventArgs e)
        {
            _typeWriter.StartThread();
        }

        private void btnThread2Stop_Click(object sender, EventArgs e)
        {
            ThreadKiller sc = new ThreadKiller(new IthreadKiller[] { _typeWriter });
            sc.ThreadClose();
        }
        /// <summary>終了ボタン押下</summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            ThreadKiller sc = new ThreadKiller(new IthreadKiller[] { _timer, _typeWriter });
            sc.ThreadClose(true);

            this.Close();
        }
        #endregion

        /// <summary>画面更新用</summary>
        private void timDisplayRefresh_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = _timer.TimerStr;
            if(lblTypeWriter.Text != _typeWriter.TypeWriterStr)
                lblTypeWriter.Text = _typeWriter.TypeWriterStr;
        }
    }
}
