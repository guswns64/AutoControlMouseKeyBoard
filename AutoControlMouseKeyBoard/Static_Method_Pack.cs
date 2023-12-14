using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;

namespace AutoControlMouseKeyBoard
{
    static class Static_Method_Pack
    {

        public const uint LEFT_BUTTON_DOWN = 0x0002;
        public const uint LEFT_BUTTON_UP = 0x0004;

        [DllImport("user32.dll")]
        static public extern int SetCursorPos(int x, int y);
        [DllImport("user32.dll")]
        static public extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
        [DllImport("user32.dll")]
        static public extern void keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);
        [DllImport("user32.dll")]
        static public extern bool GetCursorPos(out Point lpPoint);
        [DllImport("user32.dll")]
        static public extern int SetForegroundWindow(IntPtr hWnd);

        static public void clickMouse()
        {
            Static_Method_Pack.mouse_event(LEFT_BUTTON_DOWN, 0, 0, 0, 0);
            System.Threading.Thread.Sleep(200);
            Static_Method_Pack.mouse_event(LEFT_BUTTON_UP, 0, 0, 0, 0);
        }
    }
}
