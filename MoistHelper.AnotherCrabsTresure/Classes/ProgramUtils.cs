using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Imports;

class ProgramUtils
{
    internal static void ShowError(string message) { MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
    internal static void ShowInfo(string message) { MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }

    public static Process someProc = new Process();

    public static bool WriteMemorySpecial(IntPtr address, byte[] array)
    {
        IntPtr intPtr;
        return WriteProcessMemory(someProc.Handle, address, array, array.Length, out intPtr);
    }

    public static bool InjectDLL(string dllPath, string processName)
    {
        try
        {
            Process targetProcess = Process.GetProcessesByName(processName)[0];
            IntPtr procHandle = targetProcess.Handle;

            if (procHandle == IntPtr.Zero) return false;
            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
            IntPtr allocMemAddress = targetProcess.MainModule.BaseAddress + 0x1000;

            byte[] dllPathBytes = System.Text.Encoding.ASCII.GetBytes(dllPath);
            if (!WriteProcessMemory(procHandle, allocMemAddress, dllPathBytes, dllPathBytes.Length, out IntPtr bytesWritten))
                return false;

            IntPtr hThread = CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, out _);
            return hThread != IntPtr.Zero;
        }
        catch { return false; }
    }

    public static bool IsFormOpen(string name)
    {
        foreach (Form window in Application.OpenForms)
        {
            if (window.Name == name) return true;
        }

        return false;
    }

    public static Image TryPNGToImage(string pathPNG)
    {
        if (File.Exists(pathPNG))
        {
            try { return Image.FromFile(pathPNG); }
            catch { return null; }
        }

        return null;
    }

    public static bool IsKeyPressed(int keyCode)
    {
        if (keyCode == 0) return false;
        else if (GetAsyncKeyState(keyCode) != 0) return true;
        else return false;
    }

    public static string ColorToHex(Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    }

    public static Color HexToColor(string hexColor)
    {
        try { return ColorTranslator.FromHtml(hexColor); }
        catch { return Color.Empty; }
    }
}