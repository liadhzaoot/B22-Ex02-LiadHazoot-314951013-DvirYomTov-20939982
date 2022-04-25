using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            AppManager windowsApplication = AppManager.GetInstance;
            windowsApplication.Factory = new WinFormAppPagesCreator();
            windowsApplication.Run();

        }
    }
}
