using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_DeCode_basic
{
    class Encryption2
    {

        /// <summary>暗号化用デリゲート / delegate </summary>
        private delegate byte Mydelegate(byte inputvalue, bool status);
        /// <summary>エンコード／デコード配列 / trình tự giải mã</summary>

        static private Mydelegate[] _enDeCoding = new Mydelegate[] { Reverse, Change01, SwapChange,  mark, Change01_2 };

        /// <summary>文字列→バイナリ</summary>
        static public byte[] Encoding(byte[] inputdata )
        {
            byte[] output = new byte[inputdata.Length];
            for (int i = 0; i<inputdata.Length;i++)
            {
                output[i] = inputdata[i];
                for (int j = 0; j< _enDeCoding.Count();j++)
                {
                    output[i] = _enDeCoding[j](output[i],true);
                }
            }
            return output;
        }
        /// <summary>バイナリ→文字列</summary>
        static public byte[] Decoding(byte[] inputdata)
        {
            byte[] output = new byte[inputdata.Length];
            for (int i = 0; i < inputdata.Length; i++)
            {
                output[i] = inputdata[i];
                for (int j = _enDeCoding.Count()-1; j >= 0; j--)
                {
                    output[i] = _enDeCoding[j](output[i],false);
                }
            }
            return output;
        }

        /// <summary>バイナリデータを反転する  / đảo ngược byte 例  1000 1101 →　1011 0001</summary>
        static private byte Reverse(byte inputdata, bool status) 
        {
            byte output = 0;
            for(int i = 0;i<8;i++)
            {
                output <<= 1;
                output |= (byte)((inputdata>>i)&1) ;
            }
            return output;
        }
        /// <summary>方法 1: 反転ビット/ đảo ngược bit  0-> 1 and 1 ->0 例 1010 1100 -> 0101 0011 </summary>
        static private byte Change01(byte inputdata, bool status)
        {
            byte output = (byte)(~inputdata);
            return output; 
        }
        /// <summary>方法 2: 反転ビット/ đảo ngược bit  0-> 1 and 1 ->0 例 1010 1100 -> 0101 0011 </summary>
        static private byte Change01_2(byte inputdata, bool status)
        {
            byte output = new byte();
            output = (byte)(inputdata ^ 255);
            return output;
        }
        /// <summary>Encode：左シフトしてあふれた分を８文字目にする。　Decode：右シフトしてあふれた分を１文字目にする。/ đẩy 1 bit và đặt về 1 hoặc 8 </summary>
        static private byte mark(byte inputdata, bool status) 
        {
            byte output = new byte();
            output = status == true ? (byte)((inputdata) << 1 | ((inputdata) >> 7)) : (byte)((inputdata) >> 1 | ((inputdata) << 7));
            return output;
        }

        /// <summary>Bitの入れ替え</summary>
        static private byte SwapChange(byte inputdata, bool status)
        {
            byte output = inputdata;
            output = Swap(output, 4, 6);        //Bit4 と Bit6 の入れ替え
            return output;
        }
        /// <summary>Bitの入れ替え</summary>
        static private byte Swap(byte inputdata, int point1, int point2)
        {
            byte output = inputdata;
            point1 -= 1;
            point2 -= 1;
            if (((byte)(inputdata >> point1) & 1) != ((byte)(inputdata >> point2) & 1)) //ビット位置 1 とビット位置 2 が異なる場合は交換します。
            {
                output ^= (byte)(1 << point1);              //point1 で 1 と XOR してビットを反転します
                output ^= (byte)(1 << point2);              //point2 で 1 と XOR してビットを反転します
            }
            return output;
        }
    }
}
