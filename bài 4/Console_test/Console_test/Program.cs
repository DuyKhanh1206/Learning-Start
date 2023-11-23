using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Console_test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region đảo byte và đọc data bằng SHIFT-JIS
            //int bit_width = 2;
            //string[] _sb = new string[] { "12345678" };
            //_sb[0] = _sb[0].Substring(bit_width - 1, 1) + _sb[0].Substring(1, bit_width - 2) + _sb[0].Substring(0, 1);

            //string str = "シフトJISへ変換";

            //Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            //byte[] bytes = sjisEnc.GetBytes(str);
            //Console.WriteLine(BitConverter.ToString(bytes));
            #endregion

            //#region sirialize
            //string datainput = "abc123456";
            //byte[] a;
            //MemoryStream ms = new MemoryStream();
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(ms, datainput);
            //a = ms.ToArray();
            //#endregion

            //byte bData = 199;

            ////byte byteRes = bData;
            //int firstBit = 1;
            //int SecondBit = 7;

            //交換するビットが異なる場合のみ交換を行う
            //if (((byteRes >> firstBit) & 1) != ((byteRes >> SecondBit) & 1))   // nếu 2 vị trí bit bằng nhau thì k đổi
            //{
            //    byteRes ^= (byte)(1 << firstBit); //Nビット目を反転する
            //    byteRes ^= (byte)(1 << SecondBit); //Nビット目を反転する
            //}

            //bool IsEncode = true;
            //byteRes =(byte)( bData << 1);
            //byteRes = (byte)(bData >> 7);

            // byteRes = 199;
            //if (IsEncode == true)                                              // đảo bit 1<=> 8
            //    byteRes = (byte)((bData << 1) | (bData >> 7) );
            //else
            //    byteRes = (byte)((bData >> 1) | (bData << 7) );





            //IsDecode trueでもfalseでも同じ
            //byte byteRes = 00000000;

            //for (int i = 0; i < 8; i++)
            //{
            //    byteRes <<= 1; // 1ビット左シフト
            //    byteRes |= (byte)(bData & 00000001); // 最下位ビットを取得してセット
            //    bData >>= 1; // 元の値を1ビット右シフト
            //}

            //byte[] inputdata = new byte[3] { 200, 59, 19 };
            ////byte[] inputdata = new byte[3] { 64, 179, 19 };
            //byte[] tmpinput = new byte[inputdata.Length];

            //for (int i = 0; i < inputdata.Length; i++)
            //{
            //    byte tmp = 0;
            //    for (int j = 0; j < 8; j++)
            //    {
            //        tmp <<= 1;
            //        tmp |= (byte)(inputdata[i] & 1);
            //        inputdata[i] >>= 1;
            //    }
            //    tmpinput[i] = tmp;
            //}


            //for (int i = 0; i < inputdata.Length; i++)
            //{
            //    tmpinput[i] = (byte)((inputdata[i] << 1) | (inputdata[i] >> 7));
            //    tmpinput[i] = (byte)((tmpinput[i] >> 1) | (tmpinput[i] << 7));


            //}

            //int[] _outvalue = new int[inputdata.Length];
            ////byte[] tmpinput = new byte[inputdata.Length];
            //_outvalue = inputdata.Select(x => (~(int)x)).ToArray();
            //tmpinput = _outvalue.Select(x => (byte)x).ToArray();

            //int point1 = 3;
            //int point2 = 7;
            //byte x = (byte)(200 & (1 << (point1)));
            //byte y = (byte)(200 & (1 << (point1)));
            //byte z = (byte)((200 >> point2) & 1);

            //for (int i = 0; i < inputdata.Length; i++)
            //{
            //    tmpinput[i] = inputdata[i];
            //    if ((byte)((tmpinput[i]>>point1) & 1) != (byte)((tmpinput[i]>>point2) & 1))
            //    {
            //        tmpinput[i] ^= (byte)(1 << point1);
            //        tmpinput[i] ^= (byte)(1 << point2);
            //    }


            //}

            byte inputdata1 = 123;
            byte output = 0;
            for (int i = 0; i < 8; i++)
            {
                output <<= 1;
                output |= (byte)((inputdata1 >> i) & 1);
            }
        }

        //int[] str1; 
        //byte[] str11 = new byte[] { 0, 90, 8 };

        //str1 = str11.Select(x => (int)x).ToArray();
        //str1[0] = str1[1] & str1[2];

        //int arr = 5;
        //int b = arr << 6;
        //int c = b >> 2;
        //int d = arr^b;
        //int e = arr=arr|=1<<3;
        //int f = ~arr;
        //byte z = (byte)f;

        private byte SwapBit()
        {

            byte bData = 98;

            byte byteRes = bData;
            int firstBit = 3;
            int SecondBit = 4;

            //交換するビットが異なる場合のみ交換を行う
            if (((byteRes >> firstBit) & 1) != ((byteRes >> SecondBit) & 1))
            {
                byteRes ^= (byte)(1 << firstBit); //Nビット目を反転する
                byteRes ^= (byte)(1 << SecondBit); //Nビット目を反転する
            }

            return byteRes;
        }

    }
    
    
}
