using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_basic
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Pupil pup = new Pupil();
            pup.NameChanged += Pup_NameChanged;                     // 1 : gọi hàm NameChanged 
            pup.Name = " Name is changed 1";                        // 4: gọi hàm Name và gán value = Name is changed 1
            pup.Name = " Name is changed 2";
            pup.Name = " Name is changed 3";
            Console.ReadLine();
        }
        /// <summary> 5 : ủy thác dữ liệu và hiển thị </summary>

        private static void Pup_NameChanged(object sender, NameChangeEvenArgs ar)
        {
            Console.WriteLine("Name is changed :"+ ar.Name);             // 10 : NameChangeEvenArgs trả giá trị vào e|| 12 : in ra
        }
    }


    class Pupil
    {
        private string _name;
        /// <summary> set/get update value_changed </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;                                      //5: gán name = value
                // 4 : khi dùng thì gọi thông báo
                OnNameChanged(value);                               // 6: gọi hàm OnNameChanged(Name is changed 1) || 13: kết thúc hàm on
                
            }
        }
        /// <summary> 1 : tạo even như này  </summary>
        private event EventHandler<NameChangeEvenArgs> _namechanged;

        public event EventHandler<NameChangeEvenArgs> NameChanged               // 2 : khởi tạo even gán gtri ảo bằng value
        {
            add
            {
                _namechanged += value;                                          // 3 : コンストラクタ khởi tạo even add  hàm tạo  
            }
            remove
            {
                _namechanged -= value;
            }
        }

        /// <summary> 2 : hàm thông báo event lên</summary>
        void OnNameChanged(string name)
        {
            if (_namechanged != null)                       // 7:  so sánh 
            {
                _namechanged(this, new NameChangeEvenArgs(name));       // 8 : chạy vào đây và gọi hàm NameChangeEvenArgs(Name is changed 1)
            }
        }
    }
    /// <summary> 3 :thêm even mới thì thêm 1 parameter bằng class </summary>
    public class NameChangeEvenArgs : EventArgs 
    {
        public  string Name { get; set; }                       //　11:  phương thức get set để  trả về giá trị 戻り値＾＾
        public NameChangeEvenArgs(string name)
        {
            Name = name;                                        // 9: chạy hàm NameChangeEvenArgs() và gán Name = Name is changed 1
        }
    }
}
