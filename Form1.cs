using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace AfterburnerMonitor
{
    public partial class MainForm : Form
    {
        const string defaultMSIPath = @"C:\Program Files (x86)\MSI Afterburner\";
        const string msiExe = @"MSIAfterburner.exe";
        static string configPath = Application.StartupPath + @"\config.ini";

        bool startMinimzied;

        string msiPath, msiExePath;

        public MainForm()
        {
            SystemEvents.PowerModeChanged += new PowerModeChangedEventHandler(SystemEvents_PowerModeChanged);
            
            InitializeComponent();

            //Check Config
            GetIniValue();
            CheckPowerLines();
        }

        private void MinimizeForm(bool state)
        {
            if (state)
            {
                Hide();
                trayIcon.Visible = true;
            }
            else
            {
                Show();
                WindowState = FormWindowState.Normal;
                trayIcon.Visible = false;
            }
        }

        #region Start/Stop
        void CheckPowerLines()
        {
            PowerStatus pwr = SystemInformation.PowerStatus;
            switch (pwr.PowerLineStatus)
            {
                case PowerLineStatus.Offline:
                    labelStatus.Text = "Power Status : Not Charging";
                    StopProcess();
                    break;
                case PowerLineStatus.Online:
                    labelStatus.Text = "Power Status : Charging";
                    StartProcess();
                    break;
                case PowerLineStatus.Unknown:
                    labelStatus.Text = "Power Status : Unknown";
                    break;
            }

        }
        void StartProcess()
        {
            Process pr = new Process();
            pr.StartInfo.FileName = msiExePath;
            try
            {
                pr.Start();
            }
            catch (Exception)
            {

                throw;
            } 
        }

        void StopProcess()
        {
            try
            {
                foreach (Process process in Process.GetProcessesByName("MSIAfterburner"))
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {
                throw;
            }
            try
            {
                foreach (Process process in Process.GetProcessesByName("RTSS"))
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region Config
        void SelectMSI()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Title = "MSI Afterburner Executable File",
                Filter = "Executable (*.exe) | *.exe",
                InitialDirectory = "C:\\"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                msiExePath = ofd.FileName;
                msiPath = Path.GetDirectoryName(msiExe);
            }

            WriteToConfig();
        }

        private void GetIniValue()
        {
            IniHelper ini = new IniHelper(configPath);
            msiExePath = ini.IniReadValue("Application", "MSIPath");

            startMinimzied = (ini.IniReadValue("Application", "StartMinimized") == "True") ? true : false;
        }

        void WriteToConfig()
        {
            IniHelper ini = new IniHelper(configPath);
            ini.IniWriteValue("Application", "MSIPath", msiExePath);
        }
        #endregion

        #region Event Handler
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!(Process.GetProcessesByName("MSIAfterburner").Length == 0))
            {
                btnStart.Text = "Start";
                StopProcess();
            }
            else {
                btnStart.Text = "Stop";
                StartProcess(); }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectMSI();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            if (!(Process.GetProcessesByName("MSIAfterburner").Length == 0))
                btnStart.Text = "Stop";
            else 
                btnStart.Text = "Start";

            pathBox.Text = msiExePath;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized){
                MinimizeForm(true);
            }
        }

        private void Tray_DoubleClick(object sender, EventArgs e)
        {
            MinimizeForm(false);
        }

        void SystemEvents_PowerModeChanged(object sender, PowerModeChangedEventArgs e)
        {
            if (e.Mode == PowerModes.StatusChange)
            {
                CheckPowerLines();
            }
        }
        #endregion
    }
}
