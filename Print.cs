using System;

namespace PrintFromFolder
{
    class print
    {
        public void PrintDOC(string path, string name, System.Windows.Forms.DataGridView dg)
        {
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application { Visible = false };
            Microsoft.Office.Interop.Word.Document doc = new Microsoft.Office.Interop.Word.Document();
            doc = word.Documents.Open(path + "\\" + name);
            doc.PrintOut();
            dg.Rows.Add(name, DateTime.Now.ToString());
            doc.Close();
            word.Application.Quit();
        }
    }
}
