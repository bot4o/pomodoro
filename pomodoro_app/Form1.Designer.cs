namespace pomodoro_app
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_work = new Button();
            btnStart = new Button();
            btn_lbreak = new Button();
            btn_sbreak = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            timerToolStripMenuItem = new ToolStripMenuItem();
            timeToolStripMenuItem = new ToolStripMenuItem();
            autoStartToolStripMenuItem = new ToolStripMenuItem();
            longBrakeIntervalToolStripMenuItem = new ToolStripMenuItem();
            taskToolStripMenuItem = new ToolStripMenuItem();
            autoSwitchTasksToolStripMenuItem = new ToolStripMenuItem();
            alarmSoundToolStripMenuItem = new ToolStripMenuItem();
            alarmSoundToolStripMenuItem1 = new ToolStripMenuItem();
            defaultToolStripMenuItem = new ToolStripMenuItem();
            volumeToolStripMenuItem = new ToolStripMenuItem();
            repeatToolStripMenuItem = new ToolStripMenuItem();
            tickingSoundToolStripMenuItem = new ToolStripMenuItem();
            noneToolStripMenuItem = new ToolStripMenuItem();
            volumeToolStripMenuItem1 = new ToolStripMenuItem();
            themeToolStripMenuItem = new ToolStripMenuItem();
            colorThemesToolStripMenuItem = new ToolStripMenuItem();
            workToolStripMenuItem = new ToolStripMenuItem();
            shortBrakeToolStripMenuItem = new ToolStripMenuItem();
            longBrakeToolStripMenuItem = new ToolStripMenuItem();
            hourFormatToolStripMenuItem = new ToolStripMenuItem();
            hourToolStripMenuItem = new ToolStripMenuItem();
            hourToolStripMenuItem1 = new ToolStripMenuItem();
            darkModeWhenRunningToolStripMenuItem = new ToolStripMenuItem();
            enabledToolStripMenuItem1 = new ToolStripMenuItem();
            disabledToolStripMenuItem1 = new ToolStripMenuItem();
            smallWindowToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem1 = new ToolStripMenuItem();
            fullscreenToolStripMenuItem = new ToolStripMenuItem();
            labelTimer = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            labelCounter = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_work
            // 
            btn_work.Cursor = Cursors.Hand;
            btn_work.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 127);
            btn_work.FlatStyle = FlatStyle.Flat;
            btn_work.Location = new Point(70, 93);
            btn_work.Name = "btn_work";
            btn_work.Size = new Size(90, 30);
            btn_work.TabIndex = 5;
            btn_work.Text = "Pomodoro";
            btn_work.UseVisualStyleBackColor = true;
            btn_work.Click += btn_work_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.White;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.FromArgb(29, 29, 153);
            btnStart.Location = new Point(110, 276);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(229, 56);
            btnStart.TabIndex = 8;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btn_lbreak
            // 
            btn_lbreak.Cursor = Cursors.Hand;
            btn_lbreak.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 127);
            btn_lbreak.FlatStyle = FlatStyle.Flat;
            btn_lbreak.Location = new Point(285, 93);
            btn_lbreak.Name = "btn_lbreak";
            btn_lbreak.Size = new Size(90, 30);
            btn_lbreak.TabIndex = 9;
            btn_lbreak.Text = "Long Break";
            btn_lbreak.UseVisualStyleBackColor = true;
            btn_lbreak.Click += btn_lbreak_Click;
            // 
            // btn_sbreak
            // 
            btn_sbreak.Cursor = Cursors.Hand;
            btn_sbreak.FlatAppearance.BorderColor = Color.FromArgb(24, 24, 127);
            btn_sbreak.FlatStyle = FlatStyle.Flat;
            btn_sbreak.Location = new Point(177, 93);
            btn_sbreak.Name = "btn_sbreak";
            btn_sbreak.Size = new Size(90, 30);
            btn_sbreak.TabIndex = 10;
            btn_sbreak.Text = "Short Break";
            btn_sbreak.UseVisualStyleBackColor = true;
            btn_sbreak.Click += btn_sbreak_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, viewToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(434, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(39, 20);
            viewToolStripMenuItem.Text = "Edit";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timerToolStripMenuItem, taskToolStripMenuItem, alarmSoundToolStripMenuItem, themeToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // timerToolStripMenuItem
            // 
            timerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { timeToolStripMenuItem, autoStartToolStripMenuItem, longBrakeIntervalToolStripMenuItem });
            timerToolStripMenuItem.Name = "timerToolStripMenuItem";
            timerToolStripMenuItem.Size = new Size(180, 22);
            timerToolStripMenuItem.Text = "Timer";
            // 
            // timeToolStripMenuItem
            // 
            timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            timeToolStripMenuItem.Size = new Size(180, 22);
            timeToolStripMenuItem.Text = "Time";
            timeToolStripMenuItem.Click += timeToolStripMenuItem_Click;
            // 
            // autoStartToolStripMenuItem
            // 
            autoStartToolStripMenuItem.Name = "autoStartToolStripMenuItem";
            autoStartToolStripMenuItem.Size = new Size(180, 22);
            autoStartToolStripMenuItem.Text = "Auto Start ";
            autoStartToolStripMenuItem.Click += autoStartBreaksToolStripMenuItem_Click_1;
            // 
            // longBrakeIntervalToolStripMenuItem
            // 
            longBrakeIntervalToolStripMenuItem.Name = "longBrakeIntervalToolStripMenuItem";
            longBrakeIntervalToolStripMenuItem.Size = new Size(180, 22);
            longBrakeIntervalToolStripMenuItem.Text = "Long Brake Interval";
            longBrakeIntervalToolStripMenuItem.Click += longBrakeIntervalToolStripMenuItem_Click;
            // 
            // taskToolStripMenuItem
            // 
            taskToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { autoSwitchTasksToolStripMenuItem });
            taskToolStripMenuItem.Enabled = false;
            taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            taskToolStripMenuItem.Size = new Size(180, 22);
            taskToolStripMenuItem.Text = "Task";
            // 
            // autoSwitchTasksToolStripMenuItem
            // 
            autoSwitchTasksToolStripMenuItem.Name = "autoSwitchTasksToolStripMenuItem";
            autoSwitchTasksToolStripMenuItem.Size = new Size(168, 22);
            autoSwitchTasksToolStripMenuItem.Text = "Auto Switch Tasks";
            // 
            // alarmSoundToolStripMenuItem
            // 
            alarmSoundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarmSoundToolStripMenuItem1, tickingSoundToolStripMenuItem });
            alarmSoundToolStripMenuItem.Enabled = false;
            alarmSoundToolStripMenuItem.Name = "alarmSoundToolStripMenuItem";
            alarmSoundToolStripMenuItem.Size = new Size(180, 22);
            alarmSoundToolStripMenuItem.Text = "Sound";
            // 
            // alarmSoundToolStripMenuItem1
            // 
            alarmSoundToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { defaultToolStripMenuItem, volumeToolStripMenuItem, repeatToolStripMenuItem });
            alarmSoundToolStripMenuItem1.Name = "alarmSoundToolStripMenuItem1";
            alarmSoundToolStripMenuItem1.Size = new Size(180, 22);
            alarmSoundToolStripMenuItem1.Text = "Alarm Sound";
            // 
            // defaultToolStripMenuItem
            // 
            defaultToolStripMenuItem.Checked = true;
            defaultToolStripMenuItem.CheckState = CheckState.Checked;
            defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            defaultToolStripMenuItem.Size = new Size(114, 22);
            defaultToolStripMenuItem.Text = "Default";
            // 
            // volumeToolStripMenuItem
            // 
            volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            volumeToolStripMenuItem.Size = new Size(114, 22);
            volumeToolStripMenuItem.Text = "Volume";
            // 
            // repeatToolStripMenuItem
            // 
            repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            repeatToolStripMenuItem.Size = new Size(114, 22);
            repeatToolStripMenuItem.Text = "Repeat";
            // 
            // tickingSoundToolStripMenuItem
            // 
            tickingSoundToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noneToolStripMenuItem, volumeToolStripMenuItem1 });
            tickingSoundToolStripMenuItem.Name = "tickingSoundToolStripMenuItem";
            tickingSoundToolStripMenuItem.Size = new Size(180, 22);
            tickingSoundToolStripMenuItem.Text = "Ticking Sound";
            // 
            // noneToolStripMenuItem
            // 
            noneToolStripMenuItem.Checked = true;
            noneToolStripMenuItem.CheckState = CheckState.Checked;
            noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            noneToolStripMenuItem.Size = new Size(114, 22);
            noneToolStripMenuItem.Text = "None";
            // 
            // volumeToolStripMenuItem1
            // 
            volumeToolStripMenuItem1.Name = "volumeToolStripMenuItem1";
            volumeToolStripMenuItem1.Size = new Size(114, 22);
            volumeToolStripMenuItem1.Text = "Volume";
            // 
            // themeToolStripMenuItem
            // 
            themeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { colorThemesToolStripMenuItem, hourFormatToolStripMenuItem, darkModeWhenRunningToolStripMenuItem, smallWindowToolStripMenuItem });
            themeToolStripMenuItem.Enabled = false;
            themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            themeToolStripMenuItem.Size = new Size(180, 22);
            themeToolStripMenuItem.Text = "Theme";
            // 
            // colorThemesToolStripMenuItem
            // 
            colorThemesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { workToolStripMenuItem, shortBrakeToolStripMenuItem, longBrakeToolStripMenuItem });
            colorThemesToolStripMenuItem.Name = "colorThemesToolStripMenuItem";
            colorThemesToolStripMenuItem.Size = new Size(209, 22);
            colorThemesToolStripMenuItem.Text = "Color Themes";
            // 
            // workToolStripMenuItem
            // 
            workToolStripMenuItem.Name = "workToolStripMenuItem";
            workToolStripMenuItem.Size = new Size(134, 22);
            workToolStripMenuItem.Text = "Work";
            // 
            // shortBrakeToolStripMenuItem
            // 
            shortBrakeToolStripMenuItem.Name = "shortBrakeToolStripMenuItem";
            shortBrakeToolStripMenuItem.Size = new Size(134, 22);
            shortBrakeToolStripMenuItem.Text = "Short Brake";
            // 
            // longBrakeToolStripMenuItem
            // 
            longBrakeToolStripMenuItem.Name = "longBrakeToolStripMenuItem";
            longBrakeToolStripMenuItem.Size = new Size(134, 22);
            longBrakeToolStripMenuItem.Text = "Long Brake";
            // 
            // hourFormatToolStripMenuItem
            // 
            hourFormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hourToolStripMenuItem, hourToolStripMenuItem1 });
            hourFormatToolStripMenuItem.Name = "hourFormatToolStripMenuItem";
            hourFormatToolStripMenuItem.Size = new Size(209, 22);
            hourFormatToolStripMenuItem.Text = "Hour Format";
            // 
            // hourToolStripMenuItem
            // 
            hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            hourToolStripMenuItem.Size = new Size(116, 22);
            hourToolStripMenuItem.Text = "12-hour";
            // 
            // hourToolStripMenuItem1
            // 
            hourToolStripMenuItem1.Name = "hourToolStripMenuItem1";
            hourToolStripMenuItem1.Size = new Size(116, 22);
            hourToolStripMenuItem1.Text = "24-hour";
            // 
            // darkModeWhenRunningToolStripMenuItem
            // 
            darkModeWhenRunningToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enabledToolStripMenuItem1, disabledToolStripMenuItem1 });
            darkModeWhenRunningToolStripMenuItem.Name = "darkModeWhenRunningToolStripMenuItem";
            darkModeWhenRunningToolStripMenuItem.Size = new Size(209, 22);
            darkModeWhenRunningToolStripMenuItem.Text = "Dark Mode when running";
            // 
            // enabledToolStripMenuItem1
            // 
            enabledToolStripMenuItem1.Name = "enabledToolStripMenuItem1";
            enabledToolStripMenuItem1.Size = new Size(119, 22);
            enabledToolStripMenuItem1.Text = "Enabled";
            // 
            // disabledToolStripMenuItem1
            // 
            disabledToolStripMenuItem1.Name = "disabledToolStripMenuItem1";
            disabledToolStripMenuItem1.Size = new Size(119, 22);
            disabledToolStripMenuItem1.Text = "Disabled";
            // 
            // smallWindowToolStripMenuItem
            // 
            smallWindowToolStripMenuItem.Name = "smallWindowToolStripMenuItem";
            smallWindowToolStripMenuItem.Size = new Size(209, 22);
            smallWindowToolStripMenuItem.Text = "Small Window";
            // 
            // viewToolStripMenuItem1
            // 
            viewToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { fullscreenToolStripMenuItem });
            viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            viewToolStripMenuItem1.Size = new Size(44, 20);
            viewToolStripMenuItem1.Text = "View";
            // 
            // fullscreenToolStripMenuItem
            // 
            fullscreenToolStripMenuItem.Enabled = false;
            fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            fullscreenToolStripMenuItem.Size = new Size(127, 22);
            fullscreenToolStripMenuItem.Text = "Fullscreen";
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Arial Rounded MT Bold", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(70, 148);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(305, 111);
            labelTimer.TabIndex = 12;
            labelTimer.Text = "25:00";
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1;
            timerCountdown.Tick += timerCountdown_Tick;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(202, 349);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(0, 14);
            labelCounter.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 127);
            ClientSize = new Size(434, 411);
            Controls.Add(labelCounter);
            Controls.Add(labelTimer);
            Controls.Add(btnStart);
            Controls.Add(btn_work);
            Controls.Add(btn_sbreak);
            Controls.Add(btn_lbreak);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Pomodoro";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_time;
        private Button btn_work;
        private Button btnStart;
        private Button btn_sbreak;
        private Button btn_lbreak;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem timerToolStripMenuItem;
        private ToolStripMenuItem timeToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem;
        private ToolStripMenuItem disabledToolStripMenuItem;
        private ToolStripMenuItem autoStartWorkToolStripMenuItem;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripMenuItem longBrakeIntervalToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private ToolStripMenuItem autoSwitchTasksToolStripMenuItem;
        private ToolStripMenuItem alarmSoundToolStripMenuItem;
        private ToolStripMenuItem alarmSoundToolStripMenuItem1;
        private ToolStripMenuItem defaultToolStripMenuItem;
        private ToolStripMenuItem volumeToolStripMenuItem;
        private ToolStripMenuItem repeatToolStripMenuItem;
        private ToolStripMenuItem tickingSoundToolStripMenuItem;
        private ToolStripMenuItem noneToolStripMenuItem;
        private ToolStripMenuItem volumeToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem colorThemesToolStripMenuItem;
        private ToolStripMenuItem workToolStripMenuItem;
        private ToolStripMenuItem shortBrakeToolStripMenuItem;
        private ToolStripMenuItem longBrakeToolStripMenuItem;
        private ToolStripMenuItem hourFormatToolStripMenuItem;
        private ToolStripMenuItem hourToolStripMenuItem;
        private ToolStripMenuItem hourToolStripMenuItem1;
        private ToolStripMenuItem darkModeWhenRunningToolStripMenuItem;
        private ToolStripMenuItem enabledToolStripMenuItem1;
        private ToolStripMenuItem disabledToolStripMenuItem1;
        private ToolStripMenuItem smallWindowToolStripMenuItem;
        private Label labelTimer;
        public System.Windows.Forms.Timer timerCountdown;
        private Label labelCounter;
        private ToolStripMenuItem viewToolStripMenuItem1;
        private ToolStripMenuItem fullscreenToolStripMenuItem;
        private ToolStripMenuItem autoStartToolStripMenuItem;
    }
}