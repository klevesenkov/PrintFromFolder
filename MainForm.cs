using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PrintFromFolder
{
    public partial class MainForm : Form
    {
        // создаем объект для работы сканирования
        scan Scan = new scan();

        // создаем объект для печати
        print Print = new print();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Scan.ScanOn = false;
            chbNotifyOn.Checked = false;
            RePaint();
        }

        private void btnStartStopScan_Click(object sender, EventArgs e)
        {
            // fsw - watcher
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
                Scan.Path = lblFolder.Text = FBD.SelectedPath;
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

        // событие, что должен делать watcher, если в папке появился файл
        private void fsw_Created(object sender, FileSystemEventArgs e)
        {
            // проверка расширения файла и печать
            switch (Path.GetExtension(e.Name))
            {
                case ".doc": Print.PrintDOC(Scan.Path, e.Name, this.GridOfFiles, this.notifyIcon, this.chbNotifyOn); break;
                case ".docx": Print.PrintDOC(Scan.Path, e.Name, this.GridOfFiles, this.notifyIcon, this.chbNotifyOn); break;
                case ".pdf": Print.PrintPDF(Scan.Path, e.Name, this.GridOfFiles, this.notifyIcon, this.chbNotifyOn); break;
            };
        }

        private void btnClearGridOfFiles_Click(object sender, EventArgs e)
        {
            GridOfFiles.Rows.Clear();
        }
             

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Если программу свернули, то убрать ее из панели задач и показать в трее иконку
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon.Visible = true;
                // задаем иконку всплывающей подсказки
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                // задаем текст подсказки
                notifyIcon.BalloonTipText = "Нажмите правой кнопкой мыши по иконке для вызова меню.";
                // устанавливаем зголовк
                notifyIcon.BalloonTipTitle = "Программа свернулась в трей";
                // отображаем подсказку 12 секунд
                notifyIcon.ShowBalloonTip(12);
            }
            else
            {
                ShowInTaskbar = true;
                notifyIcon.Visible = false;
            }
            //base.OnResize(e);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }


}
