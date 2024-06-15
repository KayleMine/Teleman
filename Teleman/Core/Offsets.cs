using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teleman.Core
{
    public class Offsets
    {
        public static IntPtr ObjectManager = (IntPtr)0x3D921B0;
        public static IntPtr PlayerBase = (IntPtr)0x130;
        public static IntPtr MoveBase = (IntPtr)0xB0;
        public struct Coords
        {
            public static IntPtr x = (IntPtr)0x20;
            public static IntPtr y = (IntPtr)0x24;
            public static IntPtr z = (IntPtr)0x28;
            public static IntPtr facing = (IntPtr)0x30;
        }
    }
}
