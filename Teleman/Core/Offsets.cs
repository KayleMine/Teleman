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
        public static string ObjectManager = "0x20B085C";
        
        public static string PlayerBase = "0x130"; // to udpate....
    
        public static string MoveBase = "0xA0";
        public struct Coords
        {
            public static string x = "0x18";
            public static string y = "0x1C";
            public static string z = "0x20";
            public static string facing = "0x28";
        }
    }
}

