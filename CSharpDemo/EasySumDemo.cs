using System;

namespace CSharpDemo
{
    public class EasySumDemo
    {
        public static int Execte(int a,int b)
        {
            return EasySum(a, b);
        }
        /// <summary>
        /// 引入程序集入口
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("CppLib", CharSet = System.Runtime.InteropServices.CharSet.Auto, EntryPoint = "EasySum", CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        static extern int EasySum(int a, int b);
    }
}
