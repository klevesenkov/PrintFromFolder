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
        bool ScanOn;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form settingsform = new SettingsForm();
            settingsform.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ScanOn = false;
            pbxScan.Image = Properties.Resources.scan_off;
            lbScanState.Text = "Сканирование выключено";
            lbScanState.ForeColor = Color.Red;
            btnStartStopScan.Text = "Запустить сканирование";
        }

        private void btnStartStopScan_Click(object sender, EventArgs e)
        {
            if (ScanOn)
            {
                ScanOn = false;
                pbxScan.Image = Properties.Resources.scan_off;
                lbScanState.Text = "Сканирование выключено";
                lbScanState.ForeColor = Color.Red;
                btnStartStopScan.Text = "Запустить сканирование";
            }
            else
            {
                ScanOn = true;
                pbxScan.Image = Properties.Resources.scan_on;
                lbScanState.Text = "Сканирование включено";
                lbScanState.ForeColor = Color.Green;
                btnStartStopScan.Text = "Остановить сканирование";
            }
        }
    }

    
}
