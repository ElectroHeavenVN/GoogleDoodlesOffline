using System;
using System.IO;
using System.Management;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace RestartBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct BrowserInfo
        {
            public string Name;
            public string Path;
            public string Arguments;
        }
        static List<BrowserInfo> browserInfos = new List<BrowserInfo>();
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string BrowserFileName = string.Empty;
                string BrowserProcessName;
                string arguments = string.Empty;
                foreach (BrowserInfo info in browserInfos)
                {
                    if (SelectBrowserComboBox.Text == info.Name)
                    {
                        BrowserFileName = info.Path;
                        arguments = info.Arguments;
                    }
                }
                if (BrowserFileName.Contains(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Local\\Programs\\Opera")) BrowserProcessName = "opera";
                else BrowserProcessName = BrowserFileName;
                if (string.IsNullOrEmpty(SelectGameComboBox.Text))
                {
                    MessageBox.Show("Select the game you want to play!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                foreach (Process browser in Process.GetProcessesByName(BrowserProcessName)) if (GetCommandLine(browser).Contains(arguments)) goto Label;
                while (Process.GetProcessesByName(BrowserProcessName).Length > 0) if (MessageBox.Show("Close your browser before contiune", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == DialogResult.Cancel) return;
                Label:;
                string UrlGame = "file:///" + Path.GetDirectoryName(Application.ExecutablePath);
                switch (SelectGameComboBox.Text)
                {
                    case "Champion Island 2021":
                        UrlGame += "/Kitsune/logos/run.html";
                        break;
                    case "Halloween 2020":
                        UrlGame += "/Halloween/Halloween20/logos/run.html";
                        break;
                    case "Valentine's Day 2017":
                        UrlGame += "/VDay/VDay17/logos/run.html";
                        break;
                    case "Celebrating 50 years of Kids Coding 2017":
                        UrlGame += "/Logo17/logos/run.html";
                        break;
                    case "PAC-MAN 30th Anniversary":
                        UrlGame += "/Pacman/logos/2010/pacman10-i.html";
                        break;
                    default:
                        UrlGame += "/Halloween/Halloween16/logos/run.html";
                        break;
                }
                Process.Start(BrowserFileName, arguments + " " + UrlGame);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, (MessageBoxOptions)0x40000);
            }
        }       

        private void CancelBtn_Click(object sender, EventArgs e) => Application.Exit();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] dataIn = File.ReadAllLines("BrowserList.txt");
            foreach (string dataLine in dataIn)
            {
                if (dataLine.StartsWith("//")) continue;
                string[] data = dataLine.Split('|');
                browserInfos.Add(new BrowserInfo 
                { 
                    Name = data[0],
                    Path = data[1].StartsWith("%userprofile%") ? Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + data[1].Remove(0, 13) : data[1],
                    Arguments = data[2],
                });
                SelectBrowserComboBox.Items.AddRange(new object[]
                {
                    data[0]
                });
            }
        }
        private static string GetCommandLine(Process process)
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT CommandLine FROM Win32_Process WHERE ProcessId = " + process.Id)) using (ManagementObjectCollection objects = searcher.Get()) return objects.Cast<ManagementBaseObject>().SingleOrDefault()?["CommandLine"]?.ToString();
        }
    }
}
