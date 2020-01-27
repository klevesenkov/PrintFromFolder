using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFromFolder
{
    public partial class MainForm : Form
    {
        scan Scan = new scan();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {            
            Scan.ScanOn = false;
            RePaint();
        }

        private void btnStartStopScan_Click(object sender, EventArgs e)
        {
            if (Scan.ScanOn)
            {
                Scan.Stop(fsw);                
            }
            else
            {
                if (Scan.Path != null)
                {
                    if (Scan.PrinterName != null) 
                        Scan.Start(fsw);
                    else MessageBox.Show("Выберите принтер для печати", "Ошибка", MessageBoxButtons.OK);
                }
                else MessageBox.Show("Выберите папку для сканирования", "Ошибка", MessageBoxButtons.OK);

            }
            RePaint();
        }

        void RePaint()
        {
            if (Scan.ScanOn)
            {
                pbxScan.Image = Properties.Resources.scan_on;
                lbScanState.Text = "Сканирование включено";
                lbScanState.ForeColor = Color.Green;
                btnStartStopScan.Text = "Остановить сканирование";
            }
            else
            {
                pbxScan.Image = Properties.Resources.scan_off;
                lbScanState.Text = "Сканирование выключено";
                lbScanState.ForeColor = Color.Red;
                btnStartStopScan.Text = "Запустить сканирование";

            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Scan.Stop(fsw);
                RePaint();
                Scan.Path=lblFolder.Text = FBD.SelectedPath;                
            }
        }

        private void btnChoosePrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                Scan.Stop(fsw);
                RePaint();
                Scan.PrinterName = lbPrinter.Text = printDialog1.PrinterSettings.PrinterName;
            }
        }
        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            GridOfFiles.Rows.Add(e.Name, DateTime.Now.ToString());
        }

        private void btnClearGridOfFiles_Click(object sender, EventArgs e)
        {
            GridOfFiles.Rows.Clear();
        }
    }

    
}
