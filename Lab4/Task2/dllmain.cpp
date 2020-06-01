// dllmain.cpp : Определяет точку входа для приложения DLL.
#include "pch.h"
#include <Windows.h>
#include <stdio.h>
BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
typedef void(__stdcall* Output)(const char*);
extern "C" __declspec(dllexport) void __stdcall Print(Output output)
{
    if (!output)
    {
        return;
    }
    char buff[64];
    sprintf_s(buff, "Hello from C++");
    output(buff);
}

