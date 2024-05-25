using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class FPSManager
{
    readonly static string formDataPath = Path.Combine(GlobalPaths.ProgramDataPath, "FPSDisplay");
    readonly static string pathConfig = Path.Combine(formDataPath, "Config");
    readonly static string pathTextColor = Path.Combine(pathConfig, "TextColor.txt");
    readonly static string pathShowFPS = Path.Combine(pathConfig, "ShowFPS.txt");
    readonly static string pathLockFPS = Path.Combine(pathConfig, "LockFPS.txt");
    readonly static string pathBlackBox = Path.Combine(pathConfig, "BlackBackgroundBox.txt");

    public static bool IsLockFPS()
    {
        return File.Exists(pathLockFPS);
    }

    public static bool IsShowFPS()
    {
        return File.Exists(pathShowFPS);
    }

    public static bool IsBlackBox()
    {
        return File.Exists(pathBlackBox);
    }

    public static void LockFPS(bool enabled)
    {
        if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);

        if (enabled) File.WriteAllText(pathLockFPS, "");
        else if (File.Exists(pathLockFPS)) File.Delete(pathLockFPS);
    }

    public static void ShowFPS(bool enabled)
    {
        if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);

        if (enabled) File.WriteAllText(pathShowFPS, "");
        else if (File.Exists(pathShowFPS)) File.Delete(pathShowFPS);
    }

    public static void ShowBlackBox(bool enabled)
    {
        if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);

        if (enabled) File.WriteAllText(pathBlackBox, "");
        else if (File.Exists(pathBlackBox)) File.Delete(pathBlackBox);
    }

    public static void ChangeTextColor(Color color)
    {
        if (!Directory.Exists(pathConfig)) Directory.CreateDirectory(pathConfig);
        File.WriteAllText(pathTextColor, ProgramUtils.ColorToHex(color));
    }
}
