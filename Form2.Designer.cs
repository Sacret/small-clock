namespace WATCH
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDig = new System.Windows.Forms.RadioButton();
            this.rbAn = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSec = new System.Windows.Forms.CheckBox();
            this.cbMin = new System.Windows.Forms.CheckBox();
            this.cbHour = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOpacity = new System.Windows.Forms.TrackBar();
            this.cbUnder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbAlarm = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMF = new System.Windows.Forms.RadioButton();
            this.rbEvery = new System.Windows.Forms.RadioButton();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnAcc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 204);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 178);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Режим";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDig);
            this.groupBox1.Controls.Add(this.rbAn);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим отображения";
            // 
            // rbDig
            // 
            this.rbDig.AutoSize = true;
            this.rbDig.Location = new System.Drawing.Point(15, 48);
            this.rbDig.Name = "rbDig";
            this.rbDig.Size = new System.Drawing.Size(77, 17);
            this.rbDig.TabIndex = 2;
            this.rbDig.Text = "цифровые";
            this.rbDig.UseVisualStyleBackColor = true;
            // 
            // rbAn
            // 
            this.rbAn.AutoSize = true;
            this.rbAn.Checked = true;
            this.rbAn.Location = new System.Drawing.Point(15, 24);
            this.rbAn.Name = "rbAn";
            this.rbAn.Size = new System.Drawing.Size(86, 17);
            this.rbAn.TabIndex = 1;
            this.rbAn.TabStop = true;
            this.rbAn.Text = "аналоговые";
            this.rbAn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 178);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вид";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSec);
            this.groupBox2.Controls.Add(this.cbMin);
            this.groupBox2.Controls.Add(this.cbHour);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры отображения";
            // 
            // cbSec
            // 
            this.cbSec.AutoSize = true;
            this.cbSec.Checked = true;
            this.cbSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSec.Location = new System.Drawing.Point(14, 72);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(69, 17);
            this.cbSec.TabIndex = 2;
            this.cbSec.Text = "секунды";
            this.cbSec.UseVisualStyleBackColor = true;
            // 
            // cbMin
            // 
            this.cbMin.AutoSize = true;
            this.cbMin.Checked = true;
            this.cbMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMin.Location = new System.Drawing.Point(14, 48);
            this.cbMin.Name = "cbMin";
            this.cbMin.Size = new System.Drawing.Size(64, 17);
            this.cbMin.TabIndex = 1;
            this.cbMin.Text = "минуты";
            this.cbMin.UseVisualStyleBackColor = true;
            // 
            // cbHour
            // 
            this.cbHour.AutoSize = true;
            this.cbHour.Checked = true;
            this.cbHour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHour.Location = new System.Drawing.Point(14, 24);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(51, 17);
            this.cbHour.TabIndex = 0;
            this.cbHour.Text = "часы";
            this.cbHour.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tbOpacity);
            this.tabPage4.Controls.Add(this.cbUnder);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.cbPow);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(275, 178);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дополнительно";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Непрозрачность:";
            // 
            // tbOpacity
            // 
            this.tbOpacity.Location = new System.Drawing.Point(10, 100);
            this.tbOpacity.Maximum = 20;
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(254, 45);
            this.tbOpacity.TabIndex = 10;
            this.tbOpacity.Value = 20;
            // 
            // cbUnder
            // 
            this.cbUnder.AutoSize = true;
            this.cbUnder.Checked = true;
            this.cbUnder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUnder.Location = new System.Drawing.Point(98, 39);
            this.cbUnder.Name = "cbUnder";
            this.cbUnder.Size = new System.Drawing.Size(114, 17);
            this.cbUnder.TabIndex = 9;
            this.cbUnder.Text = "поверх всех окон";
            this.cbUnder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Положение:";
            // 
            // cbPow
            // 
            this.cbPow.AutoSize = true;
            this.cbPow.Checked = true;
            this.cbPow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPow.Location = new System.Drawing.Point(98, 9);
            this.cbPow.Name = "cbPow";
            this.cbPow.Size = new System.Drawing.Size(74, 17);
            this.cbPow.TabIndex = 7;
            this.cbPow.Text = "включить";
            this.cbPow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автозапуск:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimePicker1);
            this.tabPage3.Controls.Add(this.cbAlarm);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(275, 178);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Будильник";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(71, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cbAlarm
            // 
            this.cbAlarm.AutoSize = true;
            this.cbAlarm.Location = new System.Drawing.Point(95, 149);
            this.cbAlarm.Name = "cbAlarm";
            this.cbAlarm.Size = new System.Drawing.Size(74, 17);
            this.cbAlarm.TabIndex = 7;
            this.cbAlarm.Text = "включить";
            this.cbAlarm.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Будильник:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMF);
            this.groupBox3.Controls.Add(this.rbEvery);
            this.groupBox3.Controls.Add(this.rbOnce);
            this.groupBox3.Location = new System.Drawing.Point(10, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Частота срабатывания";
            // 
            // rbMF
            // 
            this.rbMF.AutoSize = true;
            this.rbMF.Location = new System.Drawing.Point(25, 75);
            this.rbMF.Name = "rbMF";
            this.rbMF.Size = new System.Drawing.Size(75, 17);
            this.rbMF.TabIndex = 2;
            this.rbMF.TabStop = true;
            this.rbMF.Text = "с пн по пт";
            this.rbMF.UseVisualStyleBackColor = true;
            // 
            // rbEvery
            // 
            this.rbEvery.AutoSize = true;
            this.rbEvery.Location = new System.Drawing.Point(25, 48);
            this.rbEvery.Name = "rbEvery";
            this.rbEvery.Size = new System.Drawing.Size(81, 17);
            this.rbEvery.TabIndex = 1;
            this.rbEvery.TabStop = true;
            this.rbEvery.Text = "ежедневно";
            this.rbEvery.UseVisualStyleBackColor = true;
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Location = new System.Drawing.Point(25, 20);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(70, 17);
            this.rbOnce.TabIndex = 0;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "один раз";
            this.rbOnce.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Время срабатывания будильника:";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(12, 210);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(130, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Отмена";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(143, 210);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.Size = new System.Drawing.Size(130, 23);
            this.btnAcc.TabIndex = 2;
            this.btnAcc.Text = "Применить";
            this.btnAcc.UseVisualStyleBackColor = true;
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 242);
            this.Controls.Add(this.btnAcc);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small clock - настройки";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOpacity)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDig;
        private System.Windows.Forms.RadioButton rbAn;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnAcc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbSec;
        private System.Windows.Forms.CheckBox cbMin;
        private System.Windows.Forms.CheckBox cbHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMF;
        private System.Windows.Forms.RadioButton rbEvery;
        private System.Windows.Forms.RadioButton rbOnce;
        private System.Windows.Forms.CheckBox cbAlarm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbOpacity;
        private System.Windows.Forms.CheckBox cbUnder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPow;
        private System.Windows.Forms.Label label1;
    }
}