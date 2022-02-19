using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AdvancedControls
{
    static class Program
    {
        /// <summary>
        /// 為調用過程分配一個新的控制台。
        /// </summary>
        [DllImport("kernel32", SetLastError = true)]
        static extern bool AllocConsole();

        /// <summary>
        /// 將調用進程附加到指定進程的控制台。
        /// </summary>
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AttachConsole(uint dwProcessId);
        const uint ATTACH_PARENT_PROCESS = 0x0ffffffff;

        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!AttachConsole(ATTACH_PARENT_PROCESS)) //配置新控制台
                AllocConsole();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

    }
}
