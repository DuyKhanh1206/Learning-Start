using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace En_DeCode_basic
{
    class Encryption
    {
        private byte[] _value;
        private string[] _sb;
        private byte[] _getValue;

        public void style(byte[] value)
        {
            _value = value;
        }
        public byte[] GetValue()
        {
            return _getValue;
        }

        public byte[] Encoding()
        {
            _sb = new string[_value.Length];
            _getValue = new byte[_sb.Length];

            for (int i = 0; i < _value.Length; i++)
            {
                _sb[i] = Convert.ToString(_value[i], 2).PadLeft(8, '0');
                _sb[i] = _sb[i].Substring(6, 2) + _sb[i].Substring(4, 2) + _sb[i].Substring(2, 2) + _sb[i].Substring(0, 2);
                _getValue[i] = Convert.ToByte((_sb[i]), 2);
            }
            return _getValue;

        }

    }
}   