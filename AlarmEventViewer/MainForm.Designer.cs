using VideoOS.Platform.Data;

namespace AlarmEventViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridViewAlarm = new System.Windows.Forms.DataGridView();
            this.buttonInprogress = new System.Windows.Forms.Button();
            this.buttonCompleted = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAccess = new System.Windows.Forms.RadioButton();
            this.rbLPR = new System.Windows.Forms.RadioButton();
            this.rbAnalytics = new System.Windows.Forms.RadioButton();
            this.rbEvents = new System.Windows.Forms.RadioButton();
            this.rbAlarms = new System.Windows.Forms.RadioButton();
            this.buttonTag = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1062, 661);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 28);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.OnClose);
            // 
            // dataGridViewAlarm
            // 
            this.dataGridViewAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAlarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewAlarm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAlarm.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAlarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlarm.Location = new System.Drawing.Point(17, 110);
            this.dataGridViewAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAlarm.MultiSelect = false;
            this.dataGridViewAlarm.Name = "dataGridViewAlarm";
            this.dataGridViewAlarm.ReadOnly = true;
            this.dataGridViewAlarm.RowHeadersVisible = false;
            this.dataGridViewAlarm.RowHeadersWidth = 51;
            this.dataGridViewAlarm.Size = new System.Drawing.Size(1144, 526);
            this.dataGridViewAlarm.TabIndex = 4;
            this.dataGridViewAlarm.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellClick);
            // 
            // buttonInprogress
            // 
            this.buttonInprogress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonInprogress.Enabled = false;
            this.buttonInprogress.Location = new System.Drawing.Point(16, 661);
            this.buttonInprogress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInprogress.Name = "buttonInprogress";
            this.buttonInprogress.Size = new System.Drawing.Size(131, 28);
            this.buttonInprogress.TabIndex = 5;
            this.buttonInprogress.Text = "In Progress";
            this.buttonInprogress.UseVisualStyleBackColor = true;
            this.buttonInprogress.Click += new System.EventHandler(this.buttonInprogress_Click);
            // 
            // buttonCompleted
            // 
            this.buttonCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCompleted.Enabled = false;
            this.buttonCompleted.Location = new System.Drawing.Point(168, 661);
            this.buttonCompleted.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCompleted.Name = "buttonCompleted";
            this.buttonCompleted.Size = new System.Drawing.Size(131, 28);
            this.buttonCompleted.TabIndex = 6;
            this.buttonCompleted.Text = "Completed";
            this.buttonCompleted.UseVisualStyleBackColor = true;
            this.buttonCompleted.Click += new System.EventHandler(this.buttonCompleted_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbAccess);
            this.groupBox1.Controls.Add(this.rbLPR);
            this.groupBox1.Controls.Add(this.rbAnalytics);
            this.groupBox1.Controls.Add(this.rbEvents);
            this.groupBox1.Controls.Add(this.rbAlarms);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1144, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Viewer mode";
            // 
            // rbAccess
            // 
            this.rbAccess.AutoSize = true;
            this.rbAccess.Location = new System.Drawing.Point(343, 25);
            this.rbAccess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAccess.Name = "rbAccess";
            this.rbAccess.Size = new System.Drawing.Size(162, 20);
            this.rbAccess.TabIndex = 4;
            this.rbAccess.TabStop = true;
            this.rbAccess.Text = "Access Control Events";
            this.rbAccess.UseVisualStyleBackColor = true;
            this.rbAccess.CheckedChanged += new System.EventHandler(this.onModeChange);
            // 
            // rbLPR
            // 
            this.rbLPR.AutoSize = true;
            this.rbLPR.Location = new System.Drawing.Point(167, 54);
            this.rbLPR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbLPR.Name = "rbLPR";
            this.rbLPR.Size = new System.Drawing.Size(98, 20);
            this.rbLPR.TabIndex = 3;
            this.rbLPR.Text = "LPR Events";
            this.rbLPR.UseVisualStyleBackColor = true;
            this.rbLPR.CheckedChanged += new System.EventHandler(this.onModeChange);
            // 
            // rbAnalytics
            // 
            this.rbAnalytics.AutoSize = true;
            this.rbAnalytics.Location = new System.Drawing.Point(167, 25);
            this.rbAnalytics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAnalytics.Name = "rbAnalytics";
            this.rbAnalytics.Size = new System.Drawing.Size(126, 20);
            this.rbAnalytics.TabIndex = 2;
            this.rbAnalytics.Text = "Analytics Events";
            this.rbAnalytics.UseVisualStyleBackColor = true;
            this.rbAnalytics.CheckedChanged += new System.EventHandler(this.onModeChange);
            // 
            // rbEvents
            // 
            this.rbEvents.AutoSize = true;
            this.rbEvents.Location = new System.Drawing.Point(9, 54);
            this.rbEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbEvents.Name = "rbEvents";
            this.rbEvents.Size = new System.Drawing.Size(69, 20);
            this.rbEvents.TabIndex = 1;
            this.rbEvents.Text = "Events";
            this.rbEvents.UseVisualStyleBackColor = true;
            this.rbEvents.CheckedChanged += new System.EventHandler(this.onModeChange);
            // 
            // rbAlarms
            // 
            this.rbAlarms.AutoSize = true;
            this.rbAlarms.Checked = true;
            this.rbAlarms.Location = new System.Drawing.Point(9, 25);
            this.rbAlarms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAlarms.Name = "rbAlarms";
            this.rbAlarms.Size = new System.Drawing.Size(70, 20);
            this.rbAlarms.TabIndex = 9;
            this.rbAlarms.TabStop = true;
            this.rbAlarms.Text = "Alarms";
            this.rbAlarms.UseVisualStyleBackColor = true;
            this.rbAlarms.CheckedChanged += new System.EventHandler(this.onModeChange);
            // 
            // buttonTag
            // 
            this.buttonTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTag.Enabled = false;
            this.buttonTag.Location = new System.Drawing.Point(320, 661);
            this.buttonTag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTag.Name = "buttonTag";
            this.buttonTag.Size = new System.Drawing.Size(131, 28);
            this.buttonTag.TabIndex = 7;
            this.buttonTag.Text = "Comment";
            this.buttonTag.UseVisualStyleBackColor = true;
            this.buttonTag.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVideo.Location = new System.Drawing.Point(472, 661);
            this.buttonVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(131, 28);
            this.buttonVideo.TabIndex = 8;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 704);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCompleted);
            this.Controls.Add(this.buttonInprogress);
            this.Controls.Add(this.buttonTag);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.dataGridViewAlarm);
            this.Controls.Add(this.buttonClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Alarms and Events Viewer Application";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlarm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dataGridViewAlarm;
        private System.Windows.Forms.Button buttonInprogress;
        private System.Windows.Forms.Button buttonCompleted;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLPR;
        private System.Windows.Forms.RadioButton rbAnalytics;
        private System.Windows.Forms.RadioButton rbEvents;
        private System.Windows.Forms.RadioButton rbAlarms;
        private System.Windows.Forms.RadioButton rbAccess;
        private System.Windows.Forms.Button buttonTag;
        private System.Windows.Forms.Button buttonVideo;
    }
}