using MoistHelper.AnotherCrabsTresure.ExternalInputOverlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure.Forms.ExternalInputOverlay
{
    public partial class FExternalInputOverlaySettings : Form
    {
        public FExternalInputOverlaySettings() { InitializeComponent(); }

        readonly static string formDataPath = Path.Combine(GlobalPaths.ProgramDataPath, "ExternalInputOverlay");

        readonly static string pathPresets = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Presets");
        readonly static string pathConfig = Path.Combine(formDataPath, "Config");

        readonly static string pathSelectedPreset = Path.Combine(pathConfig, "SelectedPreset.txt");
        readonly static string pathWindowColor = Path.Combine(pathConfig, "WindowColor.txt");
        readonly static string pathWindowAlwaysOnTop = Path.Combine(pathConfig, "WindowAlwaysOnTop.txt");

        private void FExternalInputOverlaySettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            // presets
            {
                if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);
                if (!Directory.Exists(pathPresets)) Directory.CreateDirectory(pathPresets);

                string[] presetPaths = Directory.GetDirectories(pathPresets);
                foreach (string path in presetPaths) comboBox_Preset.Items.Add(Path.GetFileName(path));

                string selectedPresetName = "";
                if (File.Exists(pathSelectedPreset)) selectedPresetName = File.ReadAllText(pathSelectedPreset);

                if (selectedPresetName != "")
                {
                    for (int i = 0; i < comboBox_Preset.Items.Count; i++)
                    {
                        if ((string)comboBox_Preset.Items[i] == selectedPresetName)
                        {
                            comboBox_Preset.SelectedItem = comboBox_Preset.Items[i];
                            break;
                        }
                    }
                }
                else if (presetPaths.Length > 0)
                {
                    for (int i = 0; i < comboBox_Preset.Items.Count; i++)
                    {
                        if ((string)comboBox_Preset.Items[i] == "Iconic")
                        {
                            comboBox_Preset.SelectedItem = comboBox_Preset.Items[i];
                            break;
                        }
                    }
                }
            }

            // window color
            {
                if (File.Exists(pathWindowColor))
                {
                    UButton_ColorPalette.BackColor = ProgramUtils.HexToColor(File.ReadAllText(pathWindowColor));
                }
            }

            // window always on top
            {
                if (File.Exists(pathWindowAlwaysOnTop))
                {
                    string readData = File.ReadAllText(pathWindowAlwaysOnTop);
                    if (readData == "Yes") comboBox_WindowAlwaysOnTop.SelectedIndex = 0;
                    else if (readData == "No") comboBox_WindowAlwaysOnTop.SelectedIndex = 1;
                    else comboBox_WindowAlwaysOnTop.SelectedIndex = 1;
                }
                else comboBox_WindowAlwaysOnTop.SelectedIndex = 1;
            }
        }

        private void comboBox_Preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);
            File.WriteAllText(pathSelectedPreset, comboBox_Preset.Text);
            FExternalInputOverlay.RefreshPending = true;
        }

        private void UButton_ColorPalette_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);
                    File.WriteAllText(pathWindowColor, ProgramUtils.ColorToHex(colorDialog.Color));
                    UButton_ColorPalette.BackColor = colorDialog.Color;
                    FExternalInputOverlay.RefreshPending = true;
                }
            }
        }

        private void comboBox_WindowAlwaysOnTop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);
            File.WriteAllText(pathWindowAlwaysOnTop, comboBox_WindowAlwaysOnTop.Text);
            FExternalInputOverlay.RefreshPending = true;
        }
    }
}
