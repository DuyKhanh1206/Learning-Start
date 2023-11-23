using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    static internal class CustomEncoder
    {
        /// <summary>文字列→バイナリ</summary>
        static public byte[] Encode(byte[] bData)
        {
            byte[] byteRes = new byte[bData.Length];

            for (int i = 0; i < bData.Length; i++)
            {
                byteRes[i] = bData[i];
                for (int ii = 0; ii < _funcEncode.Count(); ii++)
                {
                    byteRes[i] = _funcEncode[ii](byteRes[i], true);
                }
            }
            return byteRes;
        }

        /// <summary>バイナリ→文字列</summary>
        static public byte[] Decode(byte[] bData)
        {
            byte[] byteRes = new byte[bData.Length];

            for (int i = 0; i < bData.Length; i++)
            {
                byteRes[i] = bData[i];
                for (int ii = _funcEncode.Count() - 1; ii >= 0; ii--)
                {
                    byteRes[i] = _funcEncode[ii](byteRes[i], false);
                }
            }
            return byteRes;
        }

        #region ■エンコード／デコード用■
        /// <summary>暗号化用デリゲート</summary>
        private delegate byte funEncode(byte bData, bool IsEncode);
        /// <summary>エンコード／デコード配列</summary>
        static private funEncode[] _funcEncode = new funEncode[] { ReverseBinary, SwapTwoEight, SwapFourFive, ShiftChange };

        /// <summary>バイナリデータを反転する　例）0101 1101　→　1011 1010</summary>
        static private byte ReverseBinary(byte bData, bool IsEncode)
        {
            //IsDecode trueでもfalseでも同じ
            byte byteRes = 00000000;

            for (int i = 0; i < 8; i++)
            {
                byteRes <<= 1; // 1ビット左シフト
                byteRes |= (byte)(bData & 00000001); // 最下位ビットを取得してセット
                bData >>= 1; // 元の値を1ビット右シフト
            }

            return byteRes;
        }

        /// <summary>２桁目と８桁目を入れ替える　例）1111 1101　→　0111 1111</summary>
        static private byte SwapTwoEight(byte bData, bool IsEncode)
        {
            //IsDecode trueでもfalseでも同じ
            return SwapBit(bData, 2, 8);
        }

        /// <summary>４桁目と５桁目を入れ替える　例）1000 1010　→　1001 0010</summary>
        static private byte SwapFourFive(byte bData, bool IsEncode)
        {
            //IsDecode trueでもfalseでも同じ
            return SwapBit(bData, 4, 5);
        }

        /// <summary>Encode：左シフトしてあふれた分を８文字目にする。　Decode：右シフトしてあふれた分を１文字目にする。</summary>
        static private byte ShiftChange(byte bData, bool IsEncode)
        {
            byte byteRes;
            if (IsEncode == true)
                byteRes = (byte)((bData << 1) | ((bData >> 7) & 00000001));
            else
                byteRes = (byte)((bData >> 1) | ((bData << 7) & 10000000));

            return byteRes;
        }
        #endregion

        #region ■共通
        /// <summary>Bitの入れ替え</summary>
        static private byte SwapBit(byte num, int firstBit, int SecondBit)
        {
            byte byteRes = num;
            firstBit -= 1;
            SecondBit -= 1;

            //交換するビットが異なる場合のみ交換を行う
            if (((byteRes >> firstBit) & 00000001) != ((byteRes >> SecondBit) & 00000001))
            {
                byteRes ^= (byte)(00000001 << firstBit); //Nビット目を反転する
                byteRes ^= (byte)(00000001 << SecondBit); //Nビット目を反転する
            }

            return byteRes;
        }
        #endregion
    }
}
