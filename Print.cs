using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PrintFromFolder
{
    class print
    {
        
        public void PrintDOC(string path, string name, DataGridView dg, NotifyIcon ni, CheckBox chb)
        {
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            Microsoft.Office.Interop.Word.Application word = 
                new Microsoft.Office.Interop.Word.Application { Visible = false };
            doc = word.Documents.Open(path + "\\" + name);
            doc.PrintOut();
            dg.Rows.Add(name, DateTime.Now.ToString());
            if (chb.Checked) ShowNotify(ni, name);   
            doc.Close();
            word.Application.Quit();            
        }

        public void PrintPDF(string path, string name, DataGridView dg, NotifyIcon ni, CheckBox chb)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = path + "\\" + name
            };
            dg.Rows.Add(name, DateTime.Now.ToString());
            if (chb.Checked) ShowNotify(ni, name);
            p.Start();
            p.Close();
        }

        //всплывающая подсказка при печати файла
        private void ShowNotify(NotifyIcon ni, string file)
        {
            // задаем иконку всплывающей подсказки
            ni.BalloonTipIcon = ToolTipIcon.Info;
            // задаем текст подсказки
            ni.BalloonTipText = file;
            // устанавливаем зголовк
            ni.BalloonTipTitle = "Файл отправлен на печать";
            // отображаем подсказку 12 секунд
            ni.ShowBalloonTip(12);
        }
    }
}
