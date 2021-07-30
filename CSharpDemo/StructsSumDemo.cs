using CSharpCallCpp;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpDemo
{
    public class StructsSumDemo
    {

        public static SumOfTwoNumbers[] Execte(SumOfTwoNumbers[] sumOfTwoNumbers)
        {
            IntPtr intPtr = API.GetIntPtrByArray(sumOfTwoNumbers);
            StructsSum(intPtr, sumOfTwoNumbers.Length);
            return API.GetArrayByIntPtr<SumOfTwoNumbers>(intPtr, sumOfTwoNumbers.Length);
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
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
        [System.Runtime.InteropServices.DllImport("CppLib", CharSet = System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "StructsSum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        static extern int StructsSum(IntPtr sumOfTwoNumbers, int size);
    }
}
