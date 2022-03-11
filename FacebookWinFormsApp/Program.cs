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
            AppManager windowsApplication = new  AppManager ();
            windowsApplication.Run();
        }
    }
}
