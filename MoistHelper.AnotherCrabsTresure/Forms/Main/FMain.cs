
using MoistHelper.AnotherCrabsTresure.Forms.ManifestSelect;
using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            label_Version.Text = "v" + Updates.softwareVersion.TrimEnd();
            backgroundWorker_CheckForUpdates.RunWorkerAsync();
            LoadSettings();
        }

        private void LoadSettings()
        {
            if (FPSManager.IsShowFPS()) UButton_FPSDisplayEnable.Text = "Disable";
            else UButton_FPSDisplayEnable.Text = "Enable";

            if (FPSManager.IsLockFPS()) UButton_LockFPSEnable.Text = "Disable";
            else UButton_LockFPSEnable.Text = "Enable";
        }

        private void backgroundWorker_CheckForUpdates_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Updates.CheckForUpdates(); 
        }
    }
}
