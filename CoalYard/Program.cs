using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using ESRI.ArcGIS;

namespace CoalYard
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //初始化ArcGIS 
            if (!RuntimeManager.Bind(ProductCode.Engine))
            {
                if (!RuntimeManager.Bind(ProductCode.Desktop))
                {
                    MessageBox.Show("Unable to bind to ArcGIS runtime. Application will be shut down.");
                    return;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
