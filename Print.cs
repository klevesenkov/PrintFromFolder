using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFromFolder
{
    class print
    {
        private Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application { Visible = false };
        private Microsoft.Office.Interop.Word.Document doc;
        public void PrintDOC(string path, string name, System.Windows.Forms.DataGridView dg)
        {
            //word.Visible = false;
            doc = word.Documents.Open(path+"\\"+name);
            doc.PrintOut();
            //dg.Rows.Add(name, DateTime.Now.ToString());            
        }
    }
}
