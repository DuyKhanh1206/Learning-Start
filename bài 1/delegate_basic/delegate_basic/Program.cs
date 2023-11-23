using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate_basic
{
    public delegate void EventInputNumber(int x);
    //public event EventHandler input_number;

    class data_input : EventArgs
    {
        public int data { get; set; }
        public data_input(int x)
        {
            data = x;
        }
    }

    class UserInput
    {
        //public event EventInputNumber eventinputnumber;
        public event EventHandler eventinputnumber;
        public void Input()
        {
            do
            {
                Console.WriteLine("number input: ");
                string  s = Console.ReadLine();


                int i = Int32.Parse(s);
                eventinputnumber?.Invoke(this,new data_input(i));
            } while (true) ;


        }
    }

    class sqrt
    {
        public void sub(UserInput input)
        {
            input.eventinputnumber += towsqrt;
        }
        public void towsqrt(object sender, EventArgs e)
        {
            data_input datainput = (data_input)e;
            int i = datainput.data;
            Console.WriteLine("sqrt({0}) is  {1}", i, Math.Sqrt(i));
        }
    }
    class sqr
    {
        public void sub(UserInput input)
        {
            input.eventinputnumber += towsqr;
        }
        public void towsqr(object sender, EventArgs e)
        {
            data_input datainput = (data_input)e;
            int i = datainput.data;
            Console.WriteLine("sqr({0}) is  {1}", i, i*i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // publisher lớp phát even
            UserInput userinpt = new UserInput();
            userinpt.eventinputnumber +=( sender,e)  =>
            {
                data_input datainput = (data_input)e;
                Console.WriteLine("input number is {0}", datainput.data);
            };

            // subcriber lớp nhận event
            sqrt twosqrt = new sqrt();
            twosqrt.sub(userinpt);

            sqr twosqr = new sqr();
            twosqr.sub(userinpt);

            userinpt.Input();
        }
    }
}
