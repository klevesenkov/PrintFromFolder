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
            this.btnStartStopScan = new System.Windows.Forms.Button();
            this.lbScanState = new System.Windows.Forms.Label();
            this.pbxScan = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.lblFolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).BeginInit();
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
            this.pbxScan.Image = global::PrintFromFolder.Properties.Resources.scan_off;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 436);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.btnChooseFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxScan);
            this.Controls.Add(this.lbScanState);
            this.Controls.Add(this.btnStartStopScan);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 475);
            this.Name = "MainForm";
            this.Text = "Print from folder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).EndInit();
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
    }
}

