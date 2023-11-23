using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private Class1 _class1;
        public Form1()
        {
            InitializeComponent();
            _class1 = new Class1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = _class1.sample(numericUpDown1.Value, numericUpDown2.Value, calcPlus);
            textBox1.Text = ans;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ans = _class1.sample(numericUpDown1.Value, numericUpDown2.Value, calcMinus);
            textBox1.Text = ans;
        }


        private string calcPlus(decimal value1, decimal value2)
        {
            string sResult = (value1 + value2).ToString();// thu gọn bằng switch case. 
            return sResult;
        }

        private string calcMinus(decimal value1, decimal value2)
        {
            string sResult = (value1 - value2).ToString();
            return sResult;
        }
    }
}
