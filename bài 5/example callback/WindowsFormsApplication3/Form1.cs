using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Action act = () =>
            {
                for (int i = 0; i < 5; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                }

            };
            //BeginInvoke（非同期）で実行し、CallBack待機。
            act.BeginInvoke(ConnectUseCallBack, act);
        }

        /// <summary>コールバック</summary>
        private void ConnectUseCallBack(IAsyncResult ar)
        {
            Action act = new Action(() =>
            {
                textBox1.Text = "aaaaaaaaaaaaaaaaaaaaaaaa";
            });

            if (InvokeRequired)
                Invoke(act);
            else
                act.Invoke();
        }


    }
}
