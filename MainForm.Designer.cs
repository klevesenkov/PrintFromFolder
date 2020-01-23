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
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbxScan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartStopScan
            // 
            this.btnStartStopScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnStartStopScan.Location = new System.Drawing.Point(110, 39);
            this.btnStartStopScan.Name = "btnStartStopScan";
            this.btnStartStopScan.Size = new System.Drawing.Size(241, 52);
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
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnSettings.Location = new System.Drawing.Point(12, 394);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(340, 30);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 436);
            this.Controls.Add(this.pbxScan);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lbScanState);
            this.Controls.Add(this.btnStartStopScan);
            this.Name = "MainForm";
            this.Text = "Print from folder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStopScan;
        private System.Windows.Forms.Label lbScanState;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbxScan;
    }
}

