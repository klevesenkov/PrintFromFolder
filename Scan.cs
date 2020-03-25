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
        public bool ScanOn; // флаг сканирования, если true, то идет сканирование
        public string Path; // путь к папке, в которой происходит сканирование
        public string PrinterName; // имя принтера 

        // запуск watcher
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

        // остановка watcher
        public void Stop(FileSystemWatcher watcher)
        {
            ScanOn = false;
            watcher.EnableRaisingEvents = false;

        }

    }

    
}
