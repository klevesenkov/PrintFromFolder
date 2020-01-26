using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintFromFolder
{
    public partial class MainForm : Form
    {
        
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
                Scan.Stop();                
            }
            else
            {
                if (Scan.Path != null)   Scan.Start(); 
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
                Scan.Stop();
                RePaint();
                Scan.Path=lblFolder.Text = FBD.SelectedPath;                
            }
        }
    }

    
}
