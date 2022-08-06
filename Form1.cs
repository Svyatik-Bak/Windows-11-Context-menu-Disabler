using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Windows_11_Context_menu_Disabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Process.Start("reg.exe", @"add HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2}\InprocServer32 /f /ve");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Process.Start("reg.exe", @"delete HKCU\Software\Classes\CLSID\{86ca1aa0-34aa-4e8b-a509-50c905bae2a2} /f");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c taskkill /f /im explorer.exe & start explorer.exe");
        }
    }
}
