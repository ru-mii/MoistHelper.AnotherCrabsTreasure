using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure.Forms.FPSDisplay
{
    public partial class FFPSDisplaySettings : Form
    {
        public FFPSDisplaySettings() { InitializeComponent(); }

        readonly static string formDataPath = Path.Combine(GlobalPaths.ProgramDataPath, "FPSDisplay");
        readonly static string pathConfig = Path.Combine(formDataPath, "Config");
        readonly static string pathTextColor = Path.Combine(pathConfig, "TextColor.txt");
        readonly static string pathBlackBackgroundBox = Path.Combine(pathConfig, "BlackBackgroundBox.txt");

        private void FFPSDisplaySettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void UButton_ColorPalette_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    global::FPSManager.ChangeTextColor(colorDialog.Color);
                    UButton_ColorPalette.BackColor = colorDialog.Color;
                }
            }
        }

        private void LoadSettings()
        {
            if (File.Exists(pathTextColor))
            {
                UButton_ColorPalette.BackColor = ProgramUtils.HexToColor(File.ReadAllText(pathTextColor));
            }

            if (File.Exists(pathBlackBackgroundBox))
            {
                checkBox_BlackBackgroundBox.Checked = FPSManager.IsBlackBox();
            }

            checkBox_BlackBackgroundBox.Checked = FPSManager.IsBlackBox();
        }

        private void checkBox_BlackBackgroundBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);

            if (checkBox_BlackBackgroundBox.Checked) FPSManager.ShowBlackBox(true);
            else FPSManager.ShowBlackBox(false);
        }
    }
}
