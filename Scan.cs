using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFromFolder
{
    static class Scan
    {
        public static bool ScanOn;
        public static string Path;

        public static void Start()
        {
            ScanOn = true;
            
        }

        public static void Stop()
        {
            ScanOn = false;
            
        }

    }
}
