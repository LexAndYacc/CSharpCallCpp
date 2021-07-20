using System;
using System.Runtime.InteropServices;

namespace CSharpCallCpp
{
    public class API
    {
        /// <summary>
        /// 数组转IntPtr
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IntPtr GetIntPtrByArray<T>(T[] t)
        {

            int size = Marshal.SizeOf(typeof(T)) * t.Length;
            byte[] bytes = new byte[size];
            IntPtr pBuff = Marshal.AllocHGlobal(size);


            long ptr = pBuff.ToInt64();

            for (int i = 0; i < t.Length; ++i)
            {
                IntPtr RPtr = new IntPtr(ptr);
                Marshal.StructureToPtr(t[i], RPtr, false);
                ptr += Marshal.SizeOf(typeof(T));
            }

            return pBuff;
        }
        /// <summary>
        /// IntPtr转数组
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pBuff"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static T[] GetArrayByIntPtr<T>(IntPtr pBuff, int count)
        {
            T[] pDInfo = new T[count];

            for (int i = 0; i < count; ++i)
            {
                IntPtr pPonitor = new IntPtr(pBuff.ToInt64() + Marshal.SizeOf(typeof(T)) * i);
                pDInfo[i] = (T)Marshal.PtrToStructure(pPonitor, typeof(T));
            }

            Marshal.FreeHGlobal(pBuff);


            return pDInfo;
        }
    }
}
