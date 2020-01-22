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
            this.lbFolders = new System.Windows.Forms.Label();
            this.lbxFolders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStartStopScan
            // 
            this.btnStartStopScan.Location = new System.Drawing.Point(16, 36);
            this.btnStartStopScan.Name = "btnStartStopScan";
            this.btnStartStopScan.Size = new System.Drawing.Size(228, 23);
            this.btnStartStopScan.TabIndex = 0;
            this.btnStartStopScan.Text = "Остановить сканирование";
            this.btnStartStopScan.UseVisualStyleBackColor = true;
            // 
            // lbScanState
            // 
            this.lbScanState.AutoSize = true;
            this.lbScanState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScanState.ForeColor = System.Drawing.Color.Green;
            this.lbScanState.Location = new System.Drawing.Point(12, 9);
            this.lbScanState.Name = "lbScanState";
            this.lbScanState.Size = new System.Drawing.Size(232, 24);
            this.lbScanState.TabIndex = 1;
            this.lbScanState.Text = "Сканирование включено";
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(16, 65);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(228, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lbFolders
            // 
            this.lbFolders.AutoSize = true;
            this.lbFolders.Location = new System.Drawing.Point(16, 95);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(138, 13);
            this.lbFolders.TabIndex = 3;
            this.lbFolders.Text = "Папки для сканирования:";
            // 
            // lbxFolders
            // 
            this.lbxFolders.FormattingEnabled = true;
            this.lbxFolders.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.lbxFolders.Location = new System.Drawing.Point(19, 112);
            this.lbxFolders.Name = "lbxFolders";
            this.lbxFolders.Size = new System.Drawing.Size(225, 108);
            this.lbxFolders.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 436);
            this.Controls.Add(this.lbxFolders);
            this.Controls.Add(this.lbFolders);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lbScanState);
            this.Controls.Add(this.btnStartStopScan);
            this.Name = "MainForm";
            this.Text = "Print from folder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStopScan;
        private System.Windows.Forms.Label lbScanState;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lbFolders;
        private System.Windows.Forms.ListBox lbxFolders;
    }
}

