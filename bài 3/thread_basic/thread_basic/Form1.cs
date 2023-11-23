using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace thread_basic
{
    public partial class Form1 : Form
    {


        private Timer _timer;
        private WriterThread _writer;  
        private bool flagtag_time;
        private bool flagtag_writer;
        private string contence;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            _timer = new Timer(1);
            _writer = new WriterThread(100);
        }

        private void bntStartT1_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(run_thread_time1);
           
            Thread thrd = new Thread(ts);
            if (bntStartT1.Text == "Start")
            {
                flagtag_time = true;
                bntStartT1.Text = "Stop";
                thrd.Start();
            }else
            {
                bntStartT1.Text = "Start";
                flagtag_time = false ;
            }           
        }
        private void bntStartT2_Click(object sender, EventArgs e)
        {
            ThreadStart ts2 = new ThreadStart(run_thread_time2);
            Thread thrd2 = new Thread(ts2);
            if (bntStartT2.Text == "Start")
            {
                flagtag_writer = true;
                bntStartT2.Text = "Stop";
                thrd2.Start();
            }
            else
            {
                bntStartT2.Text = "Start";
                
                flagtag_writer = false;

            }
        }
        void run_thread_time1()
        {
            try
            {
                while (flagtag_time)
                {
                    _timer.StartThread();
                    string min = _timer.Format(_timer.GetMin());
                    string second = _timer.Format(_timer.GetSecond());
                    lbThreadTimer1.Text = string.Format("{0} : {1} : {2}", min, second, _timer.GetMiniSecon().ToString());
                }
                _timer.StopThread();
            }
            catch(Exception ex)
            {
                return;
            }
            
        }

        void run_thread_time2()
        {   
            try
            { 
                    
             contence = "- Có công mài sắt, có ngày nên kim.- Giặc đến nhà, đàn bà phải đánh.- Thất bại là mẹ thành công.- Công cha như núi Thái Sơn.  Nghĩa mẹ như nước trong nguồn chảy ra.  Một lòng thờ mẹ kính cha.  Cho tròn chữ hiếu mới là đạo con.";
            _writer.Sentence = contence;
            while (flagtag_writer)
            {
                _writer.StartWrite();
                lbTextResult.Text = _writer.GetWriterThread();
            }
            _writer.StopWrite();
        }
            catch(Exception ex)
            {
                return;
    }

}
     
        private void bntCancel_Click(object sender, EventArgs e)
        {
            flagtag_time = false;
            _timer.StopThread();

            flagtag_writer = false;
            _writer.StopWrite();

            Thread.Sleep(500);
            this.Close();
        }
        
    }
}
