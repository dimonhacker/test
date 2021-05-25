using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_Assistant
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form f=new Form1();
            f.ShowDialog();
        }
            [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        private const UInt32 MOVE = 0x0001;
        private const UInt32 LEFTDOWN = 0x0002;
        private const UInt32 LEFTUP = 0x0004;
        private const UInt32 RIGHTDOWN = 0x0008;
        private const UInt32 RIGHTUP = 0x0010;
        private const UInt32 MIDDLEDOWN = 0x0020;
        private const UInt32 MIDDLEUP = 0x0040;
        private const UInt32 WHEEL = 0x0800;
        private const UInt32 ABSOLUTE = 0x8000;

        public static void LeftClick()
        {
            mouse_event(LEFTDOWN | LEFTUP, 0, 0, 0, IntPtr.Zero);
        }
        public static void move(int ex, int ey)
        {
            int now_x = Cursor.Position.X;
            int now_y = Cursor.Position.Y;
            Cursor.Position=new System.Drawing.Point(now_x, now_y);
            int dx, dy;
            Random r = new Random();
            int step = (int)(r.Next(150) + 60);
            for (int i = 0; i < step; i++)
            {
                dx = (ex - now_x) / (step - i);
                dy = (ey - now_y) / (step - i);
                {
                    now_x += dx;
                    now_y += dy;
                }
                Cursor.Position = new System.Drawing.Point(now_x, now_y);
                Thread.Sleep(5);
            }
        }
        
        
    }
}
    

