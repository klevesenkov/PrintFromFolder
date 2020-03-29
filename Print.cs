using System;
using System.Diagnostics;

namespace PrintFromFolder
{
    class print
    {
        
        public void PrintDOC(string path, string name, System.Windows.Forms.DataGridView dg)
        {
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application { Visible = false };
            doc = word.Documents.Open(path + "\\" + name);
            doc.PrintOut();
            dg.Rows.Add(name, DateTime.Now.ToString());
            doc.Close();
            word.Application.Quit();            
        }

        public void PrintPDF(string path, string name, System.Windows.Forms.DataGridView dg)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = path + "\\" + name
            };
            dg.Rows.Add(name, DateTime.Now.ToString());
            p.Start();
            p.Close();
        }
    }
}
