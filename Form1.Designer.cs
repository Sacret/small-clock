namespace WATCH
{
    partial class Form1
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
            System.Windows.Forms.ContextMenuStrip cmsTray;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmsTrayRoll = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTrayR = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTreySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTrayAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsTreyExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tTick = new System.Windows.Forms.Timer(this.components);
            this.niTrey = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            cmsTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsTray
            // 
            cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTrayRoll,
            this.cmsTrayR,
            this.toolStripSeparator1,
            this.cmsTreySettings,
            this.cmsTrayAbout,
            this.toolStripSeparator2,
            this.cmsTreyExit});
            cmsTray.Name = "cmsTrey";
            cmsTray.Size = new System.Drawing.Size(153, 148);
            // 
            // cmsTrayRoll
            // 
            this.cmsTrayRoll.Image = ((System.Drawing.Image)(resources.GetObject("cmsTrayRoll.Image")));
            this.cmsTrayRoll.Name = "cmsTrayRoll";
            this.cmsTrayRoll.Size = new System.Drawing.Size(149, 22);
            this.cmsTrayRoll.Text = "Свернуть";
            this.cmsTrayRoll.Click += new System.EventHandler(this.cmsTrayRoll_Click);
            // 
            // cmsTrayR
            // 
            this.cmsTrayR.Enabled = false;
            this.cmsTrayR.Image = ((System.Drawing.Image)(resources.GetObject("cmsTrayR.Image")));
            this.cmsTrayR.Name = "cmsTrayR";
            this.cmsTrayR.Size = new System.Drawing.Size(149, 22);
            this.cmsTrayR.Text = "Развернуть";
            this.cmsTrayR.Click += new System.EventHandler(this.cmsTrayR_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // cmsTreySettings
            // 
            this.cmsTreySettings.Image = ((System.Drawing.Image)(resources.GetObject("cmsTreySettings.Image")));
            this.cmsTreySettings.Name = "cmsTreySettings";
            this.cmsTreySettings.Size = new System.Drawing.Size(149, 22);
            this.cmsTreySettings.Text = "Настройки";
            this.cmsTreySettings.Click += new System.EventHandler(this.cmsTreySettings_Click);
            // 
            // cmsTrayAbout
            // 
            this.cmsTrayAbout.Image = ((System.Drawing.Image)(resources.GetObject("cmsTrayAbout.Image")));
            this.cmsTrayAbout.Name = "cmsTrayAbout";
            this.cmsTrayAbout.Size = new System.Drawing.Size(149, 22);
            this.cmsTrayAbout.Text = "О программе";
            this.cmsTrayAbout.Click += new System.EventHandler(this.cmsTrayAbout_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // cmsTreyExit
            // 
            this.cmsTreyExit.Image = ((System.Drawing.Image)(resources.GetObject("cmsTreyExit.Image")));
            this.cmsTreyExit.Name = "cmsTreyExit";
            this.cmsTreyExit.Size = new System.Drawing.Size(149, 22);
            this.cmsTreyExit.Text = "Закрыть";
            this.cmsTreyExit.Click += new System.EventHandler(this.cmsTreyExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // tTick
            // 
            this.tTick.Enabled = true;
            this.tTick.Interval = 1000;
            this.tTick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // niTrey
            // 
            this.niTrey.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niTrey.BalloonTipText = "Small clock";
            this.niTrey.ContextMenuStrip = cmsTray;
            this.niTrey.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrey.Icon")));
            this.niTrey.Text = "Small clock";
            this.niTrey.Visible = true;
            // 
            // label1
            // 
            this.label1.ContextMenuStrip = cmsTray;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 32.25F);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00";
            this.label1.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            this.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttInfo.ToolTipTitle = "Дата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(236, 241);
            this.ContextMenuStrip = cmsTray;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WATCH.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = global::WATCH.Properties.Settings.Default.Location;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_SizeChanged);
            cmsTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tTick;
        private System.Windows.Forms.ToolStripMenuItem cmsTreySettings;
        private System.Windows.Forms.ToolStripMenuItem cmsTreyExit;
        public System.Windows.Forms.NotifyIcon niTrey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem cmsTrayRoll;
        private System.Windows.Forms.ToolStripMenuItem cmsTrayR;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmsTrayAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolTip ttInfo;
    }
}

