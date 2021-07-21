using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    public class StructSumDemo
    {

        public static int Execte(ref SumOfTwoNumbers sumOfTwoNumbers)
        {
            return StructSum(ref sumOfTwoNumbers);
        }

        public struct SumOfTwoNumbers
        {
            public int a;
            public int b;
            public int result;
        };
        /// <summary>
        /// 引入程序集入口
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("CppLib", CharSet = System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "StructSum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        static extern int StructSum(ref SumOfTwoNumbers sumOfTwoNumbers);
    }
}
