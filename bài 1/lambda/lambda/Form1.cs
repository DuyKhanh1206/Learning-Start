using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        delegate void SomeDelegate(int a);


        private void button1_Click(object sender, EventArgs e)
        {
            Action<int, int> a = (xxxxxxxxxxxxxxxxx, ádfasdfasdfasdfasdf) =>
            {
                Console.WriteLine(string.Format("{0} + {1} = {0} + {1}", xxxxxxxxxxxxxxxxx, ádfasdfasdfasdfasdf));
            };

            a(3, 5);
        }

        //----------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            b(3, 5);
        }

        private void b(int ádfasdfasdfad,int ádfasdfasdf)
        {
            Console.WriteLine(string.Format("{0} + {1} = {0} + {1}", ádfasdfasdfad, ádfasdfasdf));
        }
    }
}
