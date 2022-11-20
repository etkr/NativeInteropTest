namespace Native.Lib;

using System;
using System.Runtime.InteropServices;


public static class NativeInterop
{
    [DllImport("nativejson")]
    private static extern IntPtr Compile(string file);

    public static string CompileNative(string file)
    {
        var pointer = Compile(file);
        var @string = Marshal.PtrToStringAnsi(pointer);
        return @string ?? "";
    }

}
