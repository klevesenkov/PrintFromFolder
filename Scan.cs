using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFromFolder
{
    class scan
    {
        public bool ScanOn;
        public string Path;
        public string PrinterName;

        public void Start(FileSystemWatcher watcher)
        {

            try
            {
                watcher.Path = Path;
                watcher.EnableRaisingEvents = true;
                ScanOn = true;
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK);
            }


        }

        public void Stop(FileSystemWatcher watcher)
        {
            ScanOn = false;
            watcher.EnableRaisingEvents = false;

        }

    }

    
}
