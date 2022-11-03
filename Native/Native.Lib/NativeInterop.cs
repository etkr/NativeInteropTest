namespace Native.Lib;

using System;
using System.Runtime.InteropServices;


public static class NativeInterop
{
    [DllImport("nativejson")]
    public static extern uint Compile(string file);

}
