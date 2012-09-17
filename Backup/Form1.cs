using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Runtime.InteropServices;

namespace WATCH
{
    public partial class Form1 : Form
    {
      /*  // делегат для манипулирования лейбом   
        public delegate void DelegateForTime(Label label);
        // поле типа делегата   
        DelegateForTime DelTime;
        // поток   
        Thread t1;  */
        public Form1()
        {
            InitializeComponent();
           /* DelTime = new DelegateForTime(StartTime);// указываем метод делегату */  
        }
        //
        // Переменные
        public Point mouse_offset;
        static int s, m, h;       
        int sec, min, hour;
        static float X0 = 119, Y0 = 119, R = 119, X, Y;
        float Ls = 0.70F * R, Lm = 0.68F * R, Lh = 0.5F * R;
        Graphics g1;
        Pen myPen = new Pen(Color.White);        
        //
        // Событие - опускание "мыши" вниз
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        //
        // Событие - перемещение "мыши"
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y); // определяем текущие координаты курсора...
                Location = mousePos; // ... и перемещаем форму
            }
        }
        //
        // Начинает "тикать" при загрузке формы
        private void Form1_Load(object sender, EventArgs e)        
        {
            ApplyChanges();
            if (Properties.Settings.Default.View) RunAn();
            else RunDig();
        }
        //
        // Запустить аналоговые часы
        void RunAn()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Width = 236;
            this.Height = 241;
            this.TransparencyKey = Color.Black;
            label1.Visible = false;
            pictureBox1.Visible = true;
            //
            GraphicsPath gp = new GraphicsPath();
            Rectangle SmallRect = this.ClientRectangle;
            SmallRect.Inflate(-6, -6);
            gp.AddEllipse(SmallRect);
            this.Region = new Region(gp);
            g1 = pictureBox1.CreateGraphics();
            g1.SmoothingMode = SmoothingMode.HighQuality;            
            tTick.Start();              
        }
        //
        // Запустить цифровые часы
        void RunDig()
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Width = label1.Location.X * 2 + label1.Width;
            this.Height = 79;
            this.TransparencyKey = Color.Green;
            this.Text = "Small clock";
            label1.Visible = true;
            pictureBox1.Visible = false;
            /*tTick.Stop();*/
            //
           /* t1 = new Thread(LabelTime); // создаем поток   
            t1.IsBackground = true; // задаем фоновый режим   
            t1.Priority = ThreadPriority.Lowest; // указываем самый низкий приоритет   
            t1.Start(); // стартуем   */
            tTick.Start();      
        }
        //
        // Устанавливает время   
       /* void StartTime(Label label)
        {
            // выводим всегда две цифры    
            // (00:00)   
            string s;
            if (Properties.Settings.Default.IsHour)
                s = DateTime.Now.Hour.ToString("00");
            else s = "  ";
            s += ":";
            if (Properties.Settings.Default.IsMinute)
                s += DateTime.Now.Minute.ToString("00");
            else s += "  ";
            if (Properties.Settings.Default.IsSecond)
                s += ":" + DateTime.Now.Second.ToString("00");
            else s += "  ";
            label.Text = s;
        }
        //
        // Запуск метода
        void LabelTime()
        {
            // безконечный цикл   
            while (true)
            {
                Invoke(DelTime, label1);// запускаем метод с главного потока              
            }
        }  */        
        //
        // Движение стрелок
        private void timer1_Tick(object sender, EventArgs e)
        {
            s = DateTime.Now.Second;
            m = DateTime.Now.Minute;
            h = DateTime.Now.Hour;
            if (h > 11) h -= 12;      
            //
            int k = Properties.Settings.Default.Frequency;
            int h1=Properties.Settings.Default.Time.Hours;
            if (h1 > 11) h1 -= 12;
            if (h == h1 &&
                m == Properties.Settings.Default.Time.Minutes &&
                s == Properties.Settings.Default.Time.Seconds &&
                k != 0)
            {
                Thread t = new Thread(TimeVerif);
                t.Start();   // Выполнить в новом потоке
            }
            //
            if (Properties.Settings.Default.View)
            {
                hour = 90 - (h * 30 + m / 2);
                min = 90 - m * 6;
                sec = 90 - s * 6;
                //   
                pictureBox1.Refresh();
                //
                if (Properties.Settings.Default.IsHour)
                {
                    X = (float)(X0 + Lh * Math.Cos(hour * 2 * Math.PI / 360));
                    Y = (float)(Y0 - Lh * Math.Sin(hour * 2 * Math.PI / 360));
                    myPen.Color = Color.FromArgb(160, 160, 160);
                    myPen.Width = 5;
                    myPen.StartCap = LineCap.Flat;
                    myPen.EndCap = LineCap.DiamondAnchor;
                    g1.DrawLine(myPen, X0, Y0, X, Y);
                }
                //
                if (Properties.Settings.Default.IsMinute)
                {
                    X = (float)(X0 + Lm * Math.Cos(min * 2 * Math.PI / 360));
                    Y = (float)(Y0 - Lm * Math.Sin(min * 2 * Math.PI / 360));
                    myPen.Color = Color.FromArgb(165, 171, 186);
                    myPen.Width = 3;
                    myPen.StartCap = LineCap.RoundAnchor;
                    myPen.EndCap = LineCap.ArrowAnchor;
                    g1.DrawLine(myPen, X0, Y0, X, Y);
                }
                //
                if (Properties.Settings.Default.IsSecond)
                {
                    X = (float)(X0 + Ls * Math.Cos(sec * 2 * Math.PI / 360));
                    Y = (float)(Y0 - Ls * Math.Sin(sec * 2 * Math.PI / 360));
                    myPen.Color = Color.FromArgb(201, 208, 227);
                    myPen.Width = 1;
                    myPen.CustomEndCap = new AdjustableArrowCap(2, 3, true);
                    g1.DrawLine(myPen, X0, Y0, X, Y);
                }
            }
            else
            {
                // выводим всегда две цифры    
                // (00:00)   
                string s1;
                if (Properties.Settings.Default.IsHour)
                    s1 = DateTime.Now.Hour.ToString("00");
                else s1 = "  ";
                s1 += ":";
                if (Properties.Settings.Default.IsMinute)
                    s1 += DateTime.Now.Minute.ToString("00");
                else s1 += "  ";
                if (Properties.Settings.Default.IsSecond)
                    s1 += ":" + DateTime.Now.Second.ToString("00");
                else s1 += "  ";
                label1.Text = s1;
            }            
        }
        //
        // Закрыть приложение
        private void cmsTreyExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        // Процесс закрытия формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save();
        }
        //
        // Вызов окна настроек
        private void cmsTreySettings_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
            ApplyChanges();
        }
        //
        // Применить новые настройки
        void ApplyChanges()
        {
            if (!Properties.Settings.Default.IsUnder) this.TopMost = false;
            else this.TopMost = true;
            int Op = Properties.Settings.Default.Opacity;
            this.Opacity = (double)Op/100.0;          
            if (Properties.Settings.Default.View)
            {
                RunAn();
            }
            else RunDig();
        }
        //
        // звуковое представление
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);  
        //
        //
        void TimeVerif()
        {
            int k = Properties.Settings.Default.Frequency;
            if (k == 1)
            {
                Beep(500, 5000);
                Properties.Settings.Default.Frequency = 0;
            }
            if (k == 2) Beep(500, 5000);
            if (k == 3 && DateTime.Now.DayOfWeek != DayOfWeek.Saturday && DateTime.Now.DayOfWeek != DayOfWeek.Sunday)
            {
                Beep(500, 5000);
            }            
            Properties.Settings.Default.Save();
        }
        //
        // Свернуть
        private void cmsTrayRoll_Click(object sender, EventArgs e)
        {
            if (this.WindowState!=FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Minimized;
                cmsTrayR.Enabled = true;
                cmsTrayRoll.Enabled = false;
            }
        }
        //
        // Развернуть
        private void cmsTrayR_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Normal;
                cmsTrayR.Enabled = false;
                cmsTrayRoll.Enabled = true;
            }
        }

        private void cmsTrayAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа 'Small clock' разработана в 2011 году. Подробности на сайте www.sacret.ru",
                "Small clock - о программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
