using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Memory;

namespace Teleman.Core
{
    public static class MemoryHelper
    {
    public static Mem m = new Mem();
    public static void open(int t) => m.OpenProcess(t);
    public static float RF(string str) => m.ReadFloat(str);
    public static IntPtr RL(string str) => (IntPtr)m.ReadLong(str);
    public static double RD(string str) => m.ReadDouble(str);        

    public static void WR(string code, string type, string write, Encoding stringEncoding = null, bool RemoveWriteProtection = true) 
            => m.WriteMemory(code, type, write, "", stringEncoding, RemoveWriteProtection);
    }
}
