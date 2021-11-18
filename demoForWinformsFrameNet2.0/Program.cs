using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace demoForWinformsFrameNet2._0
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static int Add(int i1, int i2)
        {
            return i1 + i2;
        }
    }
}
