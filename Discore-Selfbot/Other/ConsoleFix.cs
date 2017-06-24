using System;
using System.Runtime.InteropServices;
static class DisableConsoleQuickEdit
{
    const uint ENABLE_QUICK_EDIT = 0x0040;
    const int STD_INPUT_HANDLE = -10;
    [DllImport("kernel32.dll", SetLastError = true)]
    static extern IntPtr GetStdHandle(int nStdHandle);

    [DllImport("kernel32.dll")]
    static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
    
    [DllImport("kernel32.dll")]
    static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
    internal static bool Go()
    {
        IntPtr consoleHandle = GetStdHandle(STD_INPUT_HANDLE);
        uint consoleMode;
        if (!GetConsoleMode(consoleHandle, out consoleMode))
        {
            return false;
        }
        consoleMode &= ~ENABLE_QUICK_EDIT;
        if (!SetConsoleMode(consoleHandle, consoleMode))
        {
            return false;
        }
        return true;
    }
}
