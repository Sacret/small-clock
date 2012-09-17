using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WATCH
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //
        // Переменные
        string pred = "00:00:00";
        //
        // При загрузке формы загружаются и все сохранённые параметры
        private void Form2_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.View) rbAn.Checked = true;
            else rbDig.Checked = true;
            cbHour.Checked = cbMin.Checked = cbSec.Checked = false;
            if (Properties.Settings.Default.IsHour) cbHour.Checked = true;
            if (Properties.Settings.Default.IsMinute) cbMin.Checked = true;
            if (Properties.Settings.Default.IsSecond) cbSec.Checked = true;
            if (Properties.Settings.Default.IsUnder) cbUnder.Checked = true;
            else cbUnder.Checked = false;
            if (Properties.Settings.Default.AutoRun) cbPow.Checked = true;
            else cbPow.Checked = false;
            tbOpacity.Value = Properties.Settings.Default.Opacity / 5;
            int k = Properties.Settings.Default.Frequency;
            if (k != 0)
            {
                cbAlarm.Checked = true;
                dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, Properties.Settings.Default.Time.Hours, Properties.Settings.Default.Time.Minutes, Properties.Settings.Default.Time.Seconds);
                if (k == 1) rbOnce.Checked = true;
                if (k == 2) rbEvery.Checked = true;
                if (k == 3) rbMF.Checked = true;
            }
        }
        //
        // Применить изменённые параметры
        private void btnAcc_Click(object sender, EventArgs e)
        {
            if (rbAn.Checked) Properties.Settings.Default.View = true;
            if (rbDig.Checked) Properties.Settings.Default.View = false;
            Properties.Settings.Default.IsHour = Properties.Settings.Default.IsMinute = Properties.Settings.Default.IsSecond = false;
            if (cbHour.Checked) Properties.Settings.Default.IsHour = true;
            if (cbMin.Checked) Properties.Settings.Default.IsMinute = true;
            if (cbSec.Checked) Properties.Settings.Default.IsSecond = true;
            if (cbUnder.Checked) Properties.Settings.Default.IsUnder = true;
            else Properties.Settings.Default.IsUnder = false;
            if (cbPow.Checked) Properties.Settings.Default.AutoRun = true;
            else Properties.Settings.Default.AutoRun = false;
            try
            {
                if (Properties.Settings.Default.AutoRun)
                {
                    // Открываем нужную ветку в реестре    
                    // @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"             
                    Microsoft.Win32.RegistryKey Key =
                        Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", true);
                    // добавляем первый параметр - название ключа   
                    // Второй параметр - это путь к    
                    // исполняемому файлу нашей программы.   
                    Key.SetValue("Small clock", Application.ExecutablePath);
                    Key.Close();
                }
                else
                {
                    //удаляем   
                    Microsoft.Win32.RegistryKey key =
                    Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                    key.DeleteValue("Small clock", false);
                    key.Close();
                }
            }
            catch
            {
                MessageBox.Show("Возникла проблема при работе с реестром");
            }
            Properties.Settings.Default.Opacity = 5 * tbOpacity.Value;
            if (cbAlarm.Checked)
            {
                int i=0;
                if (rbOnce.Checked) i = 1;
                if (rbEvery.Checked) i = 2;
                if (rbMF.Checked) i = 3;
                Properties.Settings.Default.Frequency = i;
                Properties.Settings.Default.Time = dateTimePicker1.Value.TimeOfDay;
            }
            if (!cbAlarm.Checked) Properties.Settings.Default.Frequency = 0;
            Properties.Settings.Default.Save();
            this.Close();
        }
        //
        // Отмена изменений
        private void btnUndo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
           
        
        
        
        //int k = ccurr.Count(n => n == ':');            
      

    }
}
