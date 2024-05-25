using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetModuleHandle(string lpModuleName);

    const uint PROCESS_CREATE_THREAD = 0x0002;
    const uint PROCESS_QUERY_INFORMATION = 0x0400;
    const uint PROCESS_VM_OPERATION = 0x0008;
    const uint PROCESS_VM_WRITE = 0x0020;
    const uint PROCESS_VM_READ = 0x0010;

    public static bool InjectDll(string dllPath, string processName)
    {
        try
        {
            Process targetProcess = Process.GetProcessesByName(processName)[0];
            IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

            if (procHandle == IntPtr.Zero)
                return false;

            IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            IntPtr allocMemAddress = targetProcess.MainModule.BaseAddress + 0x1000; // Using an offset from the main module base address

            byte[] dllPathBytes = System.Text.Encoding.ASCII.GetBytes(dllPath);
            if (!WriteProcessMemory(procHandle, allocMemAddress, dllPathBytes, dllPathBytes.Length, out _))
                return false;

            IntPtr hThread = CreateRemoteThread(procHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
            return hThread != IntPtr.Zero;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Injection failed: " + ex.Message);
            return false;
        }
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