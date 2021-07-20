using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDemo
{
    public class ArraySumDemo
    {
        public static int Execte(int[] arr)
        {
            return ArraySum(arr, arr.Length);
        }

        /// <summary>
        /// 引入程序集入口
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("CppLib", CharSet = System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "ArraySum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ArraySum(int[] arr, int size);
    }
}
