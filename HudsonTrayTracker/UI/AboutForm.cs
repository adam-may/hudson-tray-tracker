using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace Hudson.TrayTracker.UI
{
    public partial class AboutForm : DevExpress.XtraEditors.XtraForm
    {
        static AboutForm instance;
        public static AboutForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new AboutForm();
                return instance;
            }
        }

        public AboutForm()
        {
            InitializeComponent();

            versionLabelControl.Text = string.Format(HudsonTrayTrackerResources.Version_Format, 
                Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = ((LinkLabel)sender).Text;
            Process.Start(url);
        }

        public static void ShowDialogOrFocus()
        {
            if (Instance.Visible)
                Instance.Focus();
            else
                Instance.ShowDialog();
        }
    }
}