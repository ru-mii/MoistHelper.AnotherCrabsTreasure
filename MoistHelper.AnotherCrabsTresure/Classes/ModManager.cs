using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Reflection;

class ModManager
{
    public static bool InjectPracticeMod()
    {
        string pathDLL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Crabber.dll");
        ProgramUtils.InjectDLL(pathDLL, "AnotherCrabsTreasure");
        return false;
    }

    public static bool InstallMod()
    {
        if (Process.GetProcessesByName("AnotherCrabsTreasure").Length > 0)
        {
            ProgramUtils.ShowError("Game process detected, close the game and try again, game has to be closed.");
            return false;
        }

        ProgramUtils.ShowInfo("Select the game folder...");

        FolderPicker folderPicker = new FolderPicker
        {
            Title = "Select game folder",
            Multiselect = false
        };

        Control control = new Control();
        if (folderPicker.ShowDialog(control.Handle) != null)
        {
            string selectedPath = folderPicker.ResultPath;

            if (Directory.Exists(selectedPath))
            {
                string[] files = Directory.GetFiles(selectedPath);

                string gameDirectory = "";
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName == "AnotherCrabsTreasure.exe")
                    {
                        gameDirectory = Path.GetDirectoryName(file);
                        break;
                    }
                }

                string pathProxyDLL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "version.dll");
                string pathModDLL = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "FPSManager.dll");

                if (!File.Exists(pathProxyDLL) || !File.Exists(pathModDLL))
                {
                    ProgramUtils.ShowError("One or all of the mod dll files do not exist, extract Moist Helper again and make sure your antivirus is not removing" +
                        " files!");

                    return false;
                }

                if (gameDirectory != "")
                {
                    if (File.Exists(Path.Combine(gameDirectory, "version.dll"))) File.Delete(Path.Combine(gameDirectory, "version.dll"));
                    if (File.Exists(Path.Combine(gameDirectory, "FPSManager.dll"))) File.Delete(Path.Combine(gameDirectory, "FPSManager.dll"));
                    File.Copy(pathProxyDLL, Path.Combine(gameDirectory, "version.dll"));
                    File.Copy(pathModDLL, Path.Combine(gameDirectory, "FPSManager.dll"));
                    return true;
                }
                else ProgramUtils.ShowError("Selected directory was incorrect, select folder that has \"AnotherCrabsTreasure.exe\" file");
            }
        }

        return false;
    }
}
