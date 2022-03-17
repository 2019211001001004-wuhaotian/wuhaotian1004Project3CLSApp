namespace wuhaotian1004Project3CLSApp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSource = new System.Windows.Forms.TabPage();
            this.tabDest = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtProcessedFile = new System.Windows.Forms.TextBox();
            this.optGenerateLog = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lstevents = new System.Windows.Forms.ListBox();
            this.groupeventlog = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabDest.SuspendLayout();
            this.groupeventlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSource);
            this.tabControl1.Controls.Add(this.tabDest);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSource
            // 
            this.tabSource.Controls.Add(this.optGenerateLog);
            this.tabSource.Controls.Add(this.txtProcessedFile);
            this.tabSource.Controls.Add(this.txtSource);
            this.tabSource.Controls.Add(this.label2);
            this.tabSource.Controls.Add(this.label1);
            this.tabSource.ImageIndex = 0;
            this.tabSource.Location = new System.Drawing.Point(4, 25);
            this.tabSource.Name = "tabSource";
            this.tabSource.Padding = new System.Windows.Forms.Padding(3);
            this.tabSource.Size = new System.Drawing.Size(751, 414);
            this.tabSource.TabIndex = 0;
            this.tabSource.Text = "source options";
            this.tabSource.UseVisualStyleBackColor = true;
            this.tabSource.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabDest
            // 
            this.tabDest.Controls.Add(this.btnViewSummary);
            this.tabDest.Controls.Add(this.btnRefresh);
            this.tabDest.Controls.Add(this.groupeventlog);
            this.tabDest.Controls.Add(this.txtDest);
            this.tabDest.Controls.Add(this.label3);
            this.tabDest.ForeColor = System.Drawing.Color.Coral;
            this.tabDest.ImageIndex = 0;
            this.tabDest.Location = new System.Drawing.Point(4, 25);
            this.tabDest.Name = "tabDest";
            this.tabDest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDest.Size = new System.Drawing.Size(781, 447);
            this.tabDest.TabIndex = 1;
            this.tabDest.Text = "destination options";
            this.tabDest.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lADPJv8gSejl7BJkZA_100_100.jpg");
            this.imageList1.Images.SetKeyName(1, "lADPJv8gSejmzsxMbw_111_76.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "After Processing.More source file to:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(189, 63);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(453, 25);
            this.txtSource.TabIndex = 2;
            // 
            // txtProcessedFile
            // 
            this.txtProcessedFile.Location = new System.Drawing.Point(51, 223);
            this.txtProcessedFile.Name = "txtProcessedFile";
            this.txtProcessedFile.Size = new System.Drawing.Size(591, 25);
            this.txtProcessedFile.TabIndex = 3;
            // 
            // optGenerateLog
            // 
            this.optGenerateLog.AutoSize = true;
            this.optGenerateLog.Location = new System.Drawing.Point(51, 279);
            this.optGenerateLog.Name = "optGenerateLog";
            this.optGenerateLog.Size = new System.Drawing.Size(333, 19);
            this.optGenerateLog.TabIndex = 4;
            this.optGenerateLog.Text = "Generate event log for bed file format";
            this.optGenerateLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Destination Director";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(213, 37);
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(339, 25);
            this.txtDest.TabIndex = 1;
            // 
            // lstevents
            // 
            this.lstevents.FormattingEnabled = true;
            this.lstevents.ItemHeight = 15;
            this.lstevents.Location = new System.Drawing.Point(6, 24);
            this.lstevents.Name = "lstevents";
            this.lstevents.Size = new System.Drawing.Size(503, 274);
            this.lstevents.TabIndex = 2;
            // 
            // groupeventlog
            // 
            this.groupeventlog.Controls.Add(this.lstevents);
            this.groupeventlog.Location = new System.Drawing.Point(43, 85);
            this.groupeventlog.Name = "groupeventlog";
            this.groupeventlog.Size = new System.Drawing.Size(529, 306);
            this.groupeventlog.TabIndex = 3;
            this.groupeventlog.TabStop = false;
            this.groupeventlog.Text = "Event Log";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(70, 408);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Log";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.ForeColor = System.Drawing.Color.Black;
            this.btnViewSummary.Location = new System.Drawing.Point(279, 408);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(181, 23);
            this.btnViewSummary.TabIndex = 5;
            this.btnViewSummary.Text = "View Summary";
            this.btnViewSummary.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(92, 520);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 563);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabDest.ResumeLayout(false);
            this.tabDest.PerformLayout();
            this.groupeventlog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSource;
        private System.Windows.Forms.TabPage tabDest;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox optGenerateLog;
        private System.Windows.Forms.TextBox txtProcessedFile;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstevents;
        private System.Windows.Forms.GroupBox groupeventlog;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnExit;
    }
}

