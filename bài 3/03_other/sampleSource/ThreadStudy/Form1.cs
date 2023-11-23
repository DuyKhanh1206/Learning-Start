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
        private Timer _timer1;
        private Timer _timer2;

        /// <summary>コンストラクタ</summary>
        public Form1()
        {
            InitializeComponent();
            _timer1 = new Timer("Timer1", 1);
            _timer2 = new Timer("Timer2", 1);
        }

        #region ■ボタン
        private void btnThread1Start_Click(object sender, EventArgs e)
        {
            _timer1.StartThread();
        }

        private void btnThread1Stop_Click(object sender, EventArgs e)
        {
            _timer1.StopThread();
        }

        private void btnThread1Start2_Click(object sender, EventArgs e)
        {
            _timer2.StartThread();
        }

        private void btnThread1Stop2_Click(object sender, EventArgs e)
        {
            _timer2.StopThread();
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
