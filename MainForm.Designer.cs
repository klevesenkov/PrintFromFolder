namespace PrintFromFolder
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStartStopScan = new System.Windows.Forms.Button();
            this.lbScanState = new System.Windows.Forms.Label();
            this.pbxScan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            this.lbPrinter = new System.Windows.Forms.Label();
            this.btnChoosePrinter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GridOfFiles = new System.Windows.Forms.DataGridView();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPrint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClearGridOfFiles = new System.Windows.Forms.Button();
            this.fsw = new System.IO.FileSystemWatcher();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOfFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStopScan
            // 
            this.btnStartStopScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnStartStopScan.Location = new System.Drawing.Point(106, 39);
            this.btnStartStopScan.Name = "btnStartStopScan";
            this.btnStartStopScan.Size = new System.Drawing.Size(245, 52);
            this.btnStartStopScan.TabIndex = 0;
            this.btnStartStopScan.Text = "Остановить сканирование";
            this.btnStartStopScan.UseVisualStyleBackColor = true;
            this.btnStartStopScan.Click += new System.EventHandler(this.btnStartStopScan_Click);
            // 
            // lbScanState
            // 
            this.lbScanState.AutoSize = true;
            this.lbScanState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScanState.ForeColor = System.Drawing.Color.Green;
            this.lbScanState.Location = new System.Drawing.Point(106, 12);
            this.lbScanState.Name = "lbScanState";
            this.lbScanState.Size = new System.Drawing.Size(232, 24);
            this.lbScanState.TabIndex = 1;
            this.lbScanState.Text = "Сканирование включено";
            // 
            // pbxScan
            // 
            this.pbxScan.Image = ((System.Drawing.Image)(resources.GetObject("pbxScan.Image")));
            this.pbxScan.InitialImage = null;
            this.pbxScan.Location = new System.Drawing.Point(12, 12);
            this.pbxScan.Name = "pbxScan";
            this.pbxScan.Size = new System.Drawing.Size(88, 79);
            this.pbxScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxScan.TabIndex = 5;
            this.pbxScan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Папка для сканирования:";
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnChooseFolder.Location = new System.Drawing.Point(12, 159);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(134, 30);
            this.btnChooseFolder.TabIndex = 7;
            this.btnChooseFolder.Text = "Выбор папки";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoEllipsis = true;
            this.lblFolder.AutoSize = true;
            this.lblFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblFolder.Location = new System.Drawing.Point(16, 139);
            this.lblFolder.MaximumSize = new System.Drawing.Size(330, 20);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(130, 17);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Папка не выбрана";
            // 
            // lbPrinter
            // 
            this.lbPrinter.AutoEllipsis = true;
            this.lbPrinter.AutoSize = true;
            this.lbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbPrinter.Location = new System.Drawing.Point(19, 234);
            this.lbPrinter.MaximumSize = new System.Drawing.Size(330, 20);
            this.lbPrinter.Name = "lbPrinter";
            this.lbPrinter.Size = new System.Drawing.Size(138, 17);
            this.lbPrinter.TabIndex = 11;
            this.lbPrinter.Text = "Принтер не выбран";
            // 
            // btnChoosePrinter
            // 
            this.btnChoosePrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnChoosePrinter.Location = new System.Drawing.Point(15, 254);
            this.btnChoosePrinter.Name = "btnChoosePrinter";
            this.btnChoosePrinter.Size = new System.Drawing.Size(134, 30);
            this.btnChoosePrinter.TabIndex = 10;
            this.btnChoosePrinter.Text = "Выбор принтера";
            this.btnChoosePrinter.UseVisualStyleBackColor = true;
            this.btnChoosePrinter.Click += new System.EventHandler(this.btnChoosePrinter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label3.Location = new System.Drawing.Point(15, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Принтер для печати:";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(16, 309);
            this.label2.MaximumSize = new System.Drawing.Size(330, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "Файлы для печати: \r\n*.doc, *.docx, *rtf.\r\n";
            // 
            // GridOfFiles
            // 
            this.GridOfFiles.AllowUserToAddRows = false;
            this.GridOfFiles.AllowUserToDeleteRows = false;
            this.GridOfFiles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridOfFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridOfFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.DateOfPrint});
            this.GridOfFiles.Location = new System.Drawing.Point(373, 39);
            this.GridOfFiles.Name = "GridOfFiles";
            this.GridOfFiles.ReadOnly = true;
            this.GridOfFiles.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GridOfFiles.Size = new System.Drawing.Size(379, 356);
            this.GridOfFiles.TabIndex = 15;
            // 
            // FileName
            // 
            this.FileName.Frozen = true;
            this.FileName.HeaderText = "Имя файла";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FileName.Width = 200;
            // 
            // DateOfPrint
            // 
            this.DateOfPrint.Frozen = true;
            this.DateOfPrint.HeaderText = "Дата и время печати";
            this.DateOfPrint.Name = "DateOfPrint";
            this.DateOfPrint.ReadOnly = true;
            this.DateOfPrint.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateOfPrint.Width = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label6.Location = new System.Drawing.Point(419, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Файлы, отправленные на печать.";
            // 
            // btnClearGridOfFiles
            // 
            this.btnClearGridOfFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnClearGridOfFiles.Location = new System.Drawing.Point(618, 401);
            this.btnClearGridOfFiles.Name = "btnClearGridOfFiles";
            this.btnClearGridOfFiles.Size = new System.Drawing.Size(134, 30);
            this.btnClearGridOfFiles.TabIndex = 17;
            this.btnClearGridOfFiles.Text = "Очистка таблицы";
            this.btnClearGridOfFiles.UseVisualStyleBackColor = true;
            this.btnClearGridOfFiles.Click += new System.EventHandler(this.btnClearGridOfFiles_Click);
            // 
            // fsw
            // 
            this.fsw.EnableRaisingEvents = true;
            this.fsw.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.fsw.SynchronizingObject = this;
            this.fsw.Created += new System.IO.FileSystemEventHandler(this.fsw_Created);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 411);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/klevesenkov/PrintFromFolder";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 436);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnClearGridOfFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GridOfFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPrinter);
            this.Controls.Add(this.btnChoosePrinter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxScan);
            this.Controls.Add(this.lbScanState);
            this.Controls.Add(this.btnStartStopScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 475);
            this.Name = "MainForm";
            this.Text = "Print from folder v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOfFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnStartStopScan;
        public System.Windows.Forms.Label lbScanState;
        public System.Windows.Forms.PictureBox pbxScan;
        public System.Windows.Forms.Button btnChooseFolder;
        public System.Windows.Forms.Label lblFolder;
        public System.Windows.Forms.Label lbPrinter;
        public System.Windows.Forms.Button btnChoosePrinter;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GridOfFiles;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btnClearGridOfFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPrint;
        public  System.IO.FileSystemWatcher fsw;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

