// dllmain.cpp : 定义 DLL 应用程序的入口点。
#include "pch.h"

#pragma region EasySum
extern "C" __declspec(dllexport) int __stdcall EasySum(int a, int b)
{
	return a + b;
}
#pragma endregion

#pragma region ArraySum
extern "C" __declspec(dllexport) int __stdcall ArraySum(int* arr,int size)
{
	int sum = 0;
	
	for (int i = 0; i < size; i++) {
		sum += arr[i];
	}

	return sum;
}
#pragma endregion
